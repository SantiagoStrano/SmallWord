using Fdsmlfr.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fdsmlfr.Model.Reinos
{
    internal class ReinoAstral : IReino
    {
        string IReino.GetType()
        {
            return GetType().Name;
        }

        public override string ToString()
        {
            return "Astral";
        }
    }
}
