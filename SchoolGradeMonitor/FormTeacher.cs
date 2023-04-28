using SchoolGradeMonitor.TeacherScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolGradeMonitor
{
    public partial class FormTeacher : Form
    {
        public FormTeacher()
        {
            InitializeComponent();
        }

        private void BtCourseTransactions_Click(object sender, EventArgs e)
        {
            FormCourseTransactions formCourseTransactions = new FormCourseTransactions();
            formCourseTransactions.Show();
        }

        private void BtClubTransactions_Click(object sender, EventArgs e)
        {
            FormClubTransactions formClubTransactions = new FormClubTransactions();
            formClubTransactions.Show();
        }

        private void BtExamGrades_Click(object sender, EventArgs e)
        {
            FormExamGrades formExamGrades = new FormExamGrades();
            formExamGrades.Show();
        }

        private void BtTeacherDetails_Click(object sender, EventArgs e)
        {
            FormTeacherDetails formTeacherDetails = new FormTeacherDetails();
            formTeacherDetails.Show();
        }

        private void BtStudentTransactions_Click(object sender, EventArgs e)
        {
            FormStudentTransactions formStudentTransactions = new FormStudentTransactions();
            formStudentTransactions.Show();
        }
    }
}
