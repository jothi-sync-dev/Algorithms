using System;

namespace QuestionTwo;

public class QuestionTwo
{
    public static void Main(string[] args)
    {
        string[] stringArray = { "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };
    
        int result = LinearSearch(stringArray,"SF3067");
        if(result!=-1)
        {
            System.Console.WriteLine($"SF3067 found at index : {result}");
        }
        else 
        {
            System.Console.WriteLine("Element not found");
        }

    }
    public static int LinearSearch(string[] array, string searchElement)
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