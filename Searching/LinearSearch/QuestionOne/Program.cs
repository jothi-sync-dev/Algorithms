using System;

namespace QuestionOne;

public class QuestionOne
{
    public static void Main(string[] args)
    {
        int[] integerArray = { 45, 33, 12, 55, 77, 22, 33, 14, 67, 78, 22, 11, 44, 66, 88, 12, 35, 84, 93, 77 };
    
        int result = LinearSearch(integerArray,66);
        if(result!=-1)
        {
            System.Console.WriteLine($"66 found at index : {result}");
        }
        else 
        {
            System.Console.WriteLine("Element not found");
        }

    }
    public static int LinearSearch(int[] array, int searchElement)
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