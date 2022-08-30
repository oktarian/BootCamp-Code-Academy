using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOOP.Mobil
{
    internal class Taxi : Car
    {
        private decimal orderPerKm;
        private int order;
        private int bonus;
        private int totalKm;

       

        public Taxi(string noPolisi, int tahun, decimal orderPerKm, int bonus, int totalKm, int order)
         : base(noPolisi, tahun)
        {
            this.orderPerKm = orderPerKm;
            this.order = order;
            this.bonus = bonus;
            this.totalKm = totalKm;

            Type = "Taxi";
            TotalRevenue = (order*bonus)+(orderPerKm*totalKm);
        }



        public decimal OrderPerKm { get => orderPerKm; set => orderPerKm = value; }
        public int Order { get => order; set => order = value; }
        public int Bonus { get => bonus; set => bonus = value; }
        public int TotalKm { get => totalKm; set => totalKm = value; }

        public override string? ToString()
        {
            return $"{base.ToString()} | Total order : {this.bonus} | Harga order/KM : {this.orderPerKm.ToString("C", new CultureInfo("id-ID"))} |" +
             $" Total KM : {this.totalKm} |" +
             $" Total Bonus : {this.order}|" +
             $"Total Revenue : {this.TotalRevenue.ToString("C", new CultureInfo("id-ID"))}";
        }
    }
}
