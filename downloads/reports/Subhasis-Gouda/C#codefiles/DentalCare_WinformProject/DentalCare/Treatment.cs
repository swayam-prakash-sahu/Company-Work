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
    public partial class Treatment : Form
    {
        DentalCareEntities Dct = new DentalCareEntities();
        Treatmenttable treattbl = new Treatmenttable();
        Appointmenttable Aptbl = new Appointmenttable();
        bool updateflag = false;
        int treatid;

        public Treatment()
        {
            InitializeComponent();
            updategdv();
            var treatments = Dct.Appointmenttables.Select(x => x.Treatment).ToList();
            Treatmentnamecb.DataSource = treatments;
        }

        public void updategdv()
        {
            using (DentalCareEntities Dc = new DentalCareEntities())
            {
                List<Treatmenttable> treatments = Dc.Treatmenttables.ToList();
                treatdgv.DataSource = treatments;

            }
        }

        public void clear_tb()
        {
            Treatmentnamecb.SelectedItem = null; 
            TreatCosttb.Text = TreatDescriptiontb.Text = "";
            Savebtn.Text = "Save";
            updateflag = false;
        }

        private void Treatment_Load(object sender, EventArgs e)
        {
            clear_tb();
        }

       
        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            clear_tb();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Savebtn_Click_1(object sender, EventArgs e)
        { 
            using (DentalCareEntities dc = new DentalCareEntities())
            {
                if (updateflag)
                {
                    Treatmenttable trt = dc.Treatmenttables.Where(t=>t.TreatmentId==treatid).FirstOrDefault();
                    trt.TreatmentName = Treatmentnamecb.Text;
                    trt.TreatmentDesc = TreatDescriptiontb.Text;
                    trt.TreatmentCost = Convert.ToInt32(TreatCosttb.Text);
                    dc.Entry(trt).State = EntityState.Modified;
                    dc.SaveChanges();
                    MessageBox.Show("Treatment data updated successfully");
                    updateflag = false;
                }
                else
                {
                    treattbl.TreatmentName = Treatmentnamecb.Text;
                    treattbl.TreatmentDesc = TreatDescriptiontb.Text;
                    treattbl.TreatmentCost = Convert.ToInt32(TreatCosttb.Text);
                    dc.Treatmenttables.Add(treattbl);
                    dc.SaveChanges();
                    MessageBox.Show("Treatment data added successfully");
                }
            }
            clear_tb();
            updategdv();
        }

        private void treatdgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (treatdgv.CurrentRow != null)
            {
                treatid = Convert.ToInt32(treatdgv.Rows[e.RowIndex].Cells[0].Value);
                Treatmentnamecb.Text = treatdgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                TreatCosttb.Text = treatdgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                TreatDescriptiontb.Text = treatdgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                updateflag = true;
                Savebtn.Text = "Update";
            }
        }

        private void ShowPatient_Click(object sender, EventArgs e)
        {
            Patient p1 = new Patient();
            p1.Show();
            this.Hide();
        }

        private void ShowAppointment_Click(object sender, EventArgs e)
        {
            Appointment a1 = new Appointment();
            a1.Show();
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

        private void Cancelbtn_Click_1(object sender, EventArgs e)
        {
            clear_tb();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            using (DentalCareEntities DC = new DentalCareEntities())
            {
                Treatmenttable data = DC .Treatmenttables.Where(d=>d.TreatmentId==treatid).FirstOrDefault();
                DC.Treatmenttables.Remove(data);
                DC.SaveChanges();
                updategdv();
                clear_tb();
            }
        }
    }
}
