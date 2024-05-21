using Fdsmlfr.Controllers;
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
using Fdsmlfr.Interfaces;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Fdsmlfr
{
    public partial class FormComida : Form
    {
        ComidaController cntrlComida = ComidaController.GetInstace();
        DietaController cntrlDieta = DietaController.GetInstace();
        private Comida comidaSeleccionada;

        public FormComida()
        {
            InitializeComponent();
            CargarComida();
            CargarCombos();
        }

        private void CargarCombos()
        {
            comboDiet.Items.Add("-Seleccionar dieta-");
            List<IDieta> listaDietas = cntrlDieta.GetAllDietas();
            comboDiet.Items.AddRange(listaDietas.ToArray());
            comboDiet.SelectedIndex = 0;
        }

        private void buttomCreate_Click(object sender, EventArgs e)
        {
            if (comidaSeleccionada == null)
            {
                cntrlComida.CreateFood(tbNombre.Text,
                    (IDieta)comboDiet.SelectedItem);
            }
            else
            {
                comidaSeleccionada.Nombre = tbNombre.Text;
                comidaSeleccionada.Dieta = (IDieta)comboDiet.SelectedItem;
            }

            LimpiarControles();
            CargarComida();
        }

        public void CargarComida()
        {
            List<Comida> listComida = cntrlComida.GetComidaList();
            dataGridComida.Rows.Clear();
            foreach (var comida in listComida)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridComida);
                row.Cells[0].Value = comida.Nombre;
                row.Cells[1].Value = comida.Dieta.ToString();
                row.Tag = comida; // Asociar la comida con la fila
                dataGridComida.Rows.Add(row);
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAdmin formHome = new FormAdmin();
            formHome.Show();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridComida.SelectedRows.Count > 0)
            {
                Comida comidaSeleccionada = (Comida)dataGridComida.SelectedRows[0].Tag;
                cntrlComida.EliminarComida(comidaSeleccionada);
                CargarComida();
            }
        }


        private void LimpiarControles()
        {
            tbNombre.Clear();
            comboDiet.SelectedIndex = 0;
            comidaSeleccionada = null;
        }
    }
}
