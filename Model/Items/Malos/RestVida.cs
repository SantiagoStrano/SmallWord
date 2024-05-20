using Fdsmlfr.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fdsmlfr.Model.Items.Malos
{
    internal class RestVida: IEstrategia
    {
        public void AplicarEfecto(Criatura criatura, int cantidad) 
        {
            criatura.SetVida(cantidad);
        }

        public override string ToString()
        {
            return "Restar vida";
        }
    }
}
