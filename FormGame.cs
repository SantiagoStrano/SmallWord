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

            // Cargar listas originales
            criaturasOriginales = CriaturaController.GetInstace().GetCriaturasList();
            comidasOriginales = ComidaController.GetInstace().GetComidaList();
            itemsOriginales = ItemController.GetInstance().GetItemList();

            // Inicializar listas disponibles a partir de las originales
            ResetDisponibles();

            // Configurar el ComboBox de criaturas
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
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                int index = pictureBoxes.IndexOf(pictureBox);
                if (index >= 0 && index < terrenos.Count)
                {
                    Terreno terrenoDestino = terrenos[index];

                    if (criaturaSeleccionada != null && terrenoOrigen != null)
                    {
                        List<int> adyacentes = Mapa.ObtenerTerrenosAdyacentes(terrenos.IndexOf(terrenoOrigen) + 1);

                        // Verificar que el terreno destino es adyacente y la criatura puede pasar por el terreno
                        if (adyacentes.Contains(index + 1) && criaturaSeleccionada.PuedePasarPorTerreno(terrenoDestino.tipo))
                        {
                            terrenoOrigen.Criaturas.Remove(criaturaSeleccionada);
                            terrenoDestino.Criaturas.Add(criaturaSeleccionada);
                            criaturaSeleccionada = null;
                            terrenoOrigen = null;
                            MessageBox.Show("La criatura se ha movido correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("El terreno seleccionado no es adyacente o la criatura no puede moverse a este terreno.");
                        }
                    }
                    else
                    {
                        ActualizarDataGrids(terrenoDestino);
                    }
                }
            }
        }

        private void ActualizarDataGrids(Terreno terreno)
        {
            dataGridViewCriaturas.Rows.Clear();
            if (terreno.Criaturas.Count > 0)
            {
                foreach (Criatura criatura in terreno.Criaturas)
                {
                    dataGridViewCriaturas.Rows.Add(criatura.Nombre, criatura.Vida);
                }
            }

            dataGridViewItems.Rows.Clear();
            dataGridViewComidas.Rows.Clear();
            if (terreno.Interactuables.Count > 0)
            {
                foreach (IInteractuable interactuable in terreno.Interactuables)
                {
                    if (interactuable is Item item)
                    {
                        dataGridViewItems.Rows.Add(item.Nombre);
                    }
                    else if (interactuable is Comida comida)
                    {
                        dataGridViewComidas.Rows.Add(comida.Nombre, comida.Dieta);
                    }
                }
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
            }
        }

        private void Criatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            Criatura criaturaSeleccionada = comboBoxCriaturas.SelectedItem as Criatura;

            // Verificar si la criatura seleccionada no es nula
            if (criaturaSeleccionada != null)
            {
                // Llenar los TextBox con los valores de la criatura seleccionada
                textBoxVida.Text = criaturaSeleccionada.Vida.ToString();
                textBoxEnergia.Text = criaturaSeleccionada.Energia.ToString();
                textBoxAtaque.Text = criaturaSeleccionada.PntAtack.ToString();
                textBoxDefensa.Text = criaturaSeleccionada.PntDef.ToString();
            }
        }

        private void buttonMover_Click(object sender, EventArgs e)
        {
            if (criaturaSeleccionada == null)
            {
                MessageBox.Show("Por favor, seleccione una criatura primero.");
                return;
            }

            MessageBox.Show("Seleccione el terreno al cual desea mover la criatura.");
            // Aquí se esperará a que el usuario seleccione un terreno haciendo click en uno de los PictureBox
        }
    }
    
}

