using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormThree : Form
    {
        public FormThree()
        {
            InitializeComponent();
        }

        private void FormThree_Load(object sender, EventArgs e)
        {
            timerShow.Interval = 1000;
            timerShow.Tick += TimerShow_Tick;
            timerShow.Start();
        }

        private void TimerShow_Tick(object sender, EventArgs e)
        {
            currentTime.Text = DateTime.Now.TimeOfDay.ToString();
            timerShow.Stop();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {

            if (rbMale.Checked)
                MessageBox.Show("Male Selected");
            if (rbFemale.Checked)
                MessageBox.Show("Female Selected");

            string selectedNode = treeView.SelectedNode.Text;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            txtFile.Text = openFileDialog.FileName;
        }

        private void btnGet_MouseHover(object sender, EventArgs e)
        {
            btnGet.BackColor = SystemColors.GrayText;
        }

        private void btnGet_MouseLeave(object sender, EventArgs e)
        {
            btnGet.BackColor = SystemColors.Control;
        }
    }
}
