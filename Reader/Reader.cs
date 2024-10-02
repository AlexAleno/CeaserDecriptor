namespace StringDecoder;

class Reader
{
    public static string ReadLine(string fullpath)
    {
        string textString = File.ReadAllText(fullpath);
        Console.WriteLine("reading ..."+fullpath);
        return textString;
    }
}
