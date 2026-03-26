using BLL;
using ETL.DataGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Galio_UI.DataGestor
{
    public partial class ControlAttendence : Form
    {
        //Lista de estudiantes en memoria
        private List<Estudiante> Estudiantes { get; set; }
        //Lista de Asistencias en memoria
        private List<Asistencia> ListaAsist { get; set; }
        //Objeto para modificar una Asistencia
        private Asistencia Asistencia { get; set; }

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

            logic logic = new logic();
            Estudiantes = logic.ListGroup(cmbGrupo.SelectedItem.ToString());
            dgvStudents.DataSource = Estudiantes;
            dgvStudents.Refresh();
            dgvStudents.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }
        private void HideColumns()
        {
            dgvAttendence.Columns["ID_Asist"].Visible = false;
        }
        private void CleanGBModAtte()
        {
            lblDateMod.Text = string.Empty;
            lblStateMod.Text = string.Empty;
            cmbAttendence.SelectedItem = "Seleccione";
            gbModAttendence.Enabled = false;
        }
        private void CleanGbJustify()
        {
            lblDate.Text = string.Empty;
            lblState.Text = string.Empty;
            cmbJustify.SelectedItem = "Seleccione";
            txtJustify.Text = string.Empty;
            gbJustify.Enabled = false;
        }
        /// <summary>
        /// De aqui en adelante son los metodos privados para eventos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (rbID.Checked == true)
                if (txtBusca.Text.Trim().Length > 0)
                    dgvStudents.DataSource = Estudiantes.FindAll(item => item.Cedula.ToString().Contains(txtBusca.Text.Trim()));
            if (rbName.Checked == true)
                if (txtBusca.Text.Trim().Length > 0)
                    dgvStudents.DataSource = Estudiantes.FindAll(item => item.Nombre.ToString().ToUpper().Contains(txtBusca.Text.ToUpper().Trim()));

        }

        private void dgvStudents_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string estid = dgvStudents.Rows[e.RowIndex].Cells[0].Value.ToString();
            logic logic = new logic();
            dgvAttendence.DataSource = new List<Asistencia>();
            dgvAttendence.Refresh();
            //1
            ListaAsist = logic.GetAsistencias(estid);
            if (ListaAsist.Count > 0 )
            {
                dgvAttendence.DataSource = ListaAsist;
                dgvAttendence.Refresh();
                dgvAttendence.Columns["FechaHora"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //HideColumns();
                dgvAttendence.Columns["ID_Asist"].Visible = false;
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

        private void cmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Start();
        }

        private void dtpAtte_ValueChanged(object sender, EventArgs e)
        {
            string date = dtpAtte.Value.ToString("yyyy/MM/dd");
            List<Asistencia> lst = new List<Asistencia>();
            foreach (Asistencia item in ListaAsist)
            {
                string d = new string(item.FechaHora.Take(10).ToArray());
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
            Asistencia = new Asistencia
            {
                ID_Asist= Convert.ToInt32(dgvAttendence.Rows[e.RowIndex].Cells[0].Value.ToString()),
                Cedula= dgvAttendence.Rows[e.RowIndex].Cells[1].Value.ToString(),
                FechaHora = dgvAttendence.Rows[e.RowIndex].Cells[2].Value.ToString(),
                Estado = dgvAttendence.Rows[e.RowIndex].Cells[5].Value.ToString(),
                Observaciones = dgvAttendence.Rows[e.RowIndex].Cells[4].Value.ToString()
            };
            if (rbAttendence.Checked == true)
            {
                if (Asistencia.Estado.Equals("Ausente"))
                {
                    lblDate.Text = Asistencia.FechaHora;
                    lblState.Text = Asistencia.Estado;
                    gbJustify.Enabled = true;
                }
                else
                    MessageBox.Show("No se puede Justificar una asistencia que no es Ausencia\n" +
                        "Si desea modificar una asistencia puede hacerlo en el otro modulo.", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (rbCambiar.Checked == true)
            {
                lblDateMod.Text = Asistencia.FechaHora;
                lblStateMod.Text = Asistencia.Estado;
                gbModAttendence.Enabled = true;
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (!cmbAttendence.SelectedItem.ToString().Equals("Seleccione"))
            {
                Asistencia.Estado = cmbAttendence.SelectedItem.ToString();
                logic logic = new logic();
                DialogResult result  = MessageBox.Show("Desea Modificar esta Asistencia?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (logic.JustifyAsist(Asistencia))
                    {
                        dgvAttendence.DataSource = new List<Asistencia>();
                        MessageBox.Show("Modificacion a asistencia realizada.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CleanGBModAtte();
                    }
                }
            }
            else //Mensaje de Error
                MessageBox.Show("Debe seleccionar un opcion para modificar la asistencia", "Error!");
        }

        private void btnJustify_Click(object sender, EventArgs e)
        {
            if (!cmbJustify.SelectedItem.Equals("Seleccione") || !string.IsNullOrWhiteSpace(txtJustify.Text.Trim()))
            {
                logic logic = new logic();
                if (!cmbJustify.SelectedItem.Equals("Seleccione"))
                    Asistencia.Estado = cmbJustify.SelectedItem.ToString()+" ("+txtJustify.Text.Trim()+")";
                else
                    Asistencia.Estado = txtJustify.Text.Trim();
                Asistencia.Descripcion = "Ausencia Justificada";
                DialogResult result = MessageBox.Show("Desea Justificar esta Asistencia?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (logic.JustifyAsist(Asistencia))
                    {
                        dgvAttendence.DataSource = new List<Asistencia>();
                        MessageBox.Show("Justificacion realizada.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CleanGbJustify();
                    }
                }
            }
            else
                MessageBox.Show("Debe seleccionar o escribir una justificacion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbJustify_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbJustify.SelectedItem.ToString().Equals("Otro"))
                txtJustify.Enabled = true;
            else
            {
                txtJustify.Enabled = false;
                txtJustify.Text = "";
            }
        }

        private void rbAttendence_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAttendence.Checked == true)
            {
                gbJustify.Enabled = true;
                gbModAttendence.Enabled = false;
            }
            else
            {
                gbJustify.Enabled = false;
                gbModAttendence.Enabled = true;
            }
            
        }

        private void rbCambiar_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
