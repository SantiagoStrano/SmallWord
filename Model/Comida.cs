using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fdsmlfr.Interfaces;
namespace Fdsmlfr.Model
{
    internal class Comida: IInteractuable
    {
        private static int ContID = 0;
        public int Id { get; private set; }
        public string nombre;
        IDieta dieta;

        
        public string Nombre { get => nombre;  set => nombre = value; }
        public IDieta Dieta { get=> dieta; set=> dieta = value;}

        
        public Comida(string nombre, IDieta dieta)
        {
            ContID++;
            Id = ContID;
            Nombre = nombre;
            Dieta = dieta;
        }

        public void Interactuar(Criatura criatura)
        {
            throw new NotImplementedException();
        }
    }
}
