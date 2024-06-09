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

        public void CreateItem(string nombre, List<EstrategiaConCantidad> estrategias)
        {
            ListItems.Add(new Item(nombre, estrategias));
        }

        public List<Item> GetItemList()
        {
            return ListItems;
        }

        public void EliminarItem(string nombre)
        {
            var item = ListItems.Find(i => i.Nombre == nombre);
            if (item != null)
            {
                ListItems.Remove(item);
            }
        }

        public Item GetItem(string nombre)
        {
            return ListItems.Find(i => i.Nombre == nombre);
        }
        public void ItemsPreCargados()
        {
            CreateItem("Manzana dorada", new List<EstrategiaConCantidad>
            {
                new EstrategiaConCantidad(EstrategiaController.GetInstance().GetAllEstrategias()[0], 10),
                new EstrategiaConCantidad(EstrategiaController.GetInstance().GetAllEstrategias()[1], 25)
            });
            CreateItem("Corte", new List<EstrategiaConCantidad>
            {
                new EstrategiaConCantidad(EstrategiaController.GetInstance().GetAllEstrategias()[2], 30)
            });

        }
    }
}
