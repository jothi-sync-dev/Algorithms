using System;
using System.Collections;

namespace MergeSort;

public class Program
{
    public static void Main(string[] args)
    {
         int[] integerArray = { 45, 33, 12, 55, 77, 22, 33, 14, 67, 12, 35 };
        

        string[] stringArray = { "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };

        char[] characterArray = { 'c', 'a', 'f', 'b', 'k', 'h', 'z', 't', 'm', 'p', 'l', 'd' };

        double[] doubleArray = { 1.1, 65.3, 93.9, 55.5, 3.5, 6.9 };

        MergeSort(integerArray, 0, integerArray.Length - 1);
        foreach (int x in integerArray)
        {
            System.Console.WriteLine(x);
        }

        MergeSort(characterArray, 0, characterArray.Length - 1);
        foreach (char x in characterArray)
        {
            System.Console.WriteLine(x);
        }

        MergeSort(stringArray, 0, stringArray.Length - 1);
        foreach (string x in stringArray)
        {
            System.Console.WriteLine(x);
        }

        MergeSort(doubleArray, 0, doubleArray.Length - 1);
        foreach (double x in doubleArray)
        {
            System.Console.WriteLine(x);
        }

    }


    public static void MergeSort<T>(T[] array, int left, int right)
    {
        if (left <right)
        {
            int middle = left + (right - left) / 2 +1  ;
            MergeSort(array, left, middle - 1);
            MergeSort(array, middle, right);
            Merge(array, left, middle, right);
        }

    }

    public static void Merge<T>(T[] array, int left, int middle, int right)
    {
        int leftArrayLength = middle - left;
        int rightArrayLength = right - middle + 1;
        T[] leftArray = new T[leftArrayLength];
        T[] rightArray = new T[rightArrayLength];

        //copying left array to final array
        for (int i = 0; i < leftArrayLength; i++)
        {
            leftArray[i] = array[left + i];
        }
        //copying right array to final arrya

        for (int i = 0; i < rightArrayLength; i++)
        {
            rightArray[i] = array[middle + i];
        }

        //comparing elements of right array with lef array
        int leftIndex = 0;
        int rightIndex = 0;
        int arrayIndex = left;

        while (leftIndex < leftArrayLength && rightIndex < rightArrayLength)
        {

            if (Comparer.Default.Compare(leftArray[leftIndex], rightArray[rightIndex]) >= 0)
            {
                array[arrayIndex++] = leftArray[leftIndex++];

            }
            else
            {
                array[arrayIndex++] = rightArray[rightIndex++];
            }
        }

        //if left array is completed (no element will be in the left array to compare), copy the right elements to array
        if (leftArrayLength == leftIndex)
        {
            for (int i = rightIndex; i < rightArrayLength; i++)
            {
                array[arrayIndex++] = rightArray[i];
            }
        }
        //if right array is completed (no element will be in the left array to compare), copy the left elements to array
        if (rightArrayLength == rightIndex)
        {
            for (int i = leftIndex; i < leftArrayLength; i++)
            {
                array[arrayIndex++] = leftArray[i];
            }
        }

    }


}