using System;

namespace Sali3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testataan Henkilo-olion luontia");

            /*-----------------------------------------
             |TESTAUS ALKAA TÄSTÄ                      |
             |-----------------------------------------*/
            //Testataan oletusmuodostin

            henkilo henkilo = new henkilo();

            // Testataan muodostin kaikilla parametreillä

            henkilo henkilo1 = new henkilo("Mika", "Hakala", "Kotikatu 3", "20100", "Turku");

            // Testataan Jäsen-olion muodostimen toimintaa

            Jasen jasen = new Jasen("Mika", "Vainio", "yläneentie 146", "23100", "Mynämäki", "123", "1");

            // Katsotaan olion ominaisuuksia

            Console.WriteLine("Testi oletusmuodostimelle");
            henkilo.naytaHenkilo();
            Console.WriteLine("Testi muodostimelle kaikilla parametreilla");
            henkilo1.naytaHenkilo();
            Console.WriteLine("Testi jäsenen muodostimelle");
            jasen.naytaJasen();

        }
    }
}
