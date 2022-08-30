using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartOne
{
    internal class QA : Employee
    {
        //instance variable, gunakan huruf kecil
        private Decimal makan;

        public QA(int empId, string firstname, string lastname, DateTime joinDate,
        decimal basicSalary, string city, decimal makan) :
        base(empId, firstname, lastname, joinDate, basicSalary, city)
        {
            this.makan = makan;
            Role = "QA";
            TotalSalary = basicSalary + makan;//call method TotalSalary belong Employee
            
        }

        //method Automatically huruf capital
        public decimal Makan { get => makan; set => makan = value; }

        public override string? ToString()
        {
            return $"{base.ToString()}xx | TjMakan={this.makan.ToString("C", new CultureInfo("id-ID"))} | Total Salary :{this.TotalSalary.ToString("C", new CultureInfo("id-ID"))}";
        }
    }
}
