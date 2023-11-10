using Fdsmlfr.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fdsmlfr.Model
{
    internal class HabitadAereo: IHabitad
    {
        public bool CanHabitar(ITerreno terreno)
        {
            return terreno is TerrenoAire;
        }

        public override string ToString()
        {
            return "Aereo";
        }
    }
}
