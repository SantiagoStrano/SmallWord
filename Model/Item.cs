using Fdsmlfr.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fdsmlfr.Model
{
    internal class Item: IInteractuable
    {
        public string nombre;
        public List<IEstrategia> estrategias;

        public string Nombre { get => nombre; set => nombre = value; }
        public List<IEstrategia> Estrategias { get => estrategias; set => estrategias = value; }

        public Item(string nombre, List<IEstrategia> estrategias) 
        { 
            Nombre = nombre;
            Estrategias = estrategias;
        }

        public void Interactuar(Criatura criatura)
        {
            foreach (var estrategia in Estrategias)
            {
                estrategia.AplicarEfecto(criatura);
            }
        }
    }
}
