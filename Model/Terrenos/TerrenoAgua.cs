using Fdsmlfr.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Fdsmlfr.Model
{
    internal class TerrenoAgua: ITerreno
    {
        public override string ToString()
        {
            return "Agua";
        }
        public System.Drawing.Image GetImage()
        {
            return System.Drawing.Image.FromFile("Img/Hagua.png");
        }
    }
}
