using System;
using System.Collections.Generic;

/// <summary>
/// This class serves as a collection point for all search and sort algorithms.
/// </summary>
class Program
{
    static void Main()
    {
    //1: Skapa en array
    int length = 10;
    int[] numbers = new int[length];

    //2: Fyll arrayn med slumpmässiga tal
    FillArray(numbers);

    BubbleSort(numbers);
       
    PrintArray(numbers);
     
  
    }

    /// <summary>
    /// A method to fill an array with random numbers
    /// </summary>
    /// <param name="numbers">input array</param>
    static void FillArray(int[] numbers)
    {
        Random random = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(numbers.Length);  
        }
    }

    /// <summary>
    /// A method to print out an array
    /// </summary>
    /// <param name="numbers">array</param>
    static void PrintArray(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }  
    }

    /// <summary>
    /// Linear Search method. Returns index of first instance of key.
    /// </summary>
    /// <param name="numbers">Array to search through</param>
    /// <param name="key">Integer we are searching for.</param>
    /// <returns></returns>
    static int LinearSearch(int[] numbers,int key)
    {
        int index=-1;

        for (int i = 0; i < numbers.Length; i++)
        {
           if(key==numbers[i])
            {
                index = i;
                break;
            }
        }
        return index;
    }

    /// <summary>
    /// BubbleSort Algorithm
    /// </summary>
    /// <param name="numbers">The array to be sorted</param>
    static void BubbleSort(int[] numbers)
    {
        for (int j = numbers.Length; j > 0; j--)
        {

            for (int i = 1; i < j; i++)
            {
                //If the current index in the list is less than the one before it we change place...
                if (numbers[i - 1] > numbers[i])
                {
                    int temp = numbers[i - 1];
                    numbers[i - 1] = numbers[i];
                    numbers[i] = temp;
                }

            }
        }
    }

}

