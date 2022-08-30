using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOOP.Mobil
{
    internal class Car
    {
        //instance variable
        private string noPolisi;
        private int tahun;
        private string type;
        private decimal totalRevenue;

        public Car(string noPolisi, int tahun)
        {
            this.NoPolisi = noPolisi;
            this.Tahun = tahun;
  
        }

        public override string? ToString()
        {
            return $"Car : {this.noPolisi} | {this.Tahun} | {this.Type}  ";
        }

        public string NoPolisi { get => noPolisi; set => noPolisi = value; }
        public int Tahun { get => tahun; set => tahun = value; }
        public string Type { get => type; set => type = value; }
        public decimal TotalRevenue { get => totalRevenue; set => totalRevenue = value; }
    }
}

