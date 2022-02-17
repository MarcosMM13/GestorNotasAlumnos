using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorNotaAlumno
{
   public class Alumnos
    {
        public int Id { get; set; }
        public int Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int CicloLectivo { get; set; }
        public int NotaParcial1 { get; set; }
        public int NotaParcial2 { get; set; }
        public int NotaTrabajoP { get; set; }
        public string Materia { get; set; }
    }
}
