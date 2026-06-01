using System.Runtime.InteropServices.Marshalling;

public static class ArrayCodingProblems
{
    #region  Write a function to find the second largest number in an array.
    public static int FindSecondLargestNumberInArray()
    {
        int[] numbers = { 10, 7, 23, 45, 8 };
        int largest = numbers[0];
        int secondLargest = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            int num = numbers[i];
            if (largest < num)
            {
                secondLargest = largest;
                largest = num;
            }
            else if (num > secondLargest && num != largest)
            {
                secondLargest = num;
            }
        }
        return secondLargest;
    }

    #endregion

    #region   Write a function to calculate the sum of all elements in an array.
    public static int SumOfAllElementinArray(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }
    #endregion

    #region  Write a function to calculate the average of an array of numbers.
    public static double CalucateAverageOfArray(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return (double)sum / array.Length;
    }
    #endregion

    #region  Write a function to find the smallest number in an array
    public static int FindSmallestNumberInArray(int[] array)
    {
        int smallest = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (smallest > array[i])
            {
                smallest = array[i];
            }
        }
        return smallest;
    }
    #endregion

    #region  Write a function to find the largest number in an array
    public static int FindlargestNumberInArray(int[] array)
    {
        int largest = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (largest < array[i])
            {
                largest = array[i];
            }
        }
        return largest;

    }
    #endregion

    #region Write a function to remove duplicate in Array without built-in function
    public static void RemoveDuplicateInArray(int[] array)
    {
        int[] uniqueValue = new int[array.Length];
        int count = 0;


        for (int i = 0; i < array.Length; i++)
        {
            bool exist = false;

            for (int j = 0; j < count; j++)
            {
                if (array[i] == uniqueValue[j])
                {
                    exist = true;
                    break;

                }
            }

            if (!exist)
            {
                uniqueValue[count] = array[i];
                count++;
            }
        }

        for (int i = 0; i < count; i++)
        {
            for (int j = i + 1; j < count; j++)
            {
                if (uniqueValue[i] < uniqueValue[j])
                {
                    int temp = uniqueValue[i];
                    uniqueValue[i] = uniqueValue[j];
                    uniqueValue[j] = temp;
                }
            }
        }


        for (int y = 0; y < count; y++)
        {
            Console.WriteLine("UniqueValue :" + uniqueValue[y]);
        }

    }
    #endregion



    #region Top 5 Important array function used in coding problems.
    public static void TopFiveArrayFunction()
    {
        int[] array = { 10, 7, 9, 6, 8 }; // Initializing an array

        string arrayStr = string.Join(",", array);// Covert array to a string
        Console.WriteLine("Join by comma :" + arrayStr);//Output: Join by comma :10,7,9,6,8

        Array.Sort(array); // Sort the array in ascending order
        Console.WriteLine(string.Join(",", array));//Output: 6,7,8,9,10

        Array.Reverse(array); // Sort the array in descending order
        Console.WriteLine(string.Join(",", array));//Output: 10,9,8,7,6

        Array.Fill(array, 2);// Fill the array with a specific value
        Console.WriteLine(string.Join(",", array));//Output: 2,2,2,2,2

        array = new int[] { 10, 7, 9, 6, 8 };// Reinitialize the array
        // Copy the array to a new array of specified length
        int[] newArray = new int[7];
        Array.Copy(array, newArray, array.Length);
        Console.WriteLine(string.Join(",", newArray));//Output: 10,7,9,6,8,0,0
    }
    #endregion

    #region  Check Whether two array are same or not
    public static void CompareArrays()
    {
        int[] firstArray = { 5, 2, 9, 1, 5, 6 };
        int[] secondArray = { 5, 2, 9, 1, 5, 6 };
        Console.WriteLine(firstArray.SequenceEqual(secondArray));// Output: true

    }
    #endregion

    #region  Check if a given array is sorted or in ascending order or not
    public static bool CheckIfArraySorted()
    {
        int[] array = { 6, 7, 8, 9, 10 };

        // Iterate through the array to extract each element
        for (int i = 0; i < array.Length - 1; i++)
        {
            // Check if current element is greater then next element
            if (array[i] > array[i + 1])
            {
                return false;
            }
        }
        return true;
        // Output: True
    }

    #endregion

    # region Merage two array into a single sorted array
    public static int[] MergeAndSort(int[] firstArray, int[] secondArray)
    {
        int firstArrayLenght = firstArray.Length;
        int secondArrayLength = secondArray.Length;

        int[] mergedArray = new int[firstArrayLenght + secondArrayLength];// Create new array

        // Copy elements from first Array
        Array.Copy(firstArray, 0, mergedArray, 0, firstArrayLenght);
        // Copy elements from second array
        Array.Copy(secondArray, 0, mergedArray, firstArrayLenght, secondArrayLength);

        // Sort the merged array
        Array.Sort(mergedArray);
        return mergedArray;
        //Output : [1,2,3,4,5,6,7,8]

    }
    #endregion

    #region  Remove specific element from an array
    public static int[] RemoveElement(int[] array, int element)
    {
        // Count occurrences of the element to be removed
        int count = 0;
        foreach (int item in array)
        {
            if (item == element)
                count++;
        }

        //Create a new array of the appropriate size
        int[] newArray = new int[array.Length - count];

        int index = 0;
        //Copy elements except the one to be removed
        foreach (int item in array)
        {
            if (item != element)
            {
                newArray[index] = item; index++;
            }
        }
        return newArray;
    }
    #endregion

    public static void BubbleSortArray()
    {
        int[] array = { 5, 2, 9, 1 };

        int n = array.Length;
        bool swapped;
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < n - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped) break;
        }
        Console.WriteLine($"[{string.Join(",", array)}]");

    }


    //HCLTech InterView Question 01-06-2026
    public static void RemoveDuplicatInStringArray()
    {
        string[] inputArray = { "Monday", "Tusday", "Wensday", "Monday", "Tusday", "Friday" };

        string[] uniqueArray = new string[inputArray.Length];
        int count = 0;


        for (int i = 0; i < inputArray.Length; i++)
        {

            bool isExist = false;
            for (int j = 0; j < count; j++)
            {
                if (inputArray[i] == uniqueArray[j])
                {
                    isExist = true;
                    break;
                }
            }

            if (!isExist)
            {
                uniqueArray[count] = inputArray[i];
                count++;
            }
        }


        for (int y = 0; y < count; y++)
        {

            Console.WriteLine(uniqueArray[y]);
        }
    }
}