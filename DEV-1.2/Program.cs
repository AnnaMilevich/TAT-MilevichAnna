using System;

namespace DEV_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));
            converter.ConsoleOutput();
        }
    }
}
