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
    public partial class Attendence : Form
    {
        public Attendence()
        {
            InitializeComponent();
            CMB();
            Start();
        }

        private void Start()
        {
            //mala practica
            ListGroup(cmbGrupo.SelectedItem.ToString());
        }

        private void ListGroup(string Group)
        {
            //mejor select del cmb al inicio
            Logic logic = new Logic();
            List<Estudiante> est = logic.ListGroup(Group);
            dgvList.DataSource = est;
            dgvList.Refresh();
            //AutoSize For Name Column Adjust to size Name
            dgvList.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //Hide Group Column
            dgvList.Columns["Grupo"].Visible = false;
        }
        #region Private
        private void CMB()
        {
            cmbGrupo.Items.Add("7-1");
            cmbGrupo.Items.Add("8-1");
            cmbGrupo.Items.Add("9-1");
            cmbGrupo.Items.Add("10-1");
            cmbGrupo.Items.Add("11-1");
            cmbGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrupo.SelectedItem = "7-1";

            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn
            {
                HeaderText = "Asistencia",
                Name = "Asistencia"
            };
            cmb.Items.Add("Presente");
            cmb.Items.Add("Ausente");
            cmb.Items.Add("Tardia");
            cmb.Items.Add("Ausente Justificado");

            dgvList.Columns.Add(cmb);

            DataGridViewTextBoxColumn descript = new DataGridViewTextBoxColumn
            {
                HeaderText = "Descripcion",
                Name = "Descripcion"
            };
            dgvList.Columns.Add(descript);

            //
            foreach (DataGridViewColumn item in dgvList.Columns)
            {
                if (item.Index != 3)
                {
                    item.ReadOnly = true;
                }
            }
            dgvList.Columns["Descripcion"].ReadOnly = false;
        }
        #endregion

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgvList.Rows)
            {
                if (row.Cells["Asistencia"] is DataGridViewCell cell)
                {
                    cell.Value = "Presente";
                }

            }
        }
    }
}
