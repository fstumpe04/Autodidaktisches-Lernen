// int foo(bool abc)
// {
//     int ret = 0;
//     int ergebnis = 42*1337;
//     if (abc)
//     {
//         ret = ergebnis;
//     }
//     else
//     {
//         ret = 0;
//     }
//     return ret;
// }

// int meinInteger = foo(true);
// int meinInteger2 = foo(false);

// System.Console.WriteLine(meinInteger + "\n" + meinInteger2);

int foo(bool abc, int def, int hij)
{
    int ret = 0;
    int ergebnis = def*hij;
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
bool meinBool = true;
int meinInteger = foo(meinBool, 42, 1337);

System.Console.WriteLine(meinInteger);