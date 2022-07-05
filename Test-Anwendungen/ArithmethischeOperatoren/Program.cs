int x = 5;
int y = 3;
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

// Exponenten
x = 2;
y = 11;

z = (int)Math.Pow(x,y);
System.Console.WriteLine($"Die Exponente lautet {z}");

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