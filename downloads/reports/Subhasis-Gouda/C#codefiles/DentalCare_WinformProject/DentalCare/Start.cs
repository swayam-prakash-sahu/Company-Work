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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            progressBar1.Value += 20;
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                Login l = new Login();
                l.Show();
                this.Hide();
                timer1.Stop();
            }

        }
    }
}
