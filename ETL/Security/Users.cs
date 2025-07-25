using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETL.Security
{
    public class Users
    {
        public int  UserID { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public int Estado { get; set; }
        public Users()
        {
            UserID = int.MinValue;
            UserName = string.Empty;
            UserPass = string.Empty;
            //1 por defecto al crear cuenta  esta activa. 0 no activa
            Estado = 1;
        }
    }
}
