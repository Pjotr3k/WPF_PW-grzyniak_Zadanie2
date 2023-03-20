using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PWęgrzyniak_Zadanie2.Models
{
    internal class Zadanie
    {
        [Key]
        public int Id { get; set; }
        public string Kategoria { get; set; }
        public string Opis { get; set; }
        public bool CzyZakonczone { get; set; }

        [ForeignKey("Pracownik")]
        public int PracownikId { get; set; }
        public Pracownik Pracownik { get; set; }
        
    }
}
