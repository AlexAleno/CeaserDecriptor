using System.Xml;

namespace StringDecoder;

public class Comparator()
{
    public static char[] Compare (Dictionary<char, int> dictionary1, Dictionary<char, int> dictionary2)
    {
        
        int biggestNPlain = 0;
        int biggestNEnc = 0;
        char biggestPlain='e';
        char biggestEncrypted='e';
        int biggestNPlain1 = 0;
        int biggestNEnc1 = 0;
        char biggestPlain1='e';
        char biggestEncrypted1='e';
        
            
            for (int f=97;f <122;f++)
            {
                if (dictionary1[(char)f]>biggestNPlain)
                {
                    biggestNPlain = dictionary1[(char)f];
                    biggestPlain = (char)f;
                }

                if (dictionary2[(char)f]>biggestNEnc)
                {
                    biggestNEnc = dictionary2[(char)f];
                    biggestEncrypted = (char)f;
                }

            }  
            
        
        
            
            for (int f=65;f <90;f++)
            {
                if (dictionary1[(char)f]>biggestNPlain1)
                {
                    biggestNPlain1 = dictionary1[(char)f];
                    biggestPlain1 = (char)f;
                }

                if (dictionary2[(char)f]>biggestNEnc1)
                {
                    biggestNEnc1 = dictionary2[(char)f];
                    biggestEncrypted1 = (char)f;
                }

            }  
            
        

        char[] Records = {biggestPlain,biggestEncrypted,biggestPlain1,biggestEncrypted1};

        return Records;

    }
  
    

}