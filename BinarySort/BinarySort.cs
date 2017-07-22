using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySort
{
    class BinarySort
    {
        public static int[] Parse(string input)
        {
            string[] arr = input.Split(' ', ',', '.');
            int[] num = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                num[i] = int.Parse(arr[i]);
            return num;
        }

        public int [] Sort(int[] num)
        {
            int N = num.Length;
            for (int i = 1; i < N ; i++)
            {
                int tmp = num[i], left = 0, right = i - 1;
                while (left <= right)
                {
                    int m = (left + right) / 2;
                    //определение индекса среднего элемента

                    if (tmp < num[m])
                        right = m - 1;  // сдвиг правой 
                    else left = m + 1; //или левой границы
                }
                for (int j = i - 1; j >= left; j--)
                    num[j + 1] = num[j]; // сдвиг элементов
                num[left] = tmp; // вставка элемента на нужное место
            }
            return num;
        }

        public int Sort2(int[] num)
        {
            int count = 0;
            int N = num.Length;
            for (int i = 1; i < N; i++)
            {
                int tmp = num[i], left = 0, right = i - 1;
                while (left <= right)
                {
                    int m = (left + right) / 2;
                    //определение индекса среднего элемента

                    if (tmp < num[m])
                    {
                        right = m - 1;  // сдвиг правой 
                        count++;
                    }
                        
                    else 
                    {
                        left = m + 1; //или левой границы
                        count++;
                    }
                }
                for (int j = i - 1; j >= left; j--)
                    num[j + 1] = num[j]; // сдвиг элементов
                num[left] = tmp; // вставка элемента на нужное место
            }
            return count;

        }
    }
}
