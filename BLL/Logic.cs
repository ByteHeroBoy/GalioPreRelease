using DAL;
using ETL.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Logic
    {
        #region Login
        public bool Login(Users data)
        {
            AccessData dt = new AccessData();
            Users usr = dt.Login(data);
            if (!string.IsNullOrEmpty(usr.UserName) && usr.UserID != int.MinValue)
                return true;
            else
                return false;
        }
        #endregion
        #region 

        #endregion
    }
}
