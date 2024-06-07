using Fdsmlfr.Controllers;
using Fdsmlfr.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fdsmlfr.Model
{
    internal class Game
    {
        public List<Criatura> CriaturasOriginales { get; private set; }
        public List<Criatura> CriaturasDisponibles { get; private set; }
        public List<Comida> ComidasOriginales { get; private set; }
        public List<Item> ItemsOriginales { get; private set; }
        public List<IInteractuable> InteractuablesDisponibles { get; private set; }
        public List<Terreno> Terrenos { get; set; }

        public Game()
        {
            CriaturasOriginales = CriaturaController.GetInstace().GetCriaturasList();
            ComidasOriginales = ComidaController.GetInstace().GetComidaList();
            ItemsOriginales = ItemController.GetInstance().GetItemList();

            //copy
            ResetDisponibles();
        }

        public void ResetDisponibles()
        {
            CriaturasDisponibles = new List<Criatura>(CriaturasOriginales);
            InteractuablesDisponibles = new List<IInteractuable>();
            InteractuablesDisponibles.AddRange(ComidasOriginales);
            InteractuablesDisponibles.AddRange(ItemsOriginales);
        }
    }
}
