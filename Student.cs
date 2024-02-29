using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh1
{
    internal class Student : Person
    {
        public Student(string name, string address, string sex, string governmentID, string phoneNumber, string email, DateTime birthDate, string id = "") 
            : base(name, address, sex, governmentID, phoneNumber, email, birthDate, id)
        {

        }
    }
}
