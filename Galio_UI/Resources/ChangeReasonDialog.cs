using System;
using System.Drawing;
using System.Windows.Forms;


namespace Galio_UI.Resources
{
    public class ChangeReasonDialog : Form
    {
        private TextBox txtReason;
        private Button btnConfirm;
        private Button btnCancel;
        private Label lblInstruction;
        private Label lblError;

        public string Reason => txtReason.Text.Trim();

        public ChangeReasonDialog()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "Reason for Change";
            this.Size = new Size(420, 240);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormClosing += OnFormClosing;

            lblInstruction = new Label
            {
                Text = "Por Favor ingrese la razon del cambio de la Asistencia: ",
                Location = new Point(12, 12),
                Size = new Size(380, 20),
                Font = new Font("Segoe UI", 9f)
            };

            txtReason = new TextBox
            {
                Location = new Point(12, 38),
                Size = new Size(380, 80),
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                Font = new Font("Segoe UI", 9f)
            };
            txtReason.TextChanged += TxtReason_TextChanged;

            lblError = new Label
            {
                Text = "You must enter a reason before closing.",
                Location = new Point(12, 124),
                Size = new Size(380, 18),
                ForeColor = Color.Red,
                Font = new Font("Segoe UI", 8.5f),
                Visible = false
            };

            btnConfirm = new Button
            {
                Text = "Confirm",
                Location = new Point(236, 148),
                Size = new Size(75, 28),
                Enabled = false,
                Font = new Font("Segoe UI", 9f)
            };
            btnConfirm.Click += BtnConfirm_Click;

            this.Controls.AddRange(new Control[] {
                lblInstruction, txtReason, lblError, btnConfirm, btnCancel
            });
        }

        private void TxtReason_TextChanged(object sender, EventArgs e)
        {
            btnConfirm.Enabled = !string.IsNullOrWhiteSpace(txtReason.Text);
            if (btnConfirm.Enabled) lblError.Visible = false;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtReason.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK &&
                this.DialogResult != DialogResult.Cancel)
            {
                if (string.IsNullOrWhiteSpace(txtReason.Text))
                {
                    e.Cancel = true;
                    lblError.Visible = true;
                }
            }
        }
    }
}
