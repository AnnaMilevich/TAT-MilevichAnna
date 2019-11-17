using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = StringCreator.CreateFromConsole();
            int max = StringCreator.GetMaxNumberOfDifferentConsecutiveChar(str);
            int maxDig = StringCreator.GetMaxNumberOfIdenticalConsecutiveDigits(str);
            int maxLetter = StringCreator.GetMaxNumberOfIdenticalConsecutiveLetter(str);
        }
    }
}
