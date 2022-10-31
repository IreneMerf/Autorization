using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autorization.Model
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BornDate { get; set; }
        public decimal Salary { get; set; }

        public User()
        {
            Id = 0;
            FirstName = string.Empty;
            MiddleName = string.Empty;
            LastName = string.Empty;
            BornDate = DateTime.MinValue;
            Salary = 0;
        }

        public User(int id, string firstName, string middleName, string lastName, DateTime bornDate, decimal salary)
        {
            Id = id;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            BornDate = bornDate;
            Salary = salary;
        }


        public override string ToString()
        {
            return $"№: {Id} \n ФИО: {FirstName} {MiddleName} {LastName}\nДата рождения: {BornDate}\n" + $"Зарплата: {Salary}";
        }
    }
}
