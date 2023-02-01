using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massive
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*//Задача 1

                //1 шаг: Объявление одномерного массива с использованием конструктора

                int[] omas = new int[6];

                //2 шаг: Заполнение одномерного массива с клавиатуры

                for(int i = 0; i < omas.Length; i++)
                {
                    Console.Write($"omas[{i}] = ");
                    omas[i] = int.Parse(Console.ReadLine());
                }

                //3 шаг: Вывод одномерного массива на экран

                for (int i = 0; i < omas.Length; i++)
                {
                    Console.WriteLine($"omas[{i}] = {omas[i]}");
                }
                Console.ReadKey();*/

                //Задача 2

                /*int[] mass = { 2, 0, 5, -5, 18, -1 };
                foreach(int elem in mass)
                {
                    Console.Write($"{ elem}\t");
                }
                Console.ReadKey();*/

                //Задача 3

                /*Console.Write("n = ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] massiv = new int[n];
                Random rand = new Random();
                int i;
                for (i = 0; i < massiv.Length; i++)
                {
                    massiv[i] = rand.Next();
                    Console.Write($"massiv[{i}] = {massiv[i]}\n");
                }*/
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            Console.ReadKey();

            



        }
    }
}
