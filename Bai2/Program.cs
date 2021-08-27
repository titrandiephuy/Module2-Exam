using System;

namespace ArrFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Procces();
        }

        public static int[] CreateArray()
        {
            Console.WriteLine("Enter array length: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine($"Enter value of array[{i}]");
                array[i] = int.Parse(Console.ReadLine());

            }
            return array;
        }

        public static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        public static bool IsSymmetryArray(int[] array)
        {
            int[] arr = array;
            Array.Reverse(arr);
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == array[j])
                {
                    j++;
                    return true;
                }
            }
            return false;
        }

        public static void BubbleSort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
            Console.Write("Array new: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }

        public static void Find(int[] array, int key)
        {

            int first, middle, last;
            bool found = false;

            first = 0;
            last = array.Length;
            while (first <= last)
            {
                middle = (first + last) / 2;

                if (array[middle] < key)
                    first = middle + 1;
                else if (array[middle] == key)
                {
                    Console.WriteLine("Value {0} is in index {1} in array", key, (middle));
                    found = true;
                    break;
                }
                else
                    last = middle - 1;
            }
            if (found == false)
                Console.WriteLine("Cannot found value!");
        }

        public static void BuildMenu(out int choice)
        {
            do
            {
                Console.WriteLine("========= Menu =========");
                Console.WriteLine("1. Show Array ");
                Console.WriteLine("2. Symmetry Array");
                Console.WriteLine("3. Sort Array");
                Console.WriteLine("4. Find Array");
                Console.WriteLine("5. Exit");
                Console.WriteLine("==========================");
                Console.Write("Choose a function: ");
                int.TryParse(Console.ReadLine(), out choice);
            }
            while (choice < 1 || choice > 5);
        }

        public static void Procces()
        {
            int selected = 0;
            int[] array = CreateArray();
            do
            {

                BuildMenu(out selected);
                Console.Clear();
                switch (selected)
                {
                    case 1:
                        {
                            ShowArray(array);
                            break;
                        }
                    case 2:
                        {
                            if (IsSymmetryArray(array))
                            {
                                Console.WriteLine("Array is symmetry");
                            }
                            else
                            {
                                Console.WriteLine("Array is not symmetry");
                            };
                            break;
                        }
                    case 3:
                        {
                            BubbleSort(array);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter number:");
                            int key = int.Parse(Console.ReadLine());
                            Find(array, key);
                            break;
                        }
                    case 5:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            }
            while (selected != 5);
        }
    }
}
