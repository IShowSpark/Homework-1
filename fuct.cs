using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class fuct
    {

        public static int bebra(int arv1, int arv2)
        {
            int k = arv1 * arv2;
            return k;
        } 
        public static int[] arvud(int n)
        {
            int arv;
            int[] arv1 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Введи {0} число:", i + 1);
                arv = int.Parse(Console.ReadLine());
                arv1[i] = arv;
            }
            Array.Sort(arv1);

            int arv2 = 0;
            Array.Reverse(arv1);
            foreach (var a in arv1)
            {
                arv2 = arv2 * 10 + a;
            }
            Console.Write(arv2);

            return arv1;
            
        }
        public static double average()
        {
            Random a = new Random();
            int rand = a.Next(1, 100);
            int sum = 0;
            Console.WriteLine("Введите сколько чисел вам надо");
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                sum += a.Next(1, 100);
            }
            Console.WriteLine(sum/length);
            return sum;
            
        }
        public static string Calc()
        {
            double a;
            double b;
            double total;
            char oper;
            Console.WriteLine("Введите первое число");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите действие");
            oper = Convert.ToChar(Console.ReadLine());
            if (oper == '+')
            {
                total = a + b;
            }
            

        }
        public static int[] Stars(int a)
        {
            Console.WriteLine("Введите сколько звезд хотите увидеть");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.Write("* ");
                }
        }
    }
}
