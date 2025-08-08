using Galio_UI.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galio_UI.DataGestor
{
    public partial class ContainerData : Form
    {
        public ContainerData()
        {
            InitializeComponent();
        }
        private void S1_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Attendence);
            if (frm == null)
            {
                Attendence lst = new Attendence();
                lst.MdiParent = this;
                lst.Show();
            }
        }
        private void S2_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is NewStudent);
            if (frm == null)
            {
                NewStudent lst = new NewStudent();
                lst.MdiParent = this;
                lst.Show();
            }
        }
        private void S3_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ControlAttendence);
            if (frm == null)
            {
                ControlAttendence lst = new ControlAttendence();
                lst.MdiParent = this;
                lst.Show();
            }
        }
        private void S4_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Statistics);
            if (frm == null)
            {
                Statistics lst = new Statistics();
                lst.MdiParent = this;
                lst.Show();
            }
        }   

        private void LogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea SALIR del Sistema?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                LoginModule lgm = new LoginModule();
                lgm.Show();
                Close();
            }
        }
    }
}
