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
        private List<Terreno> terrenos;
        private List<Criatura> criaturasOriginales;
        private List<Comida> comidasOriginales;
        private List<Item> itemsOriginales;
        private List<Criatura> criaturasDisponibles;
        private List<IInteractuable> interactuablesDisponibles;
        private Random random;
        private Criatura criaturaSeleccionada;
        private Terreno terrenoOrigen;
        private bool moviendoCriatura;

        public FormGame()
        {
            InitializeComponent();
            InicializarComponentesPersonalizados();
        }

        private void InicializarComponentesPersonalizados()
        {
            pictureBoxes = new List<PictureBox> { Hexagon1, Hexagon2, Hexagon3, Hexagon4, Hexagon5, Hexagon6, Hexagon7 };
            terrenos = new List<Terreno>();
            random = new Random();

            // Listas originales
            criaturasOriginales = CriaturaController.GetInstace().GetCriaturasList();
            comidasOriginales = ComidaController.GetInstace().GetComidaList();
            itemsOriginales = ItemController.GetInstance().GetItemList();

            // Listas copias
            ResetDisponibles();

            comboBoxCriaturas.DisplayMember = "Nombre";
            comboBoxCriaturas.DataSource = criaturasDisponibles;

            InicializarTerrenos();
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

        private void ResetDisponibles()
        {
            criaturasDisponibles = new List<Criatura>(criaturasOriginales);
            interactuablesDisponibles = new List<IInteractuable>();
            interactuablesDisponibles.AddRange(comidasOriginales);
            interactuablesDisponibles.AddRange(itemsOriginales);
        }

        private void InicializarTerrenos()
        {
            terrenos.Clear();
            ResetDisponibles();

            foreach (PictureBox pictureBox in pictureBoxes)
            {
                ITerreno tipoTerreno = random.Next(2) == 0 ? (ITerreno)new TerrenoAgua() : (ITerreno)new TerrenoTierra();
                Terreno terreno = new Terreno(tipoTerreno);

                Criatura criaturaAleatoria = GetCriaturaAleatoriaParaTerreno(tipoTerreno);
                if (criaturaAleatoria != null)
                {
                    terreno.Criaturas.Add(criaturaAleatoria);
                }

                IInteractuable interactuableAleatorio = GetInteractuableAleatorio();
                if (interactuableAleatorio != null)
                {
                    terreno.Interactuables.Add(interactuableAleatorio);
                }

                terrenos.Add(terreno);
                pictureBox.Image = tipoTerreno.GetImage();
            }
        }

        private Criatura GetCriaturaAleatoriaParaTerreno(ITerreno terreno)
        {
            List<Criatura> criaturasCompatibles = criaturasDisponibles.Where(c => c.PuedePasarPorTerreno(terreno)).ToList();
            if (criaturasCompatibles.Count > 0)
            {
                int index = random.Next(criaturasCompatibles.Count);
                Criatura criatura = criaturasCompatibles[index];
                criaturasDisponibles.Remove(criatura);
                return criatura;
            }
            return null;
        }

        private IInteractuable GetInteractuableAleatorio()
        {
            if (interactuablesDisponibles.Count > 0)
            {
                int index = random.Next(interactuablesDisponibles.Count);
                IInteractuable interactuable = interactuablesDisponibles[index];
                interactuablesDisponibles.RemoveAt(index);
                return interactuable;
            }
            return null;
        }

        private void Terreno_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                int index = pictureBoxes.IndexOf(pictureBox);
                if (index >= 0 && index < terrenos.Count)
                {
                    Terreno terrenoDestino = terrenos[index];
                    ProcesarTerrenoClick(terrenoDestino, index);
                }
            }
        }
        //Vemos que deseamos hacer si actualizar o mover
        private void ProcesarTerrenoClick(Terreno terrenoDestino, int index)
        {
            if (criaturaSeleccionada != null && terrenoOrigen != null)
            {
                MoverCriatura(terrenoDestino, index);
            }
            else
            {
                ActualizarDataGrids(terrenoDestino);
            }
        }

        private void MoverCriatura(Terreno terrenoDestino, int index)
        {
            List<int> adyacentes = Mapa.ObtenerTerrenosAdyacentes(terrenos.IndexOf(terrenoOrigen) + 1);

            if (adyacentes.Contains(index + 1) && criaturaSeleccionada.PuedePasarPorTerreno(terrenoDestino.tipo))
            {
                terrenoOrigen.Criaturas.Remove(criaturaSeleccionada);
                terrenoDestino.Criaturas.Add(criaturaSeleccionada);
                ResetearResaltado();
                criaturaSeleccionada = null;
                terrenoOrigen = null;
                moviendoCriatura = false;
                MessageBox.Show("La criatura se ha movido correctamente.");
            }
            else
            {
                MessageBox.Show("El terreno seleccionado no es adyacente o la criatura no puede moverse a este terreno.");
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
            List<int> adyacentes = Mapa.ObtenerTerrenosAdyacentes(terrenos.IndexOf(terrenoOrigen) + 1);
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
                criaturaSeleccionada = terrenos.SelectMany(t => t.Criaturas)
                                               .FirstOrDefault(c => c.Nombre == nombreCriatura);
                terrenoOrigen = terrenos.FirstOrDefault(t => t.Criaturas.Contains(criaturaSeleccionada));
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
            else
            {
                MessageBox.Show("Selecciona el destino");
                moviendoCriatura = true;
            }
           
        }
    }
    
}

