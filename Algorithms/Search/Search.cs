namespace Algorithms
{
    public static class Search
    {
        // TC - O(n)
        public static int LinearSearch(List<int> list, int value)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == value)
                {
                    return i; // return current index if element match
                }
            }

            return -1; // not found
        }

        // TC - O(log n)
        public static int BinarySearch(List<int> list, int value)
        {
            int l = 0, r = list.Count - 1;

            while (l <= r)
            {
                int m = l + (r - l) / 2;

                if (list[m] == value) return m; // return current middle index
                else if (list[m] > value) r = m - 1; // search first half (sub-array)
                else l = m + 1; // search second half (sub-array)
            }

            return -1; // not found
        }

        public static int CrystalBallProblem(List<bool> breaks)
        {
            // jump sqrt(n) times and linear search nearest efficient point
            int jumpLength = (int)Math.Sqrt(breaks.Count);
            int i = jumpLength;

            for (; i < breaks.Count; i += jumpLength)
            {
                if (breaks[i])
                {
                    break;
                }
            }

            i -= jumpLength;

            for (; i < breaks.Count; i++)
            {
                if (breaks[i])
                {
                    return i;
                }
            }

            return -1;
        }

        public static void Begin()
        {
            List<int> list = new List<int> { 1, 14, 22, 99, 110, 112 };
            int value = 110;

            int result;

            // result = LinearSearch(list, value);
            result = BinarySearch(list, value);

            Console.WriteLine($"{value} position: {result}");
        }
    }
}
