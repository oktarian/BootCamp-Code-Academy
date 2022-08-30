using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOOP.Mobil
{
    internal class Carimpl : ICar
    {
        public List<Car> FindRevenueByRange(List<Car> list, decimal startFrom, decimal endTo)
        {
           var carRange = new List<Car>();

            foreach (var item in list)
            {
                if (item.TotalRevenue >= startFrom && item.TotalRevenue <= endTo) 
                {
                    carRange.Add(item);
                }

            }

           return carRange;
        }

        public Dictionary<string, decimal> GetRevenueByType(ref List<Car> list)
        {
            var mobil = new Dictionary<string, decimal>();


            decimal SUV = 0;
            decimal Taxi = 0;
            decimal Angkot = 0;


            foreach (var item in list.OfType<Car>())
            {
                if (item.Type == "SUV")
                {

                    SUV += item.TotalRevenue;

                }
                else if (item.Type == "Taxi")
                {
                    Taxi += item.TotalRevenue;

                }
                else if (item.Type == "Angkot")
                {

                    Angkot += item.TotalRevenue;
                }
            }
            mobil.Add("SUV :", SUV);
            mobil.Add("Taxi :", Taxi);
            mobil.Add("Angkot :", Angkot);

            return mobil;
        }

        public Dictionary<string, int> GetTotalByType(ref List<Car> list)
        {
            var mobil = new Dictionary<string, int>();


            var SUV = 0;
            var Taxi = 0;
            var Angkot = 0;


            foreach (var item in list.OfType<Car>())
            {
                if (item.Type == "SUV")
                {

                    SUV++;
                }
                else if (item.Type == "Taxi")
                {

                    Taxi++;
                }
                else if (item.Type == "Angkot")
                {

                    Angkot++;
                }
            }
            mobil.Add("SUV :", SUV);
            mobil.Add("Taxi :", Taxi);
            mobil.Add("Angkot :", Angkot);

            return mobil;
        }

        public List<Car> InitDataCars()
        {
            SUV suv1 = new SUV("D1001UM", 2015, 500_000, 100_000);
            SUV suv2 = new SUV("D1002UM", 2019, 500_000, 100_000);



            Angkot akt1 = new Angkot("D55UJ", 2016, 4_500, 35);
            Angkot akt2 = new Angkot("D56UJ", 2015, 4_500, 40);


            Taxi tax1 = new Taxi("D88UK", 2018, 4_500, 5, 40, 10_000);
            Taxi tax2 = new Taxi("D87UK", 2018, 4_500, 10, 100, 10_000);

            return new List<Car> {suv1, suv2, akt1, akt2, tax1, tax2 };
        }

        public void ShowDictionary(ref Dictionary<string, int> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }

      

        public void ShowDictionaryRevenue(ref Dictionary<string, decimal> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}{item.Value}");
            }
        }

        public void ShowList<T>(ref List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine();
                Console.WriteLine($"{item}");
            }
        }
    }
}
