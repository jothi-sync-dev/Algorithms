using System;

namespace QuestionOne;

public class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 45, 33, 12, 55, 77, 22, 33, 14, 67, 12, 35 };
        BubbleSort(array);
        SelectionSort(array);
        InsertionSort(array);
    }



    public static void PrintArray(int[] array)
    {
        foreach (int x in array)
        {
            System.Console.WriteLine(x);
            
        }
    }
    public static void BubbleSort(int[] array)
    {
        System.Console.WriteLine("Bubble Sort:");
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
        PrintArray(array);
    }

    public static void SelectionSort(int[] array)
    {
        System.Console.WriteLine("Selection Sort");
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

        PrintArray(array);
    }

    public static void InsertionSort(int[] array)
    {
        System.Console.WriteLine("Insertion Sort");
        for(int i = 1; i < array.Length ; i++)
        {
            int temp = array[i];
            int j = i - 1;
            while(j>=0 && temp<array[j])
            {
                array[j+1] = array[j];
                j--;
            }
            array[j+1] = temp;
        }
    }


}