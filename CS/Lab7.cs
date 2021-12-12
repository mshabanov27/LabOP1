using System;

namespace Lab7
{
    class Lab7
    {
        static void Main(string[] args)
        {
            Console.Write("Enter how many people are in the queue: ");
            int size = int.Parse(Console.ReadLine());

            int[] queue = new int[size];
            queue = arrayGenerator(queue, queue.Length);
            typeArray(queue, queue.Length);
            Console.WriteLine(); //Залишаю порожній рядок, щоб відділити вивід масиву від вивода результату
            findBestCustomer(queue, queue.Length);
        }

        static int[] arrayGenerator(int[] array, int length) //Функція кожному з покупців присвоює випадкове число хвилин на обслуговування
        {
            var rand = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(1, 16);
            }
            return array;
        }


        static void typeArray (int[] array, int length) //Форматований вивід масиву разом із значеннями
        {
            for (int j = 0; j < length; j++)
            {
                Console.WriteLine($"{array[j]} minutes to serve the {j + 1} customer."); //Додаю 1 до індексу щоб не було "нульового" покупця
            }
        }

        static void findBestCustomer (int[] array, int length) //Фукнція шукає покупця, який займає менше всього часу, і форматовано виводить його номер і значення
        {
            int minTime = array[0];
            int index = 0;
            for (int f = 0; f < array.Length; f++)
            {
                if (array[f] < minTime)
                {
                    minTime = array[f];
                    index = f;
                }
            }
            Console.WriteLine($"Visitor {index + 1} is the best customer, it took {minTime} minutes to serve him."); //Додаю 1 до індексу щоб не було "нульового" покупця
        }
    }
}
