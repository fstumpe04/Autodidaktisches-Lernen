// int foo()
// {
//     return 1;
// }
//var meineFkt = foo;
//System.Console.WriteLine(meineFkt()); //1

// int bar(Func<int> baz)
// {
//     return baz();
// }

var meineFkt = foo;
// System.Console.WriteLine(bar(meineFkt));

int foo (int n, int n2)
{
    return n * n2;
}
int bar (Func<int> baz, int n)
{
    n2 = 1337;
    return baz(n, n2);
}
System.Console.WriteLine(bar(foo, 42));