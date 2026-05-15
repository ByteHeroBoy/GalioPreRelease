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
        //Estado de la asistencia ya sea Ausencia, presente, tardia o justificado....
        public string Estado { get; set; }
        //Observaciones que el profesor ingresa al pasar asistencia
        public string Observaciones { get; set; }
        //descripcion de la asistencia al ser justificada, ejemplo al colocar Otro en la descripcion se guarda lo del campo de otro
        public string Descripcion { get; set; }
        public Asistencia()
        {
            ID_Asist = int.MinValue;//0
            Cedula = string.Empty;//1
            Materia = string.Empty;//2
            Lecciones = int.MinValue;//3
            FechaHora = string.Empty;//4
            Estado = string.Empty;//5
            Observaciones = string.Empty;//6
            Descripcion = string.Empty;//7
        }
    }
}
