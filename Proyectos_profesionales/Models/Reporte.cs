using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyectos_profesionales.Models
{
    public class Reporte
    {

        public int ReporteId { get; set; }
        public DateTime Fecha { get; set; }
        public string A_Observación { get; set; }
        public string Observación { get; set; }
        public string Comportamiento { get; set; }
        public string Descripción { get; set; }
        public string Acciones { get; set; }
        public string Acto { get; set; }
        public string Condición { get; set; }
        public string Criticidad { get; set; }
        public string P_Retroalmentada { get; set; }
        public string Aspectos { get; set; }
        public string Resposable { get; set; }
        public string Archibos { get; set; }

        public Reporte()
        {

        }

    }
}
