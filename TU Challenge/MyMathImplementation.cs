using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public static class MyMathImplementation
    {
        public static int Add(int a, int b) => a + b;

        public static bool IsMajeur(int age)
        {
            if (age < 0 || age > 140)
                throw new ArgumentException("Wesh t'as pas l'age recommandé");
            return age >= 18;
        }

        public static bool IsEven(int a) => a % 2 == 0;

        public static bool IsDivisible(int a, int b) => a % b == 0;

        public static bool IsPrimary(int a)
        {
            if (a <= 1) return false; 
            for (int i = 2; i <= Math.Sqrt(a); ++i)
            {
                if (IsDivisible(a, i))
                    return false;
            }
            return true;
        }

        public static List<int> GetAllPrimary(int a)
        {
            List<int> Primary = new List<int>();
            if (a <= 1) return Primary;
            for (int i = 2; i <= a; ++i)
            {
                if (IsPrimary(i))
                {
                    Primary.Add(i);
                }
            }
            return Primary;
        }

        public static int Power2(int a) => a * a;

        public static int Power(int a, int b)
        {
            int result = a;
            for (int i = 1; i < b; ++i)
            {
                result *= a;
            }
            return result;
        }

        public static int IsInOrder(int a, int b) => a <= b ? (a < b ? 1 : 0) : -1;

        public static bool IsListInOrder(List<int> List)
        {
            for (int i = 1; i < List.Count; i++)
            {
                if (IsInOrder(List[i-1], List[i]) < 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static List<int> Sort(List<int> list)
        {
            int bubble;

            // while not in order
            while (!IsListInOrder(list))
            {
                // get the first element not in order
                for (int i = 1; i < list.Count; ++i)
                {
                    if (IsInOrder(list[i - 1], list[i]) < 0)
                    { 
                        // move it to the top
                        bubble = list[i - 1];
                        list[i - 1] = list[i];
                        list[i] = bubble;
                    }
                }
            }

            return list;
        }

        public static List<int> GenericSort(List<int> list, Func<int, int, int> f)
        {
            int bubble;
            bool sorted = false;

            // while not in order
            while (!sorted)
            {
                sorted = true;

                // get the first element not in order
                for (int i = 1; i < list.Count; ++i)
                {
                    if (f(list[i - 1], list[i]) < 0)
                    {
                        // move it to the top
                        bubble = list[i - 1];
                        list[i - 1] = list[i];
                        list[i] = bubble;
                        sorted = false; // still sorting ? do another iteration
                    }
                }
            }

            return list;
        }


        public static int IsInOrderDesc(int a, int b) => a >= b ? (a > b ? 1 : 0) : -1;
    }
}
