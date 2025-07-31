
using System;
using System.Linq;

public static class ArrayOperations
{
    /// <summary>
    /// Returns elements from the first array that don't exist in the second array.
    /// </summary>
    /// <param name="firstArray">The array to get elements from</param>
    /// <param name="secondArray">The array to compare against</param>
    /// <returns>New array containing elements from firstArray that are not in secondArray</returns>
    public static int[] GetElementsNotInSecondArray(int[] firstArray, int[] secondArray)
    {
        // Handle null or empty arrays
        if (firstArray == null || firstArray.Length == 0)
            return new int[0];

        if (secondArray == null || secondArray.Length == 0)
            return firstArray.ToArray(); // Return copy of first array if second array is empty

        // Use LINQ's Except() to find elements in firstArray that are not in secondArray
        return firstArray.Except(secondArray).ToArray();
    }

    // Example usage
    public static void Main()
    {
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = { 2, 4, 6 };

        var result = GetElementsNotInSecondArray(array1, array2);

        Console.WriteLine("Elements in first array not in second array:");
        Console.WriteLine(string.Join(", ", result));
        
      // Should print: 1, 3, 5
    }
}