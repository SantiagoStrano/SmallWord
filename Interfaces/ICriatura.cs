using Fdsmlfr.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fdsmlfr.Interfaces
{
    internal interface ICriatura
    {
        void Comer(Comida comida);
        void Dormir();

        bool PuedePasarPorTerreno(ITerreno terreno);

        //void Morir();
    }
}
