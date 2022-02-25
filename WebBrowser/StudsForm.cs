﻿using System;
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
    public partial class StudsForm : Form
    {
        private List<Student> studentsList;
        public StudsForm()
        {
            InitializeComponent();
            string students = File.ReadAllText(Environment.CurrentDirectory + @"\Base.txt");
            studentsList = new List<Student>();
            foreach (var stud in students.Split('\n'))
            {
                studentsList.Add(new Student(stud.Split(' ')[0], 
                    stud.Split(' ')[1], 
                    stud.Split(' ')[2], 
                    stud.Split(' ')[3], 
                    string.Join(" ", stud.Split(' ').Skip(4)).Trim()));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            panel1.BackColor = Color.FromArgb(rnd.Next());
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            treeView1.SelectedNode.Nodes.Clear();
            string text = treeView1.SelectedNode.Text;
            DataTable table = new DataTable();
            foreach (var stud in studentsList.Where(x => x.Group.Equals(text)))
            {
                dataGridView1.Rows.Add(stud.ToArr());
                treeView1.SelectedNode.Nodes.Add(stud.LastName);
            }

        }
    }
}
