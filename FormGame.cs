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

        public FormGame()
        {
            InitializeComponent();
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
            // Reinicializar terrenos y listas disponibles
            terrenos.Clear();
            ResetDisponibles();

            foreach (PictureBox pictureBox in pictureBoxes)
            {
                ITerreno tipoTerreno = random.Next(2) == 0 ? (ITerreno)new TerrenoAgua() : (ITerreno)new TerrenoTierra();
                Terreno terreno = new Terreno(tipoTerreno);

                // Coloca una criatura aleatoria en el terreno si es terreno de tierra
                if (tipoTerreno is TerrenoTierra)
                {
                    Criatura criaturaAleatoria = GetCriaturaAleatoria();
                    if (criaturaAleatoria != null)
                    {
                        terreno.Criaturas.Add(criaturaAleatoria);
                    }
                }

                // Coloca un interactuable aleatorio en el terreno
                IInteractuable interactuableAleatorio = GetInteractuableAleatorio();
                if (interactuableAleatorio != null)
                {
                    terreno.Interactuables.Add(interactuableAleatorio);
                }

                terrenos.Add(terreno);
                pictureBox.Image = tipoTerreno.GetImage();
            }
        }

        private Criatura GetCriaturaAleatoria()
        {
            if (criaturasDisponibles.Count > 0)
            {
                int index = random.Next(criaturasDisponibles.Count);
                Criatura criatura = criaturasDisponibles[index];
                criaturasDisponibles.RemoveAt(index);
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
                // Obtener el índice del PictureBox
                int index = pictureBoxes.IndexOf(pictureBox);
                if (index >= 0 && index < terrenos.Count)
                {
                    Terreno terreno = terrenos[index];

                    // Actualizar el DataGridView de criaturas
                    dataGridViewCriaturas.Rows.Clear();
                    if (terreno.Criaturas.Count > 0)
                    {
                        foreach (Criatura criatura in terreno.Criaturas)
                        {
                            if (criatura != null)
                            {
                                dataGridViewCriaturas.Rows.Add(criatura.Nombre, criatura.Vida);
                            }
                        }
                    }

                    // Actualizar el DataGridView de items
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

    }
}

