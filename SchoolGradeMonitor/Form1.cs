using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolGradeMonitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtGenerator_Click(object sender, EventArgs e)
        {
            Generator generator = new Generator();
            generator.GenerateTenTeacher();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PbStudent_Click(object sender, EventArgs e)
        {
            FormStudentGrades formStudentGrades = new FormStudentGrades();
            formStudentGrades.StudentId = TbxId.Text;
            formStudentGrades.Show();
        }

        private void PbTeacher_Click(object sender, EventArgs e)
        {
            FormTeacher formTeacher = new FormTeacher();
            formTeacher.Show();
        }
    }
}
