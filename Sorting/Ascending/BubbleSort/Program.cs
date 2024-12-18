using System;

namespace BubbleSort;

public class Program
{
    public static void Main(string[] args)
    {
        int[] integerArray = { 45, 33, 12, 55, 77, 22, 33, 14, 67, 12, 35 };

        string[] stringArray = { "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };

        char[] characterArray = { 'c', 'a', 'f', 'b', 'k', 'h', 'z', 't', 'm', 'p', 'l', 'd' };

        double[] doubleArray = { 1.1, 65.3, 93.9, 55.5, 3.5, 6.9 };

        IntegerBubbleSort(integerArray);
        System.Console.WriteLine("******************************");
        StringBubbleSort(stringArray);
        System.Console.WriteLine("******************************");
        CharacterBubbleSort(characterArray);
        System.Console.WriteLine("******************************");
        DoubleBubbleSort(doubleArray);

    }

    public static void IntegerBubbleSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length - 1; j++)
            {
                if (array[j] < array[i])
                {
                    int temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                }
            }
        }
        foreach (int x in array)
        {
            System.Console.WriteLine(x);
        }
    }

    public static void StringBubbleSort(string[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length - 1; j++)
            {
                if (array[j].CompareTo(array[i]) < 0)
                {
                    string temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                }
            }
        }
        foreach (string x in array)
        {
            System.Console.WriteLine(x);
        }
    }

    public static void DoubleBubbleSort(double[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length - 1; j++)
            {
                if (array[j] < array[i])
                {
                    double temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                }
            }
        }
        foreach (double x in array)
        {
            System.Console.WriteLine(x);
        }
    }

    public static void CharacterBubbleSort(char[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length - 1; j++)
            {
                if (array[j].CompareTo(array[i]) < 0)
                {
                    char temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                }
            }
        }
        foreach (char x in array)
        {
            System.Console.WriteLine(x);
        }
    }
}