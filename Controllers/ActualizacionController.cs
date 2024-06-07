using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (criatura.PuedePasarPorTerreno(terrenoDestino.Tipo))
            {
                terrenoOrigen.RemoveCriatura(criatura);
                terrenoDestino.AddCriatura(criatura);
            }
        }
    }
}
