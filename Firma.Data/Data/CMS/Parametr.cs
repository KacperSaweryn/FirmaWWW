using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Firma.Data.Data.CMS
{
    public class Parametr
    {
        [Key]
        public int IdParametr { get; set; }

        [Required(ErrorMessage = "Nazwa jest wymagany")]
        [MaxLength(15, ErrorMessage = "Nazwa może zawierać max 15 znaków")]
        [Display(Name = "Nazwa odnośnika")]
        public string Nazwa { get; set; }


        [Display(Name = "Treść")]
        [Column(TypeName = "nvarchar(MAX)")]
        public string Tresc { get; set; }

        [Required(ErrorMessage = "Pozycja wymagana")]
        [Display(Name = "Pozycja wyświetlania")]
        public int Pozycja { get; set; }
    }
}
