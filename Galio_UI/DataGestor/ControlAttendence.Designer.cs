
namespace Galio_UI.DataGestor
{
    partial class ControlAttendence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlAttendence));
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.gbModAttendence = new System.Windows.Forms.GroupBox();
            this.lblStateMod = new System.Windows.Forms.Label();
            this.lblDateMod = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnMod = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAttendence = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbCambiar = new System.Windows.Forms.RadioButton();
            this.rbAttendence = new System.Windows.Forms.RadioButton();
            this.dtpAtte = new System.Windows.Forms.DateTimePicker();
            this.dgvAttendence = new System.Windows.Forms.DataGridView();
            this.gbJustify = new System.Windows.Forms.GroupBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbJustify = new System.Windows.Forms.ComboBox();
            this.txtJustify = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnJustify = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.gb2.SuspendLayout();
            this.gbModAttendence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendence)).BeginInit();
            this.gbJustify.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.gbModAttendence);
            this.gb2.Controls.Add(this.label4);
            this.gb2.Controls.Add(this.rbCambiar);
            this.gb2.Controls.Add(this.rbAttendence);
            this.gb2.Controls.Add(this.dtpAtte);
            this.gb2.Controls.Add(this.dgvAttendence);
            this.gb2.Controls.Add(this.gbJustify);
            this.gb2.Location = new System.Drawing.Point(594, 68);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(646, 454);
            this.gb2.TabIndex = 24;
            this.gb2.TabStop = false;
            this.gb2.Text = "Datos del Estudiante";
            // 
            // gbModAttendence
            // 
            this.gbModAttendence.Controls.Add(this.lblStateMod);
            this.gbModAttendence.Controls.Add(this.lblDateMod);
            this.gbModAttendence.Controls.Add(this.label12);
            this.gbModAttendence.Controls.Add(this.label13);
            this.gbModAttendence.Controls.Add(this.btnMod);
            this.gbModAttendence.Controls.Add(this.label7);
            this.gbModAttendence.Controls.Add(this.cmbAttendence);
            this.gbModAttendence.Location = new System.Drawing.Point(300, 221);
            this.gbModAttendence.Name = "gbModAttendence";
            this.gbModAttendence.Size = new System.Drawing.Size(340, 227);
            this.gbModAttendence.TabIndex = 10;
            this.gbModAttendence.TabStop = false;
            this.gbModAttendence.Text = "Modificar Asistencia";
            // 
            // lblStateMod
            // 
            this.lblStateMod.AutoSize = true;
            this.lblStateMod.Location = new System.Drawing.Point(110, 99);
            this.lblStateMod.Name = "lblStateMod";
            this.lblStateMod.Size = new System.Drawing.Size(0, 13);
            this.lblStateMod.TabIndex = 14;
            // 
            // lblDateMod
            // 
            this.lblDateMod.AutoSize = true;
            this.lblDateMod.Location = new System.Drawing.Point(99, 66);
            this.lblDateMod.Name = "lblDateMod";
            this.lblDateMod.Size = new System.Drawing.Size(0, 13);
            this.lblDateMod.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Fecha:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(45, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Estado:";
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(248, 198);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(75, 23);
            this.btnMod.TabIndex = 2;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Modificar Asistencia";
            // 
            // cmbAttendence
            // 
            this.cmbAttendence.FormattingEnabled = true;
            this.cmbAttendence.Location = new System.Drawing.Point(136, 131);
            this.cmbAttendence.Name = "cmbAttendence";
            this.cmbAttendence.Size = new System.Drawing.Size(96, 21);
            this.cmbAttendence.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Filtrar por Fecha:";
            // 
            // rbCambiar
            // 
            this.rbCambiar.AutoSize = true;
            this.rbCambiar.Location = new System.Drawing.Point(348, 198);
            this.rbCambiar.Name = "rbCambiar";
            this.rbCambiar.Size = new System.Drawing.Size(114, 17);
            this.rbCambiar.TabIndex = 8;
            this.rbCambiar.TabStop = true;
            this.rbCambiar.Text = "Cambiar Asistencia";
            this.rbCambiar.UseVisualStyleBackColor = true;
            this.rbCambiar.CheckedChanged += new System.EventHandler(this.rbCambiar_CheckedChanged);
            // 
            // rbAttendence
            // 
            this.rbAttendence.AutoSize = true;
            this.rbAttendence.Location = new System.Drawing.Point(104, 198);
            this.rbAttendence.Name = "rbAttendence";
            this.rbAttendence.Size = new System.Drawing.Size(113, 17);
            this.rbAttendence.TabIndex = 7;
            this.rbAttendence.TabStop = true;
            this.rbAttendence.Text = "Justificar Ausencia";
            this.rbAttendence.UseVisualStyleBackColor = true;
            this.rbAttendence.CheckedChanged += new System.EventHandler(this.rbAttendence_CheckedChanged);
            // 
            // dtpAtte
            // 
            this.dtpAtte.Location = new System.Drawing.Point(418, 42);
            this.dtpAtte.Name = "dtpAtte";
            this.dtpAtte.Size = new System.Drawing.Size(181, 20);
            this.dtpAtte.TabIndex = 2;
            this.dtpAtte.ValueChanged += new System.EventHandler(this.dtpAtte_ValueChanged);
            // 
            // dgvAttendence
            // 
            this.dgvAttendence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendence.Location = new System.Drawing.Point(42, 42);
            this.dgvAttendence.Name = "dgvAttendence";
            this.dgvAttendence.Size = new System.Drawing.Size(353, 150);
            this.dgvAttendence.TabIndex = 1;
            this.dgvAttendence.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendence_CellContentDoubleClick);
            // 
            // gbJustify
            // 
            this.gbJustify.Controls.Add(this.lblState);
            this.gbJustify.Controls.Add(this.lblDate);
            this.gbJustify.Controls.Add(this.cmbJustify);
            this.gbJustify.Controls.Add(this.txtJustify);
            this.gbJustify.Controls.Add(this.lbl1);
            this.gbJustify.Controls.Add(this.label5);
            this.gbJustify.Controls.Add(this.btnJustify);
            this.gbJustify.Controls.Add(this.label6);
            this.gbJustify.Location = new System.Drawing.Point(6, 221);
            this.gbJustify.Name = "gbJustify";
            this.gbJustify.Size = new System.Drawing.Size(272, 227);
            this.gbJustify.TabIndex = 9;
            this.gbJustify.TabStop = false;
            this.gbJustify.Text = "Justifcar";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(95, 75);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(0, 13);
            this.lblState.TabIndex = 10;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(87, 37);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 13);
            this.lblDate.TabIndex = 9;
            // 
            // cmbJustify
            // 
            this.cmbJustify.FormattingEnabled = true;
            this.cmbJustify.Location = new System.Drawing.Point(98, 99);
            this.cmbJustify.Name = "cmbJustify";
            this.cmbJustify.Size = new System.Drawing.Size(93, 21);
            this.cmbJustify.TabIndex = 8;
            this.cmbJustify.SelectedIndexChanged += new System.EventHandler(this.cmbJustify_SelectedIndexChanged);
            // 
            // txtJustify
            // 
            this.txtJustify.Location = new System.Drawing.Point(45, 149);
            this.txtJustify.Name = "txtJustify";
            this.txtJustify.Size = new System.Drawing.Size(146, 20);
            this.txtJustify.TabIndex = 7;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(33, 37);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(40, 13);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado:";
            // 
            // btnJustify
            // 
            this.btnJustify.Location = new System.Drawing.Point(191, 198);
            this.btnJustify.Name = "btnJustify";
            this.btnJustify.Size = new System.Drawing.Size(75, 23);
            this.btnJustify.TabIndex = 0;
            this.btnJustify.Text = "Justificar";
            this.btnJustify.UseVisualStyleBackColor = true;
            this.btnJustify.Click += new System.EventHandler(this.btnJustify_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Justificar:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbID);
            this.groupBox2.Controls.Add(this.rbName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbGrupo);
            this.groupBox2.Controls.Add(this.txtBusca);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgvStudents);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(12, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 379);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Estudiantes";
            // 
            // rbID
            // 
            this.rbID.AutoSize = true;
            this.rbID.Location = new System.Drawing.Point(112, 56);
            this.rbID.Name = "rbID";
            this.rbID.Size = new System.Drawing.Size(77, 17);
            this.rbID.TabIndex = 6;
            this.rbID.TabStop = true;
            this.rbID.Text = "Por Cedula";
            this.rbID.UseVisualStyleBackColor = true;
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Location = new System.Drawing.Point(195, 55);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(81, 17);
            this.rbName.TabIndex = 5;
            this.rbName.TabStop = true;
            this.rbName.Text = "Por Nombre";
            this.rbName.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cambiar Grupo";
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(420, 86);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(121, 21);
            this.cmbGrupo.TabIndex = 3;
            this.cmbGrupo.SelectedIndexChanged += new System.EventHandler(this.cmbGrupo_SelectedIndexChanged);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(63, 86);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(126, 20);
            this.txtBusca.TabIndex = 2;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Estudiante: ";
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(6, 122);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(407, 251);
            this.dgvStudents.TabIndex = 0;
            this.dgvStudents.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1238, 50);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(440, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Justificar y Modificar Asistencia";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnClose.Location = new System.Drawing.Point(1197, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 32);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ControlAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 521);
            this.ControlBox = false;
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ControlAttendence";
            this.Text = "ControlAttendence";
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.gbModAttendence.ResumeLayout(false);
            this.gbModAttendence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendence)).EndInit();
            this.gbJustify.ResumeLayout(false);
            this.gbJustify.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.GroupBox gbModAttendence;
        private System.Windows.Forms.Label lblStateMod;
        private System.Windows.Forms.Label lblDateMod;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbAttendence;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbCambiar;
        private System.Windows.Forms.RadioButton rbAttendence;
        private System.Windows.Forms.DateTimePicker dtpAtte;
        private System.Windows.Forms.DataGridView dgvAttendence;
        private System.Windows.Forms.GroupBox gbJustify;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbJustify;
        private System.Windows.Forms.TextBox txtJustify;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnJustify;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbID;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
    }
}