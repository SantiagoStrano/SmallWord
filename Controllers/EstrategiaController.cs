using Fdsmlfr.Interfaces;
using Fdsmlfr.Model.Items.Buenos;
using Fdsmlfr.Model.Items.Malos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fdsmlfr.Controllers
{
    internal class EstrategiaController
    {
        static EstrategiaController Instance;
        public static EstrategiaController GetInstance()
        {
            if (Instance == null)
            {
                Instance = new EstrategiaController();
            }
            return Instance;
        }

        public List<IEstrategia> GetAllEstrategias()
        {
            return new List<IEstrategia>
        {
            new SumVida(),
            new SumEnergia(),
            new RestEnergia(),
            new RestVida()
        };
        }
    }
}
