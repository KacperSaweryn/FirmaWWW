using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Data.Data.Sklep
{
    public class Rodzaj
    {
        [Key] public int IdRodzaju { get; set; }

        [Required(ErrorMessage = "Nazwa jest wymagana")]
        [MaxLength(30, ErrorMessage = "Nazwa może zawierać max 30 znaków")]
        public string Nazwa { get; set; }

        public string Opis { get; set; }
        public List<Towar> Towar { get; set; } //realizacja 1 do wielu
    }
}