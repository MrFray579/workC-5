int num (int N)
{
    int result = 0;
    int div = 1;
    while(N / div >= 1)
    {
        div *= 10;
        result += 1;
    }

    Console.WriteLine(result);
    return result;
}

num(5);
num(17);
num(175);
num(87579);