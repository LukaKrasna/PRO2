using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._10._2023__Ho_ //90% plača od kupec
{
    internal class ZlatniKupec:Kupec
    {
        public override void BeležiKlic(int minute, int tip)
        {
            base.BeležiKlic(minute, tip);
            stanje *= 0.9m;
        }
    }
}
