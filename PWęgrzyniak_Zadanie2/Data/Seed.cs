using Microsoft.Identity.Client;
using PWęgrzyniak_Zadanie2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWęgrzyniak_Zadanie2.Data
{
    internal class Seed
    {
        private readonly AppDbContext _appDbContext;

        public Seed(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public void ExecuteSeed()
        {
            if(!_appDbContext.Pracowniks.Any()) 
            {


                var pracowniks = new List<Pracownik>()
                {
                    new Pracownik()
                    {                        
                        Imie = "Jan"
                    },

                    new Pracownik()
                    {                        
                        Imie = "Paweł"
                    },

                    new Pracownik()
                    {
                        Imie = "Franciszek"
                    },

                     new Pracownik()
                    {
                        Imie = "Marek"
                    }
                };

                _appDbContext.Pracowniks.AddRange(pracowniks);
                _appDbContext.SaveChanges();
            }

            if (!_appDbContext.Zadanies.Any())
            {
                List<Pracownik> ps = _appDbContext.Pracowniks.ToList();
                var zadanies = new List<Zadanie>()
                {
                    new Zadanie()
                    {
                        Kategoria = "Test",
                        Opis = "Przeprowadzić testy jednostkowe",
                        CzyZakonczone = true,
                        PracownikId = ps[0].Id                     
                    },

                    new Zadanie()
                    {
                        Kategoria = "Dane",
                        Opis = "Przyogotwać bazę pod bloga",
                        CzyZakonczone = false,
                        PracownikId = ps[1].Id
                    },

                    new Zadanie()
                    {
                        Kategoria = "Test",
                        Opis = "Przeprowadzić testy jednostkowe",
                        CzyZakonczone = true,
                        PracownikId = ps[3].Id
                    },

                    new Zadanie()
                    {
                        Kategoria = "Test",
                        Opis = "Przygotować widok sklepu",
                        CzyZakonczone = false,
                        PracownikId = ps[1].Id
                    },

                    new Zadanie()
                    {
                        Kategoria = "Test",
                        Opis = "Przeprowadzić testy jednostkowe",
                        CzyZakonczone = true,
                        PracownikId = ps[1].Id
                    },

                    new Zadanie()
                    {
                        Kategoria = "Test",
                        Opis = "Przeprowadzić testy jednostkowe",
                        CzyZakonczone = false,
                        PracownikId = ps[2].Id
                    },

                    new Zadanie()
                    {
                        Kategoria = "Grafika",
                        Opis = "Przygotować szatę strony",
                        CzyZakonczone = false,
                        PracownikId = ps[3].Id
                    }
                };

                _appDbContext.Zadanies.AddRange(zadanies);
            }

            _appDbContext.SaveChanges();
        }

        //public static void SeedData(IApplicationBuilder applicationBuilder);
    }
}
