using System.Text;

namespace DEV_3
{
    public class StringTranslator // this class translates a string.
    {
       
        private readonly string[] _lettersRussian = { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о",
                                        "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ","ъ", "ы", "ь","э", "ю", "я"," "};
        private readonly string[] _lettersTranscription = { "a", "b", "v", "g", "d", "e", "yo", "zh", "z", "i", "y", "k", "l", "m", "n", "o",
                                        "p", "r", "s", "t", "u", "f", "kh", "ts", "ch", "sh", "sch", "-", "y", "-", "e", "yu", "ya", " "};
        string inputString;

        public StringTranslator(string inputString)
        {
            this.inputString=inputString;
        }

        public bool GetOptionOfWritingString() // this method determines the language of the input string.
        {
            const int _leftBorderOfTranslite = 96;
            const int _rightBorderOfTranslite = 123;
            bool translit = false;

            foreach (char letter in inputString)
            {
                if ((int)letter < _rightBorderOfTranslite && (int)letter > _leftBorderOfTranslite)
                {
                    translit = true;
                    break;
                }
            }
            return translit;
        }

        public StringBuilder GetFinalString() // this method returns the translated final version of the string.
        {
            StringBuilder finalString = new StringBuilder();
           
            return  finalString = GetOptionOfWritingString() ? GetStringConverterToRussian() : GetStringConverterToTransliteration();
           
        }
        public StringBuilder GetStringConverterToRussian() // this method translates the string into Russian
        {
            StringBuilder convertedString = new StringBuilder();
           
            for (int i=0; i<inputString.Length;i++)
            {
                StringBuilder letterFromString = new StringBuilder();

                if ( i<(inputString.Length-1) &&  inputString[i + 1].Equals('h') )
                {
                    letterFromString.Append(inputString[i]).Append(inputString[i+1]);
                    i++;
                }
                else if ( inputString[i].Equals('y') && i < (inputString.Length-1) && (inputString[i+1].Equals('o') || 
                          inputString[i+1].Equals('u') || inputString[i+1].Equals('a')))
                     {
                        letterFromString.Append(inputString[i - 1]).Append(inputString[i]);
                     }  
                else
                {
                    letterFromString.Append(inputString[i]);
                }
                convertedString.Append(_lettersRussian[GetIndexLetter(letterFromString.ToString())]);
            }
            return convertedString;
        }

        public StringBuilder GetStringConverterToTransliteration() // this method in translating a string into English
        {
            StringBuilder convertedString = new StringBuilder();
            foreach ( char letterFromString in inputString)
            {
                
                convertedString.Append( _lettersTranscription[GetIndexLetter(letterFromString.ToString())]);   
            }

            return convertedString.Replace("-",""); 
        }
        public int GetIndexLetter( string letterFromString) // returns the index from a letter from a array
        {
            int count = 0;
            int indexLetter = 0;

            if (GetOptionOfWritingString())
            {
                foreach (string letterTranslit in _lettersTranscription)
                {
                    if (letterFromString.Equals(letterTranslit))
                    {
                        indexLetter = count;
                        break;
                    }
                    count++;
                }
                return indexLetter;
            }
            else
            {
                foreach (string letterRus in _lettersRussian)
                {
                    if (letterFromString.Equals(letterRus))
                    {
                        indexLetter = count;
                        break;
                    }
                    count++;
                }
                return indexLetter;
            }
        }
    }
}
