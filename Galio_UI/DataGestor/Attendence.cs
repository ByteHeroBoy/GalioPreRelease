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
        //Lista para buscar en txtbusca global
        private List<Estudiante> data { get; set; }
        public Attendence()
        {
            InitializeComponent();
            CMB();
            Start();
            dgvList.Columns[0].DisplayIndex = 3; // La columna de index 0 pasa a la posición 3
            dgvList.Columns[1].DisplayIndex = 2; // La columna de index 1 pasa a la posición 2
            rbID.Checked = true;
        }

        private void Start()
        {
            logic logic = new logic();
            List<Estudiante> est = logic.ListGroup(cmbGrupo.SelectedItem.ToString());
            dgvList.DataSource = est;
            data = est;
            dgvList.Refresh();
            dgvList.DataBindingComplete += DgvList_DataBindingComplete;
            //Hide Group Column
            dgvList.Columns["Grupo"].Visible = false;
            //AutoSize For Name Column Adjust to size Name
            dgvList.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            foreach (DataGridViewColumn item in dgvList.Columns)
            {
                if (item.Index != 0 && item.Index != 1)
                {
                    item.ReadOnly = true;
                }
            }  
        }  
        private void DgvList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvList.Rows)
            {
                if (row.Cells["Asistencia"] is DataGridViewCell cell)
                {
                    cell.Value = "Presente";
                }
            }
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
                HeaderText = "Observaciones",
                Name = "Observaciones"
            };
            dgvList.Columns.Add(descript);

            for (int i = 0; i <8; i++)
            {
                cmbLect.Items.Add(i);
            }
            cmbLect.SelectedIndex = 0;
            cmbLect.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion

        private void cmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea Cerra la Asistencia?\n Si ha realizado modificaciones se perderan.", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        private void ResetAttendence_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea Reiniciar la asistencia?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Start();
        }

        private void SaveAttendence_Click(object sender, EventArgs e)
        {
            if ((int)cmbLect.SelectedItem != 0)
            {
                List<Asistencia> save = new List<Asistencia>();
                string classt = "";
                using (CustomMessageBox cmb1 = new CustomMessageBox())
                {
                    DialogResult result = cmb1.ShowDialog();
                    if (result != DialogResult.OK)
                        return; // Si el usuario cierra el formulario sin seleccionar una opción, salir del método

                    classt = cmb1.SelectedOption;
                            
                }
                //guardar la lista de asistencia
                foreach (DataGridViewRow fila in dgvList.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        var ObservacionesCell = fila.Cells["Observaciones"].Value;

                        if (ObservacionesCell == null || string.IsNullOrEmpty(ObservacionesCell.ToString()))
                        {
                            fila.Cells["Observaciones"].Value = "No hay Observaciones";
                        }
                        Asistencia Ast = new Asistencia
                        {
                            Cedula = fila.Cells["Cedula"].Value.ToString(),
                            FechaHora = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                            Estado = fila.Cells["Asistencia"].Value.ToString(),
                            Materia = classt,
                            Lecciones = Convert.ToInt32(cmbLect.SelectedItem.ToString()),
                            Observaciones = fila.Cells["Observaciones"].Value.ToString()
                        };


                        //                   
                        save.Add(Ast);
                    }
                }
                logic logic = new logic();
                string cmbG = cmbGrupo.SelectedItem.ToString();
                if (logic.SaveAttendence(save, cmbG))
                {
                    MessageBox.Show("¡Los datos de asistencia se guardaron correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Start();
                }
                else
                {
                    MessageBox.Show("Error al guardar los Datos\n Contacte con Soporte.", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un valor diferente a 0");
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (rbID.Checked == true)
                if (txtBusca.Text.Trim().Length > 0)
                    dgvList.DataSource = data.FindAll(item => item.Cedula.ToString().Contains(txtBusca.Text.Trim()));
            if (rbName.Checked == true)
                if (txtBusca.Text.Trim().Length > 0)
                    dgvList.DataSource = data.FindAll(item => item.Nombre.ToString().ToUpper().Contains(txtBusca.Text.ToUpper().Trim()));
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


        public class CustomMessageBox : Form
        {
            public string SelectedOption { get; private set; }

            public CustomMessageBox()
            {
                this.Text = "Seleccione una opción";
                this.Size = new System.Drawing.Size(500, 150);

                // Crear los botones
                Button option1 = new Button() { Text = "Matematica", Location = new System.Drawing.Point(30, 30) };
                Button option2 = new Button() { Text = "Act.Desarrollo", Location = new System.Drawing.Point(150, 30) };
                Button option3 = new Button() { Text = "Taller", Location = new System.Drawing.Point(270, 30) };
                Button option4 = new Button() { Text = "Guia", Location = new System.Drawing.Point(390, 30) };

                // Agregar los botones al formulario
                this.Controls.Add(option1);
                this.Controls.Add(option2);
                this.Controls.Add(option3);
                this.Controls.Add(option4);

                // Agregar manejadores de eventos a los botones
                option1.Click += (sender, e) => { SelectedOption = option1.Text; this.DialogResult = DialogResult.OK; this.Close(); };
                option2.Click += (sender, e) => { SelectedOption = option2.Text; this.DialogResult = DialogResult.OK; this.Close(); };
                option3.Click += (sender, e) => { SelectedOption = option3.Text; this.DialogResult = DialogResult.OK; this.Close(); };
                option4.Click += (sender, e) => { SelectedOption = option4.Text; this.DialogResult = DialogResult.OK; this.Close(); };
            }
        }
    }
}
