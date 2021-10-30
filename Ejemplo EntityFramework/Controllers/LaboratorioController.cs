using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejemplo_EntityFramework.Controllers
{
    public class LaboratorioController : Controller
    {
        // GET: Laboratorio
        public ActionResult Index()
        {
            return View();
        }

        public string Mensaje(string Nombre = "", int NumLab = 0)
        {
            return "Saludos "+Nombre+", este es un ejemplo de controlador "+NumLab;
        }
    }
}