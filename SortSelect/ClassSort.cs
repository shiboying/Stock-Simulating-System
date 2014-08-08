using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* SortSelect类库包含了冒泡排序 快速排序 希尔排序的三种算法 本程序选用冒泡算法作为所有排序的方法*/
namespace SortSelect
{
    public class ClassSort
    {
        public static double[] BubbleSort(double[] arr, int length)
        {
            //利用冒泡算法排序
            int i, j;
            double temp;
            for (i = 0; i < length - 1; i++)
            {
                for (j = 0; j < length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }

            }
            return arr;
        }
      
        public static void QuickSort(int[] arr, int left, int right)
        {
            //利用快速排序排序
            if (left < right)
            {
                //取中间的元素作为比较基准，小于他的往左边移，大于他的往右边移
                int middle = arr[(left + right) / 2];
                int i = left - 1;
                int j = right + 1;
                while (true)
                {
                    while (arr[++i] < middle && i < right) ;
                    while (arr[--j] > middle && j > 0) ;
                    if (i >= j)
                        break;
                    Swap(arr, i, j);
                }
                QuickSort(arr, left, i - 1);
                QuickSort(arr, j + 1, right);
            }
        }
       
        public static void Swap(int[] arr, int i, int j)
        {
            int number = arr[i];
            arr[i] = arr[j];
            arr[j] = number; 
        } 
       
        
        public static void ShellSort(int[] arr, int Length)
        {
            //利用希尔算法排序
            int m;
            for (m = 1; m <= Length / 9; m = 3 * m + 1) ;
            for (; m > 0; m /= 3)
            { 　　
                for (int i = m + 1; i <= Length; i += m)
            {
                    int t = arr[i - 1];
                    int j = i;
                    while ((j > m) && (arr[j - m - 1] > t))
                    {
                        arr[j - 1] = arr[j - m - 1];
                        j -= m;
                    }
                    arr[j - 1] = t;
                }
            }
        }
    } 
}
  


