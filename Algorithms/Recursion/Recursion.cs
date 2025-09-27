namespace Algorithms;

public static class Recursion
{
    private static int Sum(int n)
    {
        if (n <= 1) return n;
        return n + Sum(n - 1);
    }

    public static void Begin()
    {
        int n = 3;
        int result = Sum(n);
        Console.WriteLine(result);
    }
}
