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
    public partial class FormComidaPrueba : Form
    {
        CriaturaController cntrlCriatura = CriaturaController.GetInstace();
        ComidaController cntrlComida = ComidaController.GetInstace();

        public FormComidaPrueba()
        {
            InitializeComponent();
            List<Criatura> listCriatura = cntrlCriatura.GetCriaturasList();
            List<Comida> listComida = cntrlComida.GetComidaList();

            
            comboBoxCriatura.Items.AddRange(listCriatura.ToArray());
            comboBoxCriatura.DisplayMember = "Nombre";

           
            comboBoxComida.Items.AddRange(listComida.ToArray());
            comboBoxComida.DisplayMember = "Nombre";
        }

      

        private void ponerDatosCriatura(object sender, EventArgs e)
        {
            Criatura criaturaSelec = (Criatura)comboBoxCriatura.SelectedItem;
            textBoxDietaAnimal.Text = criaturaSelec.Dieta.ToString();
            textBoxEnergia.Text = criaturaSelec.Energia.ToString();
        }

        private void ponerDatosComida(object sender, EventArgs e)
        {
            Comida comidaSelec = (Comida)comboBoxComida.SelectedItem;
            textBoxDieta.Text = comidaSelec.Dieta.ToString();
        }

        private void buttonComer_Click(object sender, EventArgs e)
        {
            Criatura criaturaSelec = (Criatura)comboBoxCriatura.SelectedItem;
            Comida comidaSelec = (Comida)comboBoxComida.SelectedItem;

            if (criaturaSelec != null && comidaSelec != null)
            {
                ICriatura criaturaInterface = (ICriatura)criaturaSelec;
                criaturaInterface.Comer(comidaSelec);
                textBoxEnergia.Text = criaturaSelec.Energia.ToString();
            }
        }
    }
}
