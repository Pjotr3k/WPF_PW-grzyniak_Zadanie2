using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWęgrzyniak_Zadanie2.Models
{
    internal class Pracownik
    {
        [Key]
        public int Id { get; set; }
        public string Imie { get; set; }
        public List<Zadanie>? Zadanies { get; set;}
    }
}
