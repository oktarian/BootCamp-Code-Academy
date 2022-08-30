using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartTwo
{
    internal class Employee
    {
        //instance Variable
        private int empId;
        private string Firstname;
        private string Lastname;
        private DateTime joinDate;
        private decimal basicSalary;
        private string City;
        private string role;
        private decimal totalSalary;

        //static variable
        public static int totalEmployee = 0;
        public static Decimal totalBasicSalary = 0M;

        //empty atau default construktor
        public Employee()
        {
            totalEmployee++;
            totalBasicSalary += this.basicSalary;
            this.TotalSalary = this.basicSalary;
        }

        //Constructor Parameter
        public Employee(int empid, string firstname, string lastname, DateTime joinDate, decimal basicSalary)
        {
            this.empId = empid; //new empid.next(100,120);
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.joinDate = joinDate;
            this.basicSalary = basicSalary;
            totalEmployee++;
            totalBasicSalary += this.basicSalary;
            this.TotalSalary = this.basicSalary;

        }



        //Overloading Constructor
        public Employee(int empId, string firstname, string lastname, DateTime joinDate, decimal basicSalary, string city, string role)
            : this(empId, firstname, lastname, joinDate, basicSalary, city)
        {
            this.role = role;

        }
        public Employee(int empId, string firstname, string lastname, DateTime joinDate, decimal basicSalary, 
            string city) : this(empId, firstname, lastname, joinDate, basicSalary)
        {
            City = city;

        }

        public override string? ToString()
        {
            return $"Employee = {this.empId} | {this.Firstname} | {this.Lastname} | {this.joinDate} | {this.Role} | Basic Salary : {this.basicSalary.ToString("C", new CultureInfo("id-ID"))} ";
        }
      /*  private decimal GetTotalSalary()
        {
           return this.basicSalary;
        }*/
        public int EmpId { get => empId; set => empId = value; }
        public string Firstname1 { get => Firstname; set => Firstname = value; }
        public string Lastname1 { get => Lastname; set => Lastname = value; }
        public DateTime JoinDate { get => joinDate; set => joinDate = value; }
        public decimal BasicSalary { get => basicSalary;
            set
            {
                basicSalary = value;
                totalSalary = basicSalary;

            }
        }
        public string City1 { get => City; set => City = value; }
        public string Role { get => role; set => role = value; }
        public decimal TotalSalary { get => totalSalary; set => totalSalary = value; }
    }

}
