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
    internal class CriaturaController
    {
        static CriaturaController Instance;
        List<Criatura> ListCriaturas = new List<Criatura>();

        public static CriaturaController GetInstace()
        {
            if (Instance == null)
            {
                Instance = new CriaturaController();
            }
            return Instance;
        }

        public void CreateCriatura(string Nombre, IDieta Dieta, int MaxEnergia, int MaxVida, int PntAtack, int PntDef, IReino Reino, List<IHabitad> Habitads)
        {
            ListCriaturas.Add(new Criatura(Nombre, Dieta, MaxEnergia, MaxVida, PntAtack, PntDef, Reino, Habitads));
        }

        public List<Criatura> GetCriaturasList()
        {
            return ListCriaturas;
        }

        public void EliminarCriatura(Criatura criatura)
        {
            ListCriaturas.Remove(criatura);
        }

        public void CriaturasPrecargadas()
        {
            List<IHabitad> habitadsCriatura1 = new List<IHabitad> { new HabitadAcuatico(), new HabitadAereo() };
            CreateCriatura("Milaneso", new DietVegetariano(), 100, 100, 10, 20, new ReinoAnimal(), habitadsCriatura1);
            List<IHabitad> habitadsCriatura2 = new List<IHabitad> { new HabitadAcuatico(), new HabitadTerrestre() };
            CreateCriatura("El Mike", new DietCarnivoro(), 100, 100, 20, 10, new ReinoAnimal(), habitadsCriatura2);
            List<IHabitad> habitadsCriatura3 = new List<IHabitad> { new HabitadAereo() };
            CreateCriatura("Lord Valdomero", new DietCarnivoro(), 100, 100, 20, 20, new ReinoAnimal(), habitadsCriatura3);
        }
    }
}
