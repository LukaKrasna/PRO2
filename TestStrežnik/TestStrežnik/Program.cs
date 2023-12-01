using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStrežnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdventureWorksLT2019Entities dc=new AdventureWorksLT2019Entities();
            var r = dc.Product.Select(a => a);
            foreach(var r2 in r)
            {
                Console.WriteLine(r2.Name + " " + r2.ProductNumber);
            }
            Console.ReadLine();
        }
    }
}
