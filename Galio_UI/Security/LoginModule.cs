using BLL;
using ETL.Security;
using Galio_UI.DataGestor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galio_UI.Security
{
    public partial class LoginModule : Form
    {
        public LoginModule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt1.Text) && !string.IsNullOrEmpty(txt2.Text))
            {
                Users usr = new Users
                {
                    UserName = txt1.Text,
                    UserPass = txt2.Text
                };
                Logic lg = new Logic();
                if (lg.Login(usr))
                {
                    ContainerData cnt = new ContainerData();
                    cnt.Show();
                    Hide();

                }else
                    MessageBox.Show("Error!!, Credenciales Incorrectas.", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Error!!, Tiene campos en blanco","Error!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        //Close all the data, not leave subprocesses running
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Se enviara un Correo para solicitar Recuperacion de Usuario.\n" +
                "Espere Respuesta.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Thread hilo = new Thread(Send);
            hilo.Start();
        }
        private void Send()
        {
            Logic lg = new Logic();
            if (lg.MailSend("Recuperar Acceso"))
                MessageBox.Show("Correo Enviado Satisfactoriamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Error al enviar el Correo.\nContacte con Soporte.", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
