using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class classwork
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            //int value = rand.Next(1, 100);
            //List<int> list = new List<int>();
            //List<int> add = new List<int>();
            //List<int> add1 = new List<int>();
            //int a = 1;
            //foreach (int item in list)
            //{
            //    if (item%2==0)
            //    {
            //        add.Add(item);
            //        Console.WriteLine(item);
            //    }
            //    else
            //    {
            //        add1.Add(item);
            //        Console.WriteLine(item);
            //    }
            //Console.ReadLine();
            //}






            Dictionary<string, string> dict = new Dictionary<string, string>();

            List<string> linn = new List<string> { "Tallinn", "Valga", "Parnu ", "Võru", "Ida-Viru" };
            List<string> maakond = new List<string> { "Harjumaa", "Valgamaa", "Parnumaa ", "Võrumaa", "Ida-Virumaa" };
            bool wantTo = true;
            int randInt = 0;
            double score = 0;

            for (int i = 0; i < maakond.Count; i++)
            {
                dict.Add(maakond[i], linn[i]);
                dict.Add(linn[i], maakond[i]);
            }
            while (wantTo == true)
            {

                Console.WriteLine("Search linn/maakond - 1, test - 2");
                int answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    Console.Write("Entry linn/maakond: ");
                    string input = Console.ReadLine();
                    if (dict.ContainsKey(input))
                    {
                        Console.WriteLine("This is " + input + " is " + dict[input]);
                    }
                    else if (!dict.ContainsKey(input))
                    {
                        Console.WriteLine("you want add new words? yes - 1, no - 2");
                        answer = int.Parse(Console.ReadLine());
                        if (answer == 1)
                        {
                            Console.WriteLine("Enter new maakond");
                            string new1 = Console.ReadLine();

                            Console.WriteLine("Enter new linn");
                            string new2 = Console.ReadLine();
                            dict.Add(new1, new2);
                            dict.Add(new2, new1);
                        }
                    }
                }
                else if (answer == 2)
                {
                    score = 0;
                    for (int i = 0; i < maakond.Count; i++)
                    {
                        randInt = rnd.Next(1, 3);
                        int b = rnd.Next(1, maakond.Count);
                        if (randInt == 1)
                        {
                            Console.WriteLine("This is - " + maakond[b]);
                            string userInput = Console.ReadLine();
                            if (linn.IndexOf(userInput) == maakond.IndexOf(maakond[b]))
                            {
                                Console.WriteLine("Yes!");
                                score++;
                            }
                        }
                        else if (randInt == 2)
                        {
                            Console.WriteLine("This is - " + linn[b]);
                            string userInput = Console.ReadLine();
                            if (maakond.IndexOf(userInput) == linn.IndexOf(linn[b]))
                            {
                                Console.WriteLine("Yes!");
                                score++;
                            }
                        }
                    }
                    Console.WriteLine(score / maakond.Count * 100 + "%");
                }
            }
        }
    }
}
