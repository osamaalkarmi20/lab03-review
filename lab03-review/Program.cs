using System;
using System.IO;

namespace lab03_review
{
    public class Program
    {
        static void Main()
        {
            userInterFace();
        }

        public static void userInterFace()
        {
            try
            {
                Console.WriteLine("choose a transaction proccess between 1-10:");
                Console.WriteLine("1. challenge 1");
                Console.WriteLine("2. challenge 2");
                Console.WriteLine("3. challenge 3");
                Console.WriteLine("4. challenge 4");
                Console.WriteLine("5. challenge 5");
                Console.WriteLine("6. challenge 6");
                Console.WriteLine("7. challenge 7");
                Console.WriteLine("8. challenge 8");
                Console.WriteLine("9. challenge 9");
                Console.WriteLine("10. exit");
                int choosen = Convert.ToInt32(Console.ReadLine());

                switch (choosen)
                {
                    case 1:


                        Console.WriteLine($"challange 1 : write 3 numbers to get the product and , ");
                        string numbers = Console.ReadLine();


                        Console.WriteLine($"{product(numbers)}");
                        userInterFace();
                        break;

                    case 2:

                        Console.WriteLine($"challange 2 : write number to get the size form 2-10:");

                        int size = Convert.ToInt32(Console.ReadLine());
                        string[] arryofinputs = new string[size];
                        for (int i = 0; i < size; i++)
                        {
                            Console.Write($"Please enter number {i + 1}of {size}: ");
                            arryofinputs[i] = Console.ReadLine();

                        }
                        Console.WriteLine($"{avarage(size, arryofinputs)}");
                        userInterFace();
                        break;
                    case 3:


                        star();
                        userInterFace();
                        break;
                    case 4:

                        int[] array = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };
                        Console.WriteLine($"the most duplicate is {duplicate(array)}");
                        userInterFace();
                        break;
                    case 5:

                        int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
                        Console.WriteLine($"this is the max value in   1, 2, 3, 4, 5, 6, 7  is  {max(arr)}");
                        userInterFace();
                        break;
                    case 6:

                        SaveToFile();
                        userInterFace();
                        break;
                    case 7:

                        ReadFileText();
                        userInterFace();
                        break;
                    case 8:
                        Console.WriteLine(removeLastText());
                        userInterFace();

                        break;
                    case 9:

                        string input = "This is a sentance about important things";
                        string[] arrayofinput = numofcar(input);
                        for (int i = 0; i < arrayofinput.Length; i++)
                        {
                            Console.Write(arrayofinput[i]);
                        }

                        Console.WriteLine();
                        userInterFace();
                        break;
                    case 10:

                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("you entered the number out of range ");

                        userInterFace();
                        break;
                }

            }

            catch (FormatException)
            {
                Console.WriteLine("please inter a valid number ");
                userInterFace();
            }

        }
        public static int avarage(int size, string[] input)
        {

            int[] num = new int[size];


            int sum = 0;
            int avg = 0;
            if (size == 0)
            {

                return avg;
            }
            try
            {
                for (int i = 0; i < size; i++)


                {
                    num[i] = Convert.ToInt32(input[i]);
                    if (num[i] < 0)
                    {
                        return -1;
                    }

                    sum = num[i] + sum;
                }
                avg = sum / size;
                return avg;

            }
            catch (FormatException)
            {

                Console.WriteLine("you didn't input a data type as numbers");
                return -10;

            }

        }



        public static int product(string numbers)

        {
            string[] number = numbers.Split(',');
            int[] array = new int[number.Length];

            int product = 1;

            if (number.Length < 3)
            {
                return 0;
            }

            for (int i = 0; i < 3; i++)
            {
                try
                {
                    array[i] = Convert.ToInt32(number[i]);
                    product *= array[i];
                }

                catch (FormatException)
                {

                    array[i] = 1;
                    product *= array[i];

                }


            }
            return product;



        }
        public static void star()
        {
            int rows = 5;
            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < rows - i - 1; j++)
                {
                    Console.Write(" ");
                }


                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }


            for (int i = rows - 2; i >= 0; i--)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    Console.Write(" ");
                }


                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
        public static int max(int[] array)
        {


            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }
        public static void SaveToFile()
        {
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();

            string path = "word.txt";



            File.WriteAllText(path, word);
        }
        public static void ReadFileText()
        {
            string path = "word.txt";
            string dataFromFile = File.ReadAllText(path);


            Console.WriteLine(dataFromFile);
        }
        public static string removeLastText()
        {
            string path = "word.txt";
            string dataFromFile = File.ReadAllText(path);
            string newArray = "";

            string[] array = dataFromFile.Split(" ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == array[array.Length - 1])
                    array[i] = array[i];
                newArray = $"{newArray} {array[i]}";
            }
            return newArray;


        }


        public static string[] numofcar(string input)
        {

            string[] am = input.Split(" ");
            string[] array = new string[am.Length];
            int Counter = 0;
            for (int j = 0; j < am.Length; j++)
            {
                for (int i = 0; i < am[j].Length; i++)
                {
                    Counter++;
                }
                array[j] = $"{Counter}";
                Counter = 0;
            }
            for (int i = 0; i < am.Length - 1; i++)
            {
                array[i] = $"{am[i]} : {array[i]} ,";
            }
            array[am.Length - 1] = $"{am[am.Length - 1]} : {array[am.Length - 1]} ";
            return array;
        }
        public static int duplicate(int[] arr)
        {
            int dup = arr[0];
            int maxCount = 1;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int Num = arr[i];
                int count = 1;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] == Num)
                    {
                        count++;
                    }
                }

                if (count > maxCount)
                {
                    dup = Num;
                    maxCount = count;
                }
            }

            return dup;
        }

    }
}