using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsName
{
    public partial class Form1 : Form
    {
        StudentName names = new StudentName();

        public Form1()
        {
            InitializeComponent();
        }

        private void addStudentNameBtn_Click(object sender, EventArgs e)
        {
            string studentName = studentNameText.Text;
            names.addStudentName(studentName);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string name = searchNameTextBox.Text;
            names.howManyStudents(name);
        }
    }
}
