using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2_S19
{
    class Program
    {
        static void Main(string[] args)
        {
            // left rotation
            Console.WriteLine("Left Rotation");
            int d = 4;
            int[] a = { 1, 2, 3, 4, 5 };
            int[] r = rotLeft(a, d);
            displayArray(r);
            Console.ReadKey();

            // Maximum toys
            Console.WriteLine("\n\nMaximum toys");
            int k = 50;
            int[] prices = { 1, 12, 5, 111, 200, 1000, 10 };
            Console.WriteLine(maximumToys(prices, k));
            Console.ReadKey();

            // Balanced sums
            Console.WriteLine("\n\nBalanced sums");
            List<int> arr = new List<int> { 1, 2, 3 };
            Console.WriteLine(balancedSums(arr));
            Console.ReadKey();

            // Missing numbers
            Console.WriteLine("\n\nMissing numbers");
            int[] arr1 = { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206};
            int[] brr = {203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204};
            int[] r2 = missingNumbers(arr1, brr);
            displayArray(r2);

            // grading students
            Console.WriteLine("\n\nGrading students");
            int[] grades = { 73, 67, 38, 33, 55, 98, 43, 49, 59, 69, 79, 89 };
            int[] r3 = gradingStudents(grades);
            displayArray(r3);
            Console.ReadKey();

                      
            // find the median
            Console.WriteLine("\n\nFind the median");
            int[] arr2 = {0, 1, 2, 4, 6, 5, 3};
            Console.WriteLine(findMedian(arr2));
            Console.ReadKey();

            // closest numbers
            Console.WriteLine("\n\nClosest numbers");
            int[] arr3 = {-20, -3916237, -357920, -3620601, 7374819, -7330761, 30, 6246457, -6461594, 266854, -520, -470};
            int[] r4 = closestNumbers(arr3);
            displayArray(r4);
            Console.ReadKey();

            // Day of programmer
            Console.WriteLine("\n\nDay of Programmer");
            int year = 2017;
            Console.WriteLine(dayOfProgrammer(year));
            Console.ReadKey();

        }

        static void displayArray(int []arr)
        {
            Console.WriteLine();
            foreach(int n in arr) {
                Console.Write(n + " ");
            }
        }

        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {   
            int n,l;//declare integer n and l
            n = a.Length;//assign the length of array a to n
            int []arr = new int[n];//create a new array arr
            l = n - 1;// store the value of n -1 in l
            for(int i=1;i<=d;i++)// for loop with i as initial value 1, to a maximum of value d with increament of 1 each time| This loop is for the number of rotaions
            {
                int r = a[0];// store the value present a the 0th position of array in integer r| so that it can be assign to the last element
                for(int k=0;k<l;k++) // for loop with k as initial value 0, to a maximum of value l with increament of 1 each time|This loop is move every element in the array
                {
                    a[k] = a[k + 1];// store the value present at k+1 position at kth position
                }
                a[l] = r;//assign the value present in r to the last element of the array
            }
            return a;// return the output : array a
        }

        // Complete the maximumToys function below.
        static int maximumToys(int[] prices, int k)
        {
            int n,c=0,s=0,l = prices.Length; //declare and initialize the variables|length of the array price is stored in l
            int[] sortedPrices= sortNumbers(prices);// sort the pices in ascending order using the method sortNumber and store it in array sortedPrices
            for (n = 0; n < l - 1; n++)// for loop with n as initial value 0, to a maximum of value l with increament of 1 each time|This loop is to check all the elements in sorted array sortPrices
            {
                c = sortedPrices[n];// store the value of nth element in array sortedPrices in c
                s = s + c;//sum up all the element as per the for loop
                if (s > k)// check if the sum is greater than the k                    
                break;    // break if the loop is satisfied                      
            }
            Console.WriteLine("The maximum number of toys that can be bought is: ");//print the phase mentioned in the quotes
            return n;//return the value for number of iteration the loop ran 
        }

        public static int[] sortNumbers(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int r = array[i];
                        array[i] = array[j];
                        array[j] = r;
                    }
                }
            }
            return array;
        }

        // Complete the balancedSums function below.
        static string balancedSums(List<int> arr)
        {
         int a = 0, b = 0,j, i;
            int[] arr1 = arr.ToArray();
            for (i = 0; i < arr1.Length; ++i)
                {
                for (j = 0; j < i; j++)
                {
                    a = a + arr1[j];
                }
                for (j = i + 1; j < arr1.Length; j++)
                {
                    b = b + arr1[j];
                }
                if (a == b)
                    return ("No");
                }
            return ("Yes");
    
        }

        // Complete the missingNumbers function below.
        static int[] missingNumbers(int[] arr, int[] brr)
        {
            // Variables limited to the scope of this method
            List<int> source = brr.ToList();
            List<int> destination = arr.ToList();
            List<int> final = new List<int>();
            int[] finalArr = new int[] { };

            //int[] arr1 = { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 };
            //int[] brr = { 203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204 };

            // Iterating through the larger Array - brr
            foreach (int item in source)
            {
                if (destination.Contains(item))
                {
                    // Removing that particular number from the smaller Array - arr
                    destination.Remove(item);
                    // Adding that to a new Array
                    final.Add(item);
                }
            }
            // Removing new Array elements from the Larger Array - brr to remove duplicates
            foreach (int item in final)
            {
                source.Remove(item);
            }
            // Converting List to Array
            finalArr = source.ToArray();
            // Calling the custom defined sort function
            return sortNumbers(finalArr);
        }

        // Complete the gradingStudents function below.
        static int[] gradingStudents(int[] grades)
        {
            // Variables limited to the scope of this method
            List<int> add_list = new List<int>();
            List<int> omt_list = new List<int>();
            int x = grades.Length;
            int[] array = new int[x];

            // Iterating through each element of the given Array
            foreach (int grade in grades)
            {
                if (grade >= 38)
                {
                    int value = diff(grade);
                    add_list.Add(value);
                }
                else
                {
                    // List to be omitted, pushing it to a list, Just in case
                    omt_list.Add(grade);
                }
            }
            // Converting the List to an Array
            array = add_list.ToArray();
            return (array);
        }

        // Method to find the difference between the given number and the next multiple of 5
        public static int diff(int n)
        {
            // Variables limited to the scope of this method
            int ones = n % 10;
            int tens = n / 10;
            string a = "5";
            string b = "0";
            string x = n.ToString();

            // Checking if the number is a multiple of 5
            if (ones != 0 && ones != 5)
            {
                // Feasibility check (5): Check if the number qualifies to be rounded off to the next multiple of 5
                if (ones > 2 && ones < 5)
                {
                    string str = string.Concat(tens, a);
                    return Convert.ToInt32(str);
                }
                // Feasibility check (0): Check if the number qualifies to be rounded off to the next multiple of 5
                else if (ones > 7 && ones <= 9)
                {
                    string str1 = string.Concat((tens + 1), b);
                    return Convert.ToInt32(str1);
                }
                // If the number doesn't qualifies to be rounded off, return the same number
                else
                {
                    return n;
                }
            }
            // If number is a multiple of 5 return the same number
            else
            {
                return n;
            }
        }

        // Complete the findMedian function below.
        static int findMedian(int[] arr)
        {
            int median=0;
            //as it is mentioned that number of elements will always be odd, then median is (number of terms divided by 2)+1
            //still check to be on safe side that number of elements is odd
            if (arr.Length%2!=0)
            {
                //call the sort numbers method and pass the index for median
                median = sortNumbers(arr)[((arr.Length)/2)];
            }
            return median;
        }
            
        // Complete the closestNumbers function below.
        static int[] closestNumbers(int[] arr)
        {
            int[] sortedArr = sortNumbers(arr);
            int mindiff=Math.Abs(sortedArr[1] - sortedArr[0]), currdiff;
            List<int> list = new List<int>();
            //for loop to iterate over the numbers in the array and find the difference between neighbouring numbers
            for (int i=0; i< sortedArr.Length-1; i++)
            {
                //the difference should be the magnitude of the difference, so use absolute
                currdiff = Math.Abs(sortedArr[i+1] - sortedArr[i]);
                if (currdiff==mindiff)
                {
                    list.Add(sortedArr[i]);
                    list.Add(sortedArr[i + 1]);
                    mindiff = currdiff;
                }
                else if(currdiff<mindiff){
                    //if the new difference is less than the current difference, clear the list and start adding new numbers
                    list.Clear();
                    list.Add(sortedArr[i]);
                    list.Add(sortedArr[i+1]);
                    //save the new minimum difference again
                    mindiff = currdiff;
                }
            }
            return list.ToArray();
        }

        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {
            //number of days in a leap year till August month i.e. sum of all days from January to August
            int daysTillAugLeap = 244;
            //number of days in a non-leap year till August month i.e sum of all days from January to August
            int daysTillAugNoLeap = 243;
            //Programmer day in a year
            int progDay = 256;
            //actual date in September month that will be the programmer day
            int date=1;
            //Julian calendar check
            if (year>=1700 && year<=1917)
            {
                //check if leap year
                if (year % 4 == 0)
                {
                    date= progDay-daysTillAugLeap;
                }
                else
                {
                    date = progDay- daysTillAugNoLeap;
                }
            }
            //Gregorian calendar check
            else if (year >= 1919 && year <= 2700)
            {
                //check if leap year
                if (year % 400 == 0 || (year % 4 == 0 && year % 100 !=0))
                {
                    date = progDay - daysTillAugLeap;
                }
                else
                {
                    date = progDay - daysTillAugNoLeap;
                }
            }
            //Transition period for the year 1918
            //The next day after January 31st was February 14th, so 13 days need to be taken care of
            else
            {
                date = progDay - daysTillAugLeap+14;
            }
        
            return date+".09."+year;
        }
    
}
}