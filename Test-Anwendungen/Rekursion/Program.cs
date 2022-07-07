// Fakultät
int Fakul (int n)
{
    int ret = 0;
    if (n <= 2)
    {
        ret = n;
    }
    else
    {
        ret = n * Fakul(n - 1);
    }
    return ret;
}

int meineVar = Fakul(10);
System.Console.WriteLine(meineVar);

// Fibonacci-Folge
int Fibo(int n)
{
    int ret = 0;
    if (n >= 13)
    {
        ret = n;
    }
    else
    {
        ret = n * Fibo(n);
    }
    System.Console.WriteLine(ret); 
    return ret;
}
// Fibo(13)
// --> 1
// ----> 1
// ------> 2
// --------> 3
// ----------> 5
// ------------> 8
// --------------> 13

meineVar = Fibo(1);