using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DentalCare.EntityFolder;
namespace DentalCare
{
    public partial class Patient : Form
    {
        DentalCareEntities Dct = new DentalCareEntities();
        Patienttable pttbl = new Patienttable();
        bool updateflag  =  false;
        int patid;
        public Patient()
        {
            InitializeComponent();
            updategdv();
        }
        public void updategdv()
        {
            using(DentalCareEntities Dc = new DentalCareEntities())
            {

                List<Patienttable> pt = Dc.Patienttables.ToList();
                Patientdgv.DataSource = pt;
            }
        }
        public void clear_tb()
        {
            PatNameTb.Text = PatPhoneTb.Text = AddressTb.Text = AllergiesTb.Text ="";
            GenderCb.SelectedItem = null;
            Savebtn.Text = "Save";
            deletebtn.Enabled = false;
            updateflag = false;
            
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            clear_tb();
        }

        private void Patientdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Patientdgv.CurrentRow.Index!=-1)
            {
                patid = Convert.ToInt32(Patientdgv.Rows[e.RowIndex].Cells[0].Value);
                PatNameTb.Text = Patientdgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                PatPhoneTb.Text = Patientdgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                AddressTb.Text = Patientdgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                Patdobdata.Text = Patientdgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                GenderCb.SelectedItem = Patientdgv.Rows[e.RowIndex].Cells[5].Value.ToString();
                AllergiesTb.Text = Patientdgv.Rows[e.RowIndex].Cells[6].Value.ToString();
                updateflag = true;
                Savebtn.Text = "Update";
                deletebtn.Enabled = true;
            }

        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            clear_tb();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            
            using (DentalCareEntities dc = new DentalCareEntities())
            {

                if (updateflag)
                {
                    Patienttable pttble = dc.Patienttables.Where(x => x.PatId == patid).FirstOrDefault();
                    pttble.PatName = PatNameTb.Text;
                    pttble.PatGender = GenderCb.SelectedItem.ToString();
                    pttble.PatAllergies = AllergiesTb.Text;
                    pttble.PatDOB = Patdobdata.Value;
                    pttble.PatAddress = AddressTb.Text;
                    pttble.PatPhone = PatPhoneTb.Text;
                    dc.Entry(pttble).State = EntityState.Modified;
                    dc.SaveChanges();
                    updateflag = false;
                    MessageBox.Show("patient data is updated successfully");
                }
                else
                {
                    pttbl.PatName = PatNameTb.Text;
                    pttbl.PatGender = GenderCb.SelectedItem.ToString();
                    pttbl.PatAllergies = AllergiesTb.Text;
                    pttbl.PatDOB = Patdobdata.Value;
                    pttbl.PatAddress = AddressTb.Text;
                    pttbl.PatPhone = PatPhoneTb.Text;
                    dc.Patienttables.Add(pttbl);
                    dc.SaveChanges();
                    MessageBox.Show("patient data is added successfully");

                }
            }
            clear_tb();
            updategdv();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            using(DentalCareEntities dc =  new DentalCareEntities())
            {
                Patienttable pttble = dc.Patienttables.Where(x => x.PatId == patid).FirstOrDefault();
                dc.Patienttables.Remove(pttble);
                dc.SaveChanges();
                updategdv();
                clear_tb();
            }

        }

        private void ShowApp_Click(object sender, EventArgs e)
        {
            Appointment a1 = new Appointment();
            a1.Show();
            this.Hide();
        }

        private void ShowTreat_Click(object sender, EventArgs e)
        {
            Treatment t1 = new Treatment();
            t1.Show();
            this.Hide();
        }

        private void ShowPresc_Click(object sender, EventArgs e)
        {
            Prescription p1= new Prescription();
            p1.Show();
            this.Hide();
        }

        private void Showlogout_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Hide();
        }
    }
}
