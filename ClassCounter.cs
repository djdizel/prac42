using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac42
{
    class ClassCounter
    {
        /// <summary>
        /// Делегат MethodContainer
        /// </summary>
        public delegate void MethodContainer();
        /// <summary>
        /// Событие onCount
        /// </summary>
        public event MethodContainer onCount;
        public void Count()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if ((i == 7) && (onCount != null))
                {
                    onCount();
                }
            }
        }
        public void Message()
        {
            Console.WriteLine("У себя 7!");
        }
    }
}
