using System;
using System.Linq;

namespace rewenie
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {3, -2, 3, -4, 9, 3, 8};
            Console.WriteLine("\n Минимальный по модулю элемент массива: " + array.Min(a => Math.Abs(a)));
            Console.WriteLine(
                "\nСумма элементов массива, расположенных между первым и последним нулевыми элементами: " +
                array.SkipWhile(x => x != 0).Reverse().SkipWhile(x => x != 0).Sum());
            var q = array.OrderByDescending(x => x >= 0 ? 1 : 0).ToArray();
            for (int i = 0; i < q.Length; i++)
            {
                Console.Write(q[i] + " ");
            }
        }
    }
}