namespace BubbleSort
{
    public class Program
    {
        private const int ARRAY_SIZE = 15;
        static void Main(string[] args)
        {
            Console.WriteLine("Bubble Sort");

            int[] inputNumbers = new int[ARRAY_SIZE];

            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                Random random = new Random();
                inputNumbers[i] = random.Next(0, 99);
            }

            Console.WriteLine("Before:");
            PrintArray(inputNumbers);

            StartBubbleSort(inputNumbers);

            Console.WriteLine("After:");
            PrintArray(inputNumbers);

        }

        private static void StartBubbleSort(int[] inputNumbers)
        {
            bool swapingCompleted = true;
            while (swapingCompleted)
            {

                swapingCompleted = false;

                for (int i = 0; i < inputNumbers.Length - 1; i++)
                {

                    if (inputNumbers[i] > inputNumbers[i + 1])
                    {
                        swapingCompleted = true;
                        (inputNumbers[i + 1], inputNumbers[i]) = (inputNumbers[i], inputNumbers[i + 1]);
                    }
                }
            }

        }

        private static void PrintArray(int[] inputNumbers)
        {
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                Console.WriteLine(inputNumbers[i]);
            }
        }
    }
}