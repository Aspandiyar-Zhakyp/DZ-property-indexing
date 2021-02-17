using System;

namespace PropertyIndexersPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Введите нижний индекс диапазона массива");
            int lowerIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите верхний индекс диапазона массива");
            int uperIndex = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (!(lowerIndex > uperIndex))
            {
                Console.WriteLine("Нижний индекс равен {0} верхний индекс равен {1}", lowerIndex, uperIndex);
                RangeOfArray array = new RangeOfArray(uperIndex, lowerIndex);
                for (int i = 0; i < array.Arr.Length; i++)
                {
                    array.Arr[i] = rand.Next(10);
                }
                array.Print(array, lowerIndex);
            }
            else
            {
                Console.WriteLine("Введены некорректные индексы");
            }
        }
    }
}
