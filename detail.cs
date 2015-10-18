using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public  class Detail
    {
        public double Amount { get; set; }

        public  string Category { get; set; }

        public  DateTime Date { get; set; }

        public  int Transaction { get; set; }


        public static Detail NewDatail(double MYamount, string MYcategory, DateTime MYdate, int MYtransaction)
        {
            Detail myNewDetail = new Detail {Amount = MYamount, Category = MYcategory, Transaction = MYtransaction, Date = MYdate};


            return myNewDetail;

        }

    }

}
