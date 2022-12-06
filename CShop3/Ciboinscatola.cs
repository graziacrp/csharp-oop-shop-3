using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CShop3 
{
    internal class Ciboinscatola : Prodotto
    {
        private string cibo;
        private string materiale = ("Alluminio");

       
        //Eccezione
        public Ciboinscatola(string cibo, string materiale)
        {
            this.cibo = cibo;
            if (materiale == null| materiale == "")
            {
                throw new Exception("Il materiale non può non esistere");
            } else
            {
                this.materiale = materiale;
            }
            
        }

        public override void StampaProdotto()
        {
            Console.WriteLine("Prodotto");
            Console.WriteLine(cibo + "" + materiale);

        }
    }
}
