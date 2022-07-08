// void foo(int a){
//     a = 1337;
// }
// int a = 42;
// foo(a);
// System.Console.WriteLine(a); // 42

void foo(ref List<int> list){
    list = new List<int>() {4, 5, 6};
}
List<int> list = new List<int>() {1, 2, 3};
foo(ref list);
foreach (var item in list)
{
    System.Console.WriteLine(item); // 4 , 5, 6
}