using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TestPortableLibrary;
using Library1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Asd("true");
            Asd("false");
            Asd("1");
            Asd("0");
            Asd("falsed");
            Asd("false1");
        }

        public static void Asd(string str)
        {
            bool spot;
            int number;

            var result = int.TryParse(str, out number);

            if (result)
            {
                spot = Convert.ToBoolean(number);
            }
            else
            {
                 Boolean.TryParse(str, out spot);
            }


            Console.WriteLine(spot);
        }
    }
}
