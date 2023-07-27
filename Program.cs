﻿using System;

namespace ProblemsUsingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Fellow Learners!\nWelcome to Basic Core Programs.\nEnter the index no. of the program you want to run.");
            Console.WriteLine("1. Find the maximum no from 3 (Integers).\n2. Find the maximum number from 3 (Floats).\n3. Find the maximum string from 3.");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    TestMaxNumberFinderInt();
                    break;
                case 2:
                    TestMaxNumberFinderFloat();
                    break;
                case 3:
                    TestMaxNumberFinderString();
                    break;
                case 4:
                    TestMaxNumberFinderCustomClass();
                    break;
                default:
                    Console.WriteLine("Please Enter a Valid Index No.");
                    break;
            }
            Console.ReadLine();
        }

        public static void TestMaxNumberFinderInt()
        {
            MaxNumberFinder<int> maxNumberFinder = new MaxNumberFinder<int>(10, 5, 7);
            int result = maxNumberFinder.TestMaximum();
            Console.WriteLine("Test case 1 (Integers): " + result); // Output: 10
        }

        public static void TestMaxNumberFinderFloat()
        {
            MaxNumberFinder<float> maxNumberFinder = new MaxNumberFinder<float>(10.5f, 5.2f, 7.8f);
            float result = maxNumberFinder.TestMaximum();
            Console.WriteLine("Test case 1 (Floats): " + result); // Output: 10.5
        }

        public static void TestMaxNumberFinderString()
        {
            MaxNumberFinder<string> maxNumberFinder = new MaxNumberFinder<string>("Apple", "Peach", "Banana");
            string result = maxNumberFinder.TestMaximum();
            Console.WriteLine("Test case 1 (Strings): " + result); // Output: "Peach"
        }

        public static void TestMaxNumberFinderCustomClass()
        {
            // Defining a custom class that implements IComparable
            // Example: a custom class for Employee
            Employee emp1 = new Employee("John", 10001);
            Employee emp2 = new Employee("Jane", 10002);
            Employee emp3 = new Employee("Mike", 10003);

            MaxNumberFinder<Employee> maxNumberFinder = new MaxNumberFinder<Employee>(emp1, emp2, emp3);
            Employee result = maxNumberFinder.TestMaximum();
            Console.WriteLine("Test case 1 (Custom Class): " + result.Name); // Output: "Mike"
        }
    }
}