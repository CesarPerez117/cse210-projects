using System;
using System.Collections.Generic;

class Dictionary
{
    static void Main(string[] args)
    {
        // Create a dictionary with string keys and List<int> values
        Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();

        // Add some values to the dictionary
        dict.Add("key1", new List<int>() { 1, 2, 3 });
        dict.Add("key2", new List<int>() { 4, 5 });
        dict.Add("key3", new List<int>() { 6 });

        // Access the values for a particular key
        List<int> valuesForKey1 = dict["key1"];

        // Add a value to a particular key
        dict["key2"].Add(6);

        // Print the values in the dictionary
        foreach (KeyValuePair<string, List<int>> kvp in dict)
        {
            Console.WriteLine("Key = {0}, Values = {1}", kvp.Key, string.Join(",", kvp.Value));
        }
    }
}
