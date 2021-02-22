using System;
using System.Collections.Generic;
using System.Text;

namespace _11_OOP3
{
    class DatabaseLoggerService : ILoggerService // burada Interface den miras alır ve metodlar implemente edilir ve metod içeriğinde yaplacak işler yazılır..
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına Loglandı");    
        }
    }
}
