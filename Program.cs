using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>();
            arr.Add(2);
            arr.Add(3);
            arr.Add(5);
            arr.Add(7);
            //Список чисел 2 и нечётные до 1 000 000 с первичной обработкой;
            for (int i = 11; i < 1000000; i += 2)
                if (i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
                    arr.Add(i);
            //Поиск простых чисел от 2 до 1 000 000;
            Console.WriteLine("Выполняется обработка...");
            int x = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                x = arr[i];
                for (int j = i + 1; j < arr.Count; j++)
                    if (arr[j] % x == 0)
                    {
                        arr.RemoveAt(j);
                        j--;
                    }
            }
            //Поиск circular prime;
            int y = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                y = arr[i];
                if (y > 10 && y < 100)
                {
                    int count = 2;
                    int[] mas = new int[count];
                    mas[0] = y / 10;
                    mas[1] = y % 10;
                    y = mas[1] * 10 + mas[0];
                    if (arr.BinarySearch(y) < 0)
                    {
                        arr.RemoveAt(i);
                        i--;
                    }
                }
                else if (y > 100 && y < 1000)
                {
                    int count = 3;
                    int[] mas = new int[count];
                    for (int j = 1; j < count; j++)
                    {
                        mas[0] = y / 100;
                        mas[1] = y % 100 / 10;
                        mas[2] = y % 10;
                        y = mas[2] * 100 + mas[0] * 10 + mas[1];
                        if (arr.BinarySearch(y) < 0)
                        {
                            arr.RemoveAt(i);
                            i--;
                            break;
                        }
                    }
                }
                else if (y > 1000 && y < 10000)
                {
                    int count = 4;
                    int[] mas = new int[count];
                    for (int j = 1; j < count; j++)
                    {
                        mas[0] = y / 1000;
                        mas[1] = y % 1000 / 100;
                        mas[2] = y % 100 / 10;
                        mas[3] = y % 10;
                        y = mas[3] * 1000 + mas[0] * 100 + mas[1] * 10 + mas[2];
                        if (arr.BinarySearch(y) < 0)
                        {
                            arr.RemoveAt(i);
                            i--;
                            break;
                        }
                    }
                }
                else if (y > 10000 && y < 100000)
                {
                    int count = 5;
                    int[] mas = new int[count];
                    for (int j = 1; j < count; j++)
                    {
                        mas[0] = y / 10000;
                        mas[1] = y % 10000 / 1000;
                        mas[2] = y % 1000 / 100;
                        mas[3] = y % 100 / 10;
                        mas[4] = y % 10;
                        y = mas[4] * 10000 + mas[0] * 1000 + mas[1] * 100 + mas[2] * 10 + mas[3];
                        if (arr.BinarySearch(y) < 0)
                        {
                            arr.RemoveAt(i);
                            i--;
                            break;
                        }
                    }
                }
                else if (y > 100000 && y < 1000000)
                {
                    int count = 6;
                    int[] mas = new int[count];
                    for (int j = 1; j < count; j++)
                    {
                        mas[0] = y / 100000;
                        mas[1] = y % 100000 / 10000;
                        mas[2] = y % 10000 / 1000;
                        mas[3] = y % 1000 / 100;
                        mas[4] = y % 100 / 10;
                        mas[5] = y % 10;
                        y = mas[5] * 100000 + mas[0] * 10000 + mas[1] * 1000 + mas[2] * 100 + mas[3] * 10 + mas[4];
                        if (arr.BinarySearch(y) < 0)
                        {
                            arr.RemoveAt(i);
                            i--;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine("Количество circular prime = " + arr.Count);
            //Вывод на экран circular prime;
            foreach (int z in arr)
            {
                Console.Write(z + " ");
            }
            Console.ReadLine();
        }
    }
}

