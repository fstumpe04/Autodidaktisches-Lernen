// char
Console.WriteLine($"Die niedrigste char größe lautet: {char.MinValue}");
Console.WriteLine($"Die höchste char größe lautet: {char.MaxValue}");
for (long i = 0; i <= char.MaxValue; i++)
{
    Console.WriteLine($"DerBuchstabe an Stelle {i} lautet {(char)i}");
}