using static System.Console;
using Day05;

Person person1 = new Customer("bryan","adams","bryan@gmail.com", new DateTime(1998, 4, 24), "131-000");
Customer cust1 = new Customer("fulan","aday","fulan@gmail.com", new DateTime(1999, 2, 12), "113-231");
Customer cust2 = new Customer("adul", "edun","dulan@gmail.com", new DateTime(1993, 5, 22), "122-432");

var listOfCustomer = new List<Person> { person1, cust1, cust2 };

var incomePerson1 = new Dictionary<string, decimal>
{
    {"kontrakan", 1_000_000},
    {"Jualan Seblak", 2_000_000}
};

//person1.TotalIncome(incomePerson1);
person1.TotalRecvenue = person1.TotalIncome(incomePerson1);


var incomeCust1 = new Dictionary<string, decimal>
{
    {"Kosan", 2_000_000},
    {"Makan Online", 3_000_000}
};
cust1.TotalRecvenue = cust1.TotalIncome(incomeCust1);


var incomeCust2 = new Dictionary<string, decimal>
{
    {"kontrakan", 5_000_000},
    {"Jualan Roti Bakar", 6_000_000}
};
cust2.TotalRecvenue = cust2.TotalIncome(incomeCust2);

foreach (var item in listOfCustomer)
{
    WriteLine(item);
}

/*
WriteLine("=====================Revenue Highest");
var listHighest = listOfCustomer.Where(L => L.TotalRecvenue >= 4_000_000).ToList;
foreach (var item in listHighest)
{
    WriteLine{ item.ToString()};
}
*/
//WriteLine("=================Max Revenue============");
/*var listMax = listOfCustomer.Min(H => H.TotalRecvenue);
foreach (var item in listMax)
{
    WriteLine(item.ToString());
}



var listThanMax = ListOfCustomer.where(U => U.TotalRecvenue < listMax)
*/


WriteLine("================Select=============");
var query = listOfCustomer.Select(cust =>
    new
    {
        FullName = cust.FirstName + " " + cust.LastName,
        Email = cust.Email,
        TotalRecvenue = cust.TotalRecvenue
    }
);

foreach (var item in query)
{
    WriteLine(item);
}
    
    ;
//LINQ
//linQ.IntroLinQ();