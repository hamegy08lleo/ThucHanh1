﻿using System;
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
    public partial class FStudent : Form
    {
        StudentDAO studentDAO = new StudentDAO();
        Student student;
        public FStudent()
        {
            InitializeComponent();
            ucStudent.BtnAdd.Click += BtnAdd;
            ucStudent.GvData.CellContentClick += CellClick; 
            
        }

        private void ucInfomartion1_Load(object sender, EventArgs e)
        {

        }

        private void FStudent_Load(object sender, EventArgs e)
        {
            DataTable dtStudent = studentDAO.Load();
            ucStudent.GvData.DataSource = dtStudent;
        }
        public void GetDataFromUC()
        {
            student = new Student(ucStudent.TxtFullName.Text, ucStudent.TxtAddress.Text, ucStudent.CbSex.Text, ucStudent.TxtGovernmentID.Text, ucStudent.TxtPhoneNumber.Text, ucStudent.TxtEmail.Text, ucStudent.DtBirthdate.Value);
        }
        private void BtnAdd(object sender, EventArgs e)
        {
            try {
                GetDataFromUC();
                studentDAO.Add(student);
                FStudent_Load(sender, e); 
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void BtnDelete(object sender, EventArgs e)
        {
            try
            {
                GetDataFromUC();
                studentDAO.Delete(student); 
                FStudent_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void LoadDataFromRow(DataGridViewRow row)
        {
            ucStudent.TxtFullName.Text = row.Cells[0].Value.ToString();
            ucStudent.TxtAddress.Text = row.Cells[1].Value.ToString();
            ucStudent.TxtPhoneNumber.Text = row.Cells[2].Value.ToString();
            ucStudent.TxtEmail.Text = row.Cells[3].Value.ToString();
            ucStudent.TxtGovernmentID.Text = row.Cells[4].Value.ToString(); 
            ucStudent.CbSex.Text = row.Cells[5].Value.ToString();  
            ucStudent.DtBirthdate.Text = row.Cells[6].Value.ToString();
            ucStudent.LblIDValue.Text = row.Cells[7].Value.ToString();  
        }
        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {

            LoadDataFromRow(ucStudent.GvData.SelectedRows[0]);
        }
    }
}
