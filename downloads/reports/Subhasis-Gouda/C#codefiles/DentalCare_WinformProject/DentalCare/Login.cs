using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DentalCare.EntityFolder;
namespace DentalCare
{
    public partial class Login : Form
    {
        DentalCareEntities dct = new DentalCareEntities();
        public Login()
        {
            InitializeComponent();
            var user = dct.Usertables.Select(x => x.UName).ToList();
            Usernamecb.DataSource= user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = Usernamecb.SelectedItem?.ToString();
            string password = Userpasswordtb.Text;

            var user = dct.Usertables.FirstOrDefault(x => x.UName == username && x.UPass == password);

            if (user != null)
            {
                Patient p1 = new Patient();
                p1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Createbtn_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Show();
            this.Hide();
        }
    }
}
