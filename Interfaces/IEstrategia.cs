using Fdsmlfr.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fdsmlfr.Interfaces
{
    public interface IEstrategia
    {
        void AplicarEfecto(Criatura criatura, int cantidad);
    }
}
