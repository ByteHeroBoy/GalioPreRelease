using ETL.DataGen;
using ETL.Security;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
namespace DAL
{
    public class AccessData
    {
        #region Connection
        private static readonly string StringConect = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        private static AccessData _instance = null;
        public static AccessData Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AccessData();
                }
                return _instance;
            }
        }
        public SQLiteConnection CreateConnection()
        {
            return new SQLiteConnection(StringConect);
        }
        #endregion

        #region Security
        public Users Login (Users data)
        {
            Users usr = new Users();
            using (SQLiteConnection cnt = CreateConnection())
            {
                cnt.Open();
                string pa = "select UserID, UserName, UserPass, Estado from UsersR where UserName = @UserName and UserPass = @UserPass and Estado = 1";
                using (SQLiteCommand cmd = new SQLiteCommand(pa, cnt))
                {
                    cmd.Parameters.AddWithValue("@UserName", data.UserName);
                    cmd.Parameters.AddWithValue("@UserPass", data.UserPass);
                    cmd.CommandType = System.Data.CommandType.Text;
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usr.UserID = Convert.ToInt32(reader["UserID"].ToString());
                            usr.UserName = reader["UserName"].ToString();
                        }
                    }
                   
                }
                cnt.Close();
            }
                return usr;
        }
        #endregion
        #region DataGestor
        public List<Estudiante> ListGroup(string Group)
        {
            List<Estudiante> lst = new List<Estudiante>();
            using (SQLiteConnection cnt = CreateConnection())
            {
                cnt.Open();
                string pa = "select Cedula, Nombre, Grupo from Estudiante  where Grupo = @Grupo";
                using (SQLiteCommand cmd = new SQLiteCommand(pa, cnt))
                {
                    cmd.Parameters.AddWithValue("@Grupo", Group);
                    cmd.CommandType = System.Data.CommandType.Text;
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lst.Add(new Estudiante
                            {
                                Cedula = reader["Cedula"].ToString(),
                                Nombre = reader["Nombre"].ToString(),
                                Grupo = reader["Grupo"].ToString()
                            });
                        }
                    }
                }
                cnt.Close();
            }
            return lst;
        }
        public bool SaveAttendence(string group, List<Asistencia> lst)
        {
            bool doit = false;
            using (SQLiteConnection cnt = CreateConnection())
            {
                cnt.Open();
                string pa = "INSERT INTO Asistencia (Cedula, Materia, Lecciones, FechaHora, Estado, Observaciones) Values (@Cedula, @Materia, @Lecciones, @FechaHora, @Estado, @Observaciones)";
                using (SQLiteCommand cmd = new SQLiteCommand(pa, cnt))
                {
                    foreach (Asistencia data in lst)
                    {
                        cmd.Parameters.AddWithValue("@Cedula", data.Cedula);
                        cmd.Parameters.AddWithValue("@Materia", data.Materia);
                        cmd.Parameters.AddWithValue("@Lecciones", data.Lecciones);
                        cmd.Parameters.AddWithValue("@FechaHora", data.FechaHora);
                        cmd.Parameters.AddWithValue("@Estado", data.Estado);
                        cmd.Parameters.AddWithValue("@Observaciones", data.Observaciones);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    doit = true;
                }
                cnt.Close();               
            }
            return doit;
        }
        #endregion
    }
}
 