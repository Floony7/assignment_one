using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FredLunjevich_Assignment3
{
    public partial class StudentPerformance : Form
    {
        public StudentPerformance()
        {
            InitializeComponent();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            new ShowAllForm().Show();
            this.Hide();
        }

        private void gradStudentButton_Click(object sender, EventArgs e)
        {
            new ReportForm().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
