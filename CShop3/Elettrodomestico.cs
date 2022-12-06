using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShop3
{
    internal class Elettrodomestico : Prodotto
    {

        private string altezza;
        private string larghezza;
        private bool corrente = false;


        public Elettrodomestico(string altezza, string larghezza, string corrente)
        {
            this.altezza = altezza;
            this.larghezza = larghezza;

        }
        //Eccezione
        public void PremiPulsanteOnOff()
        {
            if (corrente == false)
            {
                throw new Exception("L'elettrodomestico si è acceso");
            }
            else
            {
                (corrente == true)
                Console.WriteLine("" + nome + " L'elettrodomestico si è spento");
            }
        }
    }

