int x = 42;
int y = 1337;
int z = x+y;
System.Console.WriteLine($"Der Plus-Operator (+) ergibt {z}");
z = x-y;
System.Console.WriteLine($"Der Minus-Operator (-) ergibt {z}");
z = x*y;
System.Console.WriteLine($"Der Mal-Operator (*) ergibt {z}");
z = x/y;
System.Console.WriteLine($"Der Geteilt-Operator (/) ergibt {z}");
z = x%y;
System.Console.WriteLine($"Der Modulo-Operator (%) ergibt {z}");

// Inkrement
x = 5;
y = 3;

z = y++;
System.Console.WriteLine($"z ist gleich {z} und y ist gleich {y}");

int w = ++x;
System.Console.WriteLine($"w ist gleich {w} und x ist gleich {x}");

// Dekrement
x = 5;
y = 3;

z = y--;
System.Console.WriteLine($"z ist gleich {z} und y ist gleich {y}");

w = --x;
System.Console.WriteLine($"w ist gleich {w} und x ist gleich {x}");