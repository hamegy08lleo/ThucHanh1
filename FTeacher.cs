using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanh1
{
    public partial class FTeacher : Form
    {
        TeacherDAO teacherDAO;
        Teacher teacher;
        public FTeacher()
        {
            InitializeComponent();
            teacherDAO = new TeacherDAO();
            ucTeacher.BtnAdd.Click += BtnAdd;
            ucTeacher.GvData.CellContentClick += CellClick;
            ucTeacher.BtnDelete.Click += BtnDelete;
            ucTeacher.BtnEdit.Click += BtnEdit;
            BtnChangeToStudent.Click += BtnChangeToStudent_Click;
            ucTeacher.GvData.DataSource = teacherDAO.Load(); 

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FTeacher_Load(object sender, EventArgs e)
        {
            DataTable dtTeacher = teacherDAO.Load();
            ucTeacher.GvData.DataSource = dtTeacher;
        }
        public void GetDataFromUC()
        {
            teacher = new Teacher(ucTeacher.TxtFullName.Text, ucTeacher.TxtAddress.Text, ucTeacher.CbSex.Text, ucTeacher.TxtGovernmentID.Text, ucTeacher.TxtPhoneNumber.Text, ucTeacher.TxtEmail.Text, ucTeacher.DtBirthdate.Value, ucTeacher.LblIDValue.Text);
        }
        private void BtnAdd(object sender, EventArgs e)
        {
            try
            {
                GetDataFromUC();
                teacherDAO.Add(teacher);
                FTeacher_Load(sender, e);
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void BtnDelete(object sender, EventArgs e)
        {
            try
            {
                GetDataFromUC();
                teacherDAO.Delete(teacher.Id);
                FTeacher_Load(sender, e);
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void BtnEdit(object sender, EventArgs e)
        {
            try
            {
                GetDataFromUC();
                teacherDAO.Update(teacher);
                FTeacher_Load(sender, e);
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void Clear()
        {
            ucTeacher.TxtAddress.Clear();
            ucTeacher.TxtFullName.Clear();
            ucTeacher.TxtPhoneNumber.Clear();
            ucTeacher.LblIDValue.Text = "";
            ucTeacher.TxtGovernmentID.Text = "";
            ucTeacher.TxtEmail.Text = "";
            ucTeacher.CbSex.Text = "";
        }
        public void LoadDataFromRow(DataGridViewRow row)
        {
            ucTeacher.TxtFullName.Text = row.Cells[0].Value.ToString();
            ucTeacher.TxtAddress.Text = row.Cells[1].Value.ToString();
            ucTeacher.TxtPhoneNumber.Text = row.Cells[2].Value.ToString();
            ucTeacher.TxtEmail.Text = row.Cells[3].Value.ToString();
            ucTeacher.TxtGovernmentID.Text = row.Cells[4].Value.ToString();
            ucTeacher.CbSex.Text = row.Cells[5].Value.ToString();
            ucTeacher.DtBirthdate.Text = row.Cells[6].Value.ToString();
            ucTeacher.LblIDValue.Text = row.Cells[7].Value.ToString();
        }
        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {

            LoadDataFromRow(ucTeacher.GvData.SelectedRows[0]);
        }
        private void BtnChangeToStudent_Click(object sender, EventArgs e)
        {
            FStudent fStudent = new FStudent();
            fStudent.Show();
            this.Hide();
        }
    }
}
