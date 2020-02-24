using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsName
{
    class StudentName
    {
        List<string> studentNames = new List<string>();
        

        public void addStudentName(string Name)
        {
            studentNames.Add(Name);
            MessageBox.Show("Student name added successfully");
        }

        public void howManyStudents(string Name)
        {
            int count = 0;
            for(int i=0; i < studentNames.Count(); i++)
            {
                if (studentNames[i] == Name)
                {
                    count++;
                }
            }

            MessageBox.Show(count + " students share '" + Name + "' name");
        }
    }
}
