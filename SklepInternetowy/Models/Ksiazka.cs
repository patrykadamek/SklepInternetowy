using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SklepInternetowy.Models
{
    public class Ksiazka
    {
        public int KsiazkaId { get; set; }
        public int KategoriaId { get; set; }
        public String TytulKsiazki { get; set; }
        public String AutorKsiazki { get; set; }
        public DateTime DataWydania { get; set; }
        public String NazwaPlikuObrazka { get; set; }
        public String OpisKsiazki { get; set; }
        public decimal CenaKsiazki { get; set; }
        public bool Bestseller { get; set; }
        public bool Ukryty { get; set; }
        public virtual Kategoria Kategoria { get; set; }
    }
}