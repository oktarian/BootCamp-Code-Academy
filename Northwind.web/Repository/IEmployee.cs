using Northwind.web.Models;
using System.Collections.Generic;

namespace Northwind.web.Repository
{
    public interface IEmployee
    {
        public List<Employee> GetAll();

    }
}
