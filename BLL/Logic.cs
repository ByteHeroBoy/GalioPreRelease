using DAL;
using ETL.DataGen;
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
        #region DataGestor
        public List<Estudiante> ListGroup(String Group)
        {
            List<Estudiante> lst = new List<Estudiante>();
            AccessData dt = new AccessData();
            lst = dt.ListGroup(Group);
            return lst;
        }
        public bool SaveAttendence(List<Asistencia>lst, string grupo)
        {
            AccessData dt = new AccessData();
            return dt.SaveAttendence(grupo, lst);
        }
        public bool NewStudent(Estudiante data)
        {
            AccessData dt = new AccessData();
            return dt.NewStudent(data);
        }
        public bool Exist (string id)
        {
            AccessData dt = new AccessData();
            return dt.Exist(id);
        }
        public bool Update(Estudiante data)
        {
            AccessData dt = new AccessData(); ;
            return dt.UpdateStudent(data);
        }
        public bool Delete(Estudiante data)
        {
            AccessData dt = new AccessData();
            return dt.DeleteStudent(data);
        }
        #endregion
    }
}
