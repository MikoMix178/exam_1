static void recurs_natural(int m, int n)
{
    if (m > 0 && m <= n)
    {
        Console.WriteLine(m);
    }
    if (m < n)
    {
        recurs_natural(m + 1, n);
    }
}
recurs_natural(-2, 20);