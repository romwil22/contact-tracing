using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace cs_contact_tracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            StreamWriter studentWriteData;
            studentWriteData = File.AppendText(@"C:\Users\Rom\Desktop\5TH YR 1ST SEM FILES\OOP\contact-tracing\student-data.txt");
            studentWriteData.WriteLine("Fullname: " + firstNameBox.Text + " " + middleInitialBox.Text + " " + surnameBox.Text);
            studentWriteData.WriteLine("Student No. " + studentNoBox.Text + "     YR/SEC: " + ynsBox.Text);
            studentWriteData.WriteLine("Birthdate: " + birthdateBox.Text + "     Gender: " + genderBox.Text + "     Age: " + ageBox.Text);
            studentWriteData.WriteLine("Address: " + addressBox.Text);
            studentWriteData.WriteLine("Email: " + emailBox.Text + "     Mobile No. " + contactNoBox.Text);
            studentWriteData.WriteLine("");
            studentWriteData.Close();

            MessageBox.Show("save successfully");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("thank you for using");
            this.Close();
        }
    }
}
