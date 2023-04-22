using Firma.PortalWWW.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Firma.Data.Data;

namespace Firma.PortalWWW.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FirmaContext _context; // to jest DB

        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }
        public HomeController(FirmaContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? id) // identyfikator kliknietej strony w menu
        {
            //ViewBag to taki listonosz ktory przenosi dane miedzy controllerem a widokiem. Po kropce we ViewBagu mozna dowolnie nazwac zmienna
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
            ).Take(3).ToList();
            // ).Take(3).ToList();   //TODO -> można ograniczyc aktualnosci np orderby id desc
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
            //jezeli ktos wejdzie 1 raz do portalu to nie ma kliknietej wybranej strony i id = null -> wtedy wysiertla sie 1 strona
            if (id == null)
            {
                id = _context.Strona.First().IdStrony;
            }
            //odnajdujemy w DB strone o danym id
            var item = _context.Strona.Find(id);
            //i przekazujemy ją do widoku zeby widok ją wyswietlil
            return View(item);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Company()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View(); //widok będzie nazywał sie tak samo jak funkcja wiec mozna -> return View()
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}