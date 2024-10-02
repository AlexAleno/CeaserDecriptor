using System;
using System.Globalization;
using System.Reflection.Metadata;

namespace StringDecoder
{
    class Program
    {
        public static string warPeacePath = "/home/alexandre/RiderProjects/StringDecoder/Reader/WarPeace.txt";
        public static string encryptedPath = "/home/alexandre/RiderProjects/StringDecoder/Reader/Encrypted.txt";
        
        public static void Main(string[] args)
        {

        string PlainTextPath= args[0];
        string EncryptedTextPath = args[1];
        string OutputPath = args[2];
        
  
        Dictionary<char, int> plainTextValues = LetterCounter.LetterCount(PlainTextPath);
        Dictionary<char, int> encryptedTextValues = LetterCounter.LetterCount(EncryptedTextPath);

        char[] TwoValues = Comparator.Compare(plainTextValues, encryptedTextValues);

        String encryptedText = Reader.ReadLine(EncryptedTextPath);

        String output = "";
            try

        {
            int shiftval = Math.Abs(((int)TwoValues[1]) - ((int)TwoValues[0]));
            int target = 26;
            int newIndex = ((shiftval + target) % 26) - 1;
            int shiftvalM = Math.Abs(((int)TwoValues[3]) - ((int)TwoValues[2]));
            int newIndexM = ((shiftval + target) % 26) - 1;

            foreach (char c in encryptedText)
            {
                char exit = c;
                int value = ((int)c);
                if (value >= 97 && value <= 122)
                {
                    if (value + shiftval > 122)
                    {
                        int v = 97 + ((value + shiftval) - 123);
                        exit = ((char)v);
                    }
                    else
                    {
                        exit = ((char)(shiftval + value));
                    }

                }

                if (value >= 65 && value <= 90)
                {
                    if (value + shiftval > 90)
                    {
                        int v = 65 + ((value + shiftval) - 91);
                        exit = ((char)v);
                    }
                    else
                    {
                        exit = ((char)(shiftval + value));
                    }
                }
                
                output = output + exit;

                
            }

           Console.WriteLine("The shift factor of {0}",shiftval);
                       Console.WriteLine("Writing the content in the file");
            File.WriteAllText(OutputPath, output);

            Console.WriteLine("Do you want to display the output? Y/N");

            string input = Console.ReadLine();

            switch (input)
            {
                case "Y":
                    case "y":
                Console.WriteLine(output);
                break;
                case "N":
                    case "n":
                        
                        break;
            }

        }
        catch

    (KeyNotFoundException)
    {
        Console.WriteLine("Key not found");
    }



}
    }
    

    }





   
    
    
