namespace DS
{
    public static class Array
    {
        public static void Begin()
        {
            // declare an integer arrya of size 10 with default values
            int[] intArray = new int[10];
            Console.WriteLine($"Length of intArray = {intArray.Length}");

            // declare and initialize an array
            char[] charArray = { 'a', 'b', 'c' };
            Console.WriteLine($"2nd character [a, b, c] = {charArray[1]}");

            // variable length array = list
            List<int> intList = new List<int>(); // no need to set length
            List<string> stringList = new List<string>();

            // initialize list
            List<bool> boolList = new List<bool> { false, true, false };

            string name = "methran";
            char[] nameArray = name.ToCharArray();

            for (int i = 0; i < nameArray.Length; i++)
            {
                Console.Write(nameArray[i]);
            }
        }
    }
}
