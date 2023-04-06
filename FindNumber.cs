namespace BinarySearchTree
{
    public class FindNumber
    {
        public void call(int low, int high)
        {
            if (low > high)
            {
                Console.WriteLine("Number not found.");
                return;
            }

            int mid = (low + high) / 2;

            Console.WriteLine($"Is the number between {low} and {mid}? (y/n) ");
            char answer = Convert.ToChar(Console.ReadLine());
            if (answer == 'y')
            {
                if (low == high)
                {
                    Console.WriteLine($"Your number is {high}");
                    return;
                }
                call(low, mid);
            }
            else
            {
                low = mid + 1;
                call(low, high);

            }




        }

    }
}
