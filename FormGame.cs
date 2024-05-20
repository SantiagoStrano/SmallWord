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
        private List<Criatura> criaturasDisponibles;
        private List<IInteractuable> interactuablesDisponibles;
        private Random random; // Nueva instancia de Random


        public FormGame()
        {
            InitializeComponent();
            pictureBoxes = new List<PictureBox> { Hexagon1, Hexagon2, Hexagon3, Hexagon4, Hexagon5, Hexagon6, Hexagon7 };
            terrenos = new List<Terreno>();
            random = new Random(); // Inicializa Random

            // Inicializa las listas de criaturas e interactuables disponibles
            criaturasDisponibles = CriaturaController.GetInstace().GetCriaturasList();
            interactuablesDisponibles = new List<IInteractuable>();
            interactuablesDisponibles.AddRange(ItemController.GetInstance().GetItemList());
            interactuablesDisponibles.AddRange(ComidaController.GetInstace().GetComidaList());

            // Configurar el ComboBox de criaturas
            comboBoxCriaturas.DisplayMember = "Nombre"; // Mostrar el nombre de la criatura
            comboBoxCriaturas.DataSource = criaturasDisponibles; // Asociar la lista de criaturas al ComboBox

            InicializarTerrenos();


        }

        private void InicializarTerrenos()
        {
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                ITerreno tipoTerreno = random.Next(2) == 0 ? (ITerreno)new TerrenoAgua() : (ITerreno)new TerrenoTierra();
                Terreno terreno = new Terreno(tipoTerreno);

                // Coloca una criatura aleatoria en el terreno si es terreno de tierra
                if (tipoTerreno is TerrenoTierra)
                {
                    Criatura criaturaAleatoria = GetCriaturaAleatoria();
                    terreno.Criaturas.Add(criaturaAleatoria);
                }

                // Coloca un interactuable aleatorio en el terreno
                IInteractuable interactuableAleatorio = GetInteractuableAleatorio();
                terreno.Interactuables.Add(interactuableAleatorio);

                terrenos.Add(terreno);
                pictureBox.Image = tipoTerreno.GetImage();
            }
        }

        private Criatura GetCriaturaAleatoria()
        {
            Criatura criatura = null;
            if (criaturasDisponibles.Count > 0)
            {
                criatura = criaturasDisponibles[0];
                criaturasDisponibles.RemoveAt(0); // Eliminar la criatura de la lista de disponibles
            }
            return criatura;
        }

        private IInteractuable GetInteractuableAleatorio()
        {
            Random random = new Random();
            int totalInteractuables = interactuablesDisponibles.Count;
            if (totalInteractuables > 0)
            {
                int index = random.Next(totalInteractuables);
                IInteractuable interactuable = interactuablesDisponibles[index];
                interactuablesDisponibles.RemoveAt(index); // Eliminar el interactuable de la lista de disponibles
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

