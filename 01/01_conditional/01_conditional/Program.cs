public class ConditionalStatements
{
    public static void Main(string[] args)
    {
        int choice, x = 100, y = 20;
        Console.WriteLine("1. simple if");
        Console.WriteLine("2. if-else");
        Console.WriteLine("3. if-else-if");
        Console.WriteLine("4. ternary operator");
        Console.WriteLine("5. exit");
        Console.Write("Enter your choice: ");
        choice = Convert.ToInt32(Console.ReadLine());

        switch(choice)
        {
            case 1: 
                Console.WriteLine("1. simple if");
                if (x > y)
                {
                    Console.WriteLine("x is greater than y");
                }
                break;
            case 2:
                Console.WriteLine("2. if-else");
                if (x < y)
                {
                    Console.WriteLine("x is greater than y");
                }
                else
                {
                    Console.WriteLine("y is greater.");
                }
                break;
            case 3:
                Console.WriteLine("3. if-else-if");
                if(x > y)
                {
                    Console.WriteLine("x is greater than y");
                }
                else if(y > x)
                {
                    Console.WriteLine("y is  greater than x");
                }
                else
                {
                    Console.WriteLine(" both are equal!!");
                }
                break;
            case 4:
                Console.WriteLine("ternary operator");
                string result = (x > y) ? "x is greater than y" : "y is greater than x";
                Console.WriteLine(result);
                break;
            case 5:
                Console.WriteLine("exiting...");
                break;
            default:
                Console.WriteLine("Invalid choice!!!");
                break;
        }
    }
}