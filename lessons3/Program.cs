using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._10._19
{
    class Program
    {
        static void Main(string[] args)
        {
            //1

            int min, max;
            Console.Write("Size= ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Size1= ");
            max = Convert.ToInt32(Console.ReadLine());
            if (max < min)
            {
                int tmp = max;
                max = min;
                min = tmp;
            }

            Random rand = new Random();
            int[] arr = new int[min];
            int[] mas = new int[max];
            for (int i = 0; i < min; i++)
            {
                arr[i] = rand.Next(0, 100);
            }
            for (int i = 0; i < max; i++)
            {
                mas[i] = rand.Next(0, 100);
            }

            for (int i = 0; i < max; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
            int cen = (max / 2) + 1;
            //Console.WriteLine((cen - (min / 2)) + " " + (cen + min / 2));

            for (int i = cen - (min / 2) - 1, j = 0; i < cen + (min / 2); i++)
            {
                mas[i] = arr[j];
                j++;
            }

            for (int i = 0; i < min; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < max; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();


            //2
            //for (int i = 1; i < 13; i++)
            //{
            //    Console.WriteLine("Month: " + i + " ,day: " + (28 + (i + i / 8) % 2 + 2 % i + 2 * (1 / i)));
            //}

            //3
            //Random rand = new Random();
            //char str;
            //int x = 0, y = 0, z = 0, hp = 100;
            //char[] arr = new char[] { '*', '-', '-', '-', '-', '-', '-', '-', '-', '-' };
            //y = rand.Next(1, 9);
            //do
            //{
            //    z = rand.Next(1, 9);
            //} while (y == z);
            //arr[y] = '%';
            //arr[z] = '$';
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.Write("Hp: " + hp);
            //Console.WriteLine();
            //while (true)
            //{
            //    Console.Write("-> ");
            //    str = Convert.ToChar(Console.ReadLine());
            //    switch (str)
            //    {
            //        case 'a':
            //            {
            //                if(x > 0)
            //                {
            //                    char tmp = arr[x];
            //                    arr[x] = arr[x - 1];
            //                    arr[x - 1] = tmp;
            //                    x--;
            //                }
            //                break;
            //            }
            //        case 'd':
            //            { 
            //                char tmp = arr[x];
            //                arr[x] = arr[x + 1];
            //                arr[x + 1] = tmp;
            //                x++;
            //                break;
            //            }
            //    }
            //    if(x == (arr.Length - 1))
            //    {
            //        break;
            //    }
            //    if (x == y)
            //    {
            //        arr[x] = '*';
            //        arr[x - 1] = '-';
            //        hp -= 50;
            //    }
            //    if (x == z)
            //    {
            //        arr[x] = '*';
            //        arr[x - 1] = '-';
            //        hp += 50;
            //    }
            //    for (int i = 0;i < arr.Length;i++)
            //    {
            //        Console.Write(arr[i] + " ");
            //    }
            //    Console.Write("Hp: " + hp);
            //    Console.WriteLine();
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.Write("Hp: " + hp);
            //Console.WriteLine();
        }
    }
}
