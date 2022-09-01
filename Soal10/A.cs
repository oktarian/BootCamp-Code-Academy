using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Soal10
{
    internal class A
    {
        private string a = null;


        
       /* public doA(string a)
        {
            this.A = a;

         
        }*/
       // public string A { get => a; set => a = value; }

        public override string? ToString()
        {
            return $"who cares what A says :{this.a}";
        }
    }
}
