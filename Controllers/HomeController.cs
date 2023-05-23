using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP4_VAZQUEZ.Models;

namespace TP4_VAZQUEZ.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.DicDias = Dias.DicDias;
        return View("Index");
    }

    public IActionResult SelectIndumentaria(){
        ViewBag.ListaCamperas = Dias.ListaCamperas;
        ViewBag.ListaTops = Dias.ListaTops;
        ViewBag.ListaRemeras = Dias.ListaRemeras;
        ViewBag.ListaCalzas = Dias.ListaCalzas;
        ViewBag.ListaZapas = Dias.ListaZapas;
        ViewBag.ListaDias = Dias.ListaDias;
        return View("SelectIndumentaria");
    }

    public IActionResult GuardarIndumentaria(int Dia, int Remera, int Campera, int Top, int Calza, int Zapatilla){
        Indumentaria indumentaria;
        if ((Dias.DicDias.ContainsKey(Dias.ListaDias[Dia-1]))||Dia==0||Remera == 0 || Campera==0||Calza==0||Top==0||Zapatilla==0)
       {
            return View("Error");
       }
       else
       {
            indumentaria=new Indumentaria(Dias.ListaCamperas[Campera-1], Dias.ListaTops[Top-1], Dias.ListaRemeras[Remera-1], Dias.ListaCalzas[Calza-1], Dias.ListaZapas[Zapatilla-1]);
            ViewBag.DicDias = Dias.IngresarIndumentaria(Dias.ListaDias[Dia-1], indumentaria);
            return View("Index");
       }  
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
