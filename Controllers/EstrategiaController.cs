using Fdsmlfr.Interfaces;
using Fdsmlfr.Model.Items.Buenos;
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
            List<IEstrategia> ListaEstrategias = new List<IEstrategia>
            {
                new SumVida(),
                new SumEnergia()
            };
            return ListaEstrategias;
        }
    }
}
