int[] arr(int N)
{
    int[] result = new int[N];
    for(int i = 0; i <= 8; i++)
    {
        int a = new Random().Next(0, 2);
        result[i] = a;
        Console.Write(result[i] + " ");
         
    }
    return result;

}

arr(15);