using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Data.Data.Sklep
{
    public class Towar
    {
        [Key] public int IdTowaru { get; set; }

        [Required(ErrorMessage = "Kod jest wymagany")]
        [MaxLength(9, ErrorMessage = "Kod może zawierać max 9 znaków")]
        public string Kod { get; set; }

        [Required(ErrorMessage = "Nazwa jest wymagana")]
        public string Nazwa { get; set; }

        [Required(ErrorMessage = "Cena jest wymagana")]
        [Column(TypeName = "money")]
        public decimal Cena { get; set; }

        [Required(ErrorMessage = "Zdjęcie jest wymagane")]
        [Display(Name = "Wybierz zdjęcie")]
        public string FotoUrl { get; set; }

        public string Opis { get; set; }
        public int RodzajId { get; set; }
        public Rodzaj Rodzaj { get; set; }
    }
}