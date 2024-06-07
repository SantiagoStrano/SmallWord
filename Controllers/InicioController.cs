using Fdsmlfr.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fdsmlfr.Model
{
    internal class InicioController
    {
        private readonly Game juego;

        public InicioController(Game game)
        {
            juego = game;
        }

        public void InitializeGame(List<PictureBox> pictureBoxes)
        {
            juego.ResetDisponibles();
            InitializeTerrenos(pictureBoxes);
        }

        private void InitializeTerrenos(List<PictureBox> pictureBoxes)
        {
            Random random = new Random();
            juego.Terrenos = new List<Terreno>();

            foreach (var pictureBox in pictureBoxes)
            {
                ITerreno tipoTerreno = random.Next(2) == 0 ? (ITerreno)new TerrenoAgua() : (ITerreno)new TerrenoTierra();
                var terreno = new Terreno(tipoTerreno);

                var criaturaAleatoria = GetCriaturaAleatoriaParaTerreno(tipoTerreno);
                if (criaturaAleatoria != null)
                {
                    terreno.AddCriatura(criaturaAleatoria);
                }

                var interactuableAleatorio = GetInteractuableAleatorio();
                if (interactuableAleatorio != null)
                {
                    terreno.AddInteractuable(interactuableAleatorio);
                }

                juego.Terrenos.Add(terreno);
                pictureBox.Image = tipoTerreno.GetImage();
            }
        }

        private Criatura GetCriaturaAleatoriaParaTerreno(ITerreno terreno)
        {
            var criaturasCompatibles = juego.CriaturasDisponibles.Where(c => c.PuedePasarPorTerreno(terreno)).ToList();
            if (criaturasCompatibles.Count > 0)
            {
                Random random = new Random();
                int index = random.Next(criaturasCompatibles.Count);
                var criatura = criaturasCompatibles[index];
                juego.CriaturasDisponibles.Remove(criatura);
                return criatura;
            }
            return null;
        }

        private IInteractuable GetInteractuableAleatorio()
        {
            if (juego.InteractuablesDisponibles.Count > 0)
            {
                Random random = new Random();
                int index = random.Next(juego.InteractuablesDisponibles.Count);
                var interactuable = juego.InteractuablesDisponibles[index];
                juego.InteractuablesDisponibles.RemoveAt(index);
                return interactuable;
            }
            return null;
        }
    }
}
