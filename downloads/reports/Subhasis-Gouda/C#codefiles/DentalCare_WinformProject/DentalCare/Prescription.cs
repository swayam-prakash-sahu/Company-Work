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
    public partial class Prescription : Form
    {
        DentalCareEntities dct = new DentalCareEntities();
        Prescriptiontable prctbl = new Prescriptiontable();
        Appointmenttable Aptbl = new Appointmenttable();
        int Prescriptionid;
        bool updateflag=false;
        public Prescription()
        {
            InitializeComponent();
            updategdv();
            var patientNames = dct.Patienttables.Select(p => p.PatName).ToList();
            PatNamecb.DataSource = patientNames;
            var treatments = dct.Appointmenttables.Select(x=>x.Treatment).ToList();
            Treatmentcb.DataSource = treatments;
        }
        public void updategdv()
        {
            using (DentalCareEntities Dc = new DentalCareEntities())
            { 
                List<Prescriptiontable> pt = Dc.Prescriptiontables.ToList();
                prescdgv.DataSource = pt;
            }
        }
        public void clear_tb()
        {
            PatNamecb.SelectedItem = null;
            Treatmentcb.SelectedItem = null;
            Quantitytb.Text ="";
            Medicinetb.Text = "";
            Costtb.Text = "";
            Deletebtn.Enabled = false;
            updateflag= false;
            Savebtn.Text = "Save";
        }

        private void Prescription_Load(object sender, EventArgs e)
        {
            clear_tb();
        }
        private void prescdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (prescdgv.CurrentRow.Index != -1)
            {
                Prescriptionid = Convert.ToInt32(prescdgv.Rows[e.RowIndex].Cells[0].Value);
                PatNamecb.SelectedItem = prescdgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                Treatmentcb.SelectedItem= prescdgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                Costtb.Text= prescdgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                Medicinetb.Text = prescdgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                Quantitytb.Text= prescdgv.Rows[e.RowIndex].Cells[5].Value.ToString();
                Deletebtn.Enabled = true;
                updateflag = true;
                Savebtn.Text = "Update";
            }

        }
        private void Savebtn_Click(object sender, EventArgs e)
        {
            using (DentalCareEntities dc = new DentalCareEntities())
            {
               if(updateflag)
                {
                    Prescriptiontable prctble = dc.Prescriptiontables.Where(x => x.PrescId == Prescriptionid).FirstOrDefault();
                    prctble.PatName = PatNamecb.SelectedItem.ToString();
                    prctble.TreatmentName = Treatmentcb.SelectedItem.ToString();
                    prctble.MedQty = int.Parse(Quantitytb.Text);
                    prctble.Medicines = Medicinetb.Text.ToString();
                    prctble.TreatmentCost = Costtb.Text.ToString();
                    dc.Entry(prctble).State = EntityState.Modified;
                    dc.SaveChanges();
                    MessageBox.Show("prescription data is updated successfully");
                    updateflag= false;
                }
                else
                {
                    prctbl.PatName = PatNamecb.SelectedItem.ToString();
                    prctbl.TreatmentName = Treatmentcb.SelectedItem.ToString();
                    prctbl.MedQty = int.Parse(Quantitytb.Text);
                    prctbl.Medicines = Medicinetb.Text.ToString();
                    prctbl.TreatmentCost = Costtb.Text.ToString();
                    dc.Prescriptiontables.Add(prctbl);
                    dc.SaveChanges();
                    MessageBox.Show("prescription data is added successfully");
                }
                
            }
            clear_tb();
            updategdv();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Treatment t1 = new Treatment();
            t1.Show();
            this.Hide();
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

        private void Showlogout_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Hide();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            using(DentalCareEntities dc= new DentalCareEntities())
            {
                Prescriptiontable data = dc.Prescriptiontables.Where(x=>x.PrescId == Prescriptionid).FirstOrDefault();
                dc.Prescriptiontables.Remove(data);
                dc.SaveChanges();
                updategdv();
                clear_tb();

            }

        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            clear_tb();
        }
    }
}
