using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DentalCare.EntityFolder;
namespace DentalCare
{
    public partial class User : Form
    {
        DentalCareEntities dct =  new DentalCareEntities();
        Usertable ustbl= new Usertable();
        bool updateflag = false;
        int Userid;
        public User()
        {
            InitializeComponent();
            updategdv();
        }
        public void updategdv()
        {
            using (DentalCareEntities dt = new DentalCareEntities())
            {
                List<Usertable> pt = dt.Usertables.ToList();
                Userdgv.DataSource = dt.Usertables.Select(e => new { e.UId, e.UName, e.Phone }).ToList();
            }
        }
        public void clear_tb()
        {
            Unametb.Text = "";
            uphonetb.Text = "";
            Upasstb.Text = "";

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (Userdgv.CurrentRow.Index != -1)
            {
                Userid = Convert.ToInt32(Userdgv.Rows[e.RowIndex].Cells[0].Value);
                Unametb.Text = Userdgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                uphonetb.Text = Userdgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                updateflag = true;
                Savebtn.Text = "Update";
                deletebtn.Enabled = true;
            }
        }
        private void Savebtn_Click(object sender, EventArgs e)
        {
            
            using(DentalCareEntities dc = new DentalCareEntities())
            {
                if(updateflag)
                {
                    Usertable ustble = dc.Usertables.Where(x=>x.UId==Userid).FirstOrDefault();
                    ustble.UPass = Upasstb.Text.ToString();
                    ustble.UName = Unametb.Text.ToString();
                    ustble.Phone = uphonetb.Text.ToString();
                    dc.Entry(ustble).State = EntityState.Modified;
                    dc.SaveChanges();
                    updateflag = false;
                    MessageBox.Show("User data is updated successfully");
                }
                else {
                    ustbl.UPass = Upasstb.Text.ToString();
                    ustbl.UName = Unametb.Text.ToString();
                    ustbl.Phone = uphonetb.Text.ToString();
                    dc.Usertables.Add(ustbl);
                    dc.SaveChanges();
                    MessageBox.Show("user is added successfully");
                }
            }
            clear_tb();
            updategdv();
        }

        private void Loginlbl_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Hide();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            clear_tb();
        }
        private void deletebtn_Click(object sender, EventArgs e)
        {
            using (DentalCareEntities dc = new DentalCareEntities())
            {
                Usertable utb = dc.Usertables.Where(x => x.UId == Userid).FirstOrDefault();
                dc.Usertables.Remove(utb);
                dc.SaveChanges();
                updategdv();
                clear_tb();
            }
        }
    }
}
