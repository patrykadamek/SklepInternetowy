using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SklepInternetowy.Models
{
    public class Ksiazka
    {
        public int KsiazkaId { get; set; }
        public int KategoriaId { get; set; }
        [Required(ErrorMessage = "Wprowadź nazwę książki")]
        [StringLength(100)]
        public String TytulKsiazki { get; set; }
        [Required(ErrorMessage = "Wprowadź nazwę autora")]
        [StringLength(100)]
        public String AutorKsiazki { get; set; }
        public DateTime DataWydania { get; set; }
        [StringLength(100)]
        public String NazwaPlikuObrazka { get; set; }
        public String OpisKsiazki { get; set; }
        public decimal CenaKsiazki { get; set; }
        public bool Bestseller { get; set; }
        public bool Ukryty { get; set; }
        public virtual Kategoria Kategoria { get; set; }
    }
}