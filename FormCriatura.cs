using Fdsmlfr.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fdsmlfr.Interfaces;
using Fdsmlfr.Model;

namespace Fdsmlfr
{
    public partial class FormCriatura : Form
    {
        DietaController cntrlDieta = DietaController.GetInstace();
        HabitadController cntrlHabitad = HabitadController.GetInstace();
        ReinoController cntrlReino = ReinoController.GetInstance();
        CriaturaController cntrCriatura = CriaturaController.GetInstace();

        private Criatura criaturaSeleccionada;

        public FormCriatura()
        {
            InitializeComponent();
            CargarCriaturas();

            comboDiet.Items.Add("-Seleccionar dieta-");
            comboReino.Items.Add("-Seleccionar reino-");

            List<IDieta> listaDietas = cntrlDieta.GetAllDietas();
            comboDiet.Items.AddRange(listaDietas.ToArray());

            List<IHabitad> listaHabitads = cntrlHabitad.GetAllHabitads();
            checkedListHabitad.Items.AddRange(listaHabitads.ToArray());

            List<IReino> listaReino = cntrlReino.GetAllReinos();
            comboReino.Items.AddRange(listaReino.ToArray());

            comboDiet.SelectedIndex = 0;
            comboReino.SelectedIndex = 0;
        }

        private void ButtonCrear_Click(object sender, EventArgs e)
        {
            List<IHabitad> habitatsSeleccionados = new List<IHabitad>();
            foreach (var item in checkedListHabitad.CheckedItems)
            {
                habitatsSeleccionados.Add((IHabitad)item);
            }

            if (criaturaSeleccionada == null)
            {
                cntrCriatura.CreateCriatura(textNomb.Text,
                    (IDieta)comboDiet.SelectedItem,
                    int.Parse(textEnerg.Text),
                    int.Parse(textVida.Text),
                    int.Parse(textAtaq.Text),
                    int.Parse(textDef.Text),
                    (IReino)comboReino.SelectedItem,
                    habitatsSeleccionados);
            }
            else
            {
                criaturaSeleccionada.Nombre = textNomb.Text;
                criaturaSeleccionada.Dieta = (IDieta)comboDiet.SelectedItem;
                criaturaSeleccionada.MaxEnergia = int.Parse(textEnerg.Text);
                criaturaSeleccionada.Energia = int.Parse(textEnerg.Text);
                criaturaSeleccionada.MaxVida = int.Parse(textVida.Text);
                criaturaSeleccionada.Vida = int.Parse(textVida.Text);
                criaturaSeleccionada.PntAtack = int.Parse(textAtaq.Text);
                criaturaSeleccionada.PntDef = int.Parse(textDef.Text);
                criaturaSeleccionada.Reino = (IReino)comboReino.SelectedItem;
                criaturaSeleccionada.Habitads = habitatsSeleccionados;
            }

            LimpiarControles();
            CargarCriaturas();
        }

        private void CargarCriaturas()
        {
            List<Criatura> listCriatura = cntrCriatura.GetCriaturasList();
            dataGridCriatura.Rows.Clear();

            foreach (var criatura in listCriatura)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridCriatura);
                row.Cells[0].Value = criatura.Nombre;
                row.Cells[1].Value = criatura.Energia;
                row.Cells[2].Value = criatura.Vida;
                row.Cells[3].Value = criatura.PntAtack;
                row.Cells[4].Value = criatura.PntDef;
                row.Cells[5].Value = criatura.Reino.ToString();
                row.Cells[6].Value = criatura.Dieta.ToString();

                string habitadsString = string.Join(", ", criatura.Habitads.Select(h => h.ToString()));
                row.Cells[7].Value = habitadsString;

                row.Tag = criatura; 

                dataGridCriatura.Rows.Add(row);
            }
        }

        private void ButtonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAdmin formHome = new FormAdmin();
            formHome.Show();
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridCriatura.SelectedRows.Count > 0)
            {
                Criatura criaturaSeleccionada = (Criatura)dataGridCriatura.SelectedRows[0].Tag;
                cntrCriatura.EliminarCriatura(criaturaSeleccionada);
                CargarCriaturas();
            }
        }

        private void ButtonModificar_Click(object sender, EventArgs e)
        {
            if (dataGridCriatura.SelectedRows.Count > 0)
            {
                criaturaSeleccionada = (Criatura)dataGridCriatura.SelectedRows[0].Tag;
                textNomb.Text = criaturaSeleccionada.Nombre;
                comboDiet.SelectedItem = criaturaSeleccionada.Dieta;
                textEnerg.Text = criaturaSeleccionada.MaxEnergia.ToString();
                textVida.Text = criaturaSeleccionada.MaxVida.ToString();
                textAtaq.Text = criaturaSeleccionada.PntAtack.ToString();
                textDef.Text = criaturaSeleccionada.PntDef.ToString();
                comboReino.SelectedItem = criaturaSeleccionada.Reino;

                for (int i = 0; i < checkedListHabitad.Items.Count; i++)
                {
                    checkedListHabitad.SetItemChecked(i, false); // Desmarcar todos
                }

                foreach (var habitad in criaturaSeleccionada.Habitads)
                {
                    for (int i = 0; i < checkedListHabitad.Items.Count; i++)
                    {
                        if (checkedListHabitad.Items[i].ToString() == habitad.ToString())
                        {
                            checkedListHabitad.SetItemChecked(i, true);
                        }
                    }
                }

                dataGridCriatura.Rows.RemoveAt(dataGridCriatura.SelectedRows[0].Index); 
            }
        }

        private void LimpiarControles()
        {
            textNomb.Clear();
            comboDiet.SelectedIndex = 0;
            textEnerg.Clear();
            textVida.Clear();
            textAtaq.Clear();
            textDef.Clear();
            comboReino.SelectedIndex = 0;
            for (int i = 0; i < checkedListHabitad.Items.Count; i++)
            {
                checkedListHabitad.SetItemChecked(i, false);
            }
            criaturaSeleccionada = null;
        }
    }
}
