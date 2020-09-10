using System;
using System.Collections.Generic;
using System.Text;

namespace Sali3
{
    class henkilo
    {
        // Määritellään kaikkien henkilöiden yhteiset ominaisuudet (Kentät)
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
    }
}
