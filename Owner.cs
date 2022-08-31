using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal class Owner : Person
    {
        private int hasCompany;

        public Owner(string firstName, string lastName, string email, DateTime birthday, int hasCompany) : base(firstName, lastName, email, birthday)
        {
            SocialNumber = new Random().Next(1000, 1100);
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Birthday = birthday;
            this.hasCompany = hasCompany;


        }

        public override string? ToString()
        {
            return $"{base.ToString()} | Has Company : {this.hasCompany}";
        }
        public int HasCompany { get => hasCompany; set => hasCompany = value; }


        public override decimal TotalIncome(Dictionary<string, decimal> data)
        {
            //throw new NotImplementedException();
            var totalIncome = 0M;
            foreach (var item in data)
            {
                totalIncome = totalIncome + item.Value * hasCompany;
            }
            return totalIncome;
        }
    }
}
