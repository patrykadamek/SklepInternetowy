using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SklepInternetowy.Models
{
    public class Kategoria
    {
        public int KategoriaId { get; set; }
        [Required(ErrorMessage = "Wprowadź nazwę kategorii")]
        [StringLength(100)]
        public string NazwaKategorii { get; set; }
        [Required(ErrorMessage = "Wprowadź opis kategorii")]
        public string OpisKategorii { get; set; }
        public string NazwaPlikuIkony { get; set; }

        public virtual ICollection<Ksiazka> Ksiazki { get; set; }

    }
}