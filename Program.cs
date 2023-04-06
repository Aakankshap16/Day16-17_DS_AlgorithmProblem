namespace BinarySearchTree
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Data Structures and Algorithms Practice Problem");
            Console.WriteLine("*********************");

            FindNumber obj = new FindNumber();
            Console.WriteLine("Enter the limit:");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Guess value B/W 0 to {N}");
            obj.call(0,N-1);
        }
    }
}