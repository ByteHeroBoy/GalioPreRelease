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
    }
}
