namespace ETL.DataGen
{
    public class DataStats
    {
       public double PorcentajeAsistencias { get; set; }
        public int Asistencias { get; set; }
        public int Ausencias { get; set; }
        public string ID_Estudiante { get; set; }
        public DataStats()
        {
            PorcentajeAsistencias = double.MinValue;
            Asistencias = int.MinValue;
            Ausencias = int.MinValue;
            ID_Estudiante = string.Empty;
        }
    }
}
