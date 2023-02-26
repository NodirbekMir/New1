void New(int N)
{
    if (N > 0)
    {
        Console.Write("{0} ", N);
        New(N - 1);
    }
}
New(5);