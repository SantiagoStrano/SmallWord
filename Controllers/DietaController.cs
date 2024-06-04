using Fdsmlfr.Interfaces;
using Fdsmlfr.Model;
using Fdsmlfr.Model.Dietas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fdsmlfr.Controllers
{
    internal class DietaController
    {
        static DietaController Instance;
        

        public static DietaController GetInstace()
        {
            if (Instance == null)
            {
                Instance = new DietaController();
            }
            return Instance;
        }
        public List<IDieta> GetAllDietas() 
        {
            List<IDieta> listaDietas = new List<IDieta>
            {
                new DietCarnivoro(),
                new DietVegetariano(),
                new DietOmnivoro()
            };
            return listaDietas;
        }
        public List<IDieta> GetAllDietasNotOmnivoro()
        {
            List<IDieta> listaDietas = new List<IDieta>
            {
                new DietCarnivoro(),
                new DietVegetariano()
                
            };
            return listaDietas;
        }
    }
}
