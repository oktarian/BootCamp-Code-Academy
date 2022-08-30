using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.PartTwo
{
    internal class EmployeeImpl : IEmployee
    {
        public List<Employee> FindSalaryRange(List<Employee> list, decimal startFrom, decimal endTo)
        {
            var empRange =  new List<Employee>();

            foreach (var item in list)
            {
                if (item.TotalSalary >= startFrom && item.TotalSalary <= endTo)
                {
                    empRange.Add(item);
                }
            }  

            return empRange;
        }

        public Employee FinfEmployeeById(List<Employee> list, int id)
        {
            Employee? emps = null;
            foreach (var item in list)
            {
                if (item.EmpId == id)
                {
                    emps = item;
                }
            }

            return emps;
        }

     /*   public Dictionary<string, int> GetTotalEmployeeByRole(List<Employee> list)
        {
            var totEmp=0;
            foreach (var item in list)
            {
                item = totEmp++;
            }
            return totEmp;
        }*/

        public decimal GetTotalSalary<T>(ref List<T> list)
        {
            var total = 0M;

            foreach (var item in list.OfType<Employee>())
            {
                total = item.TotalSalary;
            }

            return total;
        }

        public List<Employee> InitDataEmployee()
        {

            Employee emp2 = new Employee(1001, "Code", "Academy", new DateTime(), 5_000_000, "bali", "QA");
            Employee emp3 = new Employee(1002, "Code", "Academy", new DateTime(2022, 08, 10), 6_000_000, "Palembang", "Programmer");
            Employee emp4 = new Employee(1003, "fulan", "Fulan", new DateTime(2022, 08, 29), 3_000_000, "jakarta", "Programmer");

            Programmers prog1 = new Programmers(1004, "mawar", "melati", new DateTime(2021, 10, 13),
                                    4_000_000, "Lampung", 2_000_000);

            QA qa1 = new QA(1005, "subur", "rubus", new DateTime(2022, 02, 11),
                                                5_000_000, "Semarang", 1_000_000);

            Sales sls1 = new Sales(1006, "anna", "nahnu", new DateTime(2021, 03, 12),
                                                    3_000_000, "Pekanbaru", 1_300_000, 500_00);

            //direct return without variable
            return new List<Employee> { emp2, emp3, emp4, prog1, qa1, sls1};
        }

        public void ShowList<T>(ref List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
