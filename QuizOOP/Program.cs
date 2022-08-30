using static System.Console;
using QuizOOP.Mobil;

/*
SUV suv1 = new SUV("D1001UM", 2015, 500_000, 100_000);
SUV suv2 = new SUV("D1002UM", 2019, 500_000, 100_000);



Angkot akt1 = new Angkot("D55UJ", 2016, 4_500, 35);
Angkot akt2 = new Angkot("D56UJ", 2015, 4_500, 40);


Taxi tax1 = new Taxi("D88UK", 2018, 4_500, 5, 40,10_000);
Taxi tax2 = new Taxi("D87UK", 2018, 4_500, 10, 100, 10_000);*/

/*WriteLine($"Total Revenue :{TotalRevenue}");*/

//store to List
/*List<Car> listCars = new List<Car> { suv1, suv2, tax1, tax2, akt1, akt2};

foreach (var item in listCars)
{
    WriteLine(item.ToString());

}
*/

//Call interface & Implementation

ICar carInf = new Carimpl();

var listOfCar = carInf.InitDataCars();
carInf.ShowList(ref listOfCar);


WriteLine("========================SUMMARY=====================================");

//Total Car By Type
WriteLine("==========================Total Car By Type========================");
var carType = carInf.GetTotalByType(ref listOfCar);
carInf.ShowDictionary(ref carType);

//Total Car By Type
WriteLine("==========================Total Revenue By Type========================");
var carRevenueType = carInf.GetRevenueByType(ref listOfCar);
carInf.ShowDictionaryRevenue(ref carRevenueType);


//revenue  range car
WriteLine("===================Car Revenue Range========================");
var carRevenueRange = carInf.FindRevenueByRange(listOfCar, 500_000, 600_000);
carInf.ShowList(ref carRevenueRange);
ReadLine();

