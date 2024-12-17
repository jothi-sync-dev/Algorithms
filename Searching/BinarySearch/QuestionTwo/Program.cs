using System;

namespace QuestionTwo;

public class QuestionTwo
{
    public static void Main(string[] args)
    {
        string[] stringArray = { "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };
        int result = BinarySearch(stringArray,"SF3067");

        if(result == -1)
        {
            System.Console.WriteLine("Element not found");
        }
        else 
        {
            System.Console.WriteLine($"SF3067 found at index : {result}");
        }
    }

    public static int BinarySearch(string[] array, string findElement)
    {
        Array.Sort(array);
        int first = 0;
        int last = array.Length - 1;
        while (first <= last)
        {
            int mid = first + ((last-first)>>1);

            if (findElement.Equals(array[mid]))
            {
                return mid;
            }

            else if (array[mid].CompareTo(findElement)>0)
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
