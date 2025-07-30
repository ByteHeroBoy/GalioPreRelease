using ETL.Security;
using System;
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
                string pa = "select a.UserID, a.UserName, a.UserPass, a.Estado from UsersR where a.UserName = @UserName and a.UserPass = @UserPass and a.Estado = 1";
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
    }
}
 