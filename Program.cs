using static System.Console;
using Day02;


/** QUIZ SOLUTION */
/////////////////////QUIZ/////////////////////////



// soal 1
/*int[] bef = { 15, 2, 30, 12, 10, 5 };
Console.WriteLine($"before Random : {bef[0]} {bef[1]} {bef[2]} {bef[3]} {bef[4]} {bef[5]}");
var random = Quiz2.RandomPosition(bef);
Quiz2.DisplayArrayInt2(random);*/

//soal 2
/*int[] bef = { 15, 2, 30, 12, 10, 5 };
Console.WriteLine($"before tukar : ");
*//*{bef[0]} {bef[1]} {bef[2]} {bef[3]} {bef[4]} {bef[5]}*//*
var tukar = Quiz2.GeserElement(bef);
Quiz2.DisplayArrayInt3(tukar);*/

//soal3
/*int[] bef = { 2, 15, 10, 30, 12, 5 };
 Console.WriteLine($"Before Rotasi : ");
Quiz2.DisplayRotasi(bef);
var rot = Quiz2.Rotasi(bef);*/

//soal4
/*int[] bef = { 2, 15, 10, 30, 12, 5 };
Console.WriteLine($"Before Rotasi : ");
Quiz2.DisplayRotasi(bef);
var rot = Quiz2.RotasiKanan(bef);*/

//soal 5
/*int[] bef2 = { 5, 2, 30, 12, 10, 5, 2, 10, 5 };
Console.WriteLine($"element array masih duplikat : ");
Quiz2.DisplayRotasi(bef2);
var sum = Quiz2.HitungDuplikat(bef2);*/

//soal6

//soal7

//soal8

//soal9
var soal9 = Quiz2.soal9(5, 5);
Quiz2.DisplayMatrix(soal9);

//soal10
/*var soal10 = Quiz2.soal10(5, 5);
Quiz2.DisplayMatrix(soal10);*/

//soal11
/*var soal11 = Quiz2.soal11(7, 7);
Quiz2.DisplayMatrix(soal11);*/

//soal12
/*var soal12 = Quiz2.soal12(7, 7);
Quiz2.DisplayMatrix(soal12);*/


ReadLine();

