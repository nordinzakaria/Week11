using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11
{
    internal class Account
    {
        List<Payable> payables = new List<Payable>();

        public void Add(Payable payable)
        {
            payables.Add(payable);
        }

        public float Total()
        {
            float total = 0;
            foreach (Payable payable in payables)
            {
                total += payable.CalcCost();
            }
            return total;
        }
    }
}
