using System;
using System.IO;

class Program 
{
  static void Main ()
  {
    string put = "numsTask1.txt";

    Random random = new Random();

    Console.WriteLine("Enter the number of lines: ");
    int n = Convert.ToInt32(Console.ReadLine());
    
    string[] speech = new string[n];


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
    }
    string row = string.Join(" ", speech);
    File.AppendAllText(put, row + "\n" + "Words with an odd length: " + "\n");

    Console.WriteLine("Words with an odd length: "); 
    foreach (string word in speech) 
    {
        if (word.Length % 2 != 0) 
        {
           Console.WriteLine(word); 
           File.AppendAllText(put, word + "\n");
        }
    }

    Console.ReadKey();
    File.Delete(put);  
  }
}