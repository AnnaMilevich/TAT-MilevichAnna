using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_2
{
    public static class StringCreator
    {
        public static string CreateFromConsole()
        {
            Console.WriteLine("Input string");
            string str = Console.ReadLine();
            return str;
        }
        public static int GetMaxNumberOfDifferentConsecutiveChar(string str)
        {
            if (str == "")
            {
                throw new ArgumentOutOfRangeException("String cannot be empty");
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < 48 || (str[i] > 57 && str[i] < 65) || (str[i] > 90 && str[i] < 97) || str[i] > 122)
                {
                    throw new ArgumentOutOfRangeException("String cannot contain such characters");
                }
            }
            int maxcount = 1;
            int count = 1;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] != str[i + 1])
                {
                    if(count==0)
                    {
                        count+=1;
                    }
                    count += 1;
                }
                else
                {
                    if (maxcount <= count)
                    {
                        maxcount = count;
                    }
                    count = 0;

                }
            }
            if (maxcount < count)
            {
                maxcount = count;
            }
            Console.WriteLine(maxcount);
            return maxcount;
        }
        public static int GetMaxNumberOfIdenticalConsecutiveDigits(string str)
        {
            if (str == "")
            {
                throw new ArgumentOutOfRangeException("String cannot be empty");
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < 48 || (str[i] > 57 && str[i] < 65) || (str[i] > 90 && str[i] < 97) || str[i] > 122)
                {
                    throw new ArgumentOutOfRangeException("String cannot contain such characters");
                }
            }
            int count = 0;
            int maxCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < 58 && str[i] > 43)
                {
                    count = 1;
                    maxCount = 1;
                }
            }
            for (int i = 0; i < str.Length-1; i++)
            {
                if (str[i] < 58 && str[i] > 43 && str[i] == str[i + 1])
                {
                    
                        if (count == 0)
                        {
                            count+=1;
                        }
                        count += 1;
                    
                }
                else
                {
                    if (maxCount <= count)
                    {
                        maxCount = count;
                    }
                    count = 0;
                }
            }
            if (maxCount < count)
            {
                maxCount = count;
            }
            Console.WriteLine(maxCount);
            return maxCount;
        }
        public static int GetMaxNumberOfIdenticalConsecutiveLetter(string str)
        {
            if (str == "")
            {
                throw new ArgumentOutOfRangeException("String cannot be empty");
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < 48 || (str[i] > 57 && str[i] < 65) || (str[i] > 90 && str[i] < 97) || str[i] > 122)
                {
                    throw new ArgumentOutOfRangeException("String cannot contain such characters");
                }
            }
            int count = 0;
            int maxCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] < 123 && str[i] > 96) || (str[i] < 91 && str[i] > 64))
                {
                    count = 1;
                    maxCount = 1;
                }
            }
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (((str[i] < 123 && str[i] > 96) || (str[i] < 91 && str[i] > 64)) && str[i] == str[i + 1])
                {
                    if (count == 0)
                    {
                        count++;
                    }
                    count += 1;
                }
                else
                {
                    if (maxCount < count)
                    {
                        maxCount = count;
                        count = 1;
                    }
                }
            }
            if (maxCount < count)
            {
                maxCount = count;
            }
            Console.WriteLine(maxCount);
            return maxCount;
        }
    }
}
