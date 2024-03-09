static void print_array_reverse(int[] m, int iter)
{
    if (iter <= m.Length)
    {
        Console.WriteLine(m[m.Length - iter]);
        print_array_reverse(m, iter + 1);
    }
}
print_array_reverse([1, 2, 3, 4, 5, 6, 7, 8, 9, 0], 1);