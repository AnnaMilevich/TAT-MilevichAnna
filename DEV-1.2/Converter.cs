using System;
using System.Collections.Generic;

namespace DEV_1._2
{
    /// <summary>
    /// Class for converting numbers to another number system
    /// </summary>
    public class Converter
    {
        int inputValue10;
        int numberSystem;

        /// <summary>
        /// Class constuctor initializes fields
        /// </summary>
        /// <param name="inputValue10"></param>
        /// <param name="numberSystem"></param>
        public Converter(int inputValue10, int numberSystem)
        {
            this.inputValue10 = inputValue10;
            this.numberSystem = numberSystem;
        }

        /// <summary>
        /// Number conversion method
        /// </summary>
        /// <returns></returns>
        private int NumberConversion()
        {
            int divident = inputValue10;
            int temp = 0;
            List<int> numbers = new List<int>();
            while (divident > 0)
            {
                temp = divident % numberSystem;
                divident = divident / numberSystem;
                numbers.Add(temp);
            }
            return ReversOrder(numbers);
        }

        /// <summary>
        /// The method forms the final result
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        private int ReversOrder(List<int> numbers)
        {
            int[] s = new int[numbers.Count];
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                s[numbers.Count - 1 - i] = numbers[i];
            }
            return Convert.ToInt32(string.Join<int>("", s));
        }

        /// <summary>
        /// The method prints the result to the console
        /// </summary>
        public void ConsoleOutput()
        {
            Console.WriteLine(NumberConversion());
        }
    }
}
