using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Firma.Intranet.Models.CMS
{
    //tworzymy klasę z której będzie automatycznie przez EF wygenerowana tabela
    public class Strona
    {
        [Key]//to co niżej jest klucem podstawowym tabeli
        public int IdStrony { get; set; }
        
        [Required(ErrorMessage ="Tytuł jest wymagany")]//pole jest wymagane
        [MaxLength(10,ErrorMessage ="Tytuł może zawierac max 10 znakow")]//maksymalna długość
        [Display(Name ="Tutuł odnośnika do strony")]//tą nazę pola będzie widzial uzytkownik
        public string LinkTytul { get; set; }

        [Required(ErrorMessage = "Tytuł jest wymagany")]//pole jest wymagane
        [MaxLength(30, ErrorMessage = "Tytuł może zawierac max 30 znakow")]//maksymalna długość
        [Display(Name = "Tutuł strony")]//tą nazę pola będzie widzial uzytkownik
        public string Tytul { get; set; }

        [Display(Name = "Treść")]
        [Column(TypeName ="nvarchar(MAX)")]//określa jakiego typu to pole będzie w bazie danych
        public string Tresc { get; set; }

        [Display(Name = "Pozycja wyświetlania")]
        [Required(ErrorMessage = "Pozycja jest wymagana")]
        public int Pozycja { get; set; }
    }
}
