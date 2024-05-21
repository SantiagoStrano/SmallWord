using Fdsmlfr.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fdsmlfr.Model.Dietas
{
    internal class DietVegetariano : IDieta
    {
        public bool CanEat(IInteractuable food)
        {
            return food is Comida comida && comida.Dieta is DietVegetariano;
        }

        public override string ToString()
        {
            return "Vegetariano";
        }
    }
}

