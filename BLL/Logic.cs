using DAL;
using ETL.DataGen;
using ETL.Security;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

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
        public List<Asistencia> GetAsistencias(string ID)
        {
            AccessData dt = new AccessData();
            return dt.GetAsistencias(ID);
        }
        public bool JustifyAsist(Asistencia data)
        {
            AccessData dt = new AccessData();
            return dt.JustifyAsist(data);
        }
        public DataStats Estadisticas(string id)
        {
            DataStats data = new DataStats();
            AccessData dt = new AccessData();
            data = dt.Estadisticas(id);
            return data;
        }
        #endregion
        #region Secondary Logic
        //Send  support email
        public bool MailSend(string Tipo)
        {
            MailMessage mail = new MailMessage();
            SmtpClient envio = new SmtpClient();
            bool response = false;
            try
            {
                mail.From = new MailAddress("WhiteFoxSaport@outlook.com", "Correo Enviado WhiteFox", System.Text.Encoding.UTF8);
                mail.To.Add("WhiteFoxCode@hotmail.com");
                mail.Subject = "Galio Project";
                mail.Body = "Support to Galio :" + Tipo;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.Normal;
                envio.Host = "smtp-mail.outlook.com";
                envio.Port = 587;
                envio.EnableSsl = true;// Metodo de Cifrado
                envio.UseDefaultCredentials = false;
                envio.Credentials = new NetworkCredential("WhiteFoxCodeSaport@outlook.com", "CodingJust4Fun");

                envio.Send(mail);
                mail.Dispose();
                response = true; ;
            }
            catch (Exception)
            {
                response = false;
            }
            return response;
        }
            #endregion
        }
}
