using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] nums = new int[50];


            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(nums);
            //TODO: Print the first number of the array
            Console.WriteLine("First Number:");
            Console.WriteLine(nums[0]);


            //TODO: Print the last number of the array            
            Console.WriteLine("Last number");
            Console.WriteLine(nums[nums.Length-1]);


            Console.WriteLine("All Numbers Original");
            NumberPrinter(nums);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");
            ReverseArray(nums);

            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(nums);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(nums);
            NumberPrinter(nums);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            List<int> numbers = new List<int>(50);

            //TODO: Print the capacity of the list to the console
            Console.WriteLine(numbers.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numbers);

            //TODO: Print the new capacity
            Console.WriteLine(numbers.Capacity);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            int n = int.Parse(Console.ReadLine());

            NumberChecker(numbers, n);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numbers);
            NumberPrinter(numbers);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");

            numbers.Sort();
            NumberPrinter(numbers);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var toArrays = numbers.ToArray();

            //TODO: Clear the list
            numbers.Clear();
            Console.WriteLine("Capacity: " + numbers.Capacity);

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for(int y = 0; y < numbers.Length; y++)
            {
                if(numbers[y] % 3 == 0)
                {
                    numbers[y] = 0;
                }
                else
                {
                    numbers[y] = numbers[y];
                }
            }

            foreach(var x in numbers)
            {
                Console.WriteLine(x);
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for(int x = numberList.Count-1; x>=0; x--)
            {
                if (numberList[x] % 2 != 0)
                {
                    numberList.Remove(numberList[x]);
                }
            }

            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {

            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine("It is in the array");
            }
            else
            {
                Console.WriteLine("Not in the array");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int x = 0; x < numberList.Capacity; x++)
            {
                var number = rng.Next(1, 50);
                numberList.Add(number);
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
    

            for (int x = 0; x < numbers.Length; x++)
            {
                var number = rng.Next(1, 50);
                numbers[x] = number;
            }
      
        }        

        private static void ReverseArray(int[] array)
        {
            for (int x = array.Length - 1; x >= 0; x--)
            {
                Console.WriteLine(array[x]);
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
