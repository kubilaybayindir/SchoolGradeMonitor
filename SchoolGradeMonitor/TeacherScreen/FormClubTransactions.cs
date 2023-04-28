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
    public partial class FormClubTransactions : Form
    {
        public FormClubTransactions()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SchoolSystemDb;Integrated Security=True;");

        public void ListClubs()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Club", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            DgvClubs.DataSource = dataTable;
        }
        private void FormClubTransactions_Load(object sender, EventArgs e)
        {
            ListClubs();
        }

        private void BtList_Click(object sender, EventArgs e)
        {
            ListClubs();
        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("UPDATE Club SET Name=@p1 WHERE Id=@p2", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", TbxClubName.Text);
            sqlCommand.Parameters.AddWithValue("@p2", TbxClubId.Text);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Club Was Updated", "Club Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListClubs();
        }

        private void BtInsert_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Club(Name) VALUES(@p1)",sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1",TbxClubName.Text);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Club Was Inserted","Club Insert",MessageBoxButtons.OK,MessageBoxIcon.Information);
            ListClubs();
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM Club WHERE Id=@p1", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", TbxClubId.Text);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Club Was Deleted", "Club Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListClubs();
        }

        private void DgvClubs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TbxClubId.Text = DgvClubs.Rows[e.RowIndex].Cells[0].Value.ToString();
            TbxClubName.Text = DgvClubs.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
