using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _31231023770_TranHuynhAnhPhuc
{
    internal class Session06
    {
      

        static void IncreaseByAdding2(int[] arr)
        {
            for (int i = 0;i < arr.Length;i++) 
            {
                arr[i] = arr[i] + 2;
            }
        }

        static int Sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
               sum += arr[i];
            }
            return sum;
        }

        static int Min(int[] arr) 
        {
            Array.Sort(arr);
            int min = arr[0];
            return min;
        }

        static int Max(int[] arr)
        {
            Array.Sort(arr);
            int max = arr[arr.Length - 1];
            return max;
        }

        static double Average(int[] arr) 
        {
            int len = arr.Length;
            int sum = Sum(arr);
            double average = sum / len;
            return average;
        }

        static bool TestSpecificValue(int[] arr, int n)
        {
            bool value = false;
            foreach (int i in arr)
            {
                if (i == n)
                    value = true;

            }
            return value;
        }

        static int FindIndex(int[] arr, int n)
        {
            int index = 0;
            for (int i = 0; i<arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    index = i; break;
                }
            }
            return index;
        }

        static int[] Remove(int[] arr, int n)
        {
            List<int> newList = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != n)
                {
                    newList.Add(arr[i]);
                }
            }
            int[] removedlist = newList.ToArray();
            return removedlist;
        }

        static int[] Reverse(int[] arr)
        {

            arr.Reverse();
            return arr;
        }

        static int FindDuplicateVal(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                       
                    return arr[i];
                }
            return -1;
        }

        static int[] RemoveDuplicates(int[] arr)
        {
            int duplicateVal = FindDuplicateVal(arr);

            while (duplicateVal != -1)
            {
                arr = Remove(arr, duplicateVal);
                duplicateVal = FindDuplicateVal(arr); 
            }
            return arr;
        }

        static int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length -1;i++)
            {
                for (int j = i +1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

       
        static bool LinerSearch(string sentence, string word)
        {
            string wordInSentence = "";
            bool find = false;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != ' ')
                {
                    wordInSentence += sentence[i];
                }
                if (sentence[i] == ' ' || i == sentence.Length - 1)
                {
                    if (wordInSentence == word) { find = true; break; }
                    else { wordInSentence = ""; }
                }
            }
            return find;
        }

    }
}
