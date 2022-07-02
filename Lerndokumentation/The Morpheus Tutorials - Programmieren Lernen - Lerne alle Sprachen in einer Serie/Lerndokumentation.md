# Lerndokumentation Programmieren Lernen
## Lerntagebuch 02.07.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Syntax (Zusammenfügungsregeln von Zeichen)
2. Semantik (Interpretationsregeln)
3. Variablen
4. Codefluss
5. Schwachtypisierte Programmiersprachen
6. Starktypisierte Programmiersprachen
7. Byte - Ganzzahlen
8. Short - Ganzzahlen
9. Integer - Ganzzahlen
10. Long, Long Long oder BigInteger - Ganzzahlen
11. Float - Fließkommazahlen
12. Double - Fließkommazahlen
### Einleitung [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
#### Syntax (Zusammenfügungsregeln von Zeichen)
Die Syntax ist das was man im Quelltext auf den ersten Blick sieht. Sie ist von Programmiersprache zu Programmiersprache unterschiedlich und ist das was man später neu an einer weiteren Programmiersprache lernen muss.
#### Semantik (Interpretationsregeln)
Die Semantik ist die Bedeutung die der Quelltext hat, bzw. ist es das was der Quelltext in wirklichkeit ausführt.  
`int a = 5;`  
und  
`a = 5`   
haben die selbe Semantik.
### Variablen und der Codefluss [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
#### Variablen
Variablen werden in einer Programmiersprache dazu verwendet, sie im Arbeitsspeicher (RAM = Random-Access Memory) zu speichern und im weiteren Verlauf der Durchführung des Programms zu verwenden.  
`int a = 5;`
`print (a); // Würde 5 ausgeben`
`a = 10;`
`print (a); // Würde 10 ausgeben`

Heisst je mehr Variablen man verwendet je mehr Arbeitspeicher wird genutzt und desto langsamer wird das Programm, da bspw. der Arbeitsspeicher so überfüllt ist, das auf die Speicherfreigabe von anderen Variablen gewartet werden muss. 

Initialisiert und deklariert wird eine Variable z. B. so:  
`int a = 5;`  
`int` ist hier der Datentyp.  
`a` ist hier der Variablenname.  
`=` sagt aus das der folgende Variablenwert zugewiesen wird.  
`5` ist hier der zugewiesene Variablenwert.  
`;` definiert das Zeilenende.  

Hierbei kann auch nur die Initialisierung: `int a;` und nur die Deklaration `a = 5;` druchgeführt werden.  

Hier dürfen auch keine Variablennamen mit Leerzeichen getrennt werden da sonst der Kompiler diese nicht lesen kann.

Für die Wertänderungen und die Speicherverwaltung generell, gibt es auch Referenzen die beliebig gesetzt werden können.

An sich haben Variablen unterschiedlich große Speicherkapazitäten.

#### Codefluss
Der Codefluss an sich verläuft immer von oben nach unten und wird zeilenweise ausgeführt. Bei den einen Programmiersprachen wird das Zeilenende durch ein Zeichen deklariert (bspw. ein `;`), bei anderen wird das Zeilenende durch Zeilenumbrüche und Absätze dem Kompilier geläufig gemacht.
### Integer - Ganzzahlen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
#### Schwachtypisierte Programmiersprachen
Müssen keinen fest definierten Datentyp definiert bekommen.  
Es reicht entwerder nichts, var oder ein $-Zeichen davor zu schreiben, damit der Kompiler selbst entscheidet welchen Datentyp der zugehörige Varaiblenwert hat.
#### Starktypisierte Programmiersprachen
Benötigen zwingent einen von der Programmiersprache und selbst festgelegten Datentypen wie bspw. `int`.
#### Byte - Ganzzahlen
Existieren in Programmiersprachen bspw. als: `int8_t` oder `byte`, sind 8 Bit also 1 Byte groß und es gibt sie in einer signed und unsigned Variante.  
Falls man mit dem übergeben Wert einen Punkt außerhalb der folgenden Range fallen würde, würde man wieder von Vorne bzw. von Hinten anfangen zu zählen. Das nennt sich auch Overflow  
C# Beispiel:  
// sbyte (signed Variante)  
Die niedrigste sbyte größe lautet: -128  
Die höchste sbyte größe lautet: 127  
// byte (unsigned Variante)  
Die niedrigste byte größe lautet: 0  
Die höchste byte größe lautet: 255
#### Short - Ganzzahlen
Sind 16 Bit (2^16) groß und es gibt sie in einer signed und unsigned Variante.  
C#-Beispiel:  
// short (signed-Variante)
Die niedrigste short größe lautet: -32768
Die höchste byte größe lautet: 32767
// ushort (unsigned-Variante)
Die niedrigste ushort größe lautet: 0
Die höchste ubyte größe lautet: 65535
#### Integer - Ganzzahlen
Sind 32 Bit (2^32) groß und es gibt sie in einer signed und unsigned Variante. 
C#-Beispiel:  
// int (signed-Variante)
Die niedrigste int größe lautet: -2147483648
Die höchste int größe lautet: 2147483647
// uint (unsigned-Variante)
Die niedrigste uint größe lautet: 0
Die höchste uint größe lautet: 4294967295
#### Long, Long Long oder BigInteger - Ganzzahlen
Sind je nach Betriebssystem 32/64 Bit (2^32/2^64) groß und es gibt sie in einer signed und unsigned Variante.  
C#-Beispiel:  
// long (signed-Variante)
Die niedrigste long größe lautet: -9223372036854775808
Die höchste long größe lautet: 9223372036854775807
// long (unsigned-Variante)
Die niedrigste ulong größe lautet: 0
Die höchste ulong größe lautet: 18446744073709551615
// nint (signed-Variante)
Die niedrigste nint größe lautet: -9223372036854775808
Die höchste nint größe lautet: 9223372036854775807
// nuint (unsigned-Variante)
Die niedrigste nuint größe lautet: 0
Die höchste nuint größe lautet: 18446744073709551615
### Fließkommazahlen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
#### Float - Fließkommazahlen
Werden immer mit einem `.` getrennt und durch Exponenten dargestellt.  
Beispiel: 2147*1-³ = 2.147 u. 11100111001*2-5 = 111001.11001  
Im Rechner wird IEEE754 zum umrechnen von Fließkommazahlen genutzt.  
Generel sind Fließkommazahlen eeher ungenau, da wenn man bspw. folgende Variable deklariert
`double a = 0.7;`  
der Varialbenwert 0.69999999999999995559107 usw. rauskommen kann.  

C#-Beispiel:  
// float.MinValue
Die niedrigste Floatgröße lautet: -3.4028235E+38
// float.MaxValue
Die höchste Floatgröße lautet: 3.4028235E+38
// float.Epsilon
Der Epsilon-Wert von float lautet: 1E-45
// float.NaN
Der NaN-Wert von float lautet: NaN
// float.NegativeInfinity
Der NegativeInfinity-Wert von float lautet: -8
// float.PositiveInfinity
Der PositiveInfinity-Wert von float lautet: 8
#### Double - Fließkommazahlen
C#-Beispiel:  
// double.MinValue
Die niedrigste Doublegröße lautet: -1.7976931348623157E+308
// double.MaxValue
Die höchste Doublegröße lautet: 1.7976931348623157E+308
// double.Epsilon
Der Epsilon-Wert von double lautet: 5E-324
// double.NaN (Not a Number da der Computer nicht unendlich abbilden kann)
Der NaN-Wert von double lautet: NaN
// double.NegativeInfinity
Der NegativeInfinity-Wert von double lautet: -8
// double.PositiveInfinity
Der PositiveInfinity-Wert von double lautet: 8