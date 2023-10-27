using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generiki
{
    internal class SkladGen<T>
    {
        int m_size;
        int m_StackPointer;
        T[] m_Items;
        public SkladGen(int velikost)
        {
            m_size = velikost;
            m_Items = new T[m_size];
            m_StackPointer = 0;
        }
        public void Push(T item)
        {
            if (m_StackPointer >= m_size)
                throw new StackOverflowException();
            m_Items[m_StackPointer] = item;
            m_StackPointer++;
        }
        public T Pop()
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
