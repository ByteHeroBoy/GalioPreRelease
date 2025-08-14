using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETL.DataGen
{
    public class Asistencia
    {
        public int ID_Asist { get; set; }//Auto Increment on DB
        public string Cedula { get; set; }
        public string Materia { get; set; }
        public int  Lecciones { get; set; }
        public string  FechaHora { get; set; }
        public string Estado { get; set; }
        public string Observaciones { get; set; }
        public Asistencia()
        {
            ID_Asist = int.MinValue;
            Cedula = string.Empty;
            Materia = string.Empty;
            Lecciones = int.MinValue;
            FechaHora = string.Empty;
            Estado = string.Empty;
            Observaciones = string.Empty;
        }
    }
}
