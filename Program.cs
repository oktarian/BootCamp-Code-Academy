using Day03;
//MyCollections.InitList();
/*
MyCollections.InitQueue();


//declare List<T>
var list = new List<string> { "green", "red", "yellow" };
var students = MyCollections.GetStudent(ref list);

foreach (var item in students)
{
    Console.WriteLine($"{item}");
}

var numbers = new List<int> { 1, 2, 3, 4, 5 };
var MyNumber = MyCollections.GetStudent(ref numbers);

foreach (var item in MyNumber)
{
    Console.WriteLine($"{item}");
}

*/

//soal1
//Declare List<int>
/*var A = new List<int> { 1, 2, 5, 6, 9 };
var B = new List<int> { 1, 2, 3, 4 };
MyCollections.soal1(ref A, ref B);*/

//soal2
//Declare List<int>
/*var A = new List<string> { "1", "2", "3", "4" };
var B = new List<string> { "A", "BB", "CCC", "DDDD" };

var myList =  MyCollections.Reverse(ref A);
var myList2 = MyCollections.Reverse(ref B);

foreach (var item in myList)
{
    Console.Write($" { item } ");
}
Console.WriteLine();
foreach (var item in myList2)
{
    Console.Write($" { item } ");
}*/

//soal3
var A = new List<int> { 1, 1, 2, 3, 4, 1, 2, 3 };
var B = new List<int> { 7, 5, 3, 5, 1 };
var C = new List<int> { 1, 1, 1, 1, 1, 1 };

var myList = MyCollections.Remove(ref A);
var myList2 = MyCollections.Remove(ref B);
var myList3 = MyCollections.Remove(ref C);

foreach (var item in myList)
{
    Console.Write($" { item } ");
}
Console.WriteLine();
foreach (var item in myList2)
{
    Console.Write($" { item } ");
}
Console.WriteLine();
foreach (var item in myList3)
{
    Console.Write($" { item } ");
}

//soal4

//soal5
//MyCollections.soal5(); 

//sooal6
