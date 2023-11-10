using Fdsmlfr.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fdsmlfr.Interfaces
{
    internal interface ICombate
    {
        void Atacar(Criatura Defensor);
        void Defender(Criatura Atacante);
        bool VerificarEnergia(Criatura Atacante);

    }
}
