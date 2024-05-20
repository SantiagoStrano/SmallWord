using Fdsmlfr.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fdsmlfr.Model.Items.Malos
{
    internal class RestEnergia: IEstrategia
    {
        public void AplicarEfecto(Criatura criatura, int cantidad)
        {
            criatura.SetEnergia(cantidad);
        }

        public override string ToString()
        {
            return "Restar energía";
        }
    }
}
