using Fdsmlfr.Interfaces;
using Fdsmlfr.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fdsmlfr.Controllers
{
    internal class HabitadController
    {
        static HabitadController Instance;


        public static HabitadController GetInstace()
        {
            if (Instance == null)
            {
                Instance = new HabitadController();
            }
            return Instance;
        }
        public List<IHabitad> GetAllHabitads()
        {
            List<IHabitad> listaHabitads = new List<IHabitad>
            {
                new HabitadAcuatico(),
                new HabitadAereo(),
                new HabitadTerrestre()
                
            };
            return listaHabitads;
        }
    }
}
