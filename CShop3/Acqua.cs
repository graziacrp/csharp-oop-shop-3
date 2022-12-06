using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShop3
{
    internal class Acqua : Prodotto
    {

        public static double maxLitri = 1.5;
        private double readonly ph:
        private string readonly sorgente;
        private double litri;
        public static readonly double convgallone = 3.785;




        public Acqua(string nome, double litri, double ph, string sorgente, double litri) : base(nome, litri)
        {
            this.litri = litri;
            this.ph = ph;
            this.sorgente = sorgente;
        }

        //Eccezione
        public void riempi(double litriDaRiempire)
        {


            if (litri < 0)
            {
                throw new Exception("Non posso riempire senza mettere l'acqua");

            }

            if (litriDaRiempire + this.litri > maxLitri)
            {
                Console.WriteLine("La bottiglia è piena" + litriDaRiempire);
                this.litri = maxLitri;
            }
            else
            {
                Console.WriteLine("Hai fatto uscire l'acqua, la tua bottiglia è ora piena");
                this.litri = this.litri - litriDaRiempire;
            }





        }
        //Metodo
        public void Bevi(double litriDaBere)
        {
            if (litriDaBere < 0)
            {
                throw new ArgumentOutOfRangeException("litriDaBere", "Il suo valore e' negativo");
            }

            if (this.litri - litriDaBere > 0)
            {
                this.litri = this.litri - litriDaBere;
                Console.WriteLine("Ho bevuto " + litriDaBere + "l");
            }
            else
            {
                this.litri = 0;
                throw new ArgumentOutOfRangeException("litri", "L'acqua bevuta e' maggiore di quella presente nella bottiglia.");
            }
        }



        //Metodo
        public static void ConvertiInGalloni(double litriGalloni)
        {
            double GalloniDaConv = litriGalloni * convgallone;

            GalloniDaConv = Math.Round(GalloniDaConv, 3);

            Console.WriteLine("Conversione litri in Galloni: " + GalloniDaConv);
