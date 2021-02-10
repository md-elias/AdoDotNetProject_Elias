using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoDotNetProject_Elias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            Course crs = new Course();
            this.Hide();
            crs.ShowDialog();
        }

        private void btnTrainee_Click(object sender, EventArgs e)
        {
            Trainee trn = new Trainee();
            this.Hide();
            trn.ShowDialog();
        }
    }
}
