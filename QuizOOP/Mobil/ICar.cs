using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOOP.Mobil
{
    internal interface ICar
    {
        public List<Car> InitDataCars();
        public void ShowList<T>(ref List<T> list);
        public Dictionary<string, int> GetTotalByType(ref List<Car> list);
        public void ShowDictionary(ref Dictionary<string, int> dict);

        public Dictionary<string, decimal> GetRevenueByType(ref List<Car> list);
        public void ShowDictionaryRevenue(ref Dictionary<string, decimal> dict);

        public List<Car> FindRevenueByRange(List<Car> list, decimal startFrom, decimal endTo);

    }
}
