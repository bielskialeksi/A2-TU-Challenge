using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static List<int> GenericSort(List<int> toSort, Func<int, int, int> isInOrder)
        {
            for (int c = toSort.Count; c > 0; c--)
            {
                for (int i = 1; i < toSort.Count; i++)
                {
                    if (isInOrder(toSort[i - 1], toSort[i]) == -1)
                    {
                        int tpm = toSort[i];
                        toSort[i] = toSort[i - 1];
                        toSort[i - 1] = tpm;
                    }
                }
            }

            return toSort;
        }

        public static List<int> GetAllPrimary(int a)
        {
            List<int> liste = new();
            for (int i = 1; i <= a; i++)
            {
                if (IsPrimary(i))
                {
                    liste.Add(i);
                }
            }
            return liste;
        }

        public static bool IsDivisible(int a, int b)
        {
            if (a % b == 0) return true;
            else return false;
        }

        public static bool IsEven(int a)
        {
            if (a % 2 == 0) return true;
            else return false;
        }

        public static int IsInOrder(int a, int b)
        {
            if (a == b) return 0;
            if (a < b) return 1;
            else return -1; ;
        }

        public static int IsInOrderDesc(int arg1, int arg2)
        {
            if (arg1 == arg2) return 0;
            if (arg1 < arg2) return -1;
            else return 1 ;
        }

        public static bool IsListInOrder(List<int> list)
        {
            int first = list[0];
            foreach (int element in list)
            {
                if (element < first) return false;
            }
            return true;
        }

        public static bool IsMajeur(int age)
        {
            if (age < 0 || age > 140)
                throw new ArgumentException();
            return age >= 18;
        }

        public static bool IsPrimary(int a)
        {
            int _nbDiv = 0;
            for (int i = 1; i <= a; i++)
            {
                if (IsDivisible(a, i))
                {
                    _nbDiv++;
                }
            }
            return _nbDiv == 2;
        }

        public static int Power(int a, int b)
        {
            int tpm = a;
            while (b > 1)
            {
                a = a * tpm;
                b = b - 1;
            }
            return a;
        }

        public static int Power2(int a)
        {
            return a * a;
        }

        public static List<int> Sort(List<int> toSort)
        {
            for (int a = 0; a < toSort.Count(); a++)
            {
                for (int b = a + 1; b < toSort.Count(); b++)
                {
                    if (toSort[b] < toSort[a])
                    {
                        int tpm = toSort[a];
                        toSort[a] = toSort[b];
                        toSort[b] = tpm;
                    }


                }
            }
            return toSort;
        }
    }
}
