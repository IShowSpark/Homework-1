//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Homework
//{
//    class spisk
//    {
//        static void Main(string[] args)
//        {

//            Dictionary<int, string> athletes = new Dictionary<int, string>(5);
//            for (int i = 1; i < 6; i++)
//            {
//                Console.WriteLine($"Value {i}");
//                athletes.Add(i,Console.ReadLine());
//            }
//            Console.WriteLine(athletes[1]);
//            athletes.Remove(4);
//            foreach (KeyValuePair<int,string> kv in athletes)
//            {
//                Console.WriteLine(kv.Key+".place" +kv.Value);
//            }


//            LinkedList<int> list = new LinkedList<int>();
//            for (int i = 1; i < 10; i++)
//            {
//                list.AddFirst(i);
//                if (i%2!=0)
//                {
//                    list.Remove(i);
//                }
//            }
//            foreach (int item in list)
//            {
//                Console.WriteLine(item);
//            }





//            List<people> peopled = new List<people>();
//            peopled.Add(new people() { Name = "Bebra" });
//            peopled.Add(new people() { Name = "Speed" });

//            foreach (people people in peopled)
//            {
//                Console.WriteLine(people.Name);
//            }



//            string[] name1 = new string[3] { "Bebra", "Bebrous", "Bebroid" };
//            List<string> names = new List<string>(name1);
//            Console.WriteLine("Enter a name");
//            names.Add(Console.ReadLine());
//            names.Insert(0, "Artjom");
//            if (names.Contains("Artjom"))
//            {
//                Console.WriteLine("This name exists"+"it is {0} in place",names.IndexOf("Artjom"));
//            }
//            else
//            {
//                Console.WriteLine("This name not exists");
//            }
//            foreach (string name in names)
//            {
//                Console.WriteLine(name);
//            }
//            Console.ReadKey();
//        }
//    }
//}
