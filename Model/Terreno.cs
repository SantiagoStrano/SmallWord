﻿using Fdsmlfr.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fdsmlfr.Model
{
    internal class Terreno
    {
        //private static int ContID = 0;
        //public int Id { get; private set; }
        public ITerreno tipo;
        public List<IInteractuable> interactuables;

        public ITerreno Tipo { get => tipo; set => tipo = value;}
        public List<IInteractuable> Interactuables { get => interactuables; set => interactuables = value; }


        public Terreno (ITerreno tipo, List<IInteractuable> interactuables) 
        {
            //Id = ContID++;
            Tipo = tipo;
            Interactuables = interactuables;
        }
    }
}
