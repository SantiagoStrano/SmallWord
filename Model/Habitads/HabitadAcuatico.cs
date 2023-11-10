using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fdsmlfr.Interfaces;

namespace Fdsmlfr.Model
{
    internal class HabitadAcuatico: IHabitad
    {
        public bool CanHabitar(ITerreno terreno) 
        {
            return terreno is TerrenoAgua;
        }

        public override string ToString()
        {
            return "Acuatico";
        }
    }
}
