using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartOne
{
    internal class Programmers : Employee
    {
        private Decimal transportasi;

        public Programmers(int empId, string firstname, string lastname,
             DateTime joinDate, decimal basicSalary, string city, decimal transportasi)
            : base(empId, firstname, lastname, joinDate, basicSalary, city)
        {
            this.transportasi = transportasi;
            Role = "Programmer";
            TotalSalary = basicSalary +transportasi;
        }

        public decimal Transportasi { get => transportasi; set => transportasi = value; }

        
        public override string? ToString()
        {
            return $"{base.ToString()}xx | TjTransportasi ={this.transportasi.ToString("C", new CultureInfo("id-ID"))} | Total Salary :{this.TotalSalary.ToString("C", new CultureInfo("id-ID"))}";
        }
    }
    

}
