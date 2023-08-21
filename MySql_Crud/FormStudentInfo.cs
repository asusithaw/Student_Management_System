using MySql_Crud.Models;
using NHibernate;
using System.Numerics;
using System.Windows.Forms;

namespace MySql_Crud
{
    public partial class FormStudentInfo : Form
    {
        FormStudent form;

        public FormStudentInfo()
        {
            InitializeComponent();
            form = new FormStudent(this);
        }


        public void Display()
        {
            DbStudent.GetStudentInfo(dataGridView);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveInfo();
            form.ShowDialog();
        }

        private void FormStudentInfo_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DbStudent.GetStudentSearchInfo("FROM Student WHERE StudentName LIKE '%" + txtSearch.Text + "%' ", dataGridView);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Edit
                form.Clear();
                form.id = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.name = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.sinhalaname = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.reg = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.@class = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.section = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();

                return;
            }

            if (e.ColumnIndex == 1)
            {
                //Delete
                if (MessageBox.Show("Are you want to delete student record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DbStudent.DeleteStudent(Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString()));
                    //
                    Display();
                }
                return;
            }

        }
    }
}