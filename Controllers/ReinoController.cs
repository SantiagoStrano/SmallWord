using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fdsmlfr.Interfaces;
using Fdsmlfr.Model;
using Fdsmlfr.Model.Reinos;

namespace Fdsmlfr.Controllers
{
    internal class ReinoController
    {
        static ReinoController Instance;

        public static ReinoController GetInstance() 
        {
            if (Instance == null)
            {
                Instance = new ReinoController();
            }
            return Instance;
        }

        public List<IReino> GetAllReinos() 
        {
            List<IReino> listaReinos = new List<IReino>
            {
                new ReinoAnimal(),
                new ReinoAstral(),
                new ReinoMaquina()


            };
            return listaReinos;
        }
    }
}
