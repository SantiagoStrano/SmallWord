using Fdsmlfr.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fdsmlfr.Model.Dietas
{
    internal class DietOmnivoro : IDieta
    {
        public bool CanEat(IInteractuable food)
        {
            return food is Comida;
        }

        public override string ToString()
        {
            return "Omnivoro";
        }
    }
}
