using System;

namespace QuestionThree;

public class QuestionThree
{
    public static void Main(string[] args)
    {
         char[] characterArray = { 'c', 'a', 'f', 'b', 'k', 'h', 'j', 'I', 'i', 'z', 't', 'm', 'p', 'l', 'd' };
         int result = BinarySearch(characterArray,'m');
         Array.Sort(characterArray);
         foreach(char x in characterArray)
         {
            System.Console.WriteLine(x);
         }
         if(result!=-1)
         {
            System.Console.WriteLine($"m found at index: {result}");
         }
         else 
         {
            System.Console.WriteLine("Element not found");
         }
         
    }


    public static int BinarySearch(char[] array, char findElement)
    {
        Array.Sort(array);
        int first = 0;
        int last = array.Length - 1;
        while (first <= last)
        {
            int mid = first + ((last-first)>>1);

            if (findElement == array[mid])
            {
                return mid;
            }

            else if (findElement < array[mid])
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