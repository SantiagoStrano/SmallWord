using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fdsmlfr.Model
{
    public class Dado
    {
        static Random RandomValor = new Random();
        public static int LanzarDado(int Caras) 
        { 
            return RandomValor.Next(1,Caras);
        }
    }
}
