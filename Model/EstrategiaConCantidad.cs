using Fdsmlfr.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fdsmlfr.Model
{
    internal class EstrategiaConCantidad
    {
        public IEstrategia Estrategia { get; set; }
        public int Cantidad { get; set; }

        public EstrategiaConCantidad(IEstrategia estrategia, int cantidad)
        {
            Estrategia = estrategia;
            Cantidad = cantidad;
        }

        public override string ToString()
        {
            return $"{Estrategia} (Valor: {Cantidad})";
        }
    }
}
