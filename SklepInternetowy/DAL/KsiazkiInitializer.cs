using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SklepInternetowy.Models;

namespace SklepInternetowy.DAL
{
    public class KsiazkiInitializer : DropCreateDatabaseAlways<KsiazkiContext>
    {
        protected override void Seed(KsiazkiContext context)
        {
            SeedKursyData(context);
            base.Seed(context);
        }

        private void SeedKursyData(KsiazkiContext context)
        {
            var kategorie = new List<Kategoria>
            {
                new Kategoria() { KategoriaId=1, NazwaKategorii="asp", NazwaPlikuIkony="asp.png", OpisKategorii="opis asp net mvc"},
                new Kategoria() { KategoriaId=1, NazwaKategorii="asp", NazwaPlikuIkony="asp.png", OpisKategorii="opis asp net mvc"},
                new Kategoria() { KategoriaId=1, NazwaKategorii="asp", NazwaPlikuIkony="asp.png", OpisKategorii="opis asp net mvc"},
                new Kategoria() { KategoriaId=1, NazwaKategorii="asp", NazwaPlikuIkony="asp.png", OpisKategorii="opis asp net mvc"},
                new Kategoria() { KategoriaId=1, NazwaKategorii="asp", NazwaPlikuIkony="asp.png", OpisKategorii="opis asp net mvc"},
                new Kategoria() { KategoriaId=1, NazwaKategorii="asp", NazwaPlikuIkony="asp.png", OpisKategorii="opis asp net mvc"},
                new Kategoria() { KategoriaId=1, NazwaKategorii="asp", NazwaPlikuIkony="asp.png", OpisKategorii="opis asp net mvc"},
            };

            kategorie.ForEach(k => context.Kategorie.Add(k));
            context.SaveChanges();

            var ksiazki = new List<Ksiazka>
            {
                new Ksiazka() { AutorKsiazki="janek", TytulKsiazki="asp.net mvc", KategoriaId=1, CenaKsiazki=20, Bestseller=true, NazwaPlikuObrazka="asp.png", DataWydania=DateTime.Now, OpisKsiazki="opis książki"},
                new Ksiazka() { AutorKsiazki="patryk", TytulKsiazki="asp.net mvc1", KategoriaId=1, CenaKsiazki=18, Bestseller=true, NazwaPlikuObrazka="asp1.png", DataWydania=DateTime.Now, OpisKsiazki="opis książki1"},
                new Ksiazka() { AutorKsiazki="ania", TytulKsiazki="asp.net mvc2", KategoriaId=1, CenaKsiazki=7, Bestseller=true, NazwaPlikuObrazka="asp2.png", DataWydania=DateTime.Now, OpisKsiazki="opis książki2"},
                new Ksiazka() { AutorKsiazki="stanisław", TytulKsiazki="asp.net mvc3", KategoriaId=1, CenaKsiazki=189, Bestseller=true, NazwaPlikuObrazka="asp3.png", DataWydania=DateTime.Now, OpisKsiazki="opis książki3"},
            };

            ksiazki.ForEach(k => context.Ksiazki.Add(k));
            context.SaveChanges();
        }
    }
    
}