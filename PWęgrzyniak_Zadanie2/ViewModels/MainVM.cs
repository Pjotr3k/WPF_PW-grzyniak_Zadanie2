using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PWęgrzyniak_Zadanie2.Models;

namespace PWęgrzyniak_Zadanie2.ViewModels
{
    internal class MainVM  : BaseVM
    {
        private readonly List<Pracownik> _pracowniks;
        private PracownikVM  _selectedPracownik;
        
        public List<PracownikVM> PracownikVMs { get; set; } = new List<PracownikVM>();
        public PracownikVM SelectedPracownik { get 
            {
                return _selectedPracownik;
            }
            set
            {
                _selectedPracownik = value;
                OnPropertyChanged(nameof(SelectedPracownik));
            }
        }

        //Command
        public ICommand SelectPracownikCommand { get; }

        //Constructor
        public MainVM()
        {
            _pracowniks = MainVM.PopulateTest();
            SelectPracownikCommand = new CommandVM(ExecuteSelectPracownik);

            foreach (var p in _pracowniks)
            {
                PracownikVM pvm = new PracownikVM(p);
                PracownikVMs.Add(pvm);
            }

            SelectedPracownik = PracownikVMs[0];
        }

        private void ExecuteSelectPracownik(object obj)
        {
            throw new NotImplementedException();
        }

        static List<Pracownik> PopulateTest()
        {
            Pracownik a = new Pracownik()
            {
                Id = 1,
                Imie = "Andszej"
            };

            Pracownik b = new Pracownik()
            {
                Id = 2,
                Imie = "Pioter"
            };

            Pracownik c = new Pracownik()
            {
                Id = 3,
                Imie = "Żygmunt"
            };

            a.Zadanies = new List<Zadanie>()
            {
                new Zadanie()
                {
                    Id = 1,
                    Kategoria = "Historia Polski",
                    Opis = "Zjednoczenie Polski",
                    CzyZakonczone = false,
                    PracownikId = a.Id,
                    Pracownik = a

                },

                new Zadanie()
                {
                    Id = 2,
                    Kategoria = "Żeglarsto",
                    Opis = "Ile kilometrów to mila morska",
                    CzyZakonczone = false,
                    PracownikId = a.Id,
                    Pracownik = a

                }
            };

            b.Zadanies = new List<Zadanie>()
            {
                new Zadanie()
                {
                    Id = 3,
                    Kategoria = "To akurat jest ważne",
                    Opis = "I to bardzo",
                    CzyZakonczone = false,
                    PracownikId = b.Id,
                    Pracownik = b

                },

                new Zadanie()
                {
                    Id = 4,
                    Kategoria = "Nie ważne",
                    Opis = "nic",
                    CzyZakonczone = true,
                    PracownikId = b.Id,
                    Pracownik = b

                }
            };

            c.Zadanies = new List<Zadanie>()
            {
                new Zadanie()
                {
                    Id = 5,
                    Kategoria = "Salvete",
                    Opis = "Ego Petrus sum",
                    CzyZakonczone = false,
                    PracownikId = c.Id,
                    Pracownik = c

                }
            };

            return new List<Pracownik>() { a, b, c};
        }
    }
}
