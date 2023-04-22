using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Firma.Intranet.Models.CMS
{
    public class Aktualnosc
    {
        [Key]//to co niżej jest klucem podstawowym tabeli
        public int IdAktualnosci { get; set; }

        [Required(ErrorMessage = "Tytuł jest wymagany")]//pole jest wymagane
        [MaxLength(10, ErrorMessage = "Tytuł może zawierac max 10 znakow")]//maksymalna długość
        [Display(Name = "Tutuł odnośnika do aktualnosci")]//tą nazę pola będzie widzial uzytkownik
        public string LinkTytul { get; set; }

        [Required(ErrorMessage = "Tytuł jest wymagany")]//pole jest wymagane
        [MaxLength(30, ErrorMessage = "Tytuł może zawierac max 30 znakow")]//maksymalna długość
        [Display(Name = "Tutuł aktualnosci")]//tą nazę pola będzie widzial uzytkownik
        public string Tytul { get; set; }

        [Display(Name = "Treść")]
        [Column(TypeName = "nvarchar(MAX)")]//określa jakiego typu to pole będzie w bazie danych
        public string Tresc { get; set; }

        [Display(Name = "Pozycja wyświetlania")]
        [Required(ErrorMessage = "Pozycja jest wymagana")]
        public int Pozycja { get; set; }
    }
}
