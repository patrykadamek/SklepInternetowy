using SklepInternetowy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace SklepInternetowy.DAL
{
    public class KsiazkiContext : DbContext
    {
        public KsiazkiContext() : base("KsiazkiContext")
        {

        }
        public DbSet<Ksiazka> Ksiazki { get; set; }
        public DbSet<Kategoria> Kategorie { get; set; }
        public DbSet<Zamowienie> Zamowienia { get; set; }
        public DbSet<PozycjaZamowienia> PozycjeZamowienia { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Wyłącza konwencję, która dodaje automatycznie do nazw tabel końcówkę "s" tworząc liczbę mnogą
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}