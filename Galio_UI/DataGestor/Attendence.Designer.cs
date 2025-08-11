
namespace Galio_UI.DataGestor
{
    partial class Attendence
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendence));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblClass = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.ResetAttendence = new System.Windows.Forms.Button();
            this.SaveAttendence = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(-57, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(915, 50);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(407, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Asistencia";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnClose.Location = new System.Drawing.Point(874, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 32);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(743, 208);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(0, 13);
            this.lblClass.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(623, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Clase Por Horario:";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(768, 162);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(0, 13);
            this.lblGroup.TabIndex = 36;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(634, 162);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(127, 13);
            this.lbl4.TabIndex = 35;
            this.lbl4.Text = "Grupo Actual por Horario:";
            // 
            // rbID
            // 
            this.rbID.AutoSize = true;
            this.rbID.Location = new System.Drawing.Point(272, 80);
            this.rbID.Name = "rbID";
            this.rbID.Size = new System.Drawing.Size(77, 17);
            this.rbID.TabIndex = 34;
            this.rbID.TabStop = true;
            this.rbID.Text = "Por Cedula";
            this.rbID.UseVisualStyleBackColor = true;
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Location = new System.Drawing.Point(355, 79);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(81, 17);
            this.rbName.TabIndex = 33;
            this.rbName.TabStop = true;
            this.rbName.Text = "Por Nombre";
            this.rbName.UseVisualStyleBackColor = true;
            // 
            // ResetAttendence
            // 
            this.ResetAttendence.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ResetAttendence.BackgroundImage")));
            this.ResetAttendence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ResetAttendence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetAttendence.Location = new System.Drawing.Point(672, 324);
            this.ResetAttendence.Name = "ResetAttendence";
            this.ResetAttendence.Size = new System.Drawing.Size(71, 60);
            this.ResetAttendence.TabIndex = 32;
            this.ResetAttendence.UseVisualStyleBackColor = true;
            // 
            // SaveAttendence
            // 
            this.SaveAttendence.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveAttendence.BackgroundImage")));
            this.SaveAttendence.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveAttendence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAttendence.Location = new System.Drawing.Point(792, 324);
            this.SaveAttendence.Name = "SaveAttendence";
            this.SaveAttendence.Size = new System.Drawing.Size(66, 61);
            this.SaveAttendence.TabIndex = 31;
            this.SaveAttendence.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Buscar Estudiante por Nombre:";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(38, 78);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(220, 20);
            this.txtBusca.TabIndex = 28;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeColumns = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(38, 104);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(534, 229);
            this.dgvList.TabIndex = 30;
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(634, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Cambiar Grupo Actual:";
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(753, 102);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(64, 21);
            this.cmbGrupo.TabIndex = 26;
            // 
            // Attendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.rbID);
            this.Controls.Add(this.rbName);
            this.Controls.Add(this.ResetAttendence);
            this.Controls.Add(this.SaveAttendence);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbGrupo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Attendence";
            this.Text = "Attendence";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.RadioButton rbID;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.Button ResetAttendence;
        private System.Windows.Forms.Button SaveAttendence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGrupo;
    }
}