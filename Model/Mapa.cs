using Fdsmlfr.Controllers;
using Fdsmlfr.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fdsmlfr.Model
{
    internal class Mapa: IMapa
    {
        private static int ContID = 0;
        public int Id { get; private set; }
        List<ITerreno> terrenos;
        List<Criatura> criaturas;

        public List<ITerreno> Terrenos { get => terrenos; set => terrenos = value; }
        public List<Criatura> Criaturas { get => criaturas; set => criaturas = value; }

        public Mapa(int id, List<ITerreno> terrenos, List<Criatura> criaturas)
        {
            Id = ContID++;
            Terrenos = terrenos;
            Criaturas = criaturas;
        }

        public List<ITerreno> GenerarMapaAleatorio(int cantidadTerrenos)
        {
            List<ITerreno> todosLosTerrenos = TerrenoController.GetInstance().GetAllTerrenos();
            Random random = new Random();
            List<ITerreno> terrenosAleatorios = new List<ITerreno>();

            for (int i = 0; i < cantidadTerrenos; i++)
            {
                int indiceAleatorio = random.Next(todosLosTerrenos.Count);
                terrenosAleatorios.Add(todosLosTerrenos[indiceAleatorio]);
            }

            return terrenosAleatorios;
        }

        public static List<int> ObtenerTerrenosAdyacentes(int terrenoId)
        {
            switch (terrenoId)
            {
                case 1: return new List<int> { 2, 3, 4, 5, 6, 7 };
                case 2: return new List<int> { 1, 3, 7 };
                case 3: return new List<int> { 1, 2, 4 };
                case 4: return new List<int> { 1, 3, 5 };
                case 5: return new List<int> { 1, 4, 6 };
                case 6: return new List<int> { 1, 5, 7 };
                case 7: return new List<int> { 1, 2, 6 };
                default: return new List<int>();
            }
        }

    }
}
