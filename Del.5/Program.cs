/* 
Author: Cody Hoang
Date: 2/15/23
Description: Deliverable #5
*/

using System;

namespace Del._5
{
    internal class Program
    {
        
        static int[] random_array(int array_len)        //method 1
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10, 50);
            }
            return MyArray;
        }

        static int sum(int[] array)
        {
            int sum = 0;
            foreach(int item in array)
            {
                sum = sum + item;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer between 5 and 15");

            try
            {
                int input = int.Parse(Console.ReadLine());

                if (input >= 5 && input <= 15)
                {
                    int[] sArray = random_array(input);
                    Console.WriteLine("");
                    Console.WriteLine(" The elements in the random array are: ");
                    foreach (int element in sArray)
                    {
                        Console.Write(element + " ");
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("");
                    Console.WriteLine("The sum is: " + sum(sArray));
                }

                else if (input >= 0 && input >= 16)
                {
                    Console.WriteLine("Enter an integer number between 5 and 15: ");
                }
               
            }
            catch
            {
                Console.WriteLine("Enter an integer number between 5 and 15: ");
            }
            
        }
    }
}