using Fdsmlfr.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fdsmlfr.Model.Items.Buenos
{
    internal class SumVida: IEstrategia
    {
        public void AplicarEfecto(Criatura criatura, int cantidad)
        {
            criatura.SetVidaPlus(cantidad);
        }

        public override string ToString()
        {
            return "Sumar vida";
        }
    }
}
