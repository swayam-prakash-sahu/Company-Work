namespace DentalCare
{
    partial class Appointment
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
            this.Aptgdv = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PatNamecb = new System.Windows.Forms.ComboBox();
            this.ShowLogout = new System.Windows.Forms.Label();
            this.ShowPatient = new System.Windows.Forms.Label();
            this.ShowPrescription = new System.Windows.Forms.Label();
            this.ShowTreatment = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Treatmenttb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Appdatetime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Aptgdv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Aptgdv
            // 
            this.Aptgdv.BackgroundColor = System.Drawing.Color.White;
            this.Aptgdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Aptgdv.Location = new System.Drawing.Point(237, 300);
            this.Aptgdv.Name = "Aptgdv";
            this.Aptgdv.RowHeadersWidth = 62;
            this.Aptgdv.RowTemplate.Height = 28;
            this.Aptgdv.Size = new System.Drawing.Size(866, 245);
            this.Aptgdv.TabIndex = 33;
            this.Aptgdv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Aptgdv_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(939, 268);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 26);
            this.textBox1.TabIndex = 32;
            this.textBox1.Text = "Filter by Patient Name";
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Savebtn.ForeColor = System.Drawing.Color.White;
            this.Savebtn.Location = new System.Drawing.Point(237, 210);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(205, 35);
            this.Savebtn.TabIndex = 31;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(516, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(204, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Appointment Date and time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(233, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Treatment";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(233, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Patient";
            // 
            // PatNamecb
            // 
            this.PatNamecb.FormattingEnabled = true;
            this.PatNamecb.Location = new System.Drawing.Point(321, 77);
            this.PatNamecb.Name = "PatNamecb";
            this.PatNamecb.Size = new System.Drawing.Size(121, 28);
            this.PatNamecb.TabIndex = 23;
            // 
            // ShowLogout
            // 
            this.ShowLogout.AutoSize = true;
            this.ShowLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLogout.ForeColor = System.Drawing.Color.White;
            this.ShowLogout.Location = new System.Drawing.Point(44, 365);
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
            this.ShowPatient.Location = new System.Drawing.Point(44, 166);
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
            this.ShowPrescription.Location = new System.Drawing.Point(44, 297);
            this.ShowPrescription.Name = "ShowPrescription";
            this.ShowPrescription.Size = new System.Drawing.Size(114, 25);
            this.ShowPrescription.TabIndex = 6;
            this.ShowPrescription.Text = "Prescription";
            this.ShowPrescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowPrescription.Click += new System.EventHandler(this.ShowPrescription_Click);
            // 
            // ShowTreatment
            // 
            this.ShowTreatment.AutoSize = true;
            this.ShowTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowTreatment.ForeColor = System.Drawing.Color.White;
            this.ShowTreatment.Location = new System.Drawing.Point(44, 232);
            this.ShowTreatment.Name = "ShowTreatment";
            this.ShowTreatment.Size = new System.Drawing.Size(101, 25);
            this.ShowTreatment.TabIndex = 5;
            this.ShowTreatment.Text = "Treatment";
            this.ShowTreatment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowTreatment.Click += new System.EventHandler(this.ShowTreatment_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(564, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Appointment";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.ShowLogout);
            this.panel1.Controls.Add(this.ShowPatient);
            this.panel1.Controls.Add(this.ShowPrescription);
            this.panel1.Controls.Add(this.ShowTreatment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 630);
            this.panel1.TabIndex = 21;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DentalCare.Properties.Resources.Dental;
            this.pictureBox2.Location = new System.Drawing.Point(49, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 95;
            this.pictureBox2.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label15.Location = new System.Drawing.Point(206, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 25);
            this.label15.TabIndex = 95;
            this.label15.Text = "Dental Care";
            // 
            // Clearbtn
            // 
            this.Clearbtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Clearbtn.ForeColor = System.Drawing.Color.White;
            this.Clearbtn.Location = new System.Drawing.Point(459, 210);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(205, 35);
            this.Clearbtn.TabIndex = 96;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = false;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Treatmenttb
            // 
            this.Treatmenttb.Location = new System.Drawing.Point(321, 128);
            this.Treatmenttb.Multiline = true;
            this.Treatmenttb.Name = "Treatmenttb";
            this.Treatmenttb.Size = new System.Drawing.Size(179, 32);
            this.Treatmenttb.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MidnightBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1088, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 26);
            this.label4.TabIndex = 98;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Deletebtn.ForeColor = System.Drawing.Color.White;
            this.Deletebtn.Location = new System.Drawing.Point(681, 210);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(205, 35);
            this.Deletebtn.TabIndex = 99;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Appdatetime
            // 
            this.Appdatetime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Appdatetime.Location = new System.Drawing.Point(737, 75);
            this.Appdatetime.Name = "Appdatetime";
            this.Appdatetime.Size = new System.Drawing.Size(200, 26);
            this.Appdatetime.TabIndex = 100;
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 630);
            this.Controls.Add(this.Appdatetime);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Treatmenttb);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Aptgdv);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PatNamecb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Appointment";
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.Appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Aptgdv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Aptgdv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox PatNamecb;
        private System.Windows.Forms.Label ShowLogout;
        private System.Windows.Forms.Label ShowPatient;
        private System.Windows.Forms.Label ShowPrescription;
        private System.Windows.Forms.Label ShowTreatment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.TextBox Treatmenttb;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.DateTimePicker Appdatetime;
    }
}