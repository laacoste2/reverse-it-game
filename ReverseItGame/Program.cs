using System.Linq;

namespace ReverseItGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>
            {
                1, 5, 9, 3, 7, 8, 2, 4, 6
            };

            while (!Win(numbers))
            {
                Console.Clear();

                Console.WriteLine("The list:");
                Console.WriteLine(string.Join(" ", numbers));

                Console.WriteLine("\n\nType the position (1-9): ");
                int numberToReverse = int.Parse(Console.ReadLine());

                List<int> numbersToRevert;
                List<int> reversedNumbersToRevert;
                Console.Clear();

                if(numberToReverse > 1 && numberToReverse <= numbers.Count)
                {
                    numbersToRevert = numbers.GetRange(0, numberToReverse);
                    reversedNumbersToRevert = numbersToRevert.AsEnumerable().Reverse().ToList();

                    numbers.RemoveRange(0, numberToReverse);
                    numbers.InsertRange(0, reversedNumbersToRevert);
                }
                else
                {
                    Console.WriteLine("Invalid Index");
                    Console.ReadLine();
                }
            }

            Console.WriteLine("You WON the game!!!");

        }

        public static bool Win(List<int> numbers)
        {
            if (numbers[0] == 1 && numbers[1] == 2 && numbers[2] == 3 && numbers[3] == 4 &&
                numbers[4] == 5 && numbers[5] == 6 && numbers[6] == 7 && numbers[7] == 8 &&
                numbers[8] == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}