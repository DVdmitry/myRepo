using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Events
{
    class Program
    {
        public delegate bool LessNum(int num);

        public static bool GetLessFive(int num)
        {
            return (num < 5); 
        }

        public static bool GetGreater20(int num)
        {
            return (num > 20);
        }

        
        public static IEnumerable<int> GetNums(IEnumerable<int> array, LessNum meDel)
        {
            foreach (int item in array)
            {
                meDel(item);
                yield return item;
            }
        }


        static void Main(string[] args)
        {
            int[] arr = new[] { 2, 6, 12, 67, 2, 5, 6, 99 };
            LessNum md = Program.GetLessFive;
            // md += Program.GetGreater20;
            foreach(int item in Program.GetNums(arr, md))
                Console.WriteLine(item);
           
            Console.ReadKey();
        }

    }
}
