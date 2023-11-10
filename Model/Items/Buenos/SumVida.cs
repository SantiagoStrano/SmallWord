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
        public void AplicarEfecto(Criatura criatura)
        {
            criatura.Vida +=  50;
        }

        public override string ToString()
        {
            return "Sumar vida";
        }
    }
}
