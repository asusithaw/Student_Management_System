using MySql_Crud.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MySql_Crud
{
    class DbStudent
    {
        // Viewing Students on the GridView
        public static void GetStudentInfo(DataGridView dataGridView)
        {

            using (ISession session = NHibernateSessions.OpenSession())

            {
                IQuery query = session.CreateQuery("FROM Student");

                var sInfos = query.List<Student>();

                dataGridView.DataSource = sInfos;
            }

        }

        public static void GetStudentSearchInfo(string sql, DataGridView dataGridView)
        {
            using (ISession session = NHibernateSessions.OpenSession())

            {
                IQuery query = session.CreateQuery(sql);

                var sInfos = query.List<Student>();

                dataGridView.DataSource = sInfos;
            }
        }
       
        // Creating a Student
        public static void CreateStudent(Student student)
        {

        }

        // Updating/Editing a Student
        public static void UpdateStudent(Student student, string id)
        {
            student.ID = Convert.ToInt32(id);

            using (ISession session = NHibernateSessions.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(student);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Student is Updated \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
               
            }

        }

        // Deleting a Student 
        public static void DeleteStudent(int id)
        {

            using (ISession session = NHibernateSessions.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        Student student = session.Get<Student>(id);
                        session.Delete(student);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Student is Deleted \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
        }



    }
}
