using System.Text;
using System;

namespace DEV_3
{
    class Program
    {
        static void Main(string[] args)
        {
           
                string inputString = StringCreator.CreateFromConsole();
                StringTranslator stringTranslator = new StringTranslator(inputString.ToLower());
                
                StringBuilder finalString = stringTranslator.GetFinalString();
            
           
        }
    }
}
