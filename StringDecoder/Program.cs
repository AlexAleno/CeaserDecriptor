using System;

    
    
    

    string toEncode = "This is a test";
    var byteArray = System.Text.ASCIIEncoding.Default.GetBytes(toEncode);

    Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
    
    keyValuePairs.Add('a',55);
    keyValuePairs.Add('b',100);
    keyValuePairs.Add('c',200);
    keyValuePairs.Add('d',20);
    
    var maxValue = keyValuePairs.OrderBy(x => x.Value).Last();
    
    
    Console.WriteLine(maxValue);



    static void main(string[] args)
    {
        if (args.Length == 1)
        {
            Console.WriteLine("Received 1 argument");
            Console.WriteLine("Received 1 argument" + args);
        }


    }