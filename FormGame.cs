using Fdsmlfr.Controllers;
using Fdsmlfr.Interfaces;
using Fdsmlfr.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fdsmlfr
{
    public partial class FormGame : Form
    {
        private List<PictureBox> pictureBoxes;
        private Game game;
        private InicioController gameInitializer;
        private ActualizacionController gameUpdater;
        private Criatura criaturaSeleccionada;
        private Terreno terrenoOrigen;

        public FormGame()
        {
            InitializeComponent();
            InicializarComponentesPersonalizados();
        }

        private void InicializarComponentesPersonalizados()
        {
            pictureBoxes = new List<PictureBox> { Hexagon1, Hexagon2, Hexagon3, Hexagon4, Hexagon5, Hexagon6, Hexagon7 };
            game = new Game();
            gameInitializer = new InicioController(game);
            gameUpdater = new ActualizacionController(game);

            gameInitializer.InitializeGame(pictureBoxes);

            comboBoxCriaturas.DisplayMember = "Nombre";
            comboBoxCriaturas.DataSource = game.CriaturasDisponibles;

            InicializarEventos();
        }

        private void InicializarEventos()
        {
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.Click += Terreno_Click;
            }
            dataGridViewCriaturas.SelectionChanged += Criatura_Selected;
            buttonMover.Click += buttonMover_Click;
        }

        private void Terreno_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                int index = pictureBoxes.IndexOf(pictureBox);
                if (index >= 0 && index < game.Terrenos.Count)
                {
                    var terrenoDestino = game.Terrenos[index];
                    ProcesarTerrenoClick(terrenoDestino, index);
                }
            }
        }

        private void ProcesarTerrenoClick(Terreno terrenoDestino, int index)
        {
            if (criaturaSeleccionada != null && terrenoOrigen != null)
            {
                gameUpdater.MoverCriatura(terrenoOrigen, terrenoDestino, criaturaSeleccionada);
                ResetearResaltado();
                criaturaSeleccionada = null;
                terrenoOrigen = null;
                MessageBox.Show("La criatura se ha movido correctamente.");
            }
            else
            {
                ActualizarDataGrids(terrenoDestino);
            }
        }

        private void ActualizarDataGrids(Terreno terreno)
        {
            ActualizarDataGridCriaturas(terreno.Criaturas);
            ActualizarDataGridInteractuables(terreno.Interactuables);
        }

        private void ActualizarDataGridCriaturas(List<Criatura> criaturas)
        {
            dataGridViewCriaturas.Rows.Clear();
            foreach (Criatura criatura in criaturas)
            {
                string habitads = string.Join(", ", criatura.Habitads);
                dataGridViewCriaturas.Rows.Add(criatura.Nombre, criatura.Vida, habitads);
            }
        }

        private void ActualizarDataGridInteractuables(List<IInteractuable> interactuables)
        {
            dataGridViewItems.Rows.Clear();
            dataGridViewComidas.Rows.Clear();

            foreach (IInteractuable interactuable in interactuables)
            {
                switch (interactuable)
                {
                    case Item item:
                        dataGridViewItems.Rows.Add(item.Nombre);
                        break;
                    case Comida comida:
                        dataGridViewComidas.Rows.Add(comida.Nombre, comida.Dieta);
                        break;
                }
            }
        }

        private void ResaltarTerrenosAdyacentes(Terreno terrenoOrigen)
        {
            List<int> adyacentes = Mapa.ObtenerTerrenosAdyacentes(game.Terrenos.IndexOf(terrenoOrigen) + 1);
            foreach (int index in adyacentes)
            {
                if (index - 1 >= 0 && index - 1 < pictureBoxes.Count)
                {
                    pictureBoxes[index - 1].BorderStyle = BorderStyle.Fixed3D;
                    pictureBoxes[index - 1].BackColor = Color.Red; // CAMBIAR ESTOOOOOOOOO
                }
            }
        }

        private void ResetearResaltado()
        {
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.BorderStyle = BorderStyle.None;
                pictureBox.BackColor = SystemColors.Control;
            }
        }

        private void Criatura_Selected(object sender, EventArgs e)
        {
            if (dataGridViewCriaturas.SelectedRows.Count > 0)
            {
                string nombreCriatura = dataGridViewCriaturas.SelectedRows[0].Cells[0].Value.ToString();
                criaturaSeleccionada = game.Terrenos.SelectMany(t => t.Criaturas)
                                                    .FirstOrDefault(c => c.Nombre == nombreCriatura);
                terrenoOrigen = game.Terrenos.FirstOrDefault(t => t.Criaturas.Contains(criaturaSeleccionada));
                ResaltarTerrenosAdyacentes(terrenoOrigen);
            }
        }

        private void Criatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            Criatura criaturaSeleccionada = comboBoxCriaturas.SelectedItem as Criatura;

            if (criaturaSeleccionada != null)
            {
                textBoxVida.Text = criaturaSeleccionada.Vida.ToString();
                textBoxEnergia.Text = criaturaSeleccionada.Energia.ToString();
                textBoxAtaque.Text = criaturaSeleccionada.PntAtack.ToString();
                textBoxDefensa.Text = criaturaSeleccionada.PntDef.ToString();
                textBoxDieta.Text = criaturaSeleccionada.Dieta.ToString();
            }
        }

        private void buttonMover_Click(object sender, EventArgs e)
        {
            if (criaturaSeleccionada == null)
            {
                MessageBox.Show("Por favor, seleccione una criatura primero");
                return;
            }
            MessageBox.Show("Selecciona el destino");
        }
    }
}
