using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // read user input
        string name = Console.ReadLine();
        // empty set — it will automatically reject duplicate characters
        HashSet<char> seen = new HashSet<char>();
        // loops through every char in name, foreach assigns it to c
        foreach (char c in name)
            // try to add c, if it's already in the set, nothing happens
            seen.Add(c);
          
        // seen.Count is the distinct character count. even -> female, odd -> male
        Console.WriteLine(seen.Count % 2 == 0 ? "CHAT WITH HER!" : "IGNORE HIM!");
    }
}