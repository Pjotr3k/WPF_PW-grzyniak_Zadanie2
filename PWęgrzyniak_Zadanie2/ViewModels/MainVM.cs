using System;
using System.Windows;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.EntityFrameworkCore;
using PWęgrzyniak_Zadanie2.Data;
using PWęgrzyniak_Zadanie2.Models;
using System.Collections.ObjectModel;

namespace PWęgrzyniak_Zadanie2.ViewModels
{
    internal class MainVM  : BaseVM
    {
        private readonly AppDbContext _context;
        private List<Pracownik> _pracowniks;
        private PracownikVM _selectedPracownik;
        private string _newPracownikImie = "";

        //Constructor
        public MainVM()
        {
            _context = new AppDbContext();
            
            DodajPracownikVisibility = _dodajPracownikVisibility;            

            RefreshPracowniks();

            SelectedPracownik = PracownikVMs[0];
        }

        //Methods
        private void RefreshPracowniks()
        {
            _pracowniks = _context.Pracowniks
                .Include(p => p.Zadanies).ToList();
            PracownikVMs.Clear();

            foreach (var p in _pracowniks)
            {
                PracownikVM pvm = new PracownikVM(p);
                PracownikVMs.Add(pvm);
            }
            OnPropertyChanged(nameof(PracownikVMs));
        }

        private void ExecuteSelectPracownik(object obj)
        {
            throw new NotImplementedException();
        }
        private void ExecuteToggleDodajPracownikaVisibility(object obj)
        {
            if (_dodajPracownikVisibility == Visibility.Hidden) DodajPracownikVisibility = Visibility.Visible;
            else DodajPracownikVisibility = Visibility.Hidden;
        }

        private void ExecuteDodajPracownik(object obj)
        {
            Pracownik.AddPracownik(_newPracownikImie);
            NewPracownikImie = "";
            RefreshPracowniks();
        }

        private bool CanExecuteDodajPracownik(object obj)
        {
            return _newPracownikImie.Length > 1;
        }

        private void ExecuteUsunPracownik(object obj)
        {
            int idToRemove = (int)obj;
            Pracownik pnik = _pracowniks.Where(x => x.Id == idToRemove).FirstOrDefault();

            _context.Pracowniks.Remove(pnik);
            _context.SaveChanges();

            RefreshPracowniks();
            
        }

        private bool CanExecuteUsunPracownik(object obj)
        {            
            if (obj is int) 
            {
                return true;
            }

            return false;
        }



        Visibility _dodajPracownikVisibility = Visibility.Hidden;
        
        
        public ObservableCollection<PracownikVM> PracownikVMs { get; set; } = new ObservableCollection<PracownikVM>();
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
        public Visibility DodajPracownikVisibility { 
            get
            {
                return _dodajPracownikVisibility;
            }
            set
            {
                _dodajPracownikVisibility = value;
                OnPropertyChanged(nameof(DodajPracownikVisibility));
            }
        }

        public string NewPracownikImie
        {
            get
            {
                return _newPracownikImie;
            }
            set
            {
                _newPracownikImie = value;
                OnPropertyChanged(nameof(NewPracownikImie));
            }
        }


        //Command
        //private ICommand _toggleDodajPracownikaVisibilityCommand = null;
        public ICommand SelectPracownikCommand { get; }
        public ICommand ToggleDodajPracownikaVisibilityCommand { get
            {
                return new CommandVM(ExecuteToggleDodajPracownikaVisibility);
            }
        }
        public ICommand DodajPracownikCommand
        {
            get
            {
                return new CommandVM(ExecuteDodajPracownik, CanExecuteDodajPracownik);
            }
        }

        public ICommand UsunPracownikCommand
        {
            get
            {
                return new CommandVM(ExecuteUsunPracownik);
            }
        }


        
        






    }       
}
