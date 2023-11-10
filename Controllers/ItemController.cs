using Fdsmlfr.Interfaces;
using Fdsmlfr.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fdsmlfr.Controllers
{
    internal class ItemController
    {
        static ItemController Instance;
        List<Item> ListItems = new List<Item>();

        public static ItemController GetInstance() 
        {
            if (Instance == null)
            {
                Instance = new ItemController();
            }
            return Instance;
        }
        public void CreateItem(string Nombre, List<IEstrategia> Estrategias) 
        {
            ListItems.Add(new Item(Nombre, Estrategias));
        }

        public List<Item> GetItemList() 
        {
            return ListItems;
        }
    }
}
