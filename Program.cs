using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Даны две последовательности a1, a2, …an и b1, b2, …bm. (n > m).
            В каждой из них члены различны.
            Верно, ли что все члены второй последовательности входят в первую последовательность?*/


            Console.Write("Введите размер массива n: ");
            int sizearr_n = Convert.ToInt32(Console.ReadLine()); // ввод размерности массива n
            Console.Write("Введите размер массива m (массив должен быть меньше чем массив n): ");
            int sizearr_m = Convert.ToInt32(Console.ReadLine()); // ввод размерности массива m
            int counter = 0;
            if (sizearr_n <= sizearr_m)
            {
                Console.Write("Ошибка! Массив n должен быть больше массива m");
                Environment.Exit(0);
            }

            int[] array_n = new int[sizearr_n]; // объявление массива n
            int[] array_m = new int[sizearr_m]; // объявление массива m


            for (int i = 0; i < array_n.Length; i++) // цикл наполнения массива n
            {
                Console.Write("Массив A["+ i + "] = ");
                array_n[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("------------------------------\n");

            for (int i = 0; i < array_m.Length; i++) // цикл наполнения массива m
            {
                Console.Write("Массив B[" + i + "] = ");
                array_m[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < array_m.Length; i++) // цикл проверки чисел второго массива с первым
                for (int j = 0; j < array_n.Length; j++)
                {
                    if (array_m[i] == array_n[j])
                    {
                        counter++;
                        break;
                    }
                }
            if (counter == array_m.Length)
            {
                Console.Write("Все члены второй последовательности входят в первую последовательность!");
                
            }
            else Console.Write("Не все члены второй последовательности входят в первую!");
        }
    }
}