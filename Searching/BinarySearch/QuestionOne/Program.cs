using System;

namespace QuestionOne;

public class Question 
{
    public static void Main(string[] args)
    {
        int[] arrayInteger = { 45, 33, 12, 55, 77, 22, 33, 14, 67, 78, 22, 11, 44, 66, 88, 12, 35, 84, 93, 77 };
        int result = BinarySearch(arrayInteger,66);
        if(result == -1)
        {
            System.Console.WriteLine("Element not found");
        }
        else 
        {
            System.Console.WriteLine($"66 found at index : {result}");
        }

    }

     public static int BinarySearch(int[] array, int findElement)
    {
        Array.Sort(array);
        int first = 0;
        int last = array.Length - 1;
        while (first <= last)
        {
            int mid = first + ((last-first)>>1);

            if (findElement == array[mid])
            {
                return mid;
            }

            else if (findElement < array[mid])
            {
                last = mid - 1;
            }

            else
            {
                first = mid + 1;
            }

        }

        return -1;
    }


}