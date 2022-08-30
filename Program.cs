using static System.Console;
//call class Employee
using Day04.PartOne;
using Day04.PartTwo;

/*//setiap create object instance, gunakan operator new
Employee emp1 = new Employee();//ini akan memanggil empty atau default construktor
emp1.EmpId = 1000;
emp1.Firstname1 = "rian";
emp1.Lastname1 = "ors";
emp1.JoinDate = DateTime.Now;
emp1.BasicSalary = 5_000_000;
emp1.City1 = "Palembang";
emp1.Role = "Sales";



//create object Employee with parameter constructor
Employee emp2 = new Employee(1001,"Code","Academy", new DateTime(), 5_000_000 , "bali", "QA");
Employee emp3 = new Employee(1002, "Code", "Academy", new DateTime(2022,08,10), 6_000_000, "Palembang","Programmer");
Employee emp4 = new Employee(1003, "fulan", "Fulan", new DateTime(2022,08,29), 3_000_000, "jakarta", "Programmer");

emp3.BasicSalary = 8_000_000;//mengubah basic salary 

WriteLine(emp1.ToString());
WriteLine(emp2.ToString());
WriteLine(emp3.ToString());
WriteLine(emp4.ToString());
WriteLine($"Total employee :{Employee.totalEmployee}");
WriteLine($"Total Basic Salary : {Employee.totalBasicSalary}");

//class programmers.cs atau create object programmer
Programmers prog1 = new Programmers(1004, "mawar","melati", new DateTime(2021,10,13),
                                    4_000_000, "Lampung", 2_000_000);

QA qa1 = new QA(1005, "subur", "rubus", new DateTime(2022, 02, 11),
                                    5_000_000, "Semarang", 1_000_000);

Sales sls1 = new Sales(1006, "anna", "nahnu", new DateTime(2021,03,12), 
                                        3_000_000, "Pekanbaru", 1_300_000,500_00);


//store to List
List<Employee> listEmply = new List<Employee> { emp1,emp2,emp3,emp4, prog1, qa1, sls1};

foreach (var item in listEmply)
{
    WriteLine(item.ToString());

}
*/


WriteLine("==========================Implementation Interface======================");

//Call interface & Implementation

IEmployee empInf = new EmployeeImpl();

var listOfEmps = empInf.InitDataEmployee();
empInf.ShowList(ref listOfEmps);


//find employee by id
var emps = empInf.FinfEmployeeById(listOfEmps, 1003);
WriteLine($"ketemu : {emps}");


//get total salary
var total = empInf.GetTotalSalary(ref listOfEmps);
WriteLine($"Total Salary : {total}");


//salary
WriteLine("===================Salary Range========================");
var empsSalaryRange = empInf.FindSalaryRange(listOfEmps, 2_000_000, 3_000_000);
empInf.ShowList(ref empsSalaryRange);
ReadLine();
