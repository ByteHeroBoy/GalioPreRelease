using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETL.DataGen
{
   public class Estudiante
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Grupo { get; set; }
        public Estudiante()
        {
            Cedula = string.Empty;
            Nombre = string.Empty;
            Grupo = string.Empty;
        }
    }
}
