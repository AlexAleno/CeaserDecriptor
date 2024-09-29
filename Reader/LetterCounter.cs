namespace StringDecoder;

public class LetterCounter
{
 
    public static Dictionary<char,int> LetterCount(String path)
    {
        
        Dictionary<char, int> letterOccurence = new Dictionary<char, int>();
        
        for (int x = 97; x <= 122; x++)
        {
            letterOccurence.Add((char)x,0);
        }
        for (int x = 65; x <= 90; x++)
        {
            letterOccurence.Add((char)x,0);
        }

        String tocount = Reader.ReadLine(path);

       foreach (char c in tocount)
         {
            if (letterOccurence.ContainsKey(c))
            {

                letterOccurence[c]++;
        }
    }


        return letterOccurence;
    }


}