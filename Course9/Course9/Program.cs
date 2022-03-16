using System;
using System.IO;
using System.Collections.Generic;

namespace Course9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    Dictionary<string, int> Dic = new Dictionary<string, int>();
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        int n = int.Parse(line[1]);

                        if (!Dic.ContainsKey(line[0]))
                        {
                            Dic.Add(line[0], n);
                        }
                        else
                        {
                            Dic[line[0]] = Dic.GetValueOrDefault(line[0]) + n;
                        }
                    }
                    foreach (var dic in Dic)
                    {
                        Console.WriteLine(dic.Key + ": " + dic.Value);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.Write("An error occurred: ");
                Console.Write(ex.Message);

            }
        }
    }
}