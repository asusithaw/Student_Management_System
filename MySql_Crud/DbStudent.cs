using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySql_Crud
{
    class DbStudent
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=Susitha@1997;database=students";
            MySqlConnection mySqlConnection = new MySqlConnection(sql);
            try
            {
                mySqlConnection.Open();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("My SQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return mySqlConnection;
        }

        public static void AddStudent(Student student)
        {
            string sql = "INSERT INTO student VALUES (NULL, @StudentName, @StudentReg, @StudentClass, @StudentSection, NULL)";
            MySqlConnection mySqlConnection = GetConnection();
            MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
            mySqlCommand.CommandType = CommandType.Text;
            mySqlCommand.Parameters.Add("@StudentName", MySqlDbType.VarChar).Value = student.Name;
            mySqlCommand.Parameters.Add("@StudentReg", MySqlDbType.VarChar).Value = student.Reg;
            mySqlCommand.Parameters.Add("@StudentClass", MySqlDbType.VarChar).Value = student.Class;
            mySqlCommand.Parameters.Add("@StudentSection", MySqlDbType.VarChar).Value = student.Section;
            try
            {
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Added Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Student not inserted \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mySqlConnection.Close();
        }
        
        
        public static void UpdateStudent(Student student, string id)
        {
            string sql = "UPDATE student SET student_name = @StudentName, reg = @StudentReg, class = @StudentClass, section = @StudentSection WHERE id = @StudentID";
            MySqlConnection mySqlConnection = GetConnection();
            MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
            mySqlCommand.CommandType = CommandType.Text;
            mySqlCommand.Parameters.Add("@StudentID", MySqlDbType.VarChar).Value = id; 
            mySqlCommand.Parameters.Add("@StudentName", MySqlDbType.VarChar).Value = student.Name;
            mySqlCommand.Parameters.Add("@StudentReg", MySqlDbType.VarChar).Value = student.Reg;
            mySqlCommand.Parameters.Add("@StudentClass", MySqlDbType.VarChar).Value = student.Class;
            mySqlCommand.Parameters.Add("@StudentSection", MySqlDbType.VarChar).Value = student.Section;
            try
            {
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Student is not Updated. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mySqlConnection.Close();
        }

        public static void DeleteStudent(string id)
        {
            string sql = "DELETE FROM student WHERE id = @StudentID";
            MySqlConnection mySqlConnection = GetConnection();
            MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
            mySqlCommand.CommandType= CommandType.Text;
            mySqlCommand.Parameters.Add("@StudentID", MySqlDbType.VarChar).Value=id;
            try
            {
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Delete Suceessfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Student is not deleted \n" +ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);   
            }
            mySqlConnection.Close();
        } 
        
        public static void DispalyAndSearch(string query, DataGridView dataGridView)
        {
            string sql = query;
            MySqlConnection mySqlConnection = GetConnection();
            MySqlCommand mySqlCommand = new MySqlCommand(sql, mySqlConnection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            mySqlConnection.Close();
        }
    }
}
