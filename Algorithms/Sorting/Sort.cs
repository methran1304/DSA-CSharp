namespace Algorithms
{
    public static class Sort
    {
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n; i++) // iterate n times
            {
                bool madeSwaps = false;

                for (int j = 0; j < n - 1 - i; j++) // iterate from first element to (n - 1 - i)th element
                {
                    if (arr[j] > arr[j + 1]) // check adjacent elements and swap if the first element > second element
                    {
                        madeSwaps = true;
                        (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);
                    }
                }

                if (!madeSwaps)
                    break; // array is already sorted
            }
        }

        public static void PrintArray(int[] arr)
        {
            foreach (int elem in arr)
            {
                Console.Write($"{elem} ");
            }

            Console.Write('\n');
        }

        public static void Begin()
        {
            int[] arr = [5, 1, 3, 2, 4];

            PrintArray(arr);
            BubbleSort(arr);
            PrintArray(arr);
        }
    }
}
