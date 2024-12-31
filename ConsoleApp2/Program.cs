using System;

class Program
{
    static void Main()
    {
        #region Q1:Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n
        //Console.Write("Enter the size of the identity matrix (n): ");
        //int n = int.Parse(Console.ReadLine());

        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < n; j++)
        //    {
        //        Console.Write(i == j ? "1 " : "0 ");
        //    }
        //    Console.WriteLine();
        //}
        #endregion
        #region Q2:Write a program in C# Sharp to find the sum of all elements of the array
        //Console.Write("Enter the size of the array: ");
        //int n = int.Parse(Console.ReadLine());
        //int[] array = new int[n];
        //int sum = 0;

        //Console.WriteLine("Enter array elements:");
        //for (int i = 0; i < n; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //    sum += array[i];
        //}

        //Console.WriteLine($"The sum of all elements is: {sum}");
        #endregion
        #region Q3:Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order
        //Console.Write("Enter the size of the arrays: ");
        //int n = int.Parse(Console.ReadLine());
        //int[] array1 = new int[n];
        //int[] array2 = new int[n];

        //Console.WriteLine("Enter elements of the first array:");
        //for (int i = 0; i < n; i++)
        //{
        //    array1[i] = int.Parse(Console.ReadLine());
        //}

        //Console.WriteLine("Enter elements of the second array:");
        //for (int i = 0; i < n; i++)
        //{
        //    array2[i] = int.Parse(Console.ReadLine());
        //}

        //int[] mergedArray = array1.Concat(array2).ToArray();
        //Array.Sort(mergedArray);

        //Console.WriteLine("Merged and sorted array:");
        //foreach (int num in mergedArray)
        //{
        //    Console.Write(num + " ");
        //}
        #endregion
        #region Q4:Write a program in C# Sharp to count the frequency of each element of an array
        //Console.Write("Enter the size of the array: ");
        //int n = int.Parse(Console.ReadLine());
        //int[] array = new int[n];
        //Dictionary<int, int> frequency = new Dictionary<int, int>();

        //Console.WriteLine("Enter array elements:");
        //for (int i = 0; i < n; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //    if (frequency.ContainsKey(array[i]))
        //        frequency[array[i]]++;
        //    else
        //        frequency[array[i]] = 1;
        //}

        //Console.WriteLine("Frequency of elements:");
        //foreach (var pair in frequency)
        //{
        //    Console.WriteLine($"{pair.Key}: {pair.Value}");
        //}
        #endregion
        #region Q5:Write a program in C# Sharp to find maximum and minimum element in an array
        //Console.Write("Enter the size of the array: ");
        //int n = int.Parse(Console.ReadLine());
        //int[] array = new int[n];

        //Console.WriteLine("Enter array elements:");
        //for (int i = 0; i < n; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //}

        //int max = array[0];
        //int min = array[0];

        //foreach (int num in array)
        //{
        //    if (num > max) max = num;
        //    if (num < min) min = num;
        //}

        //Console.WriteLine($"Maximum: {max}, Minimum: {min}");
        #endregion
        #region Q6:Write a program in C# Sharp to find the second largest element in an array
        //Console.Write("Enter the size of the array: ");
        //int n = int.Parse(Console.ReadLine());
        //int[] array = new int[n];

        //Console.WriteLine("Enter array elements:");
        //for (int i = 0; i < n; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //}

        //Array.Sort(array);
        //int secondLargest = array[n - 2];

        //Console.WriteLine($"The second largest element is: {secondLargest}");
        #endregion
        #region Q7:Consider an Array of Integer values with size N, having values as
        //Console.Write("Enter the size of the array: ");
        //int n = int.Parse(Console.ReadLine());
        //int[] array = new int[n];

        //Console.WriteLine("Enter array elements:");
        //for (int i = 0; i < n; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //}

        //int maxDistance = 0;
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = n - 1; j > i; j--)
        //    {
        //        if (array[i] == array[j])
        //        {
        //            maxDistance = Math.Max(maxDistance, j - i);
        //            break;
        //        }
        //    }
        //}

        //Console.WriteLine($"The longest distance between two equal cells is: {maxDistance}");
        #endregion
        #region Q9:Given a list of space separated words, reverse the order of the words
        //Console.Write("Enter a sentence: ");
        //string input = Console.ReadLine();

        //string[] words = input.Split(' ');
        //Array.Reverse(words);

        //Console.WriteLine("Reversed sentence: " + string.Join(" ", words));
        #endregion
        #region Q10:Write a program to create two multidimensional arrays of same size. Accept values from the user and store them in first array. Now copy all the elements of the first array on second array and print second array
        //Console.Write("Enter the number of rows: ");
        //int rows = int.Parse(Console.ReadLine());
        //Console.Write("Enter the number of columns: ");
        //int cols = int.Parse(Console.ReadLine());

        //int[,] array1 = new int[rows, cols];
        //int[,] array2 = new int[rows, cols];

        //Console.WriteLine("Enter elements for the first array:");
        //for (int i = 0; i < rows; i++)
        //{
        //    for (int j = 0; j < cols; j++)
        //    {
        //        array1[i, j] = int.Parse(Console.ReadLine());
        //        array2[i, j] = array1[i, j]; // Copying elements
        //    }
        //}

        //Console.WriteLine("Elements of the second array:");
        //for (int i = 0; i < rows; i++)
        //{
        //    for (int j = 0; j < cols; j++)
        //    {
        //        Console.Write(array2[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        #endregion
        #region Q11:Write a Program to Print One Dimensional Array in Reverse Order
        //Console.Write("Enter the size of the array: ");
        //int n = int.Parse(Console.ReadLine());
        //int[] array = new int[n];

        //Console.WriteLine("Enter array elements:");
        //for (int i = 0; i < n; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //}

        //Console.WriteLine("Array in reverse order:");
        //for (int i = n - 1; i >= 0; i--)
        //{
        //    Console.Write(array[i] + " ");
        //}
        #endregion

    }
}