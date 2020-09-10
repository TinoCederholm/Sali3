using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Sali3
{
    class Punnitus
    {
        // kaikki kentät merkkijonoja, koska syöte tulee näppäimistöstä
        protected string paiva;
        protected string paino;
        protected string pituus;

        // Muodostin kaikilla parametreilla
        public Punnitus(string paiva, string paino, string pituus)
        {
            
            this.paiva = paiva;
            this.paino = paino;
            this.pituus = pituus;
        }


        public float BMI()
        {

            // Muutetaan olion merkkijono-ominaisuudet liukuluvuiksi ja lasketaan painoindeksi ja palautetaan se
            float bmi = float.Parse(this.paino) / (float.Parse(this.pituus) * float.Parse(this.pituus));
            return bmi;
        }

        // Testausmetodi punnitustietojen näyttämiseen
        public void naytaPunnitus()
        {
            Console.WriteLine("Punnituspäivä: " + this.paiva);
            Console.WriteLine("Paino on: " + this.paino);
            Console.WriteLine("Pituus on:" + this.pituus);
        }

    }
}
