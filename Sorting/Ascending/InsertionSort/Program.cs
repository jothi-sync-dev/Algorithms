using System;

namespace InsertionSort;

public class Program
{
    public static void Main(string[] args)
    {
        int[] integerArray = { 45, 33, 12, 55, 77, 22, 33, 14, 67, 12, 35 };

        string[] stringArray = { "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };

        char[] characterArray = { 'c', 'a', 'f', 'b', 'k', 'h', 'z', 't', 'm', 'p', 'l', 'd' };

        double[] doubleArray = { 1.1, 65.3, 93.9, 55.5, 3.5, 6.9 };

        IntegerInsertionSort(integerArray);
        System.Console.WriteLine("******************************");
        StringInsertionSort(stringArray);
        System.Console.WriteLine("******************************");
        CharacterInsertionSort(characterArray);
        System.Console.WriteLine("******************************");
        DoubleInsertionSort(doubleArray);

    }


    public static void IntegerInsertionSort(int[] array)
    {
        System.Console.WriteLine("Insertion Sort");
        for (int i = 1; i < array.Length; i++)
        {
            int temp = array[i];
            int j = i - 1;
            while (j >= 0 && temp < array[j])
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = temp;
        }

        foreach (int x in array)
        {
            System.Console.WriteLine(x);
        }

    }

    public static void StringInsertionSort(string[] array)
    {

        for (int i = 1; i < array.Length; i++)
        {
            string temp = array[i];
            int j = i - 1;
            while (j >= 0 && temp.CompareTo(array[j]) < 0)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = temp;
        }

        foreach (string x in array)
        {
            System.Console.WriteLine(x);
        }
    }

    public static void CharacterInsertionSort(char[] array)
    {

        for (int i = 1; i < array.Length; i++)
        {
            char temp = array[i];
            int j = i - 1;
            while (j >= 0 && temp.CompareTo(array[j]) < 0)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = temp;
        }

        foreach (char x in array)
        {
            System.Console.WriteLine(x);
        }
    }

    public static void DoubleInsertionSort(double[] array)
    {

        for (int i = 1; i < array.Length; i++)
        {
            double temp = array[i];
            int j = i - 1;
            while (j >= 0 && temp < array[j])
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = temp;
        }

        foreach (double x in array)
        {
            System.Console.WriteLine(x);
        }
    }






}