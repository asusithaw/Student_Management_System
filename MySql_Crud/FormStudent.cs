using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql_Crud.Models;
using MySqlX.XDevAPI;
using NHibernate;
using static System.Net.Mime.MediaTypeNames;

namespace MySql_Crud
{
    public partial class FormStudent : Form
    {
        private readonly FormStudentInfo _parent;
        public string id, name, sinhalaname, reg, @class, section;

        public FormStudent(FormStudentInfo parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void SaveInfo()
        {
            lblText.Text = "Save Student";
            btnSave.Text = "Save";
        }
        public void UpdateInfo()
        {
            lblText.Text = "Update Student";
            btnSave.Text = "Update";
            txtName.Text = name;
            txtSinhalaText.Text = sinhalaname;
            txtReg.Text = reg;
            txtClass.Text = @class;
            txtSection.Text = section;
        }

        public void Clear()
        {
            txtName.Text = txtSinhalaText.Text = txtReg.Text = txtClass.Text = txtSection.Text = string.Empty;
        }

        public void Save()
        {
            Student student = new Student(txtName.Text.Trim(), txtSinhalaText.Text.Trim(), txtReg.Text.Trim(), txtClass.Text.Trim(), txtSection.Text.Trim());
            using (ISession session = NHibernateSessions.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(student);
                        transaction.Commit();
                        Clear();

                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Student not inserted \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Student name is empty ( > 3).");
                return;
            }

            if (txtSinhalaText.Text.Trim().Length == 0)
            {
                MessageBox.Show("ශිෂ්‍යයාගේ සිංහල නම අතුලත් කල යුතුය. ");
                return;
            }

            if (txtReg.Text.Trim().Length < 1)
            {
                MessageBox.Show("Student reg is empty ( > 1).");
                return;
            }

            if (txtClass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Student class is empty ( > 1).");
                return;
            }

            if (txtSection.Text.Trim().Length == 0)
            {
                MessageBox.Show("Student section is empty ( > 1).");
                return;
            }

            if (btnSave.Text == "Save")
            {
                Save();
            }


            if (btnSave.Text == "Update")
            {
                Student student = new Student(txtName.Text.Trim(), txtSinhalaText.Text.Trim(), txtReg.Text.Trim(), txtClass.Text.Trim(), txtSection.Text.Trim());
                DbStudent.UpdateStudent(student, id);
            }

            _parent.Display();
        }
    }
}
