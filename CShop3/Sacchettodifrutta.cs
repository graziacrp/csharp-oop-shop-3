using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShop3
{
    internal class Sacchettodifrutta : Prodotto
    {
        public string[] pezziDiFrutta = new string[5];



        //Metodo 
        public void AggiungiFrutta(int fruttaDaAggiungere)
        {
            if (this.numeroPezziDiFrutta + fruttaDaAggiungere <= numeroMassimoDiPezzi)
            {
                this.numeroPezziDiFrutta = this.numeroPezziDiFrutta + fruttaDaAggiungere;
                Console.WriteLine("Ho aggiunto " + fruttaDaAggiungere + " di frutta al sacchetto");
            }
            else
            {
                Console.WriteLine("Non posso aggiungere questo quantitativo di frutta. Ma ti rimane comunque il sacchetto pieno");
                this.numeroPezziDiFrutta = numeroMassimoDiPezzi;
            }
        }






    }
}


