using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MFramework.Services.FakeData;
using System.Data.SqlClient;

namespace SchoolGradeMonitor
{
    public class Generator
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SchoolSystemDb;Integrated Security=True;");


        public void GenerateTenStudent()
        {
            sqlConnection.Open();
            for (int i = 0; i < 10; i++)
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Student(Name,Surname,ClubId,Sex) VALUES(@p1,@p2,@p3,@p4) ", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@p1", NameData.GetFirstName());
                sqlCommand.Parameters.AddWithValue("@p2", NameData.GetSurname());
                sqlCommand.Parameters.AddWithValue("@p3", NumberData.GetNumber(1, 7).ToString());
                sqlCommand.Parameters.AddWithValue("@p4", NumberData.GetNumber(2) % 2 == 1 ? "Man" : "Woman");
                sqlCommand.ExecuteNonQuery();
            }
            sqlConnection.Close();
        }
        public void GenerateTenTeacher()
        {
            sqlConnection.Open();
            for (int i = 0; i < 10; i++)
            {
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Teacher(Name,Surname,Department) VALUES(@p1,@p2,@p3) ", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@p1", NameData.GetFirstName());
                sqlCommand.Parameters.AddWithValue("@p2", NameData.GetSurname());
                sqlCommand.Parameters.AddWithValue("@p3", NumberData.GetNumber(1, 7).ToString());
                sqlCommand.ExecuteNonQuery();
            }
            sqlConnection.Close();
        }
    }
}
