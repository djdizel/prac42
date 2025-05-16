using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создание экземпляров классов 
            ClassCounter counter = new ClassCounter();
            Handler_I handler_1 = new Handler_I();
            Handler_II handler_2 = new Handler_II();
            //Счетчик
            counter.Count();
            //Добавляем действия в события
            counter.onCount += handler_1.Message;
            counter.onCount += handler_2.Message;
            counter.onCount += counter.Message;
            //Вызов события
            counter.Count();
            Console.ReadLine();
        }
    }
}
