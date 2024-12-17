using System;

namespace QuestionThree;

public class QuestionThree
{
    public static void Main(string[] args)
    {
        char[] characterArray = { 'c', 'a', 'f', 'b', 'k', 'h', 'j', 'I', 'i', 'z', 't', 'm', 'p', 'l', 'd' };
    
        int result = LinearSearch(characterArray,'m');
        if(result!=-1)
        {
            System.Console.WriteLine($"m found at index : {result}");
        }
        else 
        {
            System.Console.WriteLine("Element not found");
        }

    }
    public static int LinearSearch(char[] array, char searchElement)
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