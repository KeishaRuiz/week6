using System;
using System.Collections.Generic;

namespace Week6
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem1();
            Problem2();

        }

        static void Problem1()
        {


            {
                var names = new List<string>();

                while (true)
                {
                    var name = askName();

                    if (string.IsNullOrEmpty(name))
                        break;

                    names.Add(name);
                    Console.WriteLine(likesMessage(names));
                }
            }

            string askName()
            {
                Console.WriteLine("enter a name: press Enter to stop");
                return Console.ReadLine();
            }

            string likesMessage(List<string> names)
            {
                if (names.Count > 2)
                    return names[0] + ", "  + names[1] + " and " + getLikes(names).Count + " others liked your post";

                if (names.Count == 2)
                    return names[0]  + names[1] + " liked your post ";

                return names[0] + " liked your post";
            }

            static List<string> getLikes(List<string> names)
            {
                return names.GetRange(2, names.Count - 2);
            }
        }

          












        static void Problem2()
        {

            Run();

        }

        public static void Run()
        {
            Dictionary<char, int> properties = new Dictionary<char, int>();

            Console.WriteLine("Write a short sentence:");

            string stuff = Console.ReadLine();

            for(int i = 0; i < stuff.Length; i++)
            {
                Console.WriteLine(stuff[i]);

                if (!properties.ContainsKey(stuff[i]))
                {

                    properties.Add(stuff[i], 1);

                }


                else
                {
                    properties[stuff[i]] = properties[stuff[i]] + 1;
                }
            }

            foreach (KeyValuePair<char, int> kvp in properties)
            {
                Console.WriteLine(kvp.Key + " = " + kvp.Value);
            }
        }

      

    }
}










