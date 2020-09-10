using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLibrary;

namespace SchoolFromsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            var school = new School
            {
                Name = nameTextBox.Text,
                Address = addressTextBox.Text,
                City = cityTextBox.Text,
                State = stateTextBox.Text,
                Zip = zipTextBox.Text,
                PhoneNumber = phoneTextBox.Text
            };

            try
            {
                school.TwitterAddress = twitterTextBox.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show(school.ToString());
        }

        private void TeacherGaButton_Click(object sender, EventArgs e)
        {
            var teacher = new Teacher();
            MessageBox.Show("The grade average = ", teacher.ComputeGradeAverage().ToString());
        }
    }
}
