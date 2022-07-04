int sum (int N)
{
    int result =1;
    for(int i = 1; i <= N; i++)
    {
        result *= i;
    }
    Console.WriteLine(result);
    return result;
}

sum(10);
sum(4);