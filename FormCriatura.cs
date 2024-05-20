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

            cntrCriatura.CreateCriatura(textNomb.Text,
                (IDieta)comboDiet.SelectedItem,
                int.Parse(textEnerg.Text),
                int.Parse(textVida.Text),
                int.Parse(textAtaq.Text),
                int.Parse(textDef.Text),
                (IReino)comboReino.SelectedItem,
                habitatsSeleccionados);

            CargarCriaturas();
        }

        private void CargarCriaturas()
        {
            List<Criatura> listCriatura = cntrCriatura.GetCriaturasList();
            dataGridCriatura.Rows.Clear();

            foreach (var Criatura in listCriatura)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridCriatura);
                row.Cells[0].Value = Criatura.Nombre;
                row.Cells[1].Value = Criatura.Energia;
                row.Cells[2].Value = Criatura.Vida;
                row.Cells[3].Value = Criatura.PntAtack;
                row.Cells[4].Value = Criatura.PntDef;
                row.Cells[5].Value = Criatura.Reino.ToString();
                row.Cells[6].Value = Criatura.Dieta.ToString();

                string habitadsString = string.Join(", ", Criatura.Habitads.Select(h => h.ToString()));
                row.Cells[7].Value = habitadsString;

                dataGridCriatura.Rows.Add(row);
            }
        }

        private void ButtonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAdmin formHome = new FormAdmin();
            formHome.Show();
        }
    }
}
