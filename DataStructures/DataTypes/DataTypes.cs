namespace DS
{
    public static class DataTypes
    {
        public static void Begin()
        {
            // bytes
            byte b = 125; // 0 - 255
            sbyte sb = -85; // -128 - 128
            Console.WriteLine($"byte = {b}, sbyte = {sb}");

            // int, double, decimal, float - numerical data types
            int i = -190; // -2,147,483,648 <= int <= 2,147,483,647
            uint ui = 90; // 0 <= uint <= 4,294,967,295
            Console.WriteLine($"int = {i}, unsigned int = {ui}");

            long l = 12839123;
            ulong ul = 12934712984;
            Console.WriteLine($"long = {l}, unsigned long = {ul}");

            double d = 123.35; // precision 15-16 digits
            float f = 123.35f; // prevision 7 digits (f denotes floating precision)
            Console.WriteLine($"double = {d}, float = {f}");

            // single bit character date type
            char c = 'a';
            Console.WriteLine($"c = {c}");

            // list of characters = string; it is a reference data type
            string s = "methran";
            Console.WriteLine($"string = {s}");
        }
    }
}
