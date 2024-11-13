using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11
{
    internal class RecurringJob : Job, Payable
    {
        public DateTime LastDone {  get; set; }
        public TimeSpan TimeBeforeNext {  get; set; }

        public override void Report() // override
        {
            Console.WriteLine("*****");
            Console.WriteLine(Name +" lastdone "+LastDone.ToString());
            Console.WriteLine("Next scheduled: "+ (LastDone + TimeBeforeNext).ToString());
            Console.WriteLine("**END REPORT***");

        }

        public float CalcCost()
        {
            return 10;
        }

    }
}
