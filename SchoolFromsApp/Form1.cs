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

        private void submitButton_Click(object sender, EventArgs e)
        {
            var testSchool = new School();
            testSchool.Name = nameTextBox.Text;
            testSchool.Address = addressTextBox.Text;
            testSchool.City = cityTextBox.Text;
            testSchool.State = stateTextBox.Text;
            testSchool.Zip = zipTextBox.Text;
            testSchool.PhoneNumber = phoneTextBox.Text;
            testSchool.TwitterAddress = twitterTextBox.Text;
        }
    }
}
