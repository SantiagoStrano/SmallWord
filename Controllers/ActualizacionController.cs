using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fdsmlfr.Model
{
    internal class ActualizacionController
    {
        private readonly Game juego;

        public ActualizacionController(Game game)
        {
            juego = game;
        }

        public void MoverCriatura(Terreno terrenoOrigen, Terreno terrenoDestino, Criatura criatura)
        {
            if (criatura.PuedePasarPorTerreno(terrenoDestino))
            {
                terrenoOrigen.RemoveCriatura(criatura);
                terrenoDestino.AddCriatura(criatura);
                MessageBox.Show("La criatura se ha movido correctamento");
            }
            else
            {
                MessageBox.Show("La criatura no puede pasar por el terreno");
            }
        }

        public void UsarItem(Criatura criatura, Item item)
        {
            item.Interactuar(criatura);
            MessageBox.Show($"{criatura.Nombre} ha usado {item.Nombre}.");
        }
    }
}
