using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolGradeMonitor
{
    public partial class FormStudentGrades : Form
    {
        public FormStudentGrades()
        {
            InitializeComponent();
        }
        public string StudentId { get; set; }
        SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SchoolSystemDb;Integrated Security=True;");
        private void FormStudentGrades_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT Name,Exam1,Exam2,Exam3,Homework,Average,State FROM Grade INNER JOIN Lesson ON Grade.LessonId=Lesson.Id WHERE StudentId=@p1", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", StudentId);
            //this.Text = StudentId;

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            DgvStudentGrades.DataSource = dataTable;

            sqlConnection.Close();

        }
    }
}
