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

namespace Fdsmlfr
{
    public partial class FormAdmin : Form
    {
        
        public FormAdmin()
        {
            InitializeComponent();
            
        }

        private void buttonCriatura_Click(object sender, EventArgs e)
        {
            
            
            FormCriatura formCriatura = new FormCriatura();
            formCriatura.Show();
        }

        private void buttonComida_Click(object sender, EventArgs e)
        {
            
            FormComida formComida = new FormComida();
            formComida.Show();
        }

        private void buttonLucha_Click(object sender, EventArgs e)
        {
            FormPelea formPelea = new FormPelea();
            formPelea.Show();
        }

        private void buttonItem_Click(object sender, EventArgs e)
        {
            FormItem formItem = new FormItem();
            formItem.Show();
        }

        private void buttonUsarItem_Click(object sender, EventArgs e)
        {
            FormItemPrueba formItemPrueba = new FormItemPrueba();
            formItemPrueba.Show();
        }

        private void buttonMap_Click(object sender, EventArgs e)
        {
            FormGame formGame = new FormGame();
            formGame.Show();
        }
    }
}
