namespace Day1 { 





    class Program {
        static void Main(string[] args)
        {
            // task 1

            Console.WriteLine("task 1 positive or negative ");
            Console.WriteLine("Please enter the number");
            int x = int.Parse(Console.ReadLine());
            if (x>0)
            {
                Console.WriteLine("the number is positive");
            }else if (x<0)
            {
                Console.WriteLine("the number is negative");
            }
            else
            {
                Console.WriteLine("the number is zero");
            }

            Console.WriteLine("*******************************************");

            //task 2
            Console.WriteLine("task 2 odd or even");
            Console.WriteLine("Please enter the number");
            int y = int.Parse(Console.ReadLine());
            if (y % 2 == 0)
            {
                Console.WriteLine("the number is even");
            }
            else
            {
                Console.WriteLine("the number is odd");
            }
            Console.WriteLine("*******************************************");

            //task 3
            Console.WriteLine("task 3 rectangle or square");
            Console.WriteLine("Please enter the length of the rectangle");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the width of the rectangle");
            int w = int.Parse(Console.ReadLine());
            if (l==w)
            {
                Console.WriteLine("it is a square");
            }else
            {
                Console.WriteLine("it is not a square");
            }

        }
    }

}
