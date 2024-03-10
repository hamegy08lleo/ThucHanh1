using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanh1
{
    internal class PersonDAO
    {
        private String tableName;
        private DBConnection dbConnnection; 
        public PersonDAO(String tableName) 
        {
            this.tableName = tableName; 
            this.dbConnnection = new DBConnection(Properties.Settings.Default.connStr);
        }
        public DataTable Load()
        {
            String sqlStr = $"SELECT * FROM {tableName}";
            DataTable dtPerson = dbConnnection.AdapterExecute(sqlStr);
            return dtPerson;
        }
        public void Add(Person person)
        {
            String sqlStr = $"INSERT INTO {tableName}(fullName, address, phoneNumber, email, governmentID, sex, dateOfBirth) VALUES ('{person.Name}', '{person.Address}', '{person.PhoneNumber}', '{person.Email}', '{person.GovernmentID}', '{person.Sex}', '{person.BirthDate}')";
            dbConnnection.CommandExecute(sqlStr);
        }
        public void Delete(string id)
        {
            String sqlStr = $"DELETE FROM {tableName} WHERE id = '{id}'";
            dbConnnection.CommandExecute(sqlStr);
        }
        public void Update(Person person)
        {
            String sqlStr = $"UPDATE {tableName} SET fullName = '{person.Name}', address = '{person.Address}', phoneNumber = '{person.PhoneNumber}', email = '{person.Email}', governmentID = '{person.GovernmentID}', sex = '{person.Sex}', dateOfBirth = '{person.BirthDate.ToString()}' WHERE id = '{person.Id.ToString()}'";
            dbConnnection.CommandExecute(sqlStr);
        }
    }
}
