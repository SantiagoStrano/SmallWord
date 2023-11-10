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
    public partial class FormPelea : Form
    {
        CriaturaController cntrCriatura = CriaturaController.GetInstace();
        public FormPelea()
        {
            InitializeComponent();
            List<Criatura> listCriatura = cntrCriatura.GetCriaturasList();

            comboCriatAtack.Items.AddRange(listCriatura.ToArray());
            comboCriatAtack.DisplayMember = "Nombre";

            comboBoxCriatDef.Items.AddRange(listCriatura.ToArray());
            comboBoxCriatDef.DisplayMember = "Nombre";
        }

        private void PonerDatosAtacante(object sender, EventArgs e)
        {
            Criatura criaturaSelec = (Criatura)comboCriatAtack.SelectedItem;
            textBoxVidaAtac.Text = criaturaSelec.Vida.ToString();
            textBoxAtacEnerg.Text = criaturaSelec.Energia.ToString();
            textBoxAtacPnAtc.Text = criaturaSelec.PntAtack.ToString();

        }

        private void PonerDatosDefensor(object sender, EventArgs e)
        {
            Criatura criaturaSelec = (Criatura)comboBoxCriatDef.SelectedItem;
            textBoxVidaDef.Text = criaturaSelec.Vida.ToString();
            textBoxEnergDef.Text = criaturaSelec.Energia.ToString();
            textBoxDefensorPnDef.Text = criaturaSelec.pntDef.ToString();

        }

        private void ButtonAtacar_Click(object sender, EventArgs e)
        {
            Criatura Atacante = (Criatura)comboCriatAtack.SelectedItem;
            Criatura Defensor = (Criatura)comboBoxCriatDef.SelectedItem;
            if(Atacante != null && Defensor != null) 
            {
                Atacante.Atacar(Defensor);
                textBoxVidaAtac.Text = Atacante.Vida.ToString();
                textBoxAtacEnerg.Text = Atacante.Energia.ToString();
                textBoxVidaDef.Text = Defensor.Vida.ToString();
                textBoxEnergDef.Text = Defensor.Energia.ToString();
            }
            else 
            {
                MessageBox.Show("Deben estar ambas criaturas seleccionadas");
            }
            
        }
    }
}
