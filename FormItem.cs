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
    public partial class FormItem : Form
    {
        ItemController ctrlItem = ItemController.GetInstance();
        EstrategiaController ctrlEstrategia = EstrategiaController.GetInstance();
        List<IEstrategia> estrategiasDisponibles;

        public FormItem()
        {
            InitializeComponent();
            estrategiasDisponibles = ctrlEstrategia.GetAllEstrategias(); // Asegúrate de inicializar esto antes de usarlo

            foreach (IEstrategia estrategia in estrategiasDisponibles)
            {
                comboEfectos.Items.Add(estrategia.ToString());
            }
            CargarItems();
        }

        private void buttonCreateItem_Click(object sender, EventArgs e)
        {
            List<EstrategiaConCantidad> estrategiasSeleccionadas = new List<EstrategiaConCantidad>();

            foreach (DataGridViewRow row in dataGridEfectos.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    string nombreEstrategia = row.Cells[0].Value.ToString();
                    int valor = Convert.ToInt32(row.Cells[1].Value);

                    IEstrategia estrategia = estrategiasDisponibles.Find(estr => estr.ToString() == nombreEstrategia);
                    if (estrategia != null)
                    {
                        estrategiasSeleccionadas.Add(new EstrategiaConCantidad(estrategia, valor));
                    }
                }
            }

            if (!string.IsNullOrEmpty(textNombre.Text) && estrategiasSeleccionadas.Count > 0)
            {
                ctrlItem.CreateItem(textNombre.Text, estrategiasSeleccionadas);
                LimpiarControles();
                CargarItems();
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos antes de crear el ítem.");
            }
        }

        private void CargarItems()
        {
            List<Item> listItems = ctrlItem.GetItemList();
            dataGridItems.Rows.Clear();
            foreach (var item in listItems)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridItems);
                row.Cells[0].Value = item.Nombre;
                string estrategiasString = string.Join(", ", item.Estrategias.Select(e => e.ToString()));
                row.Cells[1].Value = estrategiasString;
                dataGridItems.Rows.Add(row);
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (comboEfectos.SelectedItem != null && !string.IsNullOrEmpty(textCant.Text))
            {
                string efectoSeleccionado = comboEfectos.SelectedItem.ToString();
                int valor;
                if (int.TryParse(textCant.Text, out valor))
                {
                    dataGridEfectos.Rows.Add(efectoSeleccionado, valor);
                    comboEfectos.SelectedIndex = -1;
                    textCant.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor válido para la cantidad.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un efecto y una cantidad antes de agregar.");
            }
        }
        private void buttonEliminarEfecto_Click(object sender, EventArgs e)
        {
            if (dataGridEfectos.SelectedRows.Count > 0)
            {
                dataGridEfectos.Rows.RemoveAt(dataGridEfectos.SelectedRows[0].Index);
            }
        }
       

        private void buttonEliminarItem_Click(object sender, EventArgs e)
        {
            if (dataGridItems.SelectedRows.Count > 0)
            {
                string nombreItem = dataGridItems.SelectedRows[0].Cells[0].Value.ToString();
                ctrlItem.EliminarItem(nombreItem);
                CargarItems();
            }
        }

        private void buttonModificarItem_Click(object sender, EventArgs e)
        {
            if (dataGridItems.SelectedRows.Count > 0)
            {
                // Obtener el nombre del ítem seleccionado
                string nombreItem = dataGridItems.SelectedRows[0].Cells[0].Value.ToString();

                // Buscar el ítem en el controlador de ítems
                Item itemSeleccionado = ctrlItem.GetItem(nombreItem);

                // Mostrar el nombre del ítem en el textbox
                textNombre.Text = itemSeleccionado.Nombre;

                // Mostrar las estrategias del ítem en la tabla dataGridEfectos
                dataGridEfectos.Rows.Clear();
                foreach (var estrategiaConCantidad in itemSeleccionado.Estrategias)
                {
                    dataGridEfectos.Rows.Add(estrategiaConCantidad.Estrategia.ToString(), estrategiaConCantidad.Cantidad);
                }

                // Eliminar el ítem seleccionado del controlador y actualizar la lista de ítems
                ctrlItem.EliminarItem(nombreItem);
                CargarItems();
            }
        }

        private void LimpiarControles()
        {
            textNombre.Clear();
            comboEfectos.SelectedIndex = -1;
            textCant.Clear();
            dataGridEfectos.Rows.Clear();
        }

    }
}
