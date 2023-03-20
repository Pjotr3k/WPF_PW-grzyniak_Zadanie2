using PWęgrzyniak_Zadanie2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWęgrzyniak_Zadanie2.ViewModels
{
    internal class PracownikVM
    {        

        public int Id { get; set; }
        public string Imie { get; set; }
        public List<ZadanieVM> NiezakonczoneZadanies { get; set; }
        public int IleNiezakonczonych { get; set; }

        public PracownikVM(Pracownik pracownik)
        {
            //this.pracownik = pracownik;
            this.Id = pracownik.Id;
            this.Imie = pracownik.Imie;

            List<Zadanie> zadanieDoKonwert = new List<Zadanie>();
            if (pracownik.Zadanies.Any(z => z.CzyZakonczone == false))
            zadanieDoKonwert = pracownik.Zadanies.Where(z => z.CzyZakonczone == false).ToList();
            
            NiezakonczoneZadanies = new List<ZadanieVM>();
            
            foreach(var zad in zadanieDoKonwert)
            {
                NiezakonczoneZadanies.Add(new ZadanieVM(zad));
            }
            //if (this.NiezakonczoneZadanies != null)
                this.IleNiezakonczonych = this.NiezakonczoneZadanies.Count();
            //else
              //  this.IleNiezakonczonych = 0;
        }

    }
}
