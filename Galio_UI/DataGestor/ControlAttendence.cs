using BLL;
using ETL.DataGen;
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
    public partial class ControlAttendence : Form
    {
        //Lista de estudiantes
        private List<Estudiante> Estudiantes { get; set; }
        //Lista de Asistencia
        private List<Asistencia> ListaAsist { get; set; }
        public ControlAttendence()
        {
            InitializeComponent();
            CMB();
            Start();
            gb2.Enabled = false;
            rbID.Checked = true;
            //rbAttendence.Checked = true;
            txtJustify.Enabled = false;
            gbJustify.Enabled = false;
            gbModAttendence.Enabled = false;
            rbAttendence.Checked = true;
            foreach (DataGridViewColumn item in dgvStudents.Columns)
            {
                item.ReadOnly = true;
            }
        }
        private void CMB()
        {
            cmbGrupo.Items.Add("7-1");
            cmbGrupo.Items.Add("8-1");
            cmbGrupo.Items.Add("9-1");
            cmbGrupo.Items.Add("10-1");
            cmbGrupo.Items.Add("11-1");
            cmbGrupo.SelectedItem = "7-1";
            cmbGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            //
            cmbJustify.Items.Add("Seleccione");
            cmbJustify.Items.Add("Enfermedad");
            cmbJustify.Items.Add("Cita Medica");
            cmbJustify.Items.Add("Otro");
            cmbJustify.SelectedItem = "Seleccione";
            cmbJustify.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbAttendence.Items.Add("Seleccione");
            cmbAttendence.Items.Add("Ausente");
            cmbAttendence.Items.Add("Presente");
            cmbAttendence.Items.Add("Tardia");
            cmbAttendence.Items.Add("Justificado");
            cmbAttendence.SelectedItem = "Seleccione";
            cmbAttendence.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void Start()
        {

            Logic logic = new Logic();
            Estudiantes = logic.ListGroup(cmbGrupo.SelectedItem.ToString());
            dgvStudents.DataSource = Estudiantes;
            dgvStudents.Refresh();
            dgvStudents.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }
        private void HideColumns()
        {
            dgvAttendence.Columns["ID"].Visible = false;
            dgvAttendence.Columns["Descript"].Visible = false;
        }
        private void CleanGbJustify()
        {
            lblDate.Text = string.Empty;
            lblState.Text = string.Empty;
            cmbJustify.SelectedItem = "Seleccione";
            txtJustify.Text = string.Empty;
            gbJustify.Enabled = false;
        }
        private void CleanGBModAtte()
        {
            lblDateMod.Text = string.Empty;
            lblStateMod.Text = string.Empty;
            cmbAttendence.SelectedItem = "Seleccione";
            gbModAttendence.Enabled = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void cmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Start();
        }
        //Dar click para traer la lista de asistencia del alumno
        private void dgvStudents_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string estid = dgvStudents.Rows[e.RowIndex].Cells[0].Value.ToString();
            Logic logic = new Logic();
            dgvAttendence.DataSource = new List<Asistencia>();
            dgvAttendence.Refresh();
            //1
            ListAsist = logic.GetListAttes(estid);
            if (ListAttes.Count > 0)
            {
                dgvAttendence.DataSource = ListAttes;
                dgvAttendence.Refresh();
                dgvAttendence.Columns["DateTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                HideColumns();
                gb2.Enabled = true;
                foreach (DataGridViewColumn item in dgvAttendence.Columns)
                {
                    item.ReadOnly = true;
                }
            }
            else
            {
                MessageBox.Show("Este estudiante no cuenta con Asistencias registradas\n" +
                    "Si considera que es un error comuniquese con Soporte.");
                gb2.Enabled = false;
            }
        }
        //Buscar por Nombre o por Cedula segun CMB
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (rbID.Checked == true)
                if (txtBusca.Text.Trim().Length > 0)
                    dgvStudents.DataSource = Students.FindAll(item => item.Cedula.ToString().Contains(txtBusca.Text.Trim()));
            if (rbName.Checked == true)
                if (txtBusca.Text.Trim().Length > 0)
                    dgvStudents.DataSource = Students.FindAll(item => item.Name.ToString().ToUpper().Contains(txtBusca.Text.ToUpper().Trim()));
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
                e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char) Keys.Back);
    }
}
//Date Picker Change select attendence for that day
private void dtpAtte_ValueChanged(object sender, EventArgs e)
{
    string date = dtpAtte.Value.ToString("yyyy/MM/dd");
    List<ListAtte> lst = new List<ListAtte>();
    foreach (ListAtte item in ListAttes)
    {
        string d = new string(item.DateTime.Take(10).ToArray());
        if (date.Equals(d))
            lst.Add(item);
    }
    if (lst.Count > 0)
    {
        dgvAttendence.DataSource = lst;
        dgvAttendence.Refresh();
    }
    else
        MessageBox.Show("El estudiante no cuenta con asistencias en el dia seleccionado.");
}
private void dgvAttendence_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
{
    listAtte = new ListAtte
    {
        ID = Convert.ToInt32(dgvAttendence.Rows[e.RowIndex].Cells[0].Value.ToString()),
        StudentID = dgvAttendence.Rows[e.RowIndex].Cells[1].Value.ToString(),
        DateTime = dgvAttendence.Rows[e.RowIndex].Cells[2].Value.ToString(),
        State = dgvAttendence.Rows[e.RowIndex].Cells[3].Value.ToString(),
        Descript = dgvAttendence.Rows[e.RowIndex].Cells[4].Value.ToString()
    };
    if (rbAttendence.Checked == true)
    {
        if (listAtte.State.Equals("Ausente"))
        {
            lblDate.Text = listAtte.DateTime;
            lblState.Text = listAtte.State;
            gbJustify.Enabled = true;
        }
        else
            MessageBox.Show("No se puede Justificar una asistencia que no es Ausencia\n" +
                "Si desea modificar una asistencia puede hacerlo en el otro modulo.", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    if (rbCambiar.Checked == true)
    {
        lblDateMod.Text = listAtte.DateTime;
        lblStateMod.Text = listAtte.State;
        gbModAttendence.Enabled = true;
    }
}
private void cmbJustify_SelectedIndexChanged(object sender, EventArgs e)
{
    if (cmbJustify.SelectedItem.ToString().Equals("Otro"))
        txtJustify.Enabled = true;
    else
        txtJustify.Enabled = false;
}
private void rbCambiar_CheckedChanged(object sender, EventArgs e)
{
    if (rbCambiar.Checked == true)
    {
        gbJustify.Enabled = false;
        lblDate.Text = string.Empty;
        lblState.Text = string.Empty;
        cmbJustify.SelectedItem = "Seleccione";
    }
}
private void rbAttendence_CheckedChanged(object sender, EventArgs e)
{
    gbModAttendence.Enabled = false;
    lblDateMod.Text = string.Empty;
    lblStateMod.Text = string.Empty;
    cmbAttendence.SelectedItem = "Seleccione";
}
private void btnJustify_Click(object sender, EventArgs e)
{
    if (!cmbJustify.SelectedItem.Equals("Seleccione") || !string.IsNullOrWhiteSpace(txtJustify.Text.Trim()))
    {
        Logic logic = new Logic();
        if (!cmbJustify.SelectedItem.Equals("Seleccione"))
            listAtte.Descript = cmbJustify.SelectedItem.ToString();
        else
            listAtte.Descript = txtJustify.Text.Trim();
        listAtte.State = "Justificado";
        DialogResult result = MessageBox.Show("Desea Justificar esta Asistencia?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            if (logic.JustifyAttes(listAtte))
            {
                dgvAttendence.DataSource = new List<ListAtte>();
                MessageBox.Show("Justificacion realizada.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CleanGbJustify();
            }
        }
    }
    else
        MessageBox.Show("Debe seleccionar o escribir una justificacion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
private void btnMod_Click(object sender, EventArgs e)
{
    if (!cmbAttendence.SelectedItem.ToString().Equals("Seleccione"))
    {
        listAtte.State = cmbAttendence.SelectedItem.ToString();
        listAtte.Descript = "";
        Logic logic = new Logic();
        DialogResult result = MessageBox.Show("Desea Modificar esta Asistencia?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            if (logic.JustifyAttes(listAtte))
            {
                dgvAttendence.DataSource = new List<ListAtte>();
                MessageBox.Show("Modificacion a asistencia realizada.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CleanGBModAtte();
            }
        }
    }
    else //Mensaje de Error
        MessageBox.Show("Debe seleccionar un opcion para modificar la asistencia", "Error!");
}


    }
}
