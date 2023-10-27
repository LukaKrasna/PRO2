using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generiki
{
    internal class Sklad
    {
        int m_size;
        int m_StackPointer;
        object[] m_Items;
        public Sklad(int velikost)
        {
            m_size = velikost;
            m_Items = new object[m_size];
            m_StackPointer = 0;
        }
        public void Push(object item)
        {
            if (m_StackPointer >= m_size)
                throw new StackOverflowException();
            m_Items[m_StackPointer] = item;
            m_StackPointer++;
        }
        public object Pop()
        {
            m_StackPointer--;
            if (m_StackPointer >= 0)
                return m_Items[m_StackPointer];
            else
            {
                m_StackPointer = 0;
                throw new InvalidOperationException("Sklad je prazen");
            }
        }
    }
}
