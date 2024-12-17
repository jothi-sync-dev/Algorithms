using System;

namespace QuestionFour;

public class QuestionFour
{
    public static void Main(string[] args)
    {
        double[] doubleArray = { 1.1, 65.3, 93.9, 55.5, 3.5, 6.9 };
        int result = BinarySearch(doubleArray,3.5);
        if(result!=-1)
        {
            System.Console.WriteLine($"3.5 is at index of : {result}");
        }
        else 
        {
            System.Console.WriteLine("Element Not Found");
        }

    }

    public static int BinarySearch(double[] array, double findElement)
    {
        Array.Sort(array);
        int first = 0;
        int last = array.Length - 1;
        while (first <= last)
        {
            int mid = first + ((last - first) >> 1);

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