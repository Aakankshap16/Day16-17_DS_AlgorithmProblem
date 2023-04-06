namespace BinarySearchTree
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structures and Algorithms Practice Problem");
            Console.WriteLine("*********************");

            SortingWithGeneric<int> obj = new SortingWithGeneric<int>();
            int[] arr = new int[7] { 10, 22, 45, 88, 56, 77, 87 };
            obj.DisplayBubble(arr);
           int val = obj.BinarySearch(arr, 56);
            if (val == -1)
            {
                Console.WriteLine("Value not found in array.");
            }
            else
            {
                Console.WriteLine($"Value found at index {val}.");
            }


        }
    }
}