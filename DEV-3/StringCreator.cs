using System;

namespace DEV_3
{
    public static class StringCreator // this class creates a string
    {
        public static string CreateFromConsole() // create a string using the console
        {
            Console.WriteLine("Enter the string");
            string inputString = Console.ReadLine().ToLower();
            if (inputString.Length==0)
                {
                    throw new InvalidCharInputException("String cannot be empty"); 
                }
            for (int i = 0; i < inputString.Length; i++)
            {
                if ( inputString[i] < 97 || (inputString[i] > 122 && inputString[i] < 192)  
                    || inputString[i] == 74 || inputString[i] == 106 )
                {
                    throw new InvalidCharInputException("String cannot contain such characters");
                }
            }
            int count = 0;
             for (int i = 0; i < inputString.Length; i++)
             {
                 if (inputString[i] > 96 && inputString[i]<123)
                 {   count++;
                     
                 }
             }
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] > 1071 && inputString[i] < 1103 && count != 0)
                {
                    throw new InvalidCharInputException("String cannot contain such characters");
                }
            }
            return inputString;
        }
    }
}
