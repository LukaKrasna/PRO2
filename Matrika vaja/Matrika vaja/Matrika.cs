using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrika_vaja
{
    internal class Matrika
    {
        public double[,] m = new double[3, 3];
        public double this[int row, int col]
        {
            get { return m[row, col]; }
            set { m[row, col] = value; }
        }

        public static Matrika operator +(Matrika m1, Matrika m2)
        {
            Matrika result = new Matrika();
            for (int row = 0; row < 3; row++)
            {
                for(int col = 0; col < 3; col++)
                {
                    result[row, col] = m1[row, col] + m2[row, col];
                }
            }
            return result;
        }

        public void Tiskaj()
        {
            for(int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(this[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
