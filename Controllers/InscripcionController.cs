
using Microsoft.AspNetCore.Mvc;
using EscuelaDanzaMVC.Models;

namespace EscuelaDanzaMVC.Controllers;

public class InscripcionController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View(new Inscripcion());
    }

    [HttpPost]
    public IActionResult Index(Inscripcion inscripcion)
    {
        if (!ModelState.IsValid)
        {
            return View(inscripcion);
        }

        return View("Resultado", inscripcion);
    }
}
