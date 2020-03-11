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
    

    public partial class ReportForm : Form
    {

        public static double getAverageMark(int[] marksArray)
        {
            return marksArray.Average();
        }
        
        // Find the highest mark in marksArray .Max()
        public static int getTopMark(int[] marksArray)
        {
            
            return marksArray.Max();
        }

        public static int getLowestMark(int[] marksArray)
        {
            // Find the lowest mark in marksArray .Min()

            return marksArray.Min();
        }
        
     
        // I HAD NO LUCK GETTING THE DATABASE CONNECTION TO WORK ACCORDING TO HOW IT WAS TAUGHT IN THE COURSE
        // THUS, I DISCOVERED THE FOLLOWING WORKAROUND
        // Establish database connection object
        public OleDbConnection connection = new OleDbConnection();
        public ReportForm()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Students.accdb;
            Persist Security Info=False;";
            
        }

        private void mainWindowButton_Click(object sender, EventArgs e)
        {
            new StudentPerformance().Show();
            this.Hide();
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
           
            string sql = @"SELECT * from Students WHERE ID1 LIKE '" + idInput.Text.Trim() + "'";
            connection.Open();
            OleDbCommand cmd = new OleDbCommand(sql, connection);
            OleDbDataReader reader = cmd.ExecuteReader();
            int[] marksArray = new int[10];
            while (reader.Read())
            {
                marksAllCourses.Clear();

                firstnameTextBox.Text = reader["Firstname"].ToString();
                lastnameTextBox.Text = reader["Lastname"].ToString();
                
                // This For loop reads all course marks
                for(int i=0; i<10; ++i)
                {
                    //Store marks in array
                    marksArray[i] = reader.GetInt32(i + 3);

                    //Write in Textbox
                    marksAllCourses.Text+=Environment.NewLine+"Course "+(i+1).ToString()+": "+reader.GetInt32(i + 3).ToString();
                }


                //Filling the average, lowest and highest marks textboxes
                avgTextBox.Text = getAverageMark(marksArray).ToString();
                MinMarksTextBox.Text =  getLowestMark(marksArray).ToString();
                MaxMarksTextBox.Text = getTopMark(marksArray).ToString();

                double average = Convert.ToDouble(avgTextBox.Text);
                if (average > 80)
                {
                    gradeLevel.Text = "Excellent";
                } else if(average <= 80 && average > 60)
                {
                    gradeLevel.Text = "Good";
                } else if(average <= 60 && average > 40)
                {
                    gradeLevel.Text = "Simple Pass";
                } else
                {
                    gradeLevel.Text = "Fail";
                }

                idInput.Clear();
            }
            
            connection.Close();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            
            
        }

    }
}
