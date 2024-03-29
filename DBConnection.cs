﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanh1
{
    internal class DBConnection
    {

        SqlConnection conn;
        public DBConnection() { }

        public DBConnection(string connectionString)
        {
            conn = new SqlConnection(connectionString);
        }
        public void CommandExecute(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable AdapterExecute(string sqlStr)
        {
            DataTable dataTable = new DataTable();

            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dataTable);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }

        public DataTable LoadData(string tableName)
        {
            string sqlStr = string.Format("SELECT * FROM {0}", tableName);
            DataTable dataTable = AdapterExecute(sqlStr);
            return dataTable;
        }

    }
}