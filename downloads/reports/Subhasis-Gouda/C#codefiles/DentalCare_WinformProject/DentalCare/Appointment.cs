using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DentalCare.EntityFolder;
namespace DentalCare
{
    public partial class Appointment : Form
    {
        DentalCareEntities dct = new DentalCareEntities();
        Patienttable pttble = new Patienttable();
        Appointmenttable aptbl = new Appointmenttable();
        bool updateflag = false;
        int appid;

        public Appointment()
        {
            InitializeComponent();
            var patientNames = dct.Patienttables.Select(p => p.PatName).ToList();
            PatNamecb.DataSource = patientNames;
            updategdv();
        }
        public void updategdv()
        {
            using (DentalCareEntities Dc = new DentalCareEntities())
            {

                List<Appointmenttable> at = Dc.Appointmenttables.ToList();
                Aptgdv.DataSource = at;

            }
        }
        public void clear_tb()
        {
            PatNamecb.SelectedItem = null;
            Treatmenttb.Text="";
            Savebtn.Text = "Save";
            Deletebtn.Enabled= false;
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            clear_tb();
        }
        private void Aptgdv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Aptgdv.CurrentRow.Index != -1)
            {
                appid = Convert.ToInt32(Aptgdv.Rows[e.RowIndex].Cells[0].Value);
                PatNamecb.SelectedItem = Aptgdv.Rows[e.RowIndex].Cells[1].Value.ToString();
                Treatmenttb.Text = Aptgdv.Rows[e.RowIndex].Cells[2].Value.ToString();
                Appdatetime.Text= Aptgdv.Rows[e.RowIndex].Cells[3].Value.ToString();
                updateflag = true;
                Savebtn.Text = "Update";
                Deletebtn.Enabled = true;

            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            
            using (DentalCareEntities dc = new DentalCareEntities())
            {
                if(updateflag)
                {
                    Appointmenttable ap = dc.Appointmenttables.Where(a => a.AppId == appid).FirstOrDefault();
                    ap.patient = PatNamecb.SelectedItem.ToString();
                    ap.Treatment = Treatmenttb.Text.ToString();
                    ap.AppDate = Appdatetime.Value;
                    dc.Entry(ap).State = EntityState.Modified;
                    dc.SaveChanges();
                    updateflag = false;
                    MessageBox.Show("patient data is updated successfully");         

                }
                else
                {

                    aptbl.patient = PatNamecb.SelectedItem.ToString();
                    aptbl.Treatment = Treatmenttb.Text.ToString();
                    aptbl.AppDate = Appdatetime.Value;
                    dc.Appointmenttables.Add(aptbl);
                    dc.SaveChanges();
                    updateflag = false;
                    MessageBox.Show("Appointment is added successfully");
                }
            }
            updategdv();
            clear_tb();

        }



        private void Clearbtn_Click(object sender, EventArgs e)
        {
            clear_tb();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowPatient_Click(object sender, EventArgs e)
        {
            Patient p1 = new Patient();
            p1.Show();
            this.Hide();
        }

        private void ShowTreatment_Click(object sender, EventArgs e)
        {
            Treatment t1 = new Treatment(); 
            t1.Show();
            this.Hide();
        }

        private void ShowPrescription_Click(object sender, EventArgs e)
        {
            Prescription p1 = new Prescription();
            p1.Show();
            this.Hide();
        }

        private void ShowLogout_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Hide();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            using(DentalCareEntities dc =  new DentalCareEntities())
            {
                Appointmenttable a = dc.Appointmenttables.Where(x=>x.AppId==appid).FirstOrDefault();
                dc.Appointmenttables.Remove(a);
                dc.SaveChanges();
                updategdv();
                clear_tb();
            }
        }
    }
}
