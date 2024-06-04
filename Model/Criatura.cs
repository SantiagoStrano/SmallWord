using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fdsmlfr.Controllers;
using Fdsmlfr.Interfaces;
using Fdsmlfr.Model.Dietas;

namespace Fdsmlfr.Model
{
    public class Criatura: ICriatura
    {
        private static int ContID = 0;
        public int Id { get; private set; }
        public string nombre;
        public IDieta dieta;
        public int maxEnergia;
        public int energia;
        public int maxVida;
        public int vida;
        public int pntAtack;
        public int pntDef;
        public IReino reino;
        public List<IHabitad> habitads;
        

        //propiedades
        public string Nombre {get=> nombre; set=> nombre = value; }
        public IDieta Dieta { get => dieta; set => dieta = value; }
        public int MaxEnergia { get => maxEnergia; set => maxEnergia = value; }
        public int Energia { get => energia; set => energia = value;}
        public int MaxVida { get => maxVida; set => maxVida = value;}
        public int Vida { get => vida; set => vida = value;}
        public int PntAtack { get => pntAtack; set => pntAtack = value;}
        public int PntDef { get => pntDef; set => pntDef = value;}
        public IReino Reino { get => reino; set => reino = value;}
        public List<IHabitad>Habitads { get => habitads; set => habitads = value; }
       
        public Criatura(string nombre, IDieta dieta, int maxEnergia, int maxVida, int pntAtack, int pntDef, IReino reino, List<IHabitad> habitads)
        {
            Id = ContID++;
            Nombre = nombre;
            Dieta = dieta;
            MaxEnergia = maxEnergia;
            Energia = MaxEnergia;
            MaxVida = maxVida;
            Vida = MaxVida;
            PntAtack = pntAtack;
            PntDef = pntDef;
            Reino = reino;
            Habitads = habitads;
           
        }

        public Criatura Clone()
        {
            return new Criatura(Nombre, Dieta, MaxEnergia, MaxVida, PntAtack, PntDef, Reino, new List<IHabitad>(Habitads));
        }
        public void Dormir()
        {
            Energia += 30;
            if(Energia > MaxEnergia)
            {
                Energia = MaxEnergia;
            }
        }

        public void SetVidaPlus(int vida)
        {
            Vida += vida;
            if (Vida > MaxVida)
            {
                Vida = MaxVida;
            }
        }

        public void SetEnergiaPlus(int energia)
        {
            Energia += energia;
            if (Energia > MaxEnergia)
            {
                Energia = MaxEnergia;
            }
        }

        public void SetVida(int vida) 
        {
            Vida -= vida;
            if(Vida >= 0)
            { 
                Vida = 0;
            }
        }
        public void SetEnergia(int energia)
        {
            Energia -= energia;
            if ( Energia <= 0)
            {
                Energia = 0;
                Dormir();
                //metodo para dormir porque ya no tiene energia
            }
        }
        public bool VerificarEnergiaAccion(int energia)
        {
            if ( Energia >= energia)
            {
                SetEnergia(energia);
                return true;
            }
            else
            {
                MessageBox.Show("Energia insuficiente para realizar esta accion");
                return false; 
            }
        }
        public void Atacar(Criatura Defensor)
        {
            if (VerificarEnergiaAccion(50)) 
            {
                int ValorDadoA = Dado.LanzarDado(6);
                int ValorDadoD = Dado.LanzarDado(6);
                int AtaqueTotal = this.PntAtack + ValorDadoA;
                Defensor.PntDef += ValorDadoD;
                if (Defensor.Defender(AtaqueTotal) == 0)
                {
                    MessageBox.Show("Ataque exitoso");
                }
                else 
                {
                    Vida -= Defensor.Defender(AtaqueTotal);
                    MessageBox.Show("Gana la defensa");
                    
                }
               
            }
        }
        public int Defender(int PntAtack)
        {
            //Aca deberia poner el empate?
            int Result= 0;
            if(PntDef > PntAtack) 
            {
                Result += PntDef - PntAtack;
            }
            else
            {
                Vida -=  PntAtack - PntDef;
            }
            return Result;
        }
        
        public bool PuedePasarPorTerreno(ITerreno terreno)
        {
            foreach (var habitad in Habitads)
            {
                
                if (habitad is HabitadAereo)
                {
                    return true;
                }

                
                if (habitad.CanHabitar(terreno))
                {
                    return true;
                }
            }
            return false;
        }

        void ICriatura.Comer(Comida comida)
        {
            if (Dieta is DietOmnivoro || Dieta.CanEat(comida))
            {
                Random random = new Random();
                int energiaRecuperada = random.Next(20, 31);
                SetEnergiaPlus(energiaRecuperada);
                MessageBox.Show($"{Nombre} ha comido {comida.Nombre} y ha ganado {energiaRecuperada} de energía.");
            }
            else
            {
                MessageBox.Show($"{Nombre} no puede comer {comida.Nombre} porque no es compatible con su dieta.");
            }
        }
       


        /*
public void Morir()
{
   CriaturaController.GetInstance().EliminarCriatura(this);
}*/
    }
}
