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
            //Random rand = new Random();
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




            List<int> beginning = new List<int>();
            List<int> ending = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                beginning.Add(int.Parse(Console.ReadLine()));
            }
            int a1 = beginning[0];
            int a2 = beginning[beginning.Count - 1];
            beginning.Insert(0, a2);
            beginning.Add(a1);
        }
    }
}
