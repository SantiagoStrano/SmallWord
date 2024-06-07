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
        public string Nombre { get; set; }
        public List<EstrategiaConCantidad> Estrategias { get; set; }

        public Item(string nombre, List<EstrategiaConCantidad> estrategias)
        {
            Nombre = nombre;
            Estrategias = estrategias;
        }

        public Item Clone()
        {
            return new Item(Nombre, new List<EstrategiaConCantidad>(Estrategias));
        }
        public void Interactuar(Criatura criatura)
        {
            foreach (var estrategiaConCantidad in Estrategias)
            {
                estrategiaConCantidad.Estrategia.AplicarEfecto(criatura, estrategiaConCantidad.Cantidad);
            }
        }
    }
}
