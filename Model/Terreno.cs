using Fdsmlfr.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fdsmlfr.Model
{
    public class Terreno
    {

        public ITerreno tipo;
        public List<Criatura> criaturas;
        public List<IInteractuable> interactuables;

        public ITerreno Tipo { get => tipo; set => tipo = value; }
        public List<Criatura> Criaturas { get => criaturas; set => criaturas = value; }
        public List<IInteractuable> Interactuables { get => interactuables; set => interactuables = value; }

        public Terreno(ITerreno tipo)
        {
            Tipo = tipo;
            Criaturas = new List<Criatura>();
            Interactuables = new List<IInteractuable>();
        }

        public void AddCriatura(Criatura criatura)
        {
            Criaturas.Add(criatura);
        }

        public void RemoveCriatura(Criatura criatura)
        {
            Criaturas.Remove(criatura);
        }

        public void AddInteractuable(IInteractuable interactuable)
        {
            Interactuables.Add(interactuable);
        }

        public void RemoveInteractuable(IInteractuable interactuable)
        {
            Interactuables.Remove(interactuable);
        }
    }
}
