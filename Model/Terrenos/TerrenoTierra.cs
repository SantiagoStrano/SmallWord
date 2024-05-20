using Fdsmlfr.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fdsmlfr.Model
{
    internal class TerrenoTierra: ITerreno
    {
        public override string ToString()
        {
            return "Tierra";
        }
        public System.Drawing.Image GetImage()
        {
            return System.Drawing.Image.FromFile("Img/Htierra.png");
        }
    }
}
