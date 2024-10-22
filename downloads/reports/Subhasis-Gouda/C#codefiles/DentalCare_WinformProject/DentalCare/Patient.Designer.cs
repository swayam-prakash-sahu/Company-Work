namespace DentalCare
{
    partial class Patient
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
            this.Patientdgv = new System.Windows.Forms.DataGridView();
            this.Savebtn = new System.Windows.Forms.Button();
            this.AllergiesTb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.PatPhoneTb = new System.Windows.Forms.TextBox();
            this.PatNameTb = new System.Windows.Forms.TextBox();
            this.Patdobdata = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GenderCb = new System.Windows.Forms.ComboBox();
            this.Showlogout = new System.Windows.Forms.Label();
            this.ShowApp = new System.Windows.Forms.Label();
            this.ShowPresc = new System.Windows.Forms.Label();
            this.ShowTreat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.deletebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Patientdgv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Patientdgv
            // 
            this.Patientdgv.BackgroundColor = System.Drawing.Color.White;
            this.Patientdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Patientdgv.GridColor = System.Drawing.Color.MidnightBlue;
            this.Patientdgv.Location = new System.Drawing.Point(216, 347);
            this.Patientdgv.Name = "Patientdgv";
            this.Patientdgv.RowHeadersWidth = 62;
            this.Patientdgv.RowTemplate.Height = 28;
            this.Patientdgv.Size = new System.Drawing.Size(893, 245);
            this.Patientdgv.TabIndex = 52;
            this.Patientdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Patientdgv_CellContentClick);
            // 
            // Savebtn
            // 
            this.Savebtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Savebtn.ForeColor = System.Drawing.Color.White;
            this.Savebtn.Location = new System.Drawing.Point(215, 276);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(119, 35);
            this.Savebtn.TabIndex = 50;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = false;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // AllergiesTb
            // 
            this.AllergiesTb.Location = new System.Drawing.Point(703, 190);
            this.AllergiesTb.Multiline = true;
            this.AllergiesTb.Name = "AllergiesTb";
            this.AllergiesTb.Size = new System.Drawing.Size(200, 83);
            this.AllergiesTb.TabIndex = 49;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label14.Location = new System.Drawing.Point(606, 193);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 20);
            this.label14.TabIndex = 48;
            this.label14.Text = "Allergies";
            // 
            // AddressTb
            // 
            this.AddressTb.Location = new System.Drawing.Point(281, 187);
            this.AddressTb.Multiline = true;
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(179, 61);
            this.AddressTb.TabIndex = 47;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Address.Location = new System.Drawing.Point(212, 193);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(68, 20);
            this.Address.TabIndex = 46;
            this.Address.Text = "Address";
            // 
            // PatPhoneTb
            // 
            this.PatPhoneTb.Location = new System.Drawing.Point(281, 123);
            this.PatPhoneTb.Name = "PatPhoneTb";
            this.PatPhoneTb.Size = new System.Drawing.Size(179, 26);
            this.PatPhoneTb.TabIndex = 45;
            // 
            // PatNameTb
            // 
            this.PatNameTb.Location = new System.Drawing.Point(281, 54);
            this.PatNameTb.Name = "PatNameTb";
            this.PatNameTb.Size = new System.Drawing.Size(179, 26);
            this.PatNameTb.TabIndex = 44;
            // 
            // Patdobdata
            // 
            this.Patdobdata.Location = new System.Drawing.Point(703, 55);
            this.Patdobdata.Name = "Patdobdata";
            this.Patdobdata.Size = new System.Drawing.Size(200, 26);
            this.Patdobdata.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(606, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 20);
            this.label12.TabIndex = 42;
            this.label12.Text = "Gender";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(606, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 41;
            this.label11.Text = "DOB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(214, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(214, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Name";
            // 
            // GenderCb
            // 
            this.GenderCb.FormattingEnabled = true;
            this.GenderCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderCb.Location = new System.Drawing.Point(703, 121);
            this.GenderCb.Name = "GenderCb";
            this.GenderCb.Size = new System.Drawing.Size(200, 28);
            this.GenderCb.TabIndex = 38;
            // 
            // Showlogout
            // 
            this.Showlogout.AutoSize = true;
            this.Showlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Showlogout.ForeColor = System.Drawing.Color.White;
            this.Showlogout.Location = new System.Drawing.Point(44, 380);
            this.Showlogout.Name = "Showlogout";
            this.Showlogout.Size = new System.Drawing.Size(72, 25);
            this.Showlogout.TabIndex = 9;
            this.Showlogout.Text = "Logout";
            this.Showlogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Showlogout.Click += new System.EventHandler(this.Showlogout_Click);
            // 
            // ShowApp
            // 
            this.ShowApp.AutoSize = true;
            this.ShowApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowApp.ForeColor = System.Drawing.Color.White;
            this.ShowApp.Location = new System.Drawing.Point(44, 193);
            this.ShowApp.Name = "ShowApp";
            this.ShowApp.Size = new System.Drawing.Size(122, 25);
            this.ShowApp.TabIndex = 7;
            this.ShowApp.Text = "Appointment";
            this.ShowApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowApp.Click += new System.EventHandler(this.ShowApp_Click);
            // 
            // ShowPresc
            // 
            this.ShowPresc.AutoSize = true;
            this.ShowPresc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPresc.ForeColor = System.Drawing.Color.White;
            this.ShowPresc.Location = new System.Drawing.Point(44, 324);
            this.ShowPresc.Name = "ShowPresc";
            this.ShowPresc.Size = new System.Drawing.Size(114, 25);
            this.ShowPresc.TabIndex = 6;
            this.ShowPresc.Text = "Prescription";
            this.ShowPresc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowPresc.Click += new System.EventHandler(this.ShowPresc_Click);
            // 
            // ShowTreat
            // 
            this.ShowTreat.AutoSize = true;
            this.ShowTreat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowTreat.ForeColor = System.Drawing.Color.White;
            this.ShowTreat.Location = new System.Drawing.Point(44, 259);
            this.ShowTreat.Name = "ShowTreat";
            this.ShowTreat.Size = new System.Drawing.Size(101, 25);
            this.ShowTreat.TabIndex = 5;
            this.ShowTreat.Text = "Treatment";
            this.ShowTreat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowTreat.Click += new System.EventHandler(this.ShowTreat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dental Care";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(563, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 29);
            this.label6.TabIndex = 37;
            this.label6.Text = "Patient";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Showlogout);
            this.panel1.Controls.Add(this.ShowApp);
            this.panel1.Controls.Add(this.ShowPresc);
            this.panel1.Controls.Add(this.ShowTreat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 604);
            this.panel1.TabIndex = 36;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DentalCare.Properties.Resources.Dental;
            this.pictureBox2.Location = new System.Drawing.Point(49, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Cancelbtn.ForeColor = System.Drawing.Color.White;
            this.Cancelbtn.Location = new System.Drawing.Point(352, 276);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(108, 35);
            this.Cancelbtn.TabIndex = 54;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = false;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MidnightBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1101, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 26);
            this.label4.TabIndex = 55;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.Location = new System.Drawing.Point(466, 276);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(119, 35);
            this.deletebtn.TabIndex = 56;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 604);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Patientdgv);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.AllergiesTb);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.PatPhoneTb);
            this.Controls.Add(this.PatNameTb);
            this.Controls.Add(this.Patdobdata);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GenderCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patient";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Patientdgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Patientdgv;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.TextBox AllergiesTb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox AddressTb;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.TextBox PatPhoneTb;
        private System.Windows.Forms.TextBox PatNameTb;
        private System.Windows.Forms.DateTimePicker Patdobdata;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox GenderCb;
        private System.Windows.Forms.Label Showlogout;
        private System.Windows.Forms.Label ShowApp;
        private System.Windows.Forms.Label ShowPresc;
        private System.Windows.Forms.Label ShowTreat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deletebtn;
    }
}