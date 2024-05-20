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
        public FormIndex()
        {
            InitializeComponent();
            cntrCriatura.CriaturasPrecargadas();
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
