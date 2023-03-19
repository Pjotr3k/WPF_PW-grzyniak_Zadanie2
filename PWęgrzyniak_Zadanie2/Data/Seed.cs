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
            if(_appDbContext.Pracowniks.Count() < 1) 
            {


                var pracowniks = new List<Pracownik>()
                {
                    new Pracownik()
                    {
                        //Id = 1,
                        Imie = "Jan"
                    },

                    new Pracownik()
                    {
                        //Id = 2,
                        Imie = "Paweł"
                    },

                    new Pracownik()
                    {
                        //Id = 3,
                        Imie = "Franciszek"
                    },

                     new Pracownik()
                    {
                        //Id = 4,
                        Imie = "Marek"
                    }
                };

                _appDbContext.Pracowniks.AddRange(pracowniks);
            }

            if (!_appDbContext.Zadanies.Any())
            {
                var zadanies = new List<Zadanie>()
                {
                    new Zadanie()
                    {
                        //Id = 1,
                        Kategoria = "Test",
                        Opis = "Przeprowadzić testy jednostkowe",
                        CzyZakonczone = true,
                        PracownikId = 1                        
                    },

                    new Zadanie()
                    {
                        //Id = 2,
                        Kategoria = "Test",
                        Opis = "Przeprowadzić testy jednostkowe",
                        CzyZakonczone = true,
                        PracownikId = 4
                    },

                    new Zadanie()
                    {
                        //Id = 3,
                        Kategoria = "Test",
                        Opis = "Przeprowadzić testy jednostkowe",
                        CzyZakonczone = true,
                        PracownikId = 2
                    },

                    new Zadanie()
                    {
                        //Id = 4,
                        Kategoria = "Test",
                        Opis = "Przeprowadzić testy jednostkowe",
                        CzyZakonczone = true,
                        PracownikId = 3
                    },

                    new Zadanie()
                    {
                        //Id = 5,
                        Kategoria = "Test",
                        Opis = "Przeprowadzić testy jednostkowe",
                        CzyZakonczone = true,
                        PracownikId = 3
                    },

                    new Zadanie()
                    {
                        //Id = 6,
                        Kategoria = "Test",
                        Opis = "Przeprowadzić testy jednostkowe",
                        CzyZakonczone = true,
                        PracownikId = 1
                    },

                    new Zadanie()
                    {
                        //Id = 7,
                        Kategoria = "Test",
                        Opis = "Przeprowadzić testy jednostkowe",
                        CzyZakonczone = true,
                        PracownikId = 1
                    }
                };

                _appDbContext.Zadanies.AddRange(zadanies);
            }

            _appDbContext.SaveChanges();
        }

        //public static void SeedData(IApplicationBuilder applicationBuilder);
    }
}
