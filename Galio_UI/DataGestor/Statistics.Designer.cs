
namespace Galio_UI.DataGestor
{
    partial class Statistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInformAsist = new System.Windows.Forms.Button();
            this.lblPercent = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAusStud = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAtteStud = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnByGroup = new System.Windows.Forms.Button();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(2, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(978, 49);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(354, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estadisticas de Asistencia";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnClose.Location = new System.Drawing.Point(937, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 32);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnInformAsist);
            this.groupBox2.Controls.Add(this.lblPercent);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblAusStud);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblAtteStud);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblTeacher);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(557, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 332);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estadisticas de asistencia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Generar Reportes del Estudiante";
            // 
            // btnInformAsist
            // 
            this.btnInformAsist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInformAsist.BackgroundImage")));
            this.btnInformAsist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInformAsist.Location = new System.Drawing.Point(284, 278);
            this.btnInformAsist.Name = "btnInformAsist";
            this.btnInformAsist.Size = new System.Drawing.Size(81, 48);
            this.btnInformAsist.TabIndex = 21;
            this.btnInformAsist.UseVisualStyleBackColor = true;
            this.btnInformAsist.Click += new System.EventHandler(this.btnInformAsist_Click);
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(211, 220);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(0, 13);
            this.lblPercent.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Porcentaje de Asistencia a 10%:";
            // 
            // lblAusStud
            // 
            this.lblAusStud.AutoSize = true;
            this.lblAusStud.Location = new System.Drawing.Point(255, 158);
            this.lblAusStud.Name = "lblAusStud";
            this.lblAusStud.Size = new System.Drawing.Size(0, 13);
            this.lblAusStud.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Ausencias del Estudiante (Justificadas o no) :";
            // 
            // lblAtteStud
            // 
            this.lblAtteStud.AutoSize = true;
            this.lblAtteStud.Location = new System.Drawing.Point(211, 106);
            this.lblAtteStud.Name = "lblAtteStud";
            this.lblAtteStud.Size = new System.Drawing.Size(0, 13);
            this.lblAtteStud.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Asistencias Validas del Estudiante:";
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Location = new System.Drawing.Point(183, 56);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(0, 13);
            this.lblTeacher.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Asistencias por el Profesor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnByGroup);
            this.groupBox1.Controls.Add(this.rbID);
            this.groupBox1.Controls.Add(this.rbName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgvList);
            this.groupBox1.Controls.Add(this.cmbGrupo);
            this.groupBox1.Controls.Add(this.txtBusca);
            this.groupBox1.Location = new System.Drawing.Point(14, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 332);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estudiantes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Generar Reportes por Grupo";
            // 
            // btnByGroup
            // 
            this.btnByGroup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnByGroup.BackgroundImage")));
            this.btnByGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnByGroup.Location = new System.Drawing.Point(444, 278);
            this.btnByGroup.Name = "btnByGroup";
            this.btnByGroup.Size = new System.Drawing.Size(68, 48);
            this.btnByGroup.TabIndex = 24;
            this.btnByGroup.UseVisualStyleBackColor = true;
            this.btnByGroup.Click += new System.EventHandler(this.btnByGroup_Click);
            // 
            // rbID
            // 
            this.rbID.AutoSize = true;
            this.rbID.Location = new System.Drawing.Point(182, 19);
            this.rbID.Name = "rbID";
            this.rbID.Size = new System.Drawing.Size(77, 17);
            this.rbID.TabIndex = 23;
            this.rbID.TabStop = true;
            this.rbID.Text = "Por Cedula";
            this.rbID.UseVisualStyleBackColor = true;
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Location = new System.Drawing.Point(265, 18);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(81, 17);
            this.rbName.TabIndex = 22;
            this.rbName.TabStop = true;
            this.rbName.Text = "Por Nombre";
            this.rbName.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Buscar Estudiante por Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cambiar Grupo Actual:";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeColumns = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(9, 75);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(347, 251);
            this.dgvList.TabIndex = 20;
            this.dgvList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentDoubleClick);
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(444, 49);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(64, 21);
            this.cmbGrupo.TabIndex = 16;
            this.cmbGrupo.SelectedIndexChanged += new System.EventHandler(this.cmbGrupo_SelectedIndexChanged);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(39, 49);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(220, 20);
            this.txtBusca.TabIndex = 18;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 402);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Statistics";
            this.Text = "Estadisticas";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInformAsist;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAusStud;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAtteStud;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnByGroup;
        private System.Windows.Forms.RadioButton rbID;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.TextBox txtBusca;
    }
}