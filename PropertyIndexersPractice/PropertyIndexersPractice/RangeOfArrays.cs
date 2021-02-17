using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyIndexersPractice
{
    class RangeOfArray
    {
        public int lowerBount;
        public int upperBount;
        public int[] Arr;
        public RangeOfArray(int upperIndex, int lowerIndex)
        {
            this.lowerBount = lowerIndex;
            this.upperBount = upperIndex;
            Arr = new int[Math.Abs(upperIndex - lowerIndex) + 1];
        }
        public void Print(RangeOfArray mass, int lowerIndex)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine($"{i + lowerIndex} элемент массива равен = " + Arr[i]);
            }
        }
    }
}
