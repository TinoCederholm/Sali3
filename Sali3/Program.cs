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

            // Testataan Trainer-olion muodostimen toimintaa, huom. nimiavaruus Henkilosto

            Henkilosto.Trainer trainer = new Henkilosto.Trainer("Jakke", "Jäynä", "Kotikatu", "21200", "Raisio", "Juoksumatto", "044 7057425", "Jakke@huuhaa.com");

            // Testataan punnitus-olion toimintaa

            Punnitus punnitus = new Punnitus("10.9.2020", "71.5", "1.71");


            // Katsotaan olioiden ominaisuuksia

            Console.WriteLine("Testi oletusmuodostimelle");
            henkilo.naytaHenkilo();
            Console.WriteLine("Testi muodostimelle kaikilla parametreilla");
            henkilo1.naytaHenkilo();
            Console.WriteLine("Testi jäsenen muodostimelle");
            jasen.naytaJasen();
            Console.WriteLine("Testi trainerin muodostimelle");
            trainer.naytaTrainer();
            Console.WriteLine("Testi punnituksen muodostimelle");
            punnitus.naytaPunnitus();
            Console.WriteLine("painoindeksi (BMI.metodi) on " + punnitus.BMI());

        }
    }
}
