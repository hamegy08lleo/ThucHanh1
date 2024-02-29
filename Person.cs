using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ThucHanh1
{
    internal class Person
    {
        private string name;
        private string address;
        private string sex;
        private string governmentID;
        private string phoneNumber;
        private string email;
        private string id;
        DateTime birthDate;

        // TODO: viet validate

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Sex { get => sex; set => sex = value; }
        public string GovernmentID { get => governmentID; set => governmentID = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Id { get => id; set => id = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }

        public void isBlankValidate()
        {
            PropertyInfo[] properties = this.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (property.Name == "Id") continue;
                if (property.PropertyType == typeof(string))
                {
                    string value = (string)property.GetValue(this);
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception(property.Name + " is empty");
                    }
                }
            }
        }

        public void ValidateData()
        {
            isBlankValidate();

            if (getAge() < 17)
            {
                throw new Exception("Age must >= 17!");
            }
            if (!IsValidPhoneNumber())
            {
                throw new Exception("The number phone isn't valid (xxx-xxxx-xxx) - x is number!");
            }
            if (!IsValidEmail())
            {
                throw new Exception("Email isn't valid format!");
            }
        }
        private bool IsValidPhoneNumber()
        {
            string regex = @"^\(?([0-9]{3})\)?[-]([0-9]{4})[-]([0-9]{3})$";
            return Regex.IsMatch(phoneNumber, regex);
        }

        private bool IsValidEmail()
        {
            string regex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            return Regex.IsMatch(email, regex);
        }
        public int getAge()
        {
            int age = (int)Math.Floor((DateTime.Now - BirthDate).TotalDays / 365.25D);
            return age;
        }

        public Person(string name, string address, string sex, string governmentID, string phoneNumber, string email, DateTime birthDate, string id = "")
        {
            this.name = name;
            this.address = address;
            this.sex = sex;
            this.governmentID = governmentID;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.id = id;
            this.birthDate = birthDate;
            ValidateData();
        }
    }
}
