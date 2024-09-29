namespace StringDecoder;

class Reader
{
    public static string ReadLine(string fullpath)
    {
        string textString = File.ReadAllText(fullpath);
        return textString;
    }
}
