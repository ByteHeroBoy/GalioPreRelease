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
        public bool NewStudent(Estudiante data)
        {
            bool doit = false;
            using (SQLiteConnection cnt = CreateConnection())
            {
                cnt.Open();
                string pa = "INSERT INTO Estudiante (Cedula, Nombre, Grupo) values (@Cedula, @Nombre, @Grupo)";
                using (SQLiteCommand cmd = new SQLiteCommand(pa, cnt))
                {
                    cmd.Parameters.AddWithValue("@Cedula", data.Cedula);
                    cmd.Parameters.AddWithValue("@Nombre", data.Nombre);
                    cmd.Parameters.AddWithValue("@Grupo", data.Grupo);
                    cmd.ExecuteNonQuery();
                    doit = true;
                }
                cnt.Close();
            }
            return doit;
        }
        public bool Exist(string id)
        {
            bool doit = false;
            using (SQLiteConnection cnt = CreateConnection())
            {
                cnt.Open();
                string pa = "Select a.Cedula FROM Estudiante a WHERE a.Cedula = @ID";
                using ( SQLiteCommand cmd = new SQLiteCommand(pa,cnt))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.CommandType = System.Data.CommandType.Text;
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        string existid = string.Empty;
                        while (reader.Read())
                        {
                            existid = reader["Cedula"].ToString();
                        }
                        if (existid.Length > 0)
                        {
                            doit = true;
                        }
                    }
                }
            }
            return doit;
        }
        public bool UpdateStudent(Estudiante data)
        {
            bool doit = false;
            using (SQLiteConnection cnt = CreateConnection())
            {
                cnt.Open();
                string pa = "UPDATE Estudiante SET Nombre = @Name, Grupo = @Grupo where Cedula = @ID";
                using (SQLiteCommand cmd = new SQLiteCommand(pa,cnt))
                {
                    cmd.Parameters.AddWithValue("@Name", data.Nombre);
                    cmd.Parameters.AddWithValue("@Grupo", data.Grupo);
                    cmd.Parameters.AddWithValue("@ID", data.Cedula);
                    cmd.ExecuteNonQuery();
                    doit = true;
                }
                cnt.Close();
            }
            return doit;
        }
        public bool DeleteStudent(Estudiante data)
        {
            bool success = false;
            using (SQLiteConnection cnt = CreateConnection())
            {
                cnt.Open();
                using (SQLiteTransaction transaction = cnt.BeginTransaction())
                {
                    try
                    {
                        string deleteAttendanceSql = "DELETE FROM Asistencia WHERE Cedula = @ID";
                        using (SQLiteCommand deleteAttendanceCmd = new SQLiteCommand(deleteAttendanceSql, cnt))
                        {
                            deleteAttendanceCmd.Parameters.AddWithValue("@ID", data.Cedula);
                            deleteAttendanceCmd.ExecuteNonQuery();
                        }
                        string deleteStudentSql = "DELETE FROM Estudiante WHERE Cedula = @ID";
                        using (SQLiteCommand deleteStudentCmd = new SQLiteCommand(deleteStudentSql, cnt))
                        {
                            deleteStudentCmd.Parameters.AddWithValue("@ID", data.Cedula);
                            int rowsAffected = deleteStudentCmd.ExecuteNonQuery();
                            success = rowsAffected > 0;
                        }
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine($"Ocurrió un error: {ex.Message}");
                    }
                }
            }
            return success;
        }
        public List<Asistencia> GetAsistencias (string ID)
        {
            List<Asistencia> lst = new List<Asistencia>();
            using (SQLiteConnection cnt = CreateConnection())
            {
                cnt.Open();
                string pa = "select a.Cedula, a.FechaHora, a.Estado,a.ID,a.Observaciones from Asistencia a where a.Cedula = @ID";
                using (SQLiteCommand cmd = new SQLiteCommand(pa, cnt))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Asistencia atte = new Asistencia
                            {
                                Cedula= reader["Cedula"].ToString()
                            };
                        }
                    }
                }
            }
            return lst;
        }
        public bool JustifyAsist(Asistencia data)
        {
            bool doit = true;
            using (SQLiteConnection cnt = CreateConnection())
            {
                cnt.Open();
                string pa = "UPDATE Asistencia SET Estado = @Estado, Observaciones = @Observaciones WHERE Cedula = @Cedula and ID = @ID";
                using (SQLiteCommand cmd = new SQLiteCommand(pa, cnt))
                {
                    cmd.Parameters.AddWithValue("@Estado", data.Estado);
                    cmd.Parameters.AddWithValue("@Observaciones", data.Observaciones);
                    cmd.Parameters.AddWithValue("@Cedula", data.Cedula);
                    cmd.Parameters.AddWithValue("@ID", data.ID_Asist);
                    cmd.ExecuteNonQuery();
                    doit = true;
                }
                cnt.Close();

            }
            return doit;
        }
        #endregion
    }
}
 