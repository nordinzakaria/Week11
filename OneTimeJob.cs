using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11
{
    internal class OneTimeJob : Job, Payable // inherits from Job
    {
        public DateTime Date { get; set; }

        public override void Report() // override
        {
            Console.WriteLine("-----");
            Console.WriteLine(Name + " done on " + Date.ToString());
        }

        public float CalcCost()
        {
            return 1000;
        }
    }
}
