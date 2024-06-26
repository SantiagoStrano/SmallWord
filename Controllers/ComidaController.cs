﻿using Fdsmlfr.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fdsmlfr.Interfaces;
using Fdsmlfr.Model.Dietas;

namespace Fdsmlfr.Controllers
{
    internal class ComidaController
    {
        static ComidaController Instance;
        List<Comida> ListComida = new List<Comida>();

        public static ComidaController GetInstace() 
        { 
            if (Instance == null)
            {
                Instance = new ComidaController();
            }
            return Instance;
        }

        public void CreateFood(string Nombre, IDieta Dieta) 
        {
            ListComida.Add(new Comida(Nombre, Dieta));
        }

        public List<Comida> GetComidaList() 
        {
            return ListComida;
        }
        
        public void EliminarComida(Comida comida) 
        { 
            ListComida.Remove(comida);
        }
        public void ComidasPreCargadas() 
        {
            CreateFood("Tomate", new DietVegetariano());
            CreateFood("Lechuga", new DietVegetariano());
            CreateFood("Zanahoria", new DietVegetariano());
            CreateFood("Pollo", new DietCarnivoro());
            CreateFood("Chuletas", new DietCarnivoro());

        }
    }
}
