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
            buttonComer.Click += buttonComer_Click;
            buttonUsar.Click += buttonUsar_Click;
            buttonAtacar.Click += buttonAtacar_Click;
        }

        private void Terreno_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                int index = pictureBoxes.IndexOf(pictureBox);
                if (index >= 0 && index < game.Terrenos.Count)
                {

                    var terrenoDestino = game.Terrenos[index];
                    comboBoxCriaturas.DataSource = null;
                    comboBoxCriaturas.Items.Clear();
                    LimpiarTextBox();
                    ProcesarTerrenoClick(terrenoDestino, index);
                    
                }
            }
        }
        private void LimpiarTextBox()
        {
            textBoxVida.Text = string.Empty;
            textBoxEnergia.Text = string.Empty;
            textBoxAtaque.Text = string.Empty;
            textBoxDefensa.Text = string.Empty;
            textBoxDieta.Text = string.Empty;
        }
        private void ProcesarTerrenoClick(Terreno terrenoDestino, int index)
        {
            if (criaturaSeleccionada != null && terrenoOrigen != null)
            {
                if (EsTerrenoAdyacente(terrenoOrigen, terrenoDestino))
                {
                    gameUpdater.MoverCriatura(terrenoOrigen, terrenoDestino, criaturaSeleccionada);
                    ResetearResaltado();
                    criaturaSeleccionada = null;
                    terrenoOrigen = null;
                    
                }
                else
                {
                    MessageBox.Show("Solo puedes moverte a terrenos adyacentes");
                }
            }
            else
            {
                
                ActualizarDataGrids(terrenoDestino);
                ActualizarComboBoxCriaturas(terrenoDestino.Criaturas);
            }
        }

        private bool EsTerrenoAdyacente(Terreno terrenoOrigen, Terreno terrenoDestino)
        {
            int indiceOrigen = game.Terrenos.IndexOf(terrenoOrigen) + 1;
            int indiceDestino = game.Terrenos.IndexOf(terrenoDestino) + 1;
            List<int> terrenosAdyacentes = Mapa.ObtenerTerrenosAdyacentes(indiceOrigen);
            return terrenosAdyacentes.Contains(indiceDestino);
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

        private void ActualizarComboBoxCriaturas(List<Criatura> criaturas)
        {
            comboBoxCriaturas.DisplayMember = "Nombre";
            comboBoxCriaturas.DataSource = criaturas;
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
                ActualizarComboBoxCriaturas(terrenoOrigen.Criaturas);
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
            if (comboBoxCriaturas.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una criatura");
                return;
            }
            criaturaSeleccionada = comboBoxCriaturas.SelectedItem as Criatura;
            MessageBox.Show("Selecciona el destino");
        }

        private void buttonComer_Click(object sender, EventArgs e)
        {
            if (comboBoxCriaturas.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una criatura");
                return;
            }
            criaturaSeleccionada = comboBoxCriaturas.SelectedItem as Criatura;

            if (dataGridViewComidas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una comida");
                return;
            }

            string nombreComida = dataGridViewComidas.SelectedRows[0].Cells[0].Value.ToString();
            Comida comidaSeleccionada = null;
            Terreno terrenoActual = null;

            
            foreach (var terreno in game.Terrenos)
            {
                comidaSeleccionada = terreno.Interactuables.OfType<Comida>().FirstOrDefault(c => c.Nombre == nombreComida);
                if (comidaSeleccionada != null)
                {
                    terrenoActual = terreno;
                    break;
                }
            }

            if (comidaSeleccionada != null && terrenoActual != null)
            {
                ((ICriatura)criaturaSeleccionada).Comer(comidaSeleccionada);

                // Vemos si funciono
                if (!game.InteractuablesDisponibles.Contains(comidaSeleccionada))
                {
                    terrenoActual.RemoveInteractuable(comidaSeleccionada);
                    ActualizarDataGrids(terrenoActual);
                }
            }
        }

        private void buttonUsar_Click(object sender, EventArgs e)
        {
            if (comboBoxCriaturas.SelectedItem == null)
            {
                MessageBox.Show("Selecciona una criatura");
                return;
            }
            criaturaSeleccionada = comboBoxCriaturas.SelectedItem as Criatura;

            if (dataGridViewItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleeciona un item");
                return;
            }

            string nombreItem = dataGridViewItems.SelectedRows[0].Cells[0].Value.ToString();
            Item itemSeleccionado = null;
            Terreno terrenoActual = null;

            // Terremp e iten
            foreach (var terreno in game.Terrenos)
            {
                itemSeleccionado = terreno.Interactuables.OfType<Item>().FirstOrDefault(i => i.Nombre == nombreItem);
                if (itemSeleccionado != null)
                {
                    terrenoActual = terreno;
                    break;
                }
            }

            if (itemSeleccionado != null && terrenoActual != null)
            {
                gameUpdater.UsarItem(criaturaSeleccionada, itemSeleccionado);
                ActualizarDataGrids(terrenoActual);
            }
        }

        private void buttonAtacar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
