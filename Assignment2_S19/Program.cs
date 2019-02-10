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
/*
            // Missing numbers
            Console.WriteLine("\n\nMissing numbers");
            int[] arr1 = { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206};
            int[] brr = {203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204};
            int[] r2 = missingNumbers(arr1, brr);
            displayArray(r2);
*/
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
            int[] arr3 = {0,0,0,0 };
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
            int n,l;
            n = a.Length;
            int []arr = new int[n];
            l = n - 1;
            for(int i=1;i<=d;i++)
            {
                int r = a[0];
                for(int k=0;k<l;k++)
                {
                    a[k] = a[k + 1];
                }
                a[l] = r;
            }
            return a;
        }

        // Complete the maximumToys function below.
        static int maximumToys(int[] prices, int k)
        {
            int n,r=0,c=0,s=0,l = prices.Length;
            //for (int i = 0; i < l - 1; i++)
            //{
            //    for (int j = i + 1; j < l; j++)
            //    {
            //        if (prices[i] > prices[j])
            //        {
            //            r = prices[i];
            //            prices[i] = prices[j];
            //            prices[j] = r;
            //        }
            //    }
            //}
            int[] sortedPrices= sortNumbers(prices);
            for (n = 0; n < l - 1; n++)
            {
                c = sortedPrices[n];
                s = s + c;                
                if (s > k)                    
                break;                          
            }
            Console.WriteLine("The maximum number of toys that can be bought is: ");
            return n;
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
            return new int[] { };
        }

        // Complete the gradingStudents function below.
        static int[] gradingStudents(int[] grades)
        {
            List<int> add_list = new List<int>();
            int x = grades.Length;
            int[] array = new int[x];
            foreach (int grade in grades)
            {
                if (grade > 40)
                {
                    int value = diff(grade);
                    add_list.Add(value);
                }
                else
                {
                    add_list.Add(grade);
                }

            }
            array = add_list.ToArray();
            return (array);
        }

        public static int diff(int n)
        {
            int ones = n % 10;
            int tens = n / 10;
            string a = "5";
            string b = "0";
            string x = n.ToString();
            
            if (ones != 0 && ones != 5)
            {
                if (ones > 2 && ones < 5)
                {
                    string str = string.Concat(tens, a);
                    return Convert.ToInt32(str);
                }
                else if (ones > 7 && ones <= 9)
                {
                    string str1 = string.Concat((tens + 1), b);
                    return Convert.ToInt32(str1);
                }
                else
                {
                    return n;
                }

            }
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
                    mindiff = currdiff;
                }

            }
            return list.ToArray();
        }

        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {
                return "";
        }
    
}
}