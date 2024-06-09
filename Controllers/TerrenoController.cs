using Fdsmlfr.Interfaces;
using Fdsmlfr.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fdsmlfr.Controllers
{
    internal class TerrenoController
    {
        static TerrenoController Instance;
        public static TerrenoController GetInstance() //singleton
        {
            if (Instance == null)
            {
                Instance = new TerrenoController();
            }
            return Instance;
        }
        public List<ITerreno> GetAllTerrenos() 
        {
            List<ITerreno> listaTerrenos = new List<ITerreno>
            {
                new TerrenoAgua(),
                //new TerrenoAire(),
                new TerrenoTierra()
            };
            return listaTerrenos;
        }
    }
}
