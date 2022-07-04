int calculed (int A)
{
    int[] arr = new int[A];
    int result  = 0;
    for (int i = 0; i <= A; i++)
    {
        result += i; 
    }
    Console.WriteLine("calculed from 1 to {0} is {1}", A, result);
    return result;
}

calculed(7);
