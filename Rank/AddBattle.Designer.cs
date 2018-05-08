namespace Rank
{
    partial class AddBattle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLosser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbWinner = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPkmW = new System.Windows.Forms.TextBox();
            this.txtPkmL = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbLosser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbWinner);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 80);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Perdedor";
            // 
            // cmbLosser
            // 
            this.cmbLosser.FormattingEnabled = true;
            this.cmbLosser.Location = new System.Drawing.Point(131, 40);
            this.cmbLosser.Name = "cmbLosser";
            this.cmbLosser.Size = new System.Drawing.Size(290, 21);
            this.cmbLosser.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vencedor";
            // 
            // cmbWinner
            // 
            this.cmbWinner.FormattingEnabled = true;
            this.cmbWinner.Location = new System.Drawing.Point(131, 11);
            this.cmbWinner.Name = "cmbWinner";
            this.cmbWinner.Size = new System.Drawing.Size(290, 21);
            this.cmbWinner.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpTime);
            this.panel2.Controls.Add(this.dtpDate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtPkmW);
            this.panel2.Controls.Add(this.txtPkmL);
            this.panel2.Controls.Add(this.cmbType);
            this.panel2.Location = new System.Drawing.Point(12, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 64);
            this.panel2.TabIndex = 1;
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(294, 39);
            this.dtpTime.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(127, 20);
            this.dtpTime.TabIndex = 7;
            this.dtpTime.Value = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(168, 39);
            this.dtpDate.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(120, 20);
            this.dtpDate.TabIndex = 6;
            this.dtpDate.Value = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "-";
            // 
            // txtPkmW
            // 
            this.txtPkmW.Location = new System.Drawing.Point(249, 13);
            this.txtPkmW.Name = "txtPkmW";
            this.txtPkmW.Size = new System.Drawing.Size(39, 20);
            this.txtPkmW.TabIndex = 5;
            // 
            // txtPkmL
            // 
            this.txtPkmL.Location = new System.Drawing.Point(361, 13);
            this.txtPkmL.Name = "txtPkmL";
            this.txtPkmL.Size = new System.Drawing.Size(39, 20);
            this.txtPkmL.TabIndex = 2;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Normal",
            "Torneo",
            "Desconexión",
            "Hacks",
            "Ilegal",
            "Anulada"});
            this.cmbType.Location = new System.Drawing.Point(17, 12);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(154, 21);
            this.cmbType.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(352, 168);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(265, 168);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(81, 23);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // AddBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 203);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddBattle";
            this.Text = "Agregar Batalla";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLosser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbWinner;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPkmW;
        private System.Windows.Forms.TextBox txtPkmL;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
    }
}