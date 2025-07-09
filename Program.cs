// See https://aka.ms/new-console-template for more information
namespace ITIDay2 {
    class Program
    {
        static void Main(string[] args)
        {


            int ID;
            do
            {
                Console.WriteLine("please enter your ID");
                ID = int.Parse(Console.ReadLine());
                if (ID <= 0)
                {
                    Console.WriteLine(" it's wrong");
                }
            } while (ID <= 0);

            Console.WriteLine($"your ID is {ID}");

            string name;
            bool hasNumber;

            do
            {
                Console.WriteLine("Please enter your name:");
                name = Console.ReadLine();
                hasNumber = false;

                for (int i = 0; i < name.Length; i++)
                {
                    char c = name[i];
                    if (c >= '0' && c <= '9')
                    {
                        hasNumber = true;
                        Console.WriteLine("Names should not contain numbers. Try again.");
                        break;
                    }
                }

            } while (hasNumber);

            Console.WriteLine("Welcome, " + name + "!");

            int Age;
            do
            {
                Console.WriteLine("please enter your Age");
                Age = int.Parse(Console.ReadLine());
                if (Age <= 0)
                {
                    Console.WriteLine(" it's wrong");
                }
            } while (Age <= 0);

            Console.WriteLine($"your Age is {Age}");

            int Salary;
            do
            {
                Console.WriteLine("please enter your Salary");
                Salary = int.Parse(Console.ReadLine());
                if (Salary <= 0)
                {
                    Console.WriteLine(" it's wrong");
                }
            } while (Salary <= 0);

            Console.WriteLine($"your Salary is {Salary}");






            Console.WriteLine("************************");
            Console.WriteLine("Task 2");
            Console.WriteLine("Here is the Time Table");

            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 12; j++) { 
                    Console.WriteLine($"{i} * {j} = {i*j}");
                }
            }




            Console.WriteLine("************************");
            Console.WriteLine("Task 3");
            Console.WriteLine("Please enter the number of students");
            int studnum = int.Parse(Console.ReadLine());
            int[] grades = new int[studnum];
            for (int i = 0; i < studnum; i++)
            {
                Console.WriteLine("Please enter grade for student " + (i + 1) + ":");
                grades[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < studnum - 1; i++)
            {
                for (int j = i + 1; j < studnum; j++)
                {
                    if (grades[i] > grades[j])
                    {
                        int temp = grades[i];
                        grades[i] = grades[j];
                        grades[j] = temp;
                    }
                }
            }
            int max = grades[studnum - 1];
            int min = grades[0];

            Console.WriteLine("Sorted grades:");
            for (int i = 0; i < studnum; i++)
            {
                Console.WriteLine("Student " + (i + 1) + ": " + grades[i]);
            }

            // Print max and min
            Console.WriteLine("Maximum grade: " + max);
            Console.WriteLine("Minimum grade: " + min);
        }


    }
}

