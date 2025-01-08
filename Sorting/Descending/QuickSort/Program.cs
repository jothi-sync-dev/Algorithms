using System;
using System.Collections;

namespace QuickSort;

public class Program
{
    public static void Main(string[] args)
    {
        int[] integerArray = { 45, 33, 12, 55, 77, 22, 33, 14, 67, 12, 35 };

        string[] stringArray = { "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };

        char[] characterArray = { 'c', 'a', 'f', 'b', 'k', 'h', 'z', 't', 'm', 'p', 'l', 'd' };

        double[] doubleArray = { 1.1, 65.3, 93.9, 55.5, 3.5, 6.9 };

        GQuickSort(integerArray, 0, integerArray.Length - 1);
        foreach (int x in integerArray)
        {
            System.Console.WriteLine(x);
        }
        GQuickSort(stringArray, 0, stringArray.Length - 1);
        foreach (string x in stringArray)
        {
            System.Console.WriteLine(x);
        }
        GQuickSort(characterArray, 0, characterArray.Length - 1);
        foreach (char x in characterArray)
        {
            System.Console.WriteLine(x);
        }
        GQuickSort(doubleArray, 0, doubleArray.Length - 1);
        foreach (double x in doubleArray)
        {
            System.Console.WriteLine(x);
        }
    }

    public static void Swap<T>(T[] array, int i, int j)
    {
        T temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    public static int Partition<T>(T[] array, int left, int right)
    {
        int index = left;
        T pivot = array[left];
        for (int i = left + 1; i <= right; i++)
        {
            if (Comparer.Default.Compare(array[i], pivot) > 0)
            {
                index++;
                Swap(array, index, i);
            }
        }
        Swap(array, index, left);
        return index;
    }

    public static void GQuickSort<T>(T[] array, int left, int right)
    {
        if (left < right)
        {
            int partition = Partition(array, left, right);
            GQuickSort(array, left, partition - 1);
            GQuickSort(array, partition + 1, right);
        }
    }
}