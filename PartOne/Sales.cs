using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartOne
{
    internal class Sales : Employee
    {
      
        private Decimal commision, bonus;

        public Sales(int empId, string firstname, string lastname, DateTime joinDate, decimal basicSalary, string city, decimal bonus, decimal commision) : base(empId, firstname, lastname, joinDate, basicSalary, city)
        {
            this.bonus = bonus;
            this.commision = commision;
            Role = "Sales";
            TotalSalary = basicSalary + bonus + commision;

        }

        public decimal Bonus { get => bonus; set => bonus = value; }
        public decimal Commision { get => commision; set => commision = value; }

        public override string? ToString()
        {
            return $"{base.ToString()}xx | TjBonus ={this.bonus.ToString("C", new CultureInfo("id-ID"))} |" +
                    $" TjCommision ={this.commision.ToString("C", new CultureInfo("id-ID"))} | " +
                    $" Total Salary :{this.TotalSalary.ToString("C", new CultureInfo("id-ID"))}";
        }
    }
}
