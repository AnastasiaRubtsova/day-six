using System;
using System.IO;

class Program 
{
  static void Main ()
  {
    string put = "numsTask2.txt";

    Random random = new Random();

    Console.WriteLine("Enter the number of lines: ");
    int n = Convert.ToInt32(Console.ReadLine());

    string[] speech = new string[n];

     Console.WriteLine("Original appearance: "); 
    for (int i = 0; i < speech.Length; i++) 
    {
        int length = random.Next(1, 10); 
        string word = "";

        for (int j = 0; j < length; j++)
        {
            char character = (char)random.Next('a', 'z' + 1); 
            word += character; 
        }
        speech[i] = word; 
        Console.WriteLine(speech[i]); 
        string line = string.Join("\n", speech[i]);
    }
    string combinedSpeech = "";
    


    for (int i = 0; i < speech.Length; i++)
    {
        combinedSpeech += speech[i];
        if (i < speech.Length - 1) combinedSpeech += " ";
    }

    Console.WriteLine("Connected strings: " + combinedSpeech);

    Console.ReadKey();
    File.Delete(put); 
  }
}