using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Zadacha
{
    class zadacha2MidExam
    {
        static void Main(string[] args)
        {
            List<string> num = Console.ReadLine()
                .Split()
                .ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();

                string name = arguments[0];

                if (name == "reverse")
                {
                    int index = int.Parse(arguments[2]);
                    int count = int.Parse(arguments[4]);

                    num.Reverse(index, count);
                }
                else if (name == "sort")
                {
                    int index = int.Parse(arguments[2]);
                    int count = int.Parse(arguments[4]);
                    num.Sort(index, count, StringComparer.Ordinal);
                }
                else if (name == "remove")
                {
                    int index = int.Parse(arguments[1]);
                    num.RemoveRange(0, index);

                }
            }
            Console.WriteLine(string.Join(", ", num));
        }
    }
}
