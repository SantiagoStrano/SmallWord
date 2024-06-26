﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fdsmlfr.Interfaces;
namespace Fdsmlfr.Model
{
    internal class DietCarnivoro: IDieta
    {
        public bool CanEat(IInteractuable food)
        {
            return food is Comida comida && comida.Dieta is DietCarnivoro;
        }

        public override string ToString()
        {
            return "Carnívoro";
        }
    }
}
