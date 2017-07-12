using System.Collections.Generic;

namespace SklepInternetowy.Models
{
    public class Kategoria
    {
        public int KategoriaId { get; set; }
        public string NazwaKategorii { get; set; }
        public string OpisKategorii { get; set; }
        public string NazwaPlikuIkony { get; set; }

        public virtual ICollection<Ksiazka> Ksiazki { get; set; }







    }
}