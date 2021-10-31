using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyectos_profesionales.Models
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public int Número { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public int Teléfono { get; set; }
        public string Correo { get; set; }
        public string Puesto { get; set; }
        public string Departamento { get; set; }
        public DateTime Fecha { get; set; }

        public Empleado()
        {
                
        }
    }
}
