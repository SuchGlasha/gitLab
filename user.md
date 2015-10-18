# gitLab
Lab 5 of Programm Technology

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class User
    {
        public  string Password { get; set; }

        public  DateTime Data { get; set; }

        public  Account Acc { get; set; }



        public void ChangePassword(string pass)
        {
            Password = pass;
        }

        public void CreatePassword(string pass)
        {
            Password = pass;

        }

    

    }
}
