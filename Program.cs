using static System.Console;
using Day05;
/*
//customer
Person person1 = new Customer("bryan","adams","bryan@gmail.com", new DateTime(1998, 4, 24), "131-000");
Customer cust1 = new Customer("fulan","aday","fulan@gmail.com", new DateTime(1999, 2, 12), "113-231");
Customer cust2 = new Customer("adul", "edun","dulan@gmail.com", new DateTime(1993, 5, 22), "122-432");



//customer
var listOfCustomer = new List<Person> { person1, cust1, cust2 };


//customer x person
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


WriteLine("=====================Revenue Highest=================");
var listHighest = listOfCustomer.Where(L => L.TotalRecvenue >= 4_000_000).ToList();
foreach (var item in listHighest)
{
    WriteLine(item.ToString());
}


WriteLine("=================Max & Min Revenue============");
var listMin = listOfCustomer.Min(H => H.TotalRecvenue);
WriteLine($"Cust Min Revenue : {listMin}");


var listMax = listOfCustomer.Max(U => U.TotalRecvenue);
WriteLine($"Cust Max Revenue : {listMax}");


var listLessThanMax = listOfCustomer.Where(T => T.TotalRecvenue < listMax);
WriteLine("===========Revenue Lower Than Max");
foreach (var item in listLessThanMax)
{
    WriteLine(item.ToString());
}


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


    */
//LINQ
//linQ.IntroLinQ();

WriteLine("======================OWNER=====================");
//Owner
Person person2 = new Owner("rian", "siswanto", "rian@gmail.com", new DateTime(1998, 8, 11), 4);
Owner owner1 = new Owner("onad", "dcpario", "onad@gmail.com", new DateTime(1992, 2, 12), 5);
Owner owner2 = new Owner("ruja", "jalu", "jalu@gmail.com", new DateTime(1992, 5, 23), 8);


//Owner
var listOfOwner = new List<Person> { person2, owner1, owner2 };

//Owner x Person
var incomePerson2 = new Dictionary<string, decimal>
{
    {"Kostan", 12_000_000},
    {"Apartement", 26_000_000}
};

//Owner
person2.TotalRecvenue = person2.TotalIncome(incomePerson2);

var incomeOwn1 = new Dictionary<string, decimal>
{
    {"Warung Makan", 9_000_000},
    {"Thrift", 13_000_000}
};

//owner
owner1.TotalRecvenue = owner1.TotalIncome(incomeOwn1);

var incomeOwn2 = new Dictionary<string, decimal>
{
    {"Toko Roti", 11_000_000},
    {"Nasi Goreng", 9_000_000}
};

owner2.TotalRecvenue = owner2.TotalIncome(incomeOwn2);

foreach (var item in listOfOwner)
{
    WriteLine(item);
}

WriteLine("=====================Revenue Highest Owner============");
var listHighestOwn = listOfOwner.Where(L => L.TotalRecvenue >= 4_000_000).ToList();
foreach (var item in listHighestOwn)
{
    WriteLine(item.ToString());
}

WriteLine("=================Max & Min Revenue============");
var listMinOwn = listOfOwner.Min(H => H.TotalRecvenue);
WriteLine($"Cust Min Revenue : {listMinOwn}");

var listMaxOwn = listOfOwner.Max(U => U.TotalRecvenue);
WriteLine($"Cust Max Revenue : {listMaxOwn}");


var listLessThanMaxOwn = listOfOwner.Where(T => T.TotalRecvenue < listMaxOwn);
WriteLine("===========Revenue Lower Than Max");
foreach (var item in listLessThanMaxOwn)
{
    WriteLine(item.ToString());
}

WriteLine("================Select=============");
var query2 = listOfOwner.Select(own =>
    new
    {
        FullName = own.FirstName + " " + own.LastName,
        Email = own.Email,
        TotalRecvenue = own.TotalRecvenue
    }
);

foreach (var item in query2)
{
    WriteLine(item);
}

