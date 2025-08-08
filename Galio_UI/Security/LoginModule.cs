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
    }
}
