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

namespace Fdsmlfr
{
    public partial class FormItemPrueba : Form
    {
        CriaturaController cntrCriatura = CriaturaController.GetInstace();
        ItemController ctrlItem = ItemController.GetInstance();
        public FormItemPrueba()
        {
            InitializeComponent();
            List<Criatura> listCriatura = cntrCriatura.GetCriaturasList();
            comboCriatura.Items.AddRange(listCriatura.ToArray());
            comboCriatura.DisplayMember = "Nombre";
            
            List<Item> listItem = ctrlItem.GetItemList();
            comboItem.Items.AddRange(listItem.ToArray());
            comboItem.DisplayMember = "Nombre";
        }

        private void ButtonInteractuar_Click(object sender, EventArgs e)
        {
            Criatura criaturaSeleccionada = (Criatura)comboCriatura.SelectedItem;
            Item itemSeleccionado = (Item)comboItem.SelectedItem;

            if (criaturaSeleccionada != null && itemSeleccionado != null)
            {
                itemSeleccionado.Interactuar(criaturaSeleccionada);
                MessageBox.Show("Item utilizado correctamente");


            }
        }
    }
}
