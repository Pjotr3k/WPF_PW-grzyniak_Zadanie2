using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWęgrzyniak_Zadanie2.Models
{
    internal class Zadanie
    {
        [Key]
        public int Id { get; set; }
        public string Kategoria { get; set; }
        public string Opis { get; set; }
        public bool CzyZakończone { get; set; }

        [ForeignKey("Pracownik")]
        public int PracownikId { get; set; }
        public Pracownik Pracownik { get; set; }
        
    }
}
