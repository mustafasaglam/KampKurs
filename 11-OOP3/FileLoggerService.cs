using System;

namespace _11_OOP3
{
    class FileLoggerService : ILoggerService // burada Interface den miras alır ve metodlar implemente edilir ve metod içeriğinde yaplacak işler yazılır..
        //Buradada dosyaya loglama işlemi yapmak istedik.
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı");
        }
    }
}
