using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class StudentForm : Form
    {
        public StudentForm(Student student)
        {
            InitializeComponent();
            textBoxName.Text = string.Join(" ", student.LastName, student.FirstName);
            textBoxAge.Text = student.Age;
            textBoxGroup.Text = student.Group;
            pictureBox1.Image = new Bitmap(Environment.CurrentDirectory + $@"\pictures\{student.IdPic}.jpg");
        }
        public StudentForm()
        {
            InitializeComponent();
        }
    }
}
