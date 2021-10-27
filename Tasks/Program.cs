using System;

namespace ConsoleApp6
{
    class Program
    {
        //Task 5
        //static void Main(string[] args)
        //{

        //    int n;
        //    Console.Write("Enter the number to convert: ");
        //    n = int.Parse(Console.ReadLine());
        //    DecimalTobinary(n);
        //    static void DecimalTobinary(int n)
        //    {
        //        int[] a = new int[10];
        //        int i;
        //        for (i = 0; n > 0; i++)
        //        {
        //            a[i] = n % 2;
        //            n = n / 2;
        //        }
        //        Console.Write("Binary of the given number= ");
        //        for (i = i - 1; i >= 0; i--)
        //        {
        //            Console.Write(a[i]);
        //        }
        //    }



        //}




        //Task 8
        //public static void Main()
        //{
        //    int n, i, sum = 0;
        //    Console.Write("Input the numbe of terms : ");
        //    n = Convert.ToInt32(Console.ReadLine());
        //    SumOfSerios(n);

        //    static void SumOfSerios(int n)
        //    {
        //        int i, sum = 0;
        //        int t = 2;


        //        for (i = 1; i <= n; i++)
        //        {
        //            Console.Write("{0} + ", t);
        //            sum = sum + t;
        //            t = (t * 10) + 2;
        //        }
        //        Console.Write("\nThe Sum is : {0}\n", sum);
        //    }

        //}


        //Task 6 
        //public static void Main()
        //{
        //    int n;
        //    Console.WriteLine("Input: ");
        //    n = Convert.ToInt32(Console.ReadLine());
        //    cube(n);

        //    static void cube(int n)
        //    {
        //        int c = n * n * n;
        //        Console.WriteLine(c);
        //    }
        //}

        //Task 4
        //public static void Main()
        //{
        //    int number, index;
        //    Console.WriteLine("number: ");

        //    number = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("index: ");

        //    index = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("digit answer  " + digit(number, index));
        //    static char digit(int a, int b)
        //    {
        //        String x = a + "";
        //        char[] x1 = x.ToCharArray();
        //        int length = x1.Length;
        //        char result = x1[length - b];
        //        return result;
        //    }

        //}

        //Task 7
        //public static void Main()
        //{
        //    Console.WriteLine(Length(1234567890));
        //    static int Length(double number)
        //    {
        //        number = Math.Abs(number);
        //        int length = 1;
        //        while ((number /= 10) >= 1)
        //            length++;
        //        return length;
        //    }
        //}




        //Task 10
        //    static void Main(string[] args)
        //    {
        //        int count;
        //        string name = "Hello, How are you?";
        //        count = name.Split(' ').Length-1;
        //        Console.WriteLine("The count is " + count);
        //        Console.ReadLine();
        //    }
        //}



        //Task 9
        //    public static void Main(string[] args)
        //    {
        //        Console.Write("Enter a number: ");
        //        int n = Convert.ToInt32(Console.ReadLine());

        //        Console.WriteLine();

        //        for (int i = 1; i < n; i++)
        //        {
        //            for (int j = 1; j <= i; j++)
        //                Console.Write("*");
        //            Console.WriteLine();
        //        }
        //        for (int i = n; i >= 0; i--)
        //        {
        //            for (int j = 1; j <= i; j++)
        //                Console.Write("*");
        //            Console.WriteLine();
        //        }
        //        Console.WriteLine();
        //    }
        //
    }
}
