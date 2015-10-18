using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Account
    {
        public  double CurrentBalance { get; set; }

        public  string name { get; set; }

        public List<Detail> Details  { get; set; }


        public static double getBalance(List<Detail> currentdetails)
        {
            double x = 0;
            foreach (var details in currentdetails)
            {
                x += details.Amount;
            }return x;
        }

    }
}
