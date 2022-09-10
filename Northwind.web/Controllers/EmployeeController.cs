using Microsoft.AspNetCore.Mvc;
using Northwind.web.Models;
using System.Collections.Generic;
using System;
using Northwind.web.Repository;

namespace Northwind.web.Controllers
{
    public class EmployeeController : Controller
    {
        //use dependency injection
        private readonly IEmployee _IEmployee;

        public EmployeeController(IEmployee iEmployee)
        {
            _IEmployee = iEmployee;
        }

        public IActionResult ListEmployee()
        {
           /* var listOfEmployee = new List<Employee>()
            {
                new Employee{Id = 1001, Name ="rian", BirthDate = new System.DateTime(1998, 12, 12)},
                new Employee{Id = 1002, Name ="siswanto", BirthDate = new System.DateTime(1991, 12, 1)},
                new Employee{Id = 1003, Name ="okta", BirthDate = new System.DateTime(1995, 10, 3)}

            };*/
            return View("ListEmployee", _IEmployee.GetAll());
        }
    }
}
