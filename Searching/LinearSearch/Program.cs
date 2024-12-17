using System;
namespace LinearSearch;



// Implement a program to find an presence of an element and location of element using linear searching algorithm. 
// 45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77  -> Find 66 
// SF3023, SF3021, SF3067, SF3043, SF3053, SF3032, SF3063, SF3089, SF3062, SF3092 -> Find - SF3067 
// c,a,f,b,k,h,j,I,i,z,t,m,p,l,d -> Find m 
// 1.1,65.3,93.9,55.5,3.5,6.9 -> find 3.5 

public class Program
{
    public static void Main(string[] args)
    {
        
        //declaring arrays
        int[] integerArray = { 45, 33, 12, 55, 77, 22, 33, 14, 67, 78, 22, 11, 44, 66, 88, 12, 35, 84, 93, 77 };
        string[] stringArray = { "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };
        char[] characterArray = { 'c', 'a', 'f', 'b', 'k', 'h', 'j', 'I', 'i', 'z', 't', 'm', 'p', 'l', 'd' };
        double[] doubleArray = { 1.1, 65.3, 93.9, 55.5, 3.5, 6.9 };

        //performing linear search operation on each array to find the required element
        int findInteger = 66;
        LinearSearch(ref integerArray, ref findInteger);
        string findString = "SF3067";
        LinearSearch(ref stringArray, ref findString);
        char findCharacter = 'm';
        LinearSearch(ref characterArray, ref findCharacter);
        double findDouble = 3.5;
        LinearSearch(ref doubleArray, ref findDouble);
    }



    //defining linear search as generic method
    public static void LinearSearch<T>(ref T[] array, ref T searchElement)
    {
        for (int i = 0; i < array.Length; i++)
        {
            //if the search element is equal to the i th elemnt of the array 
            if (searchElement.Equals(array[i]))
            {
                //print the index
                System.Console.WriteLine($"{searchElement} is found at index : {i}");
                //break the loop
                break;
            }
        }
    }
}

