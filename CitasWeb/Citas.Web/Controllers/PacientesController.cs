using Citas.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Citas.Web.Controllers
{
    public class PacientesController : Controller
    {
        // GET: Pacientes
        public ActionResult Index()
        {
            var paciente1 = new PacienteModel();
            paciente1.Id = 1;
            paciente1.Nombre = "Santos Andres Yanes Quiroz";
            paciente1.Telefono = 555664232;
            paciente1.Direccion = "SPS";
            paciente1.FechaNacimiento = "21 enero 1986";

            var paciente2 = new PacienteModel();
            paciente2.Id = 2;
            paciente2.Nombre = "Carlos David Flores Aguilar";
            paciente2.Telefono = 123664232;
            paciente2.Direccion = "SPS";
            paciente2.FechaNacimiento = "13 Mayo 1998";

            var paciente3 = new PacienteModel();
            paciente3.Id = 3;
            paciente3.Nombre = "Miguel Raul Navarro Lopez";
            paciente3.Telefono = 555664907;
            paciente3.Direccion = "SPS";
            paciente3.FechaNacimiento = "31 Agosto 1989";

            var listadePacientes = new List<PacienteModel>();
            listadePacientes.Add(paciente1);
            listadePacientes.Add(paciente2);
            listadePacientes.Add(paciente3);

            return View(listadePacientes);
        }
    }
}