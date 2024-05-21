using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fdsmlfr.Interfaces
{
    public interface IDieta
    {
        bool CanEat(IInteractuable food);
    }
}
