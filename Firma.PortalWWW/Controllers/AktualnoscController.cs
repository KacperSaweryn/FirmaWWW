using Firma.Data.Data;
using Microsoft.AspNetCore.Mvc;
using Firma.PortalWWW.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Firma.Data.Data;

namespace Firma.PortalWWW.Controllers
{
    public class AktualnoscController : Controller
    {
        //private readonly ILogger<AktualnoscController> _logger;
        private readonly FirmaContext _context; // to jest DB

        public AktualnoscController(FirmaContext context)
        {
            _context = context;
        }
        public IActionResult Index(int id) //id kliknietej aktualnosci
        {
            ViewBag.ModelStrony =
            (
                from strona in _context.Strona
                orderby strona.Pozycja
                select strona
            ).ToList();
            ViewBag.ModelAktualnosci =
            (
                from aktualnosc in _context.Aktualnosc
                orderby aktualnosc.Pozycja
                select aktualnosc
            ).ToList();
            ViewBag.ModelInformacjeDodatkowe =
            (
                from strona in _context.Strona
                orderby strona.Pozycja
                select strona
            ).ToList();
            ViewBag.ModelKontakt =
            (
                from aktualnosc in _context.Aktualnosc
                orderby aktualnosc.Pozycja
                select aktualnosc
            ).ToList();
            ViewBag.ModelParametry =
            (
                from parametr in _context.Parametr
                orderby parametr.Pozycja
                select parametr
            ).ToList();
            //wyszukujemy aktualnosci o danym kliknietym ID
            var item = _context.Aktualnosc.Find(id);

            return View(item);
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
