using System;
using System.Collections.Generic;
using System.Text;

namespace Sali3
{
    class henkilo
    {
        // Määritellään kaikkien henkilöiden yhteiset ominaisuudet (Kentät)
        // Jäsen-luokka perii nämä ominaisuudet
        protected string etunimi;
        protected string sukunimi;
        protected string katuosoite;
        protected string postinumero;
        protected string postitoimipaikka;

        // Olionmuodostimet (konstruktorit)

        public henkilo()
        {
            this.etunimi = "etunimi";
            this.sukunimi = "sukunimi";
            this.katuosoite = "N/A";
            this.postinumero = "N/A";
            this.postitoimipaikka = "N/A";
        }

        // Muodostin kaikilla parametreilla
        public henkilo(string etu, string suku, string katu, string pnro, string paikka)
        {
            this.etunimi = etu;
            this.sukunimi = suku;
            this.katuosoite = katu;
            this.postinumero = pnro;
            this.postitoimipaikka = paikka;
        }

        // Metodeja testaukseen
        public void naytaHenkilo()
        {
            Console.WriteLine("Etunimi on " + this.etunimi);
            Console.WriteLine("Sukunimi on " + this.sukunimi);
            Console.WriteLine("katuosoite on " + this.katuosoite);
            Console.WriteLine("Postinumero on " + this.postinumero);
            Console.WriteLine("Postitoimipaikka on " + this.postitoimipaikka);
        }
    }
    class Jasen : henkilo
    {
        // Jäsen-olioiden erityisominaisuudet, jota ei ole Henkilo-luokassa
        protected string jasenid;
        protected string sukupuoli;

        //Muodostin kaikilla parametreillä
        public Jasen(string etu, string suku, string katu, string pnro, string paikka, string id, string sukupuoli)
        {
            this.etunimi = etu;
            this.sukunimi = suku;
            this.katuosoite = katu;
            this.postinumero = pnro;
            this.postitoimipaikka = paikka;
            this.jasenid = id;
            this.sukupuoli = sukupuoli;

        }

        // Metodeja testaukseen 
        public void naytaJasen()
        {
            Console.WriteLine("Etunimi on " + this.etunimi);
            Console.WriteLine("Sukunimi on " + this.sukunimi);
            Console.WriteLine("katuosoite on " + this.katuosoite);
            Console.WriteLine("Postinumero on " + this.postinumero);
            Console.WriteLine("Postitoimipaikka on " + this.postitoimipaikka);
            Console.WriteLine("jäsennumero on " + this.jasenid);
            Console.WriteLine("sukupuoli on " + this.sukupuoli);
        }

    }
}
