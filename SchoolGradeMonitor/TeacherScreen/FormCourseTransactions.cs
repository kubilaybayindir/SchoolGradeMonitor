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

namespace SchoolGradeMonitor.TeacherScreen
{
    public partial class FormCourseTransactions : Form
    {
        public FormCourseTransactions()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SchoolSystemDb;Integrated Security=True;");
    }
}
