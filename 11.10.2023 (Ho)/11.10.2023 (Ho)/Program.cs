using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._10._2023__Ho_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kupec Janez = new Kupec();
            //Janez.Ime = "Janez Novak";
            //Janez.BeležiKlic(100, 2);
            //    //Console.WriteLine(Janez.Ime+" dolguje "+Janez.Stanje);
            //Console.WriteLine(Janez.ToString()); //12.10

            ////12.10.2023
            //Console.WriteLine();
            //Console.WriteLine( "Janez.getType " + Janez.GetType() );
            //Console.WriteLine( "Janez.tostring " + Janez.ToString() );
            //Console.WriteLine();

            //Kupec60  Alenka= new Kupec60();
            //Alenka.Ime = "Alenka Prinčič";
            //Alenka.BeležiKlic(100, 1);
            //    //Console.WriteLine(Alenka.Ime + " dolguje " + Alenka.Stanje); 
            //Console.WriteLine(Alenka.ToString() ); //12.10


            //12.10
            Kupec[] vsiKupci = new Kupec[2];
            vsiKupci[0]=new Kupec();
            vsiKupci[1]=new Kupec60();

            vsiKupci[0].Ime = "Janez Novak";
            vsiKupci[0].BeležiKlic(100, 2);

            vsiKupci[1].Ime = "Alenka Prinčič";
            vsiKupci[1].BeležiKlic(100, 1);

            for(int k=0; k<2; k++)
            {
                Console.WriteLine(vsiKupci[k].ToString());
            }
            Console.ReadLine();
        }
    }
}
