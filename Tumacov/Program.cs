using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tumacov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            lab22();
        }
        public static void lab21()
        {
            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();       // вводим имя
            Console.WriteLine($"Привет, {name}"); ;    // выводим имя на консоль
        }
        public static void lab22()
        {
            try
            {
                Console.WriteLine("Задача 2.2 На вход подается два  целых числа, на выходе – результат деления одного числа на другое.");
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                int div = x / y;
                Console.WriteLine($"Результат деления:{div}");
            }
            catch (System.DivideByZeroException ex)
            {
                Console.WriteLine("Делить на ноль нельзя");
            }
            Console.ReadKey();
        }
        public static void dz21()
        {
            var a = Char.Parse(Console.ReadLine());//считываем с консоли бувку
            var res = Aplphavite(a);//получаем следущий по алфавиту символ
            Console.WriteLine(res);//выводим на консоль
            Console.ReadKey();
        }
        public static char Aplphavite(char c)
        {
            var str = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";//в этой сроке храним алфавит
            int i = str.LastIndexOf(c);//находим индекс c в алфавите
            i++;//увеличивем его на один
            if (i == str.Length) i = 0;//если символ вышел за пределы массива, прирваниваем его к А
            return str[i];//возвращаем следующий после c символ
        }
        public static void dz22()
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            int c = int.Parse(Console.ReadLine());
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D < 0) Console.WriteLine("У уравнения нет корней");
            else
            {
                double x1 = -(b - Math.Sqrt(D)) / 2;
                double x2 = -(b + Math.Sqrt(D)) / 2;

                if (x1 == x2)
                {
                    Console.WriteLine("У уравнения только один корень: x={0}", x1);
                }
                else
                {
                    Console.WriteLine($"У уравнения два корня: x1={0}; x2={1}", x1, x2);
                }

            }
            Console.ReadKey();
        }

    }



    }
        



    
}
