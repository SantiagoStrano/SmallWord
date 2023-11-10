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
    }
}
