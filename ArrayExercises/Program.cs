using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = { 1, 1, 2, 3, 5, 8 };
            //foreach (int num in numArr)
            //{
           //     Console.WriteLine(num);
           // }
           for (int i = 0; i < numArr.Length; i++)
            {
                if (numArr[i] % 2 != 0)
                {
                    Console.WriteLine(numArr[i]);
                }
            }
        }
    }
}
