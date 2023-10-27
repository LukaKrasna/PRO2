using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Vaja1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. naloga
            //"Znak
            //A ima kodo 65".
            //Program naj izpiše ustrezne stavke za znake A, B, a, b, $, + in /.
            //char črka = 'A';
            //int koda = črka;
            //Console.WriteLine("Znak " + črka + " ima kodo " + koda);
            //Console.ReadLine();

            //(Del 2. naloge)
            Console.WriteLine("5!= " + fakulteta(5));
            //Console.ReadLine();

            //(Del 3. naloge)
            Console.WriteLine("5!= " + rekurzija(5));
            //Console.ReadLine();

            //(Del 4. naloge)
            Console.WriteLine("2 na 10 je " + potenca2(10));
            //Console.ReadLine();

            //(Del 5. naloge)
            Console.WriteLine("8 Fibonaccijevo število je " + Fib(8));
            //Console.ReadLine();

            //(Del 6. naloge)
            Console.WriteLine("2. člen je " + Fib2(2) + " in 5. člen je " + Fib2(5));
            //Console.ReadLine();

            //(Del 7. naloge)
            Console.WriteLine("2. člen je " + Fib3(2) + " in 5. člen je " + Fib3(5));
            //Console.ReadLine();

            //(Del 8. naloge)
            Console.WriteLine("2. člen je " + Fib4(2) + " in 5. člen je " + Fib4(5));
            Console.ReadLine();

        }
        //2. naloga
        //Napišite program, s katerim preberete nenegativno celo število in izpišite njegovo fakulteto.
        //Fakulteta števila n je definirana n!=n.(n-1).(n-2)….3.2.1. Primer 5!=5.4.3.2.1=120.
        static int fakulteta(int n)
        {
            int produkt = 1;
            for (int k = n; k > 0; k--)
            {
                produkt = produkt * k;
            }
            return produkt;
        }
        //3. naloga
        static int rekurzija(int n)
        {
            if (n == 0)
                return 1;
            return n * rekurzija(n - 1);
        }
        //4. naloga
        static int potenca2(int n)
        {
            if (n == 0)
                return 1;
            return 2 * potenca2(n - 1);
        }
        //5. naloga
        //Podano je zaporedje:1,1,2,3,5,8,13,21,34, ...
        //F1 = 1
        //F2 = 1
        //Fa= Fn-1 + Fn-2
        static int Fib(int n)
        {
            if (n==1) return 1;
            if (n == 2) return 1;
            return Fib(n - 1) + Fib(n - 2);
        }

        /*
        6. naloga
        Podano je zaporedje: 2, 2, 3, 5, 14, 69, 965, ...
a. Z uporabo rekurzije napišite metodo, ki vrne n-ti element zaporedja.
b. Napišite sled izvajanja programa za klic test.clen(2) in test.clen(5)!
Upoštevajte, da je zaporedje definirano:
a1 = 2
a2 = 2
a(n) = a(n-2)*a(n-1) – 1 
        */
        static int Fib2(int n)
        {
            if (n == 1) return 2;
            if (n == 2) return 2;
            return Fib2(n-2)*Fib2(n-1) - 1;
        }

        /*
        7. naloga
        Podano je zaporedje: 2, 8, 26, 80, 242, ...
a. Z uporabo rekurzije napišite metodo, ki vrne n-ti element zaporedja.
b. Napišite sled izvajanja programa za klic test.clen(2) in test.clen(5).
Upoštevajte, da je zaporedje definirano:
a1 = 2
a(n) = 3 * a(n-1) + 2
        */
        static int Fib3(int n)
        {
            if (n == 1) return 2;
            if (n == 2) return 8;
            return 3 * Fib3(n - 1) + 2;
        }

        /*
        8. naloga
        Podano je zaporedje:: 1, 2, 5, 12, 29, …
a. Z uporabo rekurzije napišite metodo, ki vrne n-ti element zaporedja.
Upoštevajte, da je zaporedje definirano:
a1 = 1
a2 = 2
a(n) = a(n-1)*2 + a(n-2)
        */
        static int Fib4(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
            return Fib4(n - 1) * 2 + Fib4(n - 2);
        }
    }
}
