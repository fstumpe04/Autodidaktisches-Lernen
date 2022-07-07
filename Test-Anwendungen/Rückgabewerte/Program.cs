// void foo()
// {

// }

// foo();
int foo()
{
    bool abc = true;
    int ret = 0;
    int ergebnis = 42*1337;
    if (abc)
    {
        ret = ergebnis;
    }
    else
    {
        ret = 0;
    }
    return ret;
}

int meinInteger = foo();

System.Console.WriteLine(meinInteger);