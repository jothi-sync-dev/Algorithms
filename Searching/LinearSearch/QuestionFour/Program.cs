using System;

namespace QuestionFour;

public class QuestionFour
{
    public static void Main(string[] args)
    {
        double[] doubleArray = { 1.1, 65.3, 93.9, 55.5, 3.5, 6.9 };

    
        int result = LinearSearch(doubleArray,3.5);
        if(result!=-1)
        {
            System.Console.WriteLine($"3.5 found at index : {result}");
        }
        else 
        {
            System.Console.WriteLine("Element not found");
        }

    }
    public static int LinearSearch(double[] array, double searchElement)
    {

        for (int i = 0; i < array.Length; i++)
        {
            //if the search element is equal to the i th elemnt of the array 
            if (searchElement.Equals(array[i]))
            {
                //break the loop
                return i;
            }

        }
        return -1;
    }
}