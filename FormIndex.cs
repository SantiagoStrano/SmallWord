using Fdsmlfr.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fdsmlfr
{
    public partial class FormIndex : Form
    {
        CriaturaController cntrCriatura = CriaturaController.GetInstace();
        ComidaController cntrComida = ComidaController.GetInstace();
        ItemController cntrItem = ItemController.GetInstance();
        public FormIndex()
        {
            InitializeComponent();
            cntrCriatura.CriaturasPrecargadas();
            cntrComida.ComidasPreCargadas();
            cntrItem.ItemsPreCargados();
            buttonEntrar.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAdmin.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {

            Form frm = new FormGame();
            frm.ShowDialog();
            //this.Close();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            Form frm = new FormAdmin();
            frm.ShowDialog();
            //this.Close();
        }
    }
}
