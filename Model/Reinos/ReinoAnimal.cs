using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fdsmlfr.Interfaces;

namespace Fdsmlfr.Model
{
    internal class ReinoAnimal: IReino
    {
        string IReino.GetType()
        {
            return GetType().Name;
        }

        public override string ToString()
        {
            return "Animal";
        }
    }
}
