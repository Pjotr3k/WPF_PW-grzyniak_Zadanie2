using PWęgrzyniak_Zadanie2.Models;

namespace PWęgrzyniak_Zadanie2.ViewModels
{
    internal class ZadanieVM
    {
        public int Id { get; set; }
        public string Kategoria { get; set; }
        public string Opis { get; set; }

        public ZadanieVM(Zadanie zad)
        {
            Id = zad.Id;
            Kategoria = zad.Kategoria;
            Opis = zad.Opis;
        }
    }
}
