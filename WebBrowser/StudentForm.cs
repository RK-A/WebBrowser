using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class StudentForm : Form
    {
        private int indexStud;
        private List<Student> students;
        private string id;
        public StudentForm(Student student, int indexStud, ref List<Student> students)
        {
            this.students = students;
            this.indexStud = indexStud;
            InitializeComponent();
            textBoxName.Text = string.Join(" ", student.LastName, student.FirstName);
            textBoxAge.Text = student.Age;
            textBoxGroup.Text = student.Group;
            textBoxAbout.Text = student.Descripton;
            this.id = student.IdPic;
            pictureBox1.Image = new Bitmap(Environment.CurrentDirectory + $@"\pictures\{student.IdPic}.jpg");
        }
        public StudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string LsName = textBoxName.Text.Split()[0];
            string FsName = textBoxName.Text.Split()[1];
            Student stud = new Student(FsName,
                LsName, 
                textBoxAge.Text, 
                textBoxGroup.Text, 
                id, 
                textBoxAbout.Text);
            students[indexStud] = stud;
            this.Close();
        }
    }
}
