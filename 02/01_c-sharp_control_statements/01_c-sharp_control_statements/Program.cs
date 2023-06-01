namespace _01_c_sharp_control_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice, i = 1;
            Console.WriteLine("1. for loop");
            Console.WriteLine("2. while loop");
            Console.WriteLine("3. do-while");
            Console.WriteLine("4. exit");
            Console.WriteLine("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("1. for loop");
                    for(i = 0; i < 10; i++)
                        Console.Write(i + " ");
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("2. while loop");
                    i = 0;
                    while (i < 10)
                    {
                        Console.Write(i + " ");
                        i++;
                    }
                    Console.WriteLine();
                        break;
                case 3:
                    Console.WriteLine("3. do-while");
                    i = 0;
                    do
                    {
                        Console.Write(i + " ");
                        i++;
                    }
                    while (i < 10);
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine("exiting... ");
                    break;
                default:
                    Console.WriteLine("Invalid choice!!");
                    break;
            }
        }
    }
}