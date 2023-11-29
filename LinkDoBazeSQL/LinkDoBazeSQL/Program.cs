using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinkDoBazeSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NorthDataContext dc = new NorthDataContext();
            var a1 = from b in dc.Customers
                     select b;
            //Console.WriteLine("**************************");
            //foreach(var x in a1)
            //{
            //    Console.WriteLine(x.CompanyName + " " + x.ContactName);
            //}
            //izberi samo imena podjetji
            var a2 = from b in dc.Customers
                     select b.CompanyName;
            //Console.WriteLine("**************************");
            //foreach (var x in a2)
            //{
            //    Console.WriteLine(x);
            //}
            var a3 = from b in dc.Customers
                     select new { Podjetje = b.CompanyName, Kontakt = b.ContactName };
            Console.WriteLine("**************************");
            foreach (var x in a3)
            {
                Console.WriteLine(x.Podjetje +" "+x.Kontakt);
            }
            //izpiši podrobnosti naročila 11076
            var a4 = from n in dc.Order_Details
                     where n.OrderID == 11076
                     select n;
            Console.WriteLine("\nPodrobnosti naročila 11076:");
            foreach (var x in a4)
            {
                Console.WriteLine(x.OrderID+" "+x.ProductID+" "+x.Quantity+ " " + x.Discount);
            }
            Order_Detail o = new Order_Detail() 
            { 
                OrderID=11076,
                ProductID=6,
                UnitPrice=0.2m,
                Quantity=2500,
                Discount=0
            };
            //Vstavi(o);
            Console.WriteLine("********************");
            //Briši(11076, 7);
            Posodobi(o, dc);
            foreach(var x in a4)
            {
                Console.WriteLine(x.OrderID + " " + x.ProductID + " " + x.Quantity + " " + x.Discount);
            }
            Console.ReadLine();
        }
        public static void Posodobi(Order_Detail o, NorthDataContext ndc)
        {
            try
            {
                var r = (from a in ndc.Order_Details
                         where a.OrderID == o.OrderID && a.ProductID == o.ProductID
                         select a).FirstOrDefault();
                if(r != null)
                {
                    r.Quantity = o.Quantity;
                    ndc.SubmitChanges();
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Briši(int idN, int id)
        {
            try 
            {
                NorthDataContext ndc = new NorthDataContext();
                var zaBrisanje = (from a in ndc.Order_Details
                                 where a.OrderID == idN && a.ProductID == id
                                 select a).FirstOrDefault();
                ndc.Order_Details.DeleteOnSubmit(zaBrisanje);
                ndc.SubmitChanges();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        public static void Vstavi(Order_Detail o)
        {
            NorthDataContext ndc = new NorthDataContext();
            try
            {
                Order_Detail od = new Order_Detail();
                od.OrderID = o.OrderID;
                od.ProductID = o.ProductID;
                od.Quantity = o.Quantity;
                od.Discount = o.Discount;
                od.UnitPrice = o.UnitPrice;
                ndc.Order_Details.InsertOnSubmit(od);
                ndc.SubmitChanges();
            }
            catch ( Exception ex)
            {
                Console.WriteLine(ex.Message); ;
            }
        }
    }
}
