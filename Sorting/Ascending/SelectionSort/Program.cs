using System;
using System.Runtime.CompilerServices;

namespace SelectionSort;

public class Program
{
    public static void Main(string[] args)
    {
        int[] integerArray = { 45, 33, 12, 55, 77, 22, 33, 14, 67, 12, 35 };

        string[] stringArray = { "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };

        char[] characterArray = { 'c', 'a', 'f', 'b', 'k', 'h', 'z', 't', 'm', 'p', 'l', 'd' };

        double[] doubleArray = { 1.1, 65.3, 93.9, 55.5, 3.5, 6.9 };
        System.Console.WriteLine("Selection Sort");
        IntegerSelectionSort(integerArray);
        System.Console.WriteLine("************************");
        StringSelectionSort(stringArray);
        System.Console.WriteLine("************************");
        CharacterSelectionSort(characterArray);
        System.Console.WriteLine("************************");
        DoubleSelectionSort(doubleArray);
    }


    public static void IntegerSelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < array.Length - 1; j++)
            {
                if (array[j] < array[min])
                {
                    min = j;
                }
            }
            int temp = array[min];
            array[min] = array[i];
            array[i] = temp;
        }
        foreach (int x in array)
        {
            System.Console.WriteLine(x);
        }
    }

    public static void StringSelectionSort(string[] array)
    {

        for (int i = 0; i < array.Length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < array.Length - 1; j++)
            {
                if (array[j].CompareTo(array[min]) < 0)
                {
                    min = j;
                }
            }
            string temp = array[min];
            array[min] = array[i];
            array[i] = temp;
        }
        foreach (string x in array)
        {
            System.Console.WriteLine(x);
        }
    }

    public static void CharacterSelectionSort(char[] array)
    {

        for (int i = 0; i < array.Length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < array.Length - 1; j++)
            {
                if (array[j].CompareTo(array[min]) < 0)
                {
                    min = j;
                }
            }
            char temp = array[min];
            array[min] = array[i];
            array[i] = temp;
        }
        foreach (char x in array)
        {
            System.Console.WriteLine(x);
        }

    }

    public static void DoubleSelectionSort(double[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < array.Length - 1; j++)
            {
                if (array[j] < array[min])
                {
                    min = j;
                }
            }
            double temp = array[min];
            array[min] = array[i];
            array[i] = temp;
        }
        foreach (double x in array)
        {
            System.Console.WriteLine(x);
        }
    }

}