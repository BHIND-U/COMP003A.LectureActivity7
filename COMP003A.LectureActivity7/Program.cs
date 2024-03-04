/*
 * Author: Joshua Isidro
 * Course: COMP-003A
 * Purpose: Array and List Activity Lecture
 */

namespace COMP003A.LectureActivity7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SectionSeparator("Arrays");
            int[] array1 = new int[5];
            array1[0] = 5;
            array1[1] = 10;
            array1[2] = 15;
            array1[3] = 20;
            array1[4] = 25;
            Console.WriteLine($"Length of array1: {array1.Length}\n");

            int[] array2 = new int[] { 1, 3, 5, 7, 9 };

            Console.WriteLine("array2 Traversal");
            ArrayTraversal(array2);

            int[] grades = new int[] { 100, 85, 92, 87, 91, 78, 89 };

            Console.WriteLine($"\ngrades Average: {GetAverage(grades)}");

            Console.WriteLine("\nstring Traversal");
            string message = "hello";
            StringTraversal(message);

            SectionSeparator("Lists");

            List<char> alphabet = new List<char>();
            alphabet.Add('A');
            alphabet.Add('B');
            alphabet.Add('C');
            alphabet.Add('D');
            alphabet.Add('E');

            Console.WriteLine($"Count of alphabet: {alphabet.Count}");

            Console.WriteLine($"alphabet[0]: {alphabet[0]}");
            Console.WriteLine($"alphabet[2]: {alphabet[2]}");
            Console.WriteLine($"alphabet[4]: {alphabet[4]}");

            alphabet.Remove('C');
            Console.WriteLine("\nContents of alphabet after removing 'C'");
            ListTraversal(alphabet);

            /// <summary>
            /// Section separator method
            /// </summary>
            /// <param name="section">String input for section name</param>
            static void SectionSeparator(string section)
            {
                Console.WriteLine("".PadRight(50, '*') + $"\n\t\t{section} Section\n" + "".PadRight(50, '*'));
            }

            /// <param name="array">Integer array to traverse</param>
            static void ArrayTraversal(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"Array at index {i}: {array[i]}");
                }
            }

            ///<param name="array">String input</param>
            static void StringTraversal(string array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"Array at index {i}: {array[i]}");
                }
            }

            ///<param name="array">Integer array input</param>
            ///<returns></returns>
            static double GetAverage(int[] array)
            {
                int runningTotal = 0;
                foreach (int item in array)
                {
                    runningTotal += item;
                }
                return runningTotal / array.Length;
            }
            ///<param name="list">Character list input </param>
            static void ListTraversal(List<char> list)
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
