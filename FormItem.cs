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
        public FormItem()
        {
            InitializeComponent();
            List<IEstrategia> listaEstrategias = ctrlEstrategia.GetAllEstrategias();
            checkedListBoxEstrategia.Items.AddRange(listaEstrategias.ToArray());
        }

        private void buttonCreateItem_Click(object sender, EventArgs e)
        {
            List<IEstrategia> EstrategiasSeleccionadas = new List<IEstrategia>();
            foreach (IEstrategia estrategia in checkedListBoxEstrategia.CheckedItems)
            {
                EstrategiasSeleccionadas.Add(estrategia);
            }
            ctrlItem.CreateItem(textNombre.Text,
                EstrategiasSeleccionadas);
            CargarItems();
            
        }
        private void CargarItems() 
        {
            List<Item> listItems = ctrlItem.GetItemList();
            dataGridItems.Rows.Clear();
            foreach (var Item in listItems) 
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridItems);
                row.Cells[0].Value = Item.Nombre;
                string estrategiasStromg = string.Join(", ", Item.Estrategias.Select(h => h.ToString()));
                row.Cells[1].Value = estrategiasStromg;
                dataGridItems.Rows.Add(row);
            }

        }
    }
}
