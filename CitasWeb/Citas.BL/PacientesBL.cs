using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admon.BL
{
    public class PacientesBL
    {
        Contexto _contexto;
        public List<Paciente> ListadePacientes { get; set; }

        public PacientesBL()
        {
            _contexto = new Contexto();
            ListadePacientes = new List<Paciente>();
        }

        public List<Paciente> ObtenerPaciente()
        {
            ListadePacientes = _contexto.Pacientes.ToList();
            return ListadePacientes;
        }
    }
}
