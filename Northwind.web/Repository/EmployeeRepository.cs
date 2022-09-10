using Northwind.web.Models;
using System.Collections.Generic;

namespace Northwind.web.Repository
{
    public class EmployeeRepository : IEmployee
    {
        public List<Employee> GetAll()
        {
            var listOfEmployee = new List<Employee>()
            {
                new Employee{Id = 1001, Name ="rian", BirthDate = new System.DateTime(1998, 12, 12)},
                new Employee{Id = 1002, Name ="siswanto", BirthDate = new System.DateTime(1991, 12, 1)},
                new Employee{Id = 1003, Name ="okta", BirthDate = new System.DateTime(1995, 10, 3)},
                new Employee{Id = 1004, Name ="indah", BirthDate = new System.DateTime(1998, 10, 22)}


            };
            return listOfEmployee;
            //throw new System.NotImplementedException();
        }
    }
}
