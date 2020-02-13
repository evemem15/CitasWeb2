using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Citas.Web.Models
{
    public class PacienteModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public string FechaNacimiento { get; set; }
    }
}