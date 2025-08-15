using BLL;
using ETL.DataGen;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Galio_UI.DataGestor
{
    public partial class NewStudent : Form
    {
        private List<Estudiante> Students { get; set; }
        public NewStudent()
        {
            InitializeComponent();
            Start();
            CMB();
            DataCall();
            rb1.Checked = true;
            lblNameUpdate.Visible = false;
            txtNameUpdate.Visible = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnDelete.Visible = false;
            foreach (DataGridViewColumn item in dgvList.Columns)
            {
                item.ReadOnly = true;
            }
            rbID.Checked = true;
        }
        private void Start()
        {
            cmbGrupo.Enabled = false;
            txtApe1.Enabled = false;
            txtApe2.Enabled = false;
            txtName.Enabled = false;
            btnSave.Enabled = false;
            txtid.Enabled = true;
            rbOtro.Visible = true;
            rb1.Checked = true;
        }
        private void CMB()
        {
            cmbGrupo.Items.Add("Grupo");
            cmbGrupo.Items.Add("7-1");
            cmbGrupo.Items.Add("8-1");
            cmbGrupo.Items.Add("9-1");
            cmbGrupo.Items.Add("10-1");
            cmbGrupo.Items.Add("11-1");
            cmbGrupo.SelectedItem = "Grupo";
            cmbGrupo.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbGrupoAct.Items.Add("7-1");
            cmbGrupoAct.Items.Add("8-1");
            cmbGrupoAct.Items.Add("9-1");
            cmbGrupoAct.Items.Add("10-1");
            cmbGrupoAct.Items.Add("11-1");
            cmbGrupoAct.SelectedItem = "7-1";
            cmbGrupoAct.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void DataCall()
        {
            Logic logic = new Logic();
            List<Estudiante> list = logic.ListGroup(cmbGrupoAct.SelectedItem.ToString());
            Students = list;
            dgvList.DataSource = list;
            dgvList.Refresh();
            dgvList.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void cmbGrupoAct_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataCall();
        }

        private void dgvList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Visible = true;
            btnDelete.Enabled = true;
            txtid.Text = dgvList.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNameUpdate.Text = dgvList.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbGrupo.SelectedItem = dgvList.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtApe1.Visible = false;
            txtName.Visible = false;
            txtApe2.Visible = false;
            lblApe1.Visible = false;
            lblApe2.Visible = false;
            lblName.Visible = false;
            rbOtro.Checked = true;
            rbOtro.Visible = false;
            rb1.Visible = false;
            rb2.Visible = false;
            lblNameUpdate.Visible = true;
            txtNameUpdate.Visible = true;
            txtid.Enabled = false;
            btnSave.Enabled = false;
            //Bloquear boton guardar y habilitar boton actualizar            
            //Preguntar si actualizar y hacer update SQLite
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (rbID.Checked == true)
                if (txtBusca.Text.Trim().Length > 0)
                    dgvList.DataSource = Students.FindAll(item => item.Cedula.ToString().Contains(txtBusca.Text.Trim()));
            if (rbName.Checked == true)
                if (txtBusca.Text.Trim().Length > 0)
                    dgvList.DataSource = Students.FindAll(item => item.Nombre.ToString().ToUpper().Contains(txtBusca.Text.ToUpper().Trim()));
        }

        private void txtBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            /// <summary>
            /// Code from : https://ourcodeworld.com/articles/read/507/how-to-allow-only-numbers-inside-a-textbox-in-winforms-c-sharp
            /// <summary>
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (rbID.Checked == true)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                    //Some Error Message ??
                }
            }
            /*
               // If you want, you can allow decimal (float) numbers
               if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
               {
                   e.Handled = true;
               }
             */
            /// <summary>
            /// Code from : https://stackoverflow.com/questions/8321871/how-to-make-a-textbox-accept-only-alphabetic-characters
            /// User: https://stackoverflow.com/users/570150/v4vendetta
            /// <summary>
            // Verify that the pressed key isn't CTRL or any nuemric Digit
            if (rbName.Checked == true)
            {
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
            }
        }

        private void txtApe1_TextChanged(object sender, EventArgs e)
        {
            if (txtApe1.Text.Length > 0)
            {
                txtApe2.Enabled = true;
            }
            else txtApe2.Enabled = false;
        }

        private void txtApe2_TextChanged(object sender, EventArgs e)
        {
            if (txtApe2.Text.Length > 0)
            {
                txtName.Enabled = true;
            }
            else txtName.Enabled = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0)
            {
                btnSave.Enabled = true;
            }
            else btnSave.Enabled = false;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }      

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea Cerrar el modulo?" +
                "\n Si tiene datos sin guardar se perderan.", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            if (CheckID())
            {
                cmbGrupo.Enabled = true;
                txtApe1.Enabled = true;
                btnSave.Enabled = true;
            }
            else
            {
                Start();
            }
        }
        private void rbOtro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOtro.Checked == true)
                MessageBox.Show("Sea cuidadoso al ingresar la identificacion del alumno.");
        }


        private bool CheckID()
        {
            if (rbOtro.Checked == true)
                return true;

            //Nacional
            if (rb1.Checked == true)
            {
                CheckerData val = new CheckerData
                {
                    Valor = txtid.Text,
                    Patron = @"^[0-9]{9}$"
                };
                return val.Checker();
            }
            //Dimex
            if (rb2.Checked == true)
            {
                CheckerData val = new CheckerData
                {
                    Valor = txtid.Text,
                    Patron = @"^[0-9]{12}$"
                };
                return val.Checker();
            }
            else
                return false;
        }
        private void Clean()
        {
            txtApe1.Text = string.Empty;
            txtApe2.Text = string.Empty;
            txtName.Text = string.Empty;
            txtid.Text = string.Empty;
            cmbGrupo.SelectedItem = "Grupo";
            cmbGrupoAct.SelectedItem = "7-1";
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Visible = false;

            txtApe1.Visible = true;
            txtName.Visible = true;
            txtApe2.Visible = true;
            lblApe1.Visible = true;
            lblApe2.Visible = true;
            lblName.Visible = true;
            rb1.Visible = true;
            rb2.Visible = true;
            lblNameUpdate.Visible = false;
            txtNameUpdate.Visible = false;
            Start();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
