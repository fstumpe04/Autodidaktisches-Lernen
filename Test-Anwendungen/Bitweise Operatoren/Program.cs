// Logischer AND-Operator &
uint a = 0b_1111_1000; //0xF8
uint b = 0b_1001_1101; //0x9D
uint c = a & b;
Console.WriteLine(Convert.ToString(c, toBase: 2));
// Output:
// 10011000 0x98

// Logischer OR-Operator |
a = 0b_1010_0000; //0xA0
b = 0b_1001_0001; //0x91
c = a | b;
Console.WriteLine(Convert.ToString(c, toBase: 2));
// Output:
// 10110001 0xB1

// Logischer exklusiver OR-Operator ^
a = 0b_1111_1000; //0xF8
b = 0b_0001_1100; //0x1C
c = a ^ b;
Console.WriteLine(Convert.ToString(c, toBase: 2));
// Output:
// 11100100 0xE4

// Operator für Linksverschiebung <<
uint x = 0b_1100_1001_0000_0000_0000_0000_0001_0001; //0xC9000011
Console.WriteLine($"Before: {Convert.ToString(x, toBase: 2)}");

uint y = x << 4;
Console.WriteLine($"After:  {Convert.ToString(y, toBase: 2)}");
// Output:
// Before: 11001001000000000000000000010001 0xC9000011
// After:  10010000000000000000000100010000 0x90000110

byte aByte = 0b_1111_0001; //0xF1

var bByte = aByte << 8;
Console.WriteLine(bByte.GetType());
Console.WriteLine($"Shifted byte: {Convert.ToString(bByte, toBase: 2)}");
// Output:
// System.Int32
// Shifted byte: 1111000100000000 0xF100

// Operator für die rechte Schicht >>

// Falls signed int oder signed long
int signedA = int.MinValue;
Console.WriteLine($"Before: {Convert.ToString(a, toBase: 2)}");

int signedB = signedA >> 3;
Console.WriteLine($"After:  {Convert.ToString(signedB, toBase: 2)}");
// Output:
// Before: 10000000000000000000000000000000 
// After:  11110000000000000000000000000000

// Falls unsigned int oder unsigned long
c = 0b_1000_0000_0000_0000_0000_0000_0000_0000;
Console.WriteLine($"Before: {Convert.ToString(c, toBase: 2), 32}");

uint d = c >> 3;
Console.WriteLine($"After:  {Convert.ToString(d, toBase: 2), 32}");
// Output:
// Before: 10000000000000000000000000000000
// After:     10000000000000000000000000000

// Nicht signierter Operator für die rechte Schicht >>>
int signedX = -8;
Console.WriteLine($"Before:    {signedX,11}, hex: {signedX,8:x}, binary: {Convert.ToString(signedX, toBase: 2),33}");

int signedY = signedX >> 2;
Console.WriteLine($"After  >>: {signedY,11}, hex: {signedY,8:x}, binary: {Convert.ToString(signedY, toBase: 2),33}");

// Ist erst ab C# 11 verfügbar
// int signedZ = signedX >>> 2;
// Console.WriteLine($"After >>>: {signedZ,11}, hex: {signedZ,8:x}, binary: {Convert.ToString(signedZ, toBase: 2),33}");
// Output:
// Before:             -8, hex: fffffff8, binary:  11111111111111111111111111111000
// After  >>:          -2, hex: fffffffe, binary:  11111111111111111111111111111110
// After >>>:  1073741822, hex: 3ffffffe, binary:    111111111111111111111111111110