using System;
string word = Console.ReadLine();
int n = int.Parse(word);
for (int i = 0; i < n; i++)
{
    string newWord = Console.ReadLine();

    if(newWord.Length > 10)
    {
        Console.Write(newWord[0]);
        Console.Write(newWord.Length - 2);
        Console.WriteLine(newWord[newWord.Length - 1]);
    }
    else
    {
        Console.WriteLine(newWord);
    }
}