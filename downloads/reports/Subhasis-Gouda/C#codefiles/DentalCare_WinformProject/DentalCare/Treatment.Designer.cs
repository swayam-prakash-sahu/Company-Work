namespace DentalCare
{
    partial class Treatment
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
            this.label13 = new System.Windows.Forms.Label();
            this.ShowAppointment = new System.Windows.Forms.Label();
            this.TreatCosttb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ShowLogout = new System.Windows.Forms.Label();
            this.ShowPatient = new System.Windows.Forms.Label();
            this.ShowPrescription = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.TreatDescriptiontb = new System.Windows.Forms.TextBox();
            this.treatdgv = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Treatmentnamecb = new System.Windows.Forms.ComboBox();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label13.Location = new System.Drawing.Point(652, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 20);
            this.label13.TabIndex = 63;
            this.label13.Text = "Cost";
            // 
            // ShowAppointment
            // 
            this.ShowAppointment.AutoSize = true;
            this.ShowAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAppointment.ForeColor = System.Drawing.Color.White;
            this.ShowAppointment.Location = new System.Drawing.Point(44, 240);
            this.ShowAppointment.Name = "ShowAppointment";
            this.ShowAppointment.Size = new System.Drawing.Size(122, 25);
            this.ShowAppointment.TabIndex = 10;
            this.ShowAppointment.Text = "Appointment";
            this.ShowAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowAppointment.Click += new System.EventHandler(this.ShowAppointment_Click);
            // 
            // TreatCosttb
            // 
            this.TreatCosttb.Location = new System.Drawing.Point(758, 75);
            this.TreatCosttb.Name = "TreatCosttb";
            this.TreatCosttb.Size = new System.Drawing.Size(179, 26);
            this.TreatCosttb.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(589, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "Treatment";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.ShowAppointment);
            this.panel1.Controls.Add(this.ShowLogout);
            this.panel1.Controls.Add(this.ShowPatient);
            this.panel1.Controls.Add(this.ShowPrescription);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 604);
            this.panel1.TabIndex = 54;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DentalCare.Properties.Resources.Dental;
            this.pictureBox2.Location = new System.Drawing.Point(49, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // ShowLogout
            // 
            this.ShowLogout.AutoSize = true;
            this.ShowLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLogout.ForeColor = System.Drawing.Color.White;
            this.ShowLogout.Location = new System.Drawing.Point(44, 360);
            this.ShowLogout.Name = "ShowLogout";
            this.ShowLogout.Size = new System.Drawing.Size(72, 25);
            this.ShowLogout.TabIndex = 9;
            this.ShowLogout.Text = "Logout";
            this.ShowLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowLogout.Click += new System.EventHandler(this.ShowLogout_Click);
            // 
            // ShowPatient
            // 
            this.ShowPatient.AutoSize = true;
            this.ShowPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPatient.ForeColor = System.Drawing.Color.White;
            this.ShowPatient.Location = new System.Drawing.Point(44, 182);
            this.ShowPatient.Name = "ShowPatient";
            this.ShowPatient.Size = new System.Drawing.Size(72, 25);
            this.ShowPatient.TabIndex = 7;
            this.ShowPatient.Text = "Patient";
            this.ShowPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowPatient.Click += new System.EventHandler(this.ShowPatient_Click);
            // 
            // ShowPrescription
            // 
            this.ShowPrescription.AutoSize = true;
            this.ShowPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPrescription.ForeColor = System.Drawing.Color.White;
            this.ShowPrescription.Location = new System.Drawing.Point(44, 304);
            this.ShowPrescription.Name = "ShowPrescription";
            this.ShowPrescription.Size = new System.Drawing.Size(114, 25);
            this.ShowPrescription.TabIndex = 6;
            this.ShowPrescription.Text = "Prescription";
            this.ShowPrescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowPrescription.Click += new System.EventHandler(this.ShowPrescription_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(248, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 57;
            this.label10.Text = "Description";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(629, 258);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(112, 26);
            this.textBox5.TabIndex = 61;
            this.textBox5.Text = "Filter by Name";
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Savebtn.ForeColor = System.Drawing.Color.White;
            this.Savebtn.Location = new System.Drawing.Point(656, 147);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(122, 35);
            this.Savebtn.TabIndex = 60;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click_1);
            // 
            // TreatDescriptiontb
            // 
            this.TreatDescriptiontb.Location = new System.Drawing.Point(389, 144);
            this.TreatDescriptiontb.Multiline = true;
            this.TreatDescriptiontb.Name = "TreatDescriptiontb";
            this.TreatDescriptiontb.Size = new System.Drawing.Size(179, 98);
            this.TreatDescriptiontb.TabIndex = 59;
            // 
            // treatdgv
            // 
            this.treatdgv.BackgroundColor = System.Drawing.Color.White;
            this.treatdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.treatdgv.Location = new System.Drawing.Point(249, 290);
            this.treatdgv.Name = "treatdgv";
            this.treatdgv.RowHeadersWidth = 62;
            this.treatdgv.RowTemplate.Height = 28;
            this.treatdgv.Size = new System.Drawing.Size(870, 290);
            this.treatdgv.TabIndex = 62;
            this.treatdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.treatdgv_CellContentClick_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(248, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 56;
            this.label9.Text = "Treatment Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(206, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 65;
            this.label2.Text = "Dental Care";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 26);
            this.label1.TabIndex = 66;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Treatmentnamecb
            // 
            this.Treatmentnamecb.FormattingEnabled = true;
            this.Treatmentnamecb.Location = new System.Drawing.Point(391, 82);
            this.Treatmentnamecb.Name = "Treatmentnamecb";
            this.Treatmentnamecb.Size = new System.Drawing.Size(177, 28);
            this.Treatmentnamecb.TabIndex = 67;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Cancelbtn.ForeColor = System.Drawing.Color.White;
            this.Cancelbtn.Location = new System.Drawing.Point(784, 147);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(122, 35);
            this.Cancelbtn.TabIndex = 68;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = false;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click_1);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Deletebtn.ForeColor = System.Drawing.Color.White;
            this.Deletebtn.Location = new System.Drawing.Point(912, 147);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(122, 35);
            this.Deletebtn.TabIndex = 69;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Treatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 604);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Treatmentnamecb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TreatCosttb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.TreatDescriptiontb);
            this.Controls.Add(this.treatdgv);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Treatment";
            this.Text = "Treatment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label ShowAppointment;
        private System.Windows.Forms.TextBox TreatCosttb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ShowLogout;
        private System.Windows.Forms.Label ShowPatient;
        private System.Windows.Forms.Label ShowPrescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.TextBox TreatDescriptiontb;
        private System.Windows.Forms.DataGridView treatdgv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Treatmentnamecb;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Button Deletebtn;
    }
}