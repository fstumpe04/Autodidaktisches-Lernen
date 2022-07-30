# Lerndokumentation [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
1. Syntax (Zusammenf¸gungsregeln von Zeichen)
2. Semantik (Interpretationsregeln)
3. Variablen
4. Codefluss
5. Schwachtypisierte Programmiersprachen
6. Starktypisierte Programmiersprachen
7. Byte - Ganzzahlen
8. Short - Ganzzahlen
9. Integer - Ganzzahlen
10. Long, Long Long oder BigInteger - Ganzzahlen
11. Float - Flieﬂkommazahlen
12. Double - Flieﬂkommazahlen
13. Buchstaben - Character
14. Kommentare
15. Arrays
16. Mehrdimensionale Arrays
17. Listen
18. Mehrdimensionale Listen
19. Strings
20. Unicode-Zeichensatz
21. Arithmetische Operatoren
22. IF-Verzweigungen
23. Booleans und Vergleichsoperatoren
24. Logische Operatoren
25. Bitweise Operatoren
26. While Schleifen 
27. for-Schleifen
28. foreach-Schleifen
29. break und continue
30. Funktionen 
31. R¸ckgabewerte
32. Parameter
33. Rekursion
34. Default Argumente 
35. Call-by-Value vs Call-by-Reference
36. Lazy Evaluation
37. Function Pointer
38. Lambda Funktionen
39. Inline Funktionen
40. Code lesen
41. Klassen
42. Methoden
43. Konstruktoren
44. Zugriffsmodifikatoren
45. Getter/Setter
46. Static - Klassenvariablen
47. Vererbung 
48. TypeCasts 
49. instanceof
50. typeof
51. ¸berschreiben von Methoden
52. Enums
53. Operatoren ¸berschreiben 
54. Super
55. Interfaces
56. Mehrfachvererbung und das Diamantenproblem
57. Abstrakte Klassen 
58. Der Zugriffsmodifikator protected
59. Statische innere Klassen
60. Innere Klassen
61. Anonyme innere Klassen 
62. Module 
63. Dynamic vs Static Scoping
64. Mixins
65. Generics 
66. Generische Funktionen
67. Typschranken
68. Prozesse und Threads
69. Threads erstellen
70. Nebenl‰ufigkeit von Threads 
71. Atomare Operationen
72. synchronized
73. locks
74. Semaphoren
75. Deadlocks
76. Concurrent Programming Languages 
77. Actors und Message Passing
78. Events
79. Event Driven Development
80. Debugging und Breakpoints
81. Testen
82. Exceptions
83. Eigene Exceptions
84. RegEx - Regul‰re Ausdr¸cke
## Einleitung [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
### Syntax (Zusammenf¸gungsregeln von Zeichen)
Die Syntax ist das was man im Quelltext auf den ersten Blick sieht. Sie ist von Programmiersprache zu Programmiersprache unterschiedlich und ist das was man sp?ter neu an einer weiteren Programmiersprache lernen muss.
### Semantik (Interpretationsregeln)
Die Semantik ist die Bedeutung die der Quelltext hat, bzw. ist es das was der Quelltext in wirklichkeit ausf¸hrt.  
`int a = 5;`  
und  
`a = 5`   
haben die selbe Semantik.
## Variablen und der Codefluss [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
### Variablen
Variablen werden in einer Programmiersprache dazu verwendet, sie im Arbeitsspeicher (RAM = Random-Access Memory) zu speichern und im weiteren Verlauf der Durchf?hrung des Programms zu verwenden.  
`int a = 5;`  
`print (a); // W?rde 5 ausgeben`  
`a = 10;`
`print (a); // W?rde 10 ausgeben`

Heisst je mehr Variablen man verwendet je mehr Arbeitspeicher wird genutzt und desto langsamer wird das Programm, da bspw. der Arbeitsspeicher so ?berf?llt ist, das auf die Speicherfreigabe von anderen Variablen gewartet werden muss. 

Initialisiert und deklariert wird eine Variable z. B. so:  
`int a = 5;`  
`int` ist hier der Datentyp.  
`a` ist hier der Variablenname.  
`=` sagt aus das der folgende Variablenwert zugewiesen wird.  
`5` ist hier der zugewiesene Variablenwert.  
`;` definiert das Zeilenende.  

Hierbei kann auch nur die Initialisierung: `int a;` und nur die Deklaration `a = 5;` druchgef?hrt werden.  

Hier d?rfen auch keine Variablennamen mit Leerzeichen getrennt werden da sonst der Kompiler diese nicht lesen kann.

F?r die Wert?nderungen und die Speicherverwaltung generell, gibt es auch Referenzen die beliebig gesetzt werden k?nnen.

An sich haben Variablen unterschiedlich gro?e Speicherkapazit?ten.

### Codefluss
Der Codefluss an sich verl?uft immer von oben nach unten und wird zeilenweise ausgef?hrt. Bei den einen Programmiersprachen wird das Zeilenende durch ein Zeichen deklariert (bspw. ein `;`), bei anderen wird das Zeilenende durch Zeilenumbr?che und Abs?tze dem Kompilier gel?ufig gemacht.
## Integer - Ganzzahlen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
### Schwachtypisierte Programmiersprachen
M?ssen keinen fest definierten Datentyp definiert bekommen.  
Es reicht entwerder nichts, var oder ein $-Zeichen davor zu schreiben, damit der Kompiler selbst entscheidet welchen Datentyp der zugeh?rige Varaiblenwert hat.
### Starktypisierte Programmiersprachen
Ben?tigen zwingent einen von der Programmiersprache und selbst festgelegten Datentypen wie bspw. `int`.
### Byte - Ganzzahlen
Existieren in Programmiersprachen bspw. als: `int8_t` oder `byte`, sind 8 Bit also 1 Byte gro? und es gibt sie in einer signed und unsigned Variante.  
Falls man mit dem ?bergeben Wert einen Punkt au?erhalb der folgenden Range fallen w?rde, w?rde man wieder von Vorne bzw. von Hinten anfangen zu z?hlen. Das nennt sich auch Overflow  
C# Beispiel:  
// sbyte (signed Variante)  
Die niedrigste sbyte gr??e lautet: -128  
Die h?chste sbyte gr??e lautet: 127  
// byte (unsigned Variante)  
Die niedrigste byte gr??e lautet: 0  
Die h?chste byte gr??e lautet: 255
### Short - Ganzzahlen
Sind 16 Bit (2^16) gro? und es gibt sie in einer signed und unsigned Variante.  
C#-Beispiel:  
// short (signed-Variante)
Die niedrigste short gr??e lautet: -32768
Die h?chste byte gr??e lautet: 32767
// ushort (unsigned-Variante)
Die niedrigste ushort gr??e lautet: 0
Die h?chste ubyte gr??e lautet: 65535
### Integer - Ganzzahlen
Sind 32 Bit (2^32) gro? und es gibt sie in einer signed und unsigned Variante. 
C#-Beispiel:  
// int (signed-Variante)
Die niedrigste int gr??e lautet: -2147483648
Die h?chste int gr??e lautet: 2147483647
// uint (unsigned-Variante)
Die niedrigste uint gr??e lautet: 0
Die h?chste uint gr??e lautet: 4294967295
### Long, Long Long oder BigInteger - Ganzzahlen
Sind je nach Betriebssystem 32/64 Bit (2^32/2^64) gro? und es gibt sie in einer signed und unsigned Variante.  
C#-Beispiel:  
// long (signed-Variante)
Die niedrigste long gr??e lautet: -9223372036854775808
Die h?chste long gr??e lautet: 9223372036854775807
// long (unsigned-Variante)
Die niedrigste ulong gr??e lautet: 0
Die h?chste ulong gr??e lautet: 18446744073709551615
// nint (signed-Variante)
Die niedrigste nint gr??e lautet: -9223372036854775808
Die h?chste nint gr??e lautet: 9223372036854775807
// nuint (unsigned-Variante)
Die niedrigste nuint gr??e lautet: 0
Die h?chste nuint gr??e lautet: 18446744073709551615
## Flie?kommazahlen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
### Float - Flie?kommazahlen
Werden immer mit einem `.` getrennt und durch Exponenten dargestellt.  
Beispiel: 2147*1-ù = 2.147 u. 11100111001*2-5 = 111001.11001  
Im Rechner wird IEEE754 zum umrechnen von Flie?kommazahlen genutzt.  
Generel sind Flie?kommazahlen eeher ungenau, da wenn man bspw. folgende Variable deklariert
`double a = 0.7;`  
der Varialbenwert 0.69999999999999995559107 usw. rauskommen kann.  

C#-Beispiel:  
// float.MinValue
Die niedrigste Floatgr??e lautet: -3.4028235E+38
// float.MaxValue
Die h?chste Floatgr??e lautet: 3.4028235E+38
// float.Epsilon
Der Epsilon-Wert von float lautet: 1E-45
// float.NaN
Der NaN-Wert von float lautet: NaN
// float.NegativeInfinity
Der NegativeInfinity-Wert von float lautet: -8
// float.PositiveInfinity
Der PositiveInfinity-Wert von float lautet: 8
### Double - Flie?kommazahlen
C#-Beispiel:  
// double.MinValue
Die niedrigste Doublegr??e lautet: -1.7976931348623157E+308
// double.MaxValue
Die h?chste Doublegr??e lautet: 1.7976931348623157E+308
// double.Epsilon
Der Epsilon-Wert von double lautet: 5E-324
// double.NaN (Not a Number da der Computer nicht unendlich abbilden kann)
Der NaN-Wert von double lautet: NaN
// double.NegativeInfinity
Der NegativeInfinity-Wert von double lautet: -8
// double.PositiveInfinity
Der PositiveInfinity-Wert von double lautet: 8

## Buchstaben - Character [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Der Character wir wie im folgenden ?hnlich bie beim Integer deklariert und initalisiert.  
`char a = 'n';`  
Normalerweise wird der Wert in einfachen hochkomma Zeichen (') hinein geschrieben, es gibt aber auch Programmiersprachen wo diese in den doppelten hochkomma Zeichen (") geschrieben werden.  

An sich ist ein Character eine Ganzzahl wie ein Byte, also wird er auch mit der selben Range von 0 - 255 gespeichert.  

Buchstaben k?nnen in Zahlen umgewandelt werden und umgekehrt genau so.

Der ASCII-Zeichensatz bildet hier den Standard mit seinen 7 Bit also 127 Zecihen insgesamt.

Hier gibt es auch noch weiter Zeichens?tze wie bspw. Unicode, damit auch Smiles oder ?hnliches abgebildet werden kann.

## Kommentare [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Kommentare werden dazu verwendet den ?berlick in seinem geschriebenen Quelltext zu behalten und sich auch noch nach Jahren wieder in den Quelltext einlesen zu k?nnen.  

Je nach Programmiersprache werden diese mit einem Route-Zeichen(#), doppelten Schr?gstrichen(//) oder einem kleiner als Zeichen gefolgt von zwei Minus-Zeichen (<--) gekennzeichnet.

Kommentare werden immer vom Kompiler ignoriert!  

Es gibt Schl?sselw?rter in den Kommentaren wie z.B. `//TODO:` um Aufgaben zu definieren oder auch Zusammenfassungen um aus den Kommentaren eine Dokumentation erstellen zu k?nnen.

## Arrays [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Arrays sind dazu da mehrere Variablen eines Datentyps zusammen zu fassen und neben einander im Speicher zu lagern.  

Statt also mehrere Variablen einzeln anlegen zu m?ssen,  
`int x1;`  
`int x2;`  
`int x3;`  
kann man also alle in eine Datenstruktur packen.  
`int[] a = new int[3];`  

Um die Variablen in dem Array nun verwenden zu k?nnen, nutzt man einen Index der immer bei 0 beginnt. Das heisst wenn man wie hier auf den Index 3 zugreifen w?rde, ergebe das einen Fehler da nur die Indexe 0, 1 und 2 existieren und hierf?r der Speicherplatz belegt wurde.  

Die Wert werden also wie im folgenden zugewiesen und auch hier kann die Initalisierung und Deklaration in der selben Zeile durchgef?hrt werden.  
 
`int[] a = new int[3];`  
`a[0] = 1;`  
`a[1] = 2;`  
`a[2] = 42;`  
`int[] a = new int[] {1, 2, 42};`  
`int[] a = {1, 2, 42};`

## Mehrdimensionale Arrays [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Die Mehrdimensionalen Arrays sind an sich Arrays in Arrays und sind quasi eine Matrix.  

Es gibt sie in der Programmierung als 2D-Arrays ([Zeilen(Horizontal)][Spalten(Vertikal)]):  
`int[,] a = new int[3,3];`  
`a[0,0] = 1;`  
`a[1,0] = 2;`  
`a[2,0] = 42;`  
`a[0,1] = 2;`  
`a[1,1] = 5;`  
`a[2,1] = 1337;`  
`a[0,2] = 3;`  
`a[1,2] = 6;`  
`a[2,2] = 128;`  
`int[,] a = new int[,] {{1, 2, 42}, {2, 5, 1337}, {3, 6, 128}};`  
`int[,] a = {{1, 2, 42}, {2, 5, 1337}, {3, 6, 128}};`  
und in bestimmten Bereichen auch als 3D-Arrays ([X][Y][Z]):  

`int [,,] a = new int[2,2,2];`  
`a[0,0,0] = 1;`  
`a[0,0,1] = 2;`  
`a[0,1,0] = 42;`  
`a[0,1,1] = 5;`  
`a[1,0,0]= 1337;`  
`a[1,0,1] = 3;`  
`a[1,1,0] = 6;`  
`a[1,1,1] = 128;`  
`int [,,] a = new int[,,] {{{1, 2}, {42, 5}}, {{1337, 3}, {6, 128}}};`  
`int [,,] a = {{{1, 2}, {42, 5}}, {{1337, 3}, {6, 128}}};`  
## Listen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Im Gegensatz zu den Arrays muss bei den Listen der Speicher der belegt werden soll nicht vorher definiert werden.  

`a = [42, 1337, 128, 256]`

Um nun einer Liste einen Wert hinzuzuf?gen bentuzt man die Add-Funktion.  

Mit der Len-Funktion gibt man die Anzahl an Elementen die sich in der Liste befinden zur?ck.

Funktionen wie Push() und Pop() k?nnen der Liste ebenfalls eine Element hinzuf?gen bzw. ein Element aus der Liste entfernen.  

Grunds?tzlich sind Listen langsamer als Arrays, da sie eine l?ngere Zugriffzeit ben?tigen um auf ein Element zugreifen zu k?nnen.

Bei einer Liste bekommt ein Element immer die Speicheraddresse des n?chsten Element zugewiesen, diese Datenstruktur nennt man auuch Linked List.

42-->1337-->128-->256

Um hier also an die 256 zu kommen muss man also durch die gesamte Liste durchgehen, man hat also 4 Zugriffszeiten.

Es gibt auch eine Double Linked List, bei der auch die Speicheraddresse des vorherigen Elements im Element gespeichert wird und sogar das erste mit dem letzten verkettet ist.

42<-->1337<-->128<-->256  
<----------------------------->  
## Mehrdimensionale Listen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Mehrdimensionale Listen funktionieren genau so wie die mehrdimensionalen Arrays, heisst es werden Listen in Listen gespeichert.
## Strings [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Strings sind Zeichenketten, also nicht anderes als variabel Gro?e Char-Arrays bzw. Listen aus Chars.  

`string a = "irgendwas";`

Falls hier von der Programmiersprache ein Array genutzt wird, wird unter der Haube von der Programmiersprache selbst immer ein neues Array angelegt falls sich die Gr??e des Arrays ?ndert.  

Die einzelnen Chars in einem String k?nnen also auch mit einem Index behandelt werden.  

Der Backslash (umgekehrten Schr?gstrich) hat in einem String eine besondere Bedeutung und zwar dient dieser als Markierungszeichen um ein Special-Char nutzen zu k?nnen.  

Diese Special-Chars sind bspw. `"\n"` um einen Zeilenumbruch druchzuf?gren oder `"\t"` um einen Tabulator einzuf?gen.

Falls man nun einen Backslash in seinen String schreiben m?chte, schreibt man einfach einen weiteren Backslash davor damit derKompiler diesen wieder als Backslash identifizieren kann.

Um einen String an sich zu identifizeren schreib man doppelte Anf?hrungszeichen (") vor und hinter die Zeichenkette, falls auch hier das doppelte Anf?hrungszeichen innerhalb der zeichenkette genutzt werden soll, schreibt man auch ein Backslash davor.
## Unicode-Zeichensatz [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Mit dem Unicode Zeichensatz kann man durch Special-Chars nun bspw. Smiles in seinen Strings einf?gen.  

Dies tut man in dem man \u gefolgt von der gew?nschten Hexadezimalzahl in den String schreibt.  

Diese Hexadezimalzahl steht bspw. f?r ein Herz:  
`"\u2665"`

Eine Tabelle mit s?mtlichen Unicode-Zeichen inkl. Hexadezimalenzahlen findet man hier:  
https://unicode-table.com/de/
## Arithmetische Operatoren [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Es gibt 5 arithmetische Operatoren. Plus, Minus, Mal, Geteilt und Modulo.  
`a = x+y;`  
`a = x-y;`  
`a = x*y;`  
`a = x/y;`  
`a = x%y;`  

Auch hier kann ein Overflow im Speicher entstehen wenn man nach der Berechnung die Range des Datentypen ?ber- bzw. unterschreitet.

Bei dem Geteilt-Operator muss beachtet werden, das nich durch 0 geteilt wird da der zur?ckgegebene Wert sonst NaN ist und f?r Fehler im Programm sorgen kann.

Der Modulo-Operator wird dazu verwendet um nur den Rest einer Division in einer Variablen zu speichern. Dies wird h?ufig bei Grafikprogrammierung genutzt.

`int x = 5;`  
`int y = 3;`  
`int z = x % y;`  
5/3 = 1 R = 2 also ist Z = 2

Es gibt auch die M?glichkeit Variablen mit einem anderen Wert zu ver?ndern, was mit allen arithmetischen Operatoren funktioniert.  
`y += 1;` oder `y = y + 1;`  
`y -= 1;` oder `y = y - 1;`  
`y *= 1;` oder `y = y * 1;`  
`y /= 1;` oder `y = y / 1;`  
`y %= 1;` oder `y = y % 1;`  

Um einen Wert um eine Stufe zu vergr??ern bzw. zu verkleinern (Inkrementierung/Dekrementierung), kann man auch eine vereinfachte Schreibweise verwenden.  
y++; u. y--;  

Hier gilt zu beachten, dass wenn man den inkrementierten Wert ?bergeben will die Varaible hinter die Operatoren schreiben muss.  

`int x= 5;`  
`int y= 3;`  
`int z= y++;`  
`// z = 3, y = 4`  
`int w= ++x;`  
`// w = 6, x = 6`  
Expontenten werden wie folgt gekennzeichnet:  
`int z = x**y;` oder `int z = x^y;` oder `int z = Math.Pow(x, y);`
## IF-Verzweigungen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Wird dazu ben?tigt seinen Code zu strukturieren und um mit Bedingungen arbeiten zu k?nnen. 

Um einen if-Block zu beginnen, schreibt man das if-Schl?sselwort, gefolgt von der Bedingung, gefolgt von den gescheiften Klammern in dem der Code steht der ausgef?hrt werden soll, wenn die Bedingung erf?llt worden ist.  
`if (BEDINGUNG)`  
`{`  
  `// irgendwelcher Code`  
`}`  

bei Bedingungen werden Vergleich?berpr?fung vor genommen die mit einem doppelten Gleichheitszeichen geschrieben werden.  
`if (x == 42)`  

Das else-Schl?sselwort sorgt daf?r, dass immer etwas ausgef?hrt wird falls keine der vorherigen if-Bedingungen erf?llt worden sind.  
`if (BEDINGUNG)`  
`{`  
  `// irgendwelcher Code`  
`}`  
`else`  
`{`  
  `// irgend ein ausnahme Code`  
`}` 

In der Verbindung mit beiden Schl?sselw?rtern also `else if` kann man nun auch weitere Bedingungen in dem IF-Block hinzuf?gen, um andere Bedingungen ablaufen zu k?nnen.

`if (BEDINGUNG)`  
`{`  
  `// irgendwelcher Code`  
`}`  
`else if (BEDINGUNG)`  
`{`  
  `// irgend ein anderer Code`  
`}`  
`else`  
`{`  
  `// irgend ein ausnahme Code`  
`}`  
## Booleans und Vergleichsoperatoren [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Booleans werden h?ufig mit bool abgek?rzt, sind 1 Bit gro? und k?nnen sowohl 0=false als auch 1 = true sein.  

Bei einer IF-Verweigung kann man diesen Datentypen mit einem sogenannten Vergleichsoperator (==)verwenden, um einen bestimmte Bedingung zu definieren.  
`bool x = true;`  
`bool y = true;`  
`bool wahrheit = x == y;`  
`if (wahrheit){`
`}`

Hier wird also der Code in dem if-Block ausgef?hrt da x und y gleich sind.  

Es gibt auch noch Verlgeichssoperatoren die Abfragen ob etwas gr??er (>), kleiner (<), gr??ergleich (>=) oder kleinergleich(<=) dem folgenden Wert ist.  

Falls man auch Ungleichheit pr?fen m?chte, gibt es auch noch die folgenden Schreibweisen:  
`x != y;` oder `x <> y;` oder `x ~= y;`  

Ein boolscher Wert kann auch negiert werden so das immer der gegenteilige Wert ?bergeben wird.  
`bool falschheit = !wahrheit;`
## Logische Operatoren [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Die logischen Operatoren k?nnen mit boolschen Werten verkn?pft werden.  

Der Und-Operator (AND o. &&) ist nur wahr wenn beide Werte wahr sind.  
`bool log = true;`  
`bool log2 = true;`  
`bool ergebnis = log && log2;`  

Der Oder-Operator (OR o. || o. ^) gibt wahr zur?ck wenn mindestens ein Wert wahr ist, also gibt er nur falsch z?rck wenn beide Werte falsch sind.  
`bool ergebnis = log || log2;`  

Falls man nun beide Operatoren in einer Bedingung verwenden m?chte, hat der Und-Operator (AND o. &&) eine st?rkere Gewichtung als der Oder-Operator (OR o. || o. ^). Dies ist vergleichbar mit der Punkt vor Strich-Rechnung aus der Mathematik.  
`if ((a && b) || (a && c)){`  
`}`  

Hier k?nnen aber auch Klammern gesetzt werden, um die Oder-Verkn?pfung zuerst ausf?hren lassen zu k?nnen.  
`if (a && (b || a) && c){`  
`}`  
## Bitweise Operatoren [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Die Bitweisen Operatoren sind ?hnlich wie die logischen operatoren, werden aber auf ganzzahlige Werte angewendet.  

Hier werden meistens Hexadezimale- (0x...) oder Bin?rzahlen(0b...) verwendet.  
0123456789ABCDEF (0-15)  = 4 Bit o. 2^4  

Bei den Bitweisen Operatoren wird also jedes einzelne Bit mit dem bitweisen Und- (&) oder Oder-Operator (|) verglichen.  

Bitweiser Und-Operator (&):  
`int bitmaske = 0x000F;`  
`int wert = 0xAAAA;`  
`int ergebnis = wert & bitmaske;`  
1010 1010 1010 1010  
0000 0000 0000 1111  
0000 0000 0000 1010  
`int ergebnis = 0x000A;`  

Bitweiser Oder-Operator (|):  
`int bitmaske = 0x000F;`  
`int wert = 0xAAAA;`  
`int ergebnis = wert | bitmaske;`  
1010 1010 1010 1010  
0000 0000 0000 1111  
1010 1010 1010 1111  
`int ergebnis = 0xAAAF;`  

Sowohl bei den logischen als auch bei den bitweisen Operatoren gibt es auch noch den Entweder/Oder-Operator (XOR o. ^), der immer dann wahr zur?ck gibt, wenn nur einer der beiden Werte wahr ist. Also wird hier immer wenn beide Werte gleich sind falsch zur?ck gegeben.  

Bitweiser Entweder/Oder-Operator (XOR o. ^):  
`int bitmaske = 0x000F;`  
`int wert = 0xAAAA;`  
`int ergebnis = wert ^ bitmaske;`  
1010 1010 1010 1010  
0000 0000 0000 1111  
1010 1010 1010 0101  
`int ergebnis = 0xAAA5;`  

Es gibt auch noch das Bitshiften, womit man eine vorgegebene Anzahl an Bits aus einer Bitreihe vorne oder hinten abkappt, die verleibenden Bits aufr?cken l?sst und die leeren Pl?tze mit den selben Bitwerten f?llt wie der naheliegenste Bit.  
`int wert = 0xAAAA;`  
1010 1010 1010 1010  
`int ergebnis = wert >> 3;`  
1111 0101 0101 0101  

`int bitmaske = 0x000F;`  
0000 0000 0000 1111
`int ergebnis = bitmaske >> 3;`  
0000 0000 0000 0001  

Mit dem erweiterten Bitshift-Operator (>>>) kann man auch festlegen, dass die leeren Pl?tze immer mit 0 aufgef?llt werden sollen.  

`int wert = 0xAAAA;`   
1010 1010 1010 1010  
`int ergebnis = wert >> 3;`  
1111 0101 0101 0101  
`int ergebnis = 0xF555;`  

Das funktioniert aber nur die Rechte-Richtung!  

Das gleiche funktioniert auch in die andere Richtung, nur wird hier immer mit 0 aufgef?llt.

`int wert = 0xAAAA;`   
1010 1010 1010 1010  
`int ergebnis = wert << 3;`  
0101 0101 0101 0000  
`int ergebnis = 0x5550;`
## While Schleifen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Schleifen sorgen generell daf?r Code mehrfach ausf?hren zu k?nnen.  

Bei der while Schleife wird der Code solange mehrfach ausgef?hrt, wie die Bedingung erf?llt also wahr ist.  
`while (BEDINGUNG){`  
`}`  
o.  
`while (BEDINGUNG){`  
`}`  

Wenn sich die Bedingung im Code nie ?ndert, erzeugt man eine Endlosschleife, die den Code permanent ausf?hrt.  
`bool wahrheit = true;`  
`while (wahrheit){`  
    `// Endlose Code ausf?hrung`  
`}`  

Um nun einen Code nur um eine bestimmte Anzahl nach wiederholt auszuf?hren, arbeitet man hier mit den kleiner o. gr??er als Vergleichoperator und einem ganzzahligen Wert als Bedingung und einer Inkrementierung/Dekrementierung des zuvor gennanten ganzzahligen Wertes.  
`int i = 0;`  
`while (i < 42){`  
    `print("hello");`  
    `i++;`  
`}`

Es gibt auch nich die do-while Schleife die man dann verwenden kann, wenn man den Code innerhalb der Schleife mindestens einmal ausf?hren will.  
`int i = 0;`  
`do {`  
    `print("hello");`  
    `i++;`  
`} while (i < 42);`  
## for-Schleifen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Ist eine Alternative zu while-Schleifen und wird eher genutzt wenn man etwas durchz?hlen m?chte.  
`for (int i = 0; i < 42; i++)`  
`{`  
    `// Schleifenrumpf`  
`}`  

Hier w?rde man von 0-41 in Einzelschritten druchiterieren.  

Dies Form von Schleifen werden auch h?ufig f?r Arrays oder Listen verwendet.  
`int[] meinArray = {42, 1337, 42, 42, 42};`  
`for (int i = 0; i < meinArray.Length; i++)`  
`{`  
    `System.Console.WriteLine(meinArray[i]);`  
`}`  

Hier w?rde jedes Element aus dem Array hintereinander auf der Konsole ausgegeben werden.  

Die Variable `int i;` kann nur in dem for-Schleifenrumpf verwendet werden, da diese nur dort bekannt ist. Nach den Schleifendruchl?ufen wird der belegte Speicher hierf?r also frei gegeben.
## foreach-Schleifen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Wird dazu verwendet um bspw. jedes Element eines Arrays zu durchlaufen.  
`int[] meinIntArray = {42, 1337, 42, 42, 42};`  
`foreach (int element in meinIntArray)`  
`{`  
    `System.Console.WriteLine(element);`  
`}`  

Hier wird jede Zahl in dem zuvor definierten Array auf der Konsole ausgegeben.  

F?r String-Arrays ist diese Form von Schleifen auch sehr praktisch.  
`string[] meinStringArray = {"42", "dieses", "tut", "ist", "geil"};`  
`foreach (string element in meinStringArray)`  
`{`  
    `System.Console.WriteLine(element);`  
`}`  

Diese Form von Schleifen kommt h?ufig in schwachtypisierten Programmiersprachen vor.  
## break und continue [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
`break` und  `continue` sind Schl?sselw?rter die in Schleifendruchl?ufen dazu verwendet werden, diese zu unterbrechen.  
### continue
Bei dem Schl?sselwort `continue` wird der derzeitige Schleifendurchlauf an der Stelle unterbrochen und es wird direkt zum n?chsten Schleifendurchlauf gesprungen.  
`string[] meinStringArray = {"42", "dieses", "tut", "ist", "geil"};`  
`foreach (string element in meinStringArray)`  
`{`  
    `System.Console.WriteLine("abc");`  
    `continue;`  
    `System.Console.WriteLine(element);`  
`}`  

Hier w?rde also 5 mal `abc` auf der Nosole ausgegeben werden, da `print(element);` hinter dem `continue` steht.  

Dies funktioniert in jeglicher Form von Schleifen.  

Nun kan mauch IF-Verzweigungen mit dem `continue` verwenden um dies nur unter einer Bedingung ausf?hren zu lassen.  
`foreach (string element in meinStringArray)`  
`{`  
    `if (element == "42")`  
    `{`  
        `continue;`  
    `}`  
    `System.Console.WriteLine(element);`  
`}`  

Hiuer wird also nur `diesestutistgeil` auf der Konsole ausgegeben.  

Wenn man generell das `continue` am Ende der Schleife setzt, verschwendet man nur unn?tige Rechenzeit, da man ncihts ?berspringt.  
### break
Das Schl?sselwort `break`sorgt auch daf?r das der Schleifendurchlauf unterbrochen wird, nur werden hier bei alle weiteren Schleifendurchl?ufe die noch kommen sollten nich mehr ausgef?hrt.  
`string meinStringArray = new string[] {"dieses", "tut", "ist", "geil","42", "hi", "wtf", "ist"};`  
`foreach (string element in meinStringArray)`  
`{`  
    `System.Console.WriteLine(element);`  
    `if (element == "geil")`  
    `{`  
        `break;`  
    `}`  
`}`  

Hier wird nur `diesestutistgeil` ausgegeben und es mach Sinn das `break` vor dem Schleifenende auszuf?hren, da man hier noch etwas unterbricht.  
## Funktionen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Ben?tigt man um Code auslagern zu k?nnen den man mehrfach ausf?hren will.  

Nennt man mei?tens foo o. bar o. baz. und man definiert sie mit dem Schl?sselwort def o. function davor.  
`function foo()`  
`{`  
    `System.Console.WriteLine("***STARTE DAS PROGRAMM***");`  
    `System.Console.WriteLine("_________________________");`  
`}`  

Diese Funktion kann man nun ?ber den Funktionsnamen und den runden Klammern aufrufen und z.B. in einer Schleife mehrfach ausf?hren.  
`for (int i = 0; i < 10; i++){`  
    `foo();`  
`}`  

Diese Art kennt man auch aus der Mathematik.  
`f(x) = 2*x`  
## R?ckgabewerte [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
R?ckgabewerte weerden dazu ben?tigt um etwas von einer Funktion zur?ckgeben zu k?nnen.  

Falls man keinen R?ckgabewert verwenden m?chte, nutzt man hier den Wert `void`.  
`void function foo(){`  
`}`  

Um nun einen Wert von einer Funktion zur?ckgeben zu k?nnen, gibt man hier statt `void` einen Datentyp wie z.B. `int` an und gibt den Wert mit dem Schl?sselwort `return` zur?ck.  
`int function foo(){`  
    `int ergebnis = 42*1337;`  
    `return ergebnis;`  
`}`  

Zu beachten gilt hier, das der Code nach dem `return` nicht mehr ausgef?hrt wird.  

Falls man nun eine IF-Verzweigung innerhalb der Funktion nutzen m?chte, muss man immer daran denken ein `return` zur?ckzugeben, sonst w?rde ein Fehler entstehen.  
`int function foo(){`  
    `int ergebnis = 42*1337;`  
    `bool abc = true;`  
    `if (abc){`  
        `return ergebnis;`  
    `}`  
    `else`  
    `{`  
        `return 0;`  
    `}`  
`}`  

Ein besserer Programmierstil ist hier eine Variable `int ret` anzulegen, da man hier nur auf den Wert der Variablen achten muss und nicht jedes mal `return` schreiben muss.  
`int function foo(){`  
    `int ergebnis = 42*1337;`  
    `bool abc = true;`  
    `int ret = 0;`  
    `if (abc){`  
        `ret = ergebnis;`  
    `}`  
    `return ret;`  
`}`  

Nun kann man den R?ckgabewert aus der Funktion in eine Variable schreiben. Dabei gilt zu beachten, dass die Varaible und die Funktion den selben Datentyp haben.  
`int meinInteger = foo();`  
## Parameter [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Parameter k?nnen ?ber die runden Klammern an die Funktion ?bergeben werden.  
`int function foo(bool abc){`  
    `int ergebnis = 42*1337;`  
    `int ret = 0;`  
    `if (abc){`  
        `ret = ergebnis;`  
    `}`  
    `return ret;`  
`}`  
`int meineVar = foo(true) // Ergebnis von 42 * 1337`  
`int meineVar2 = foo(false) // 0`  

Der Parameter muss hier, ?hnlich wie bei den R?ckgabewerten, den selben Datentyp haben wie die ?bergebene Variable.  

Damit lassen sich auch Funktionen anandere zur Verwendung weitergeben.  

Man kann auch mehrere Parameter an eine Funktion ?bergeben und nutzen.  
`int function foo(bool abc, int def, int hij){`  
    `int ergebnis = def*hij;`  
    `int ret = 0;`  
    `if (abc){`  
        `ret = ergebnis;`  
    `}`  
    `return ret;`  
`}`  
`bol meinBool = true`  
`int meineVar = foo(meinBool, 42, 1337) // 0`  

Die Parameter sind also Platzhalter die f?r verschiedene Ergebnise einer Funktion sorgen kann.  
## Rekursion [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Rekursion bedeutet das sich eine Funktion selbst x mal aufruft. Damit lassen sich auch Funktionen wie die Fakult?t 10! = 10*9*8*7...! oder die Fibonacci-Folge 0,1,1,2,3,5,8,13... aus der Mathematik berechnen und abbilden.  
int function fakul (int n){
    if (n <= 2){
        return n;
    }
    return n * fakul (n - 1);
}
int meineVar = fakul(10);  
fakul(10)  
--> 10*fakul(9)  
----> 9*fakul(8)  
------> 8*fakul(7)  
--------> 7*fakul(6)  
----------> 6*fakul(5)  
------------> 5*fakul(4)  
--------------> 4*fakul(3)  
----------------> 3*fakul(2) = 3*2  
------------------> 2  

Es ist immer wichtig einen Abbruchfall bei einer Rekursion einzubauen, da sonst die Funktion unendlich aufgerufen wird.
## Default Argumente [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Als Parameter einer Funktion kann auch ein Defaul Argument gesetzt werden, welches immer dann vergeben wird, wenn der Parameter beim Aufruf nicht gesetzt wird.  
`int function foo (bool abc = true){`  
`}`  
`int meineVar = foo();`  

Bie mehreren Parametern funktioniert das genau so, man kann aber nur in manchen Programmiersprachen einen ausgew?hlten Parameter setzen.  
`int function foo (int n = 10, bool b = true){`  
`}`  
`int meineVar = foo(b = false);`  
## Call-by-Value vs Call-by-Reference [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Bei Call-by-Value und Call-by-Reference geht es um die unterschiedlichen Speicherverwaltungen, wenn eine Variable als Argument an eine Funktiuon ?bergeben wird.  

Teilweise hat man die Kontrolle dar?ber welche Speicherverwaltung hier gentuzt wird. Mei?tens wird das aber automatisiert so das man selbst keine Kontrolle dar?ber hat. Es ist also von der Programmiersprache abh?ngig ob dies m?glich ist oder nicht und bei welchen Typen das jeweilige Call-by Verfahren anwendet wird.  

Bei primitiven Datentypen (bool, char, short, int, long) wird mei?tens ein Call-by-Value genutzt und bei Arrays und Listen ein Call-by-Reference, was wie gesagt unterschiedlich zwischen den Programmierpsrachen ist.  

In Java ist es bspw. genau so wie eben beschrieben, in C++ werden Zeiger verwendet, wenn man einen Call-by-Reference haben m?chte und bei C# kann man ein Schl?sselwort mit angeben um ein Call-by-Reference nutzen zu k?nnen.  

Der Call-by-Value sorgt also daf?r, dass eine Kopie des ?bergebenen Arguments erzeugt wird und diese innerhalb der Funktionen gentuzt wird ohne das die Variable die als Argument ?bergeben wurde ver?ndert wird.  
`void function foo(int a){`  
    `a = 1337`  
`}`  
`int a = 42`  
`foo(a)`  
`print(a) // 42`  

Der Call-by-Reference sorgt daf?r das die Speicheraddresse die auf die Variablen zeigt die als Argument ?bergeben wird an die Funktion ?bergeben wird, sodass sich die Variable innerhalb der Funktion ?ndert und man mit der ge?ndert Variablen weiter arbeiten kann.  
`void function foo(List list){`  
    `list = {4, 5, 6}`  
`}`  
`List list = {1, 2, 3}`  
`foo(list)`  
`print(list) // 4, 5, 6`  

Um nun bspw. einen Integer mit einem Call-by-Reference aufrufen zu k?nnen, gibt es in manchen Programmiersprachen das Schl?sselwort `ref`.  
`void function foo(ref int a){`  
    `a = 1337`  
`}`  
`int a = 42`  
`foo(a)`  
`print(a) // 1337`  

Somit kann man im Prinzip mehrere R?ckgabewerte aus einer Funktion herausbekommen.
## Lazy Evaluation [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Normalerweise wird in Programmiersprachen eine Eager Evaluation durchgef?hrt die daf?r sorgt das immer alle Bestandteile bspw. einer Liste aufgebaut und ausgef?hrt werden bevor man mit einem Index darauf zugreift.  
`List list = {42, 1337, sleep(3)}`  
`print(list[1])`  

Hier w?rde mit der Eager Evaluation die sleep-Funktion bei der Erstellung der Liste ausgef?hrt werden, obwohl wir gar nicht mit dem Index im weiteren Codefluss darauf zugreifen.  

Bei der Lazy Evaluation, die mei?tens in funktionalen Programmiersprachen vorkommt, wird erst geschaut welches Element in der Liste gebraucht wird und dann wird nur das gew?hlte Element bzw. die gew?hlten Elemente aufgebaut und ausgef?hrt, was Rechenzeit spart.  
`List list = {42, 1337, sleep(3)}`  
`print(list[1])`  

Hier w?rde mit der Lazy Evaluation die sleep-Funktion bei der Erstellung der Liste nur ausgef?hrt werden, wenn wir mit dem Index im weiteren Codefluss darauf zugreifen w?rden. 
## Function Pointer [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Funktionen k?nnen auch wie eine Variable behandelt werden und erst sp?ter im Codefluss ausgef?hrt, werden in dem man Funktionszeiger nutzt.  
`function foo(){`  
    `return 1`  
`}`  
`var meineFkt = foo`  
`print(meineFkt()) // 1`  

Die Funktionszeiger k?nnen auch als Parameter ?bergeben werden, was h?ufig bei Loggern genutzt wird, bzw. wenn man seinen Output selbst schreiben m?chte.  
`function foo(n, n2){`  
    `return n * n2`  
`}`  
`function bar (baz, n){`  
    `n2 = 1337`  
    `return baz(n, n2)`  
`}`  
`bar(foo,42)`  
## Lambda Funktionen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Definiert eine Funktion innerhalb von einer Zeile, was Rechenzeit erspart. Sie muss aber in eine Variable geschrieben werden, um sie nutzen zu k?nnen.  
`var fkt = (a, b) -> a * b // Java schreibweise`  
`fkt = lambda a, b: a * b // Python schreibweise`

Nun kann sie wie eine klassische Versionverwendet werden, mann kann sich auch erst in der Argumentenliste definieren.  
`bar (lambda a, b: a * b, 42)`  
## Inline Funktionen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Inline Funktionen sind Omptimierungen die zwar daf?r sorgen das mehr Speicherbelegt wird, aber daf?r sorgt, dass das die Rechenzeit k?rzer ist.  
`inline function square(double a){`  
    `return a*a;`  
`}`  
`print(square(4));`  
`// Unter der Haube: print (4*4);`  

Im Prinzip wird hier an der Stelle wo die Funktion aufgerufen werden w?rde, der Inhalt der Funktion direkt in den Quelltext geschrieben ohne einen Funktuionsaufruf dazwischen zu haben.  
## Code lesen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Programmieren lern man am besten, in dem man sich auch fremden Code durchliest und diesen versteht.  

Dazu kann man sich bei den mei?ten Programmiersprachen die Referenzen des Sourcecode der eigenen Standard-Bibliothek ansehen.  
Java: http://hg.openjdk.java.net/jdk8/jdk8/jdk/file/687fd7c7986d/src/share/classes/java/lang  
C#: https://referencesource.microsoft.com/#mscorlib  
C++: https://en.cppreference.com/w/  

Hiervon kann man sich nun einzelne Funktionen oder Methoden angucken und versuchen zu versehen,  was genau beim Aufruf passiert.
## Klassen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Ist ein Konzept, welches mehr Struktur und Ordnung in ein Projekt bringt.  

Grade f?r gro?e Projekte ist dieses Konzept essentiel wichtig, da so eine bessere ?bersicht gegeben ist.  

Ein Klasse ist an sich eine Blaupause von etwas was konkretisiert werden kann.  
`class Schule{`  
    `string name;`  
    `int anzahlSchueler;`  
`}`  

Hier wird als eine Klasse `Schule` definiert die einen Wert f?r den Namen der Schule und einen Wert f?r die Anzahl der Sch?ler bereit stellt. Die Variablen haben hier f?rs erste einen von der Programmiersprache definierten Standardwert zugewiesen bekommen, der bspw- beim String `null` oder ein Leerstring (`" "`) und beim Integer eine `0` sein kann.  

Diese kann jetzt instanziiert werden, es k?nnen also jetzt mehrere Schulen konretisiert werden.  
`Schule youtube = new Schule();`  
`youtube.name = "The Morpheus Tutorials";`  
`youtube.anzahlSchueler = 13000;`  
`Schule kit = new Schule();`  
`kit.name = "KIT";`  
`kit.anzahlSchueler = 23000;`  

Wenn sich also gewiise Gemeinsamkeiten bei mehreren Konstrukten abbilden lassen k?nnen, kann man hiermit sehr gut eine Klasse erstellen die diese Wert definiert, sodass die Werte nur noch deklariert werden m?ssen.  
## Methoden  [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Sind an sich auch nur Funktionen, die die besondere Eigenschaft haben direkt auch Variablen in der selben Klasse zugreifen zu k?nnen, bzw. bekommen diese die selbe Klasse unter der Haube zugewiesen.  

In den mei?ten Programmiersprachen wird das automaitsch von der Klasse ?bernommen, in Python wird aber bspw. das `self`-Schl?sselwort dazu als Parameter ?bergeben um diese Funktion gew?hrleisten zu k?nnen.  

Die mei?ten Programmiersprachen nutzen das `this`-Schl?sselwort um die Variablen inder der Klasse nutzen zu k?nnen, man kann sie aber auch ohne das Schl?sselwort direkt nutznen.  
`class Schule{`  
    `string name;`  
    `int anzahlSchueler;`  
    `function neuerSchueler(){`  
        `this.anzahlSchueler++;`  
    `}`  
`}`  
`Schule youtube = new Schule();`  
`youtube.name = "The Morpheus Tutorials";`  
`youtube.anzahlSchueler = 13000;`  
`youtube.neuerSchueler(); //anzahlSchueler = 13001`  

Hier wird bspw. die Variable `anzahlSchueler` nur durch den Methodenaufruf `neuerSchueler()` um 1 erh?ht.  
## Konstruktoren [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Ein Konstruktor ist die erste Methode die in einer Klasse aufgerufen wird und setzt standardm??ig alle Klassenvariablen auf einen Standardwert und belegt somit den dementsprechenden Speicher, was je nach Programmiersprache unterschiedlich ist. Man also eigentlich immer einen Standardkonstruktor der unter der Haube ausgef?hrt wird.  

Aufgerufen wird dieser Konstruktor bei der Erzeugung einer Instanz mit dem `new`-Schl?sselwort.  
`class Schule{`  
    `string name;`  
    `int anzahlSchueler;`  
    `Schule(){`  
        `name = "MeineSchule";`  
        `anzahlSchueler = 500;`  
    `}`  
`}`  
`Schule schule = new Schule();`  

Nun kann man auch einen eigenen Konstruktor schreiben, in dem man sogar eine Parameterliste einbauen kann. Wenn man das tut verf?llt der Standardkonstruktor unter der Haube.  
`class Schule{`  
    `string name;`  
    `int anzahlSchueler;`  
    `Schule(string name, int anzahlSchueler){`  
        `this.anzahlSchueler = anzahlSchueler;`  
        `this.name = name;`  
    `}`  
`}`  
`Schule kit = new Schule("KIT", 23000);`  

Hier kann jetzt nur noch eine Instanz erzeugt werden, wenn die Parameterliste gef?llt ist.  

Das `this`-Schl?sselwort ist hier nun relevanter, da man hiermit sicherstellen kann, dass die Variable in der Klasse gemeint ist und nicht das Argument welches an die Funktion ?bergeben wird.  

Falls man jetzt Standardwerte f?r die Parameter des Kosntruktor setzten m?chte, lann man von der Klasse auch wieder Instanzen erzeugen, die keinen Parameter ?bergeben bekommen.  
`class Schule{`  
    `string name;`  
    `int anzahlSchueler;`  
    `Schule(string name = "", int anzahlSchueler = 0){`  
        `this.anzahlSchueler = anzahlSchueler;`  
        `this.name = name;`  
    `}`  
`}`  
`Schule schule = new Schule();`
## Zugriffsmodifikatoren [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Durch Zuggriffsmodifikatoren kann man den Zugriff auf eine Klasse steuern, wenn man bspw. verhindern m?chte, dass eine Wert ver?ndert wird.  

Die grundlegenenden Zugriffsmodifikatoren die es in so ziemlicher jeder Programmierpsrache gibt,  sind `public` und `private`. `public` ist mei?tens der standardm??ige Zugriffsmodifikator und sorgt daf?r das jeglicher Zugriff auf die Klassenvariable, Methode oder Klasse an sich erlaubt ist, w?hrend `private` daf?r sorgt das nur ein Zugriff innerhalb der Klasse erlaubt ist.  
`public class Schule{`  
    `public string name;`  
    `private int anzahlSchueler;`  
    `public Schule(string name = "", int anzahlSchueler = 0){`  
        `this.anzahlSchueler = anzahlSchueler;`  
        `this.name = name;`  
    `}`  
`}`  
`Schule kit = new Schule("KIT", 23000);`  

Hier kann man zwar die Variable `int anzahlSchueler` beim Initialisieren durch den Konstruktor setzen, man kann aber durch das `private`-Schl?sselwort nicht mehr darauf zugreifen.  
## Getter/Setter [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Um nun `private` Variablen nur auslesbar oder nur schreibbar zu machen, gibt es sogenannte Getter- und Setter-Methoden, die dies druch einen Methodenaufruf erm?glichen.  
`public class Schule{`  
    `private int anzahlSchueler;`  
    `public Schule(int anzahlSchueler){`  
        `this.anzahlSchueler = anzahlSchueler;`  
    `}`  
    `public int getAnzahlSchueler(){`  
        `return anzahlSchueler;`  
    `}`  
`}`  
`Schule schule = new Schule(23000);`  
`int anzahlSchueler = schule.getAnzahlSchueler();`  

Hier kann man also nur noch die Variable auslesen und nicht mehr schreiben.  
`public class Schule{`  
    `private int anzahlSchueler;`  
    `public Schule(){`  
        `this.anzahlSchueler = 0;`  
    `}`  
    `public int getAnzahlSchueler(){`  
        `return anzahlSchueler;`  
    `}`  
    `public void setAnzahlSchueler(int anzahlSchueler){`  
        `if (anzahlSchueler >= 0){`
        `this.anzahlSchueler = anzahlSchueler;`  
        `}`
    `}`  
`}`  

Hier kann man durch den Setter daf?r sorgen, dass die Anzahl der Sch?ler nur auf einen positiven Wert gesetzt wird.  

Wenn man also im Getter nur die Variable zur?ck gibt und im Setter nur die Variable setzt, kann man besser einfach die Variable auf `public` setzen.  
## Static - Klassenvariablen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Falls man einen Wert setzen m?chte der f?r alle Instanzen einer Klasse gleich sien soll, benutzt man dazu `static`-Klassenvariablen.  
`public class Schule{`  
    `public static string gesetzesgrundlage = "SchG";`  
`}`  

Diese `static`-Klassenvariable ist nun f?r alle Instanzen gleich und sie belegt auch nur einmalig den Speicher.  
`Schule kit = new Schule();`  
`Schule youtube = new Schule();`  
`// kit.gesetzesgrundlage == youtube.gesetzesgrundlage`  

Je nach Programmierpsrache kann man diesen Wert jetzt ?ndern, dieser wird aber dann f?r alle Instanzen ge?ndert.  
`// Schule.gesetzesgrundlage = "abc" o. kit.gesetzesgrundlage = "abc"`  

Man kann hier auch Getter- und Setter-Methoden benutzen nur m?ssen die auch `static` sein und man kann hier keine Variablen nutzen die nicht `static` sind.  

Da das `this`-Schl?sselwort auch nur f?r nicht statische Variablen funktioniert, nutzt man hier statt dessen den Klassennamen.  
`public class Schule{`  
    `private static string gesetzesgrundlage = "SchG";`  
    `public static string getGesetzesgrundlage(){`  
        `return Schule.gesetzesgrundlage;`  
    `}`  
`}`  
## Vererbung [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Eine Vererbung ist eine Verbindung zwischen Klassen.  

Generell solte man beim Programmieren nie Copy-Pasten m?ssen, da man immer besser Funktion/Klassen erstellt oder von anderen erbt, um den selben Code mehrfach aufzurufen.  

Wenn man nun seine Klasse spezifizieren will und die selben Variablen und Methoden aus einer Klasse ben?tigt, kann man die Vererbung nutzen.  
`class Schule{`  
    `public string name;`  
    `public int anzahlSchueler;`  
`}`  
`class Gymnasium extends Schule{`  
`}`  

Hier kann man jetzt eine Instanz von der Klasse `Gymnasium` erzeugen und die gleichen Variablen aus der Klasse `Schule` nutzen, da diese quasi in die Klasse `Gymnasium` kopiert werden.  
`Gymnasium g = new Gymnasium();`  
`g.name = "MeinGymmi";`  
`g.anzahlSchueler = 400;`  

Der Klasse `Gymnasium` kann man jetzt auch eigene passende Variablen und Methoden hinzuf?gen und nutzen, diese haben dann nat?rlich nichts mehr mit der Klasse `Schule` zu tun.  
`class Schule{`  
    `public string name;`  
    `public int anzahlSchueler;`  
`}`  
`class Gymnasium extends Schule{`  
    `public string abschluss = "Abitur";`  
`}`  
`Gymnasium g = new Gymnasium();`  
`g.name = "MeinGymmi";`  
`g.anzahlSchueler = 400;`  
`string abschluss = g.abschluss;`  
## TypeCasts [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Beim TypeCast wird eine Instanz einer Klasse in ihrer vererbten Klasse erzeugt und weiter verwendet.  
`class Schule{`  
`}`  
`class Gymnasium extends Schule{`  
    `public string abschluss = "Abitur";`  
`}`  
`Schule g = new Gymnasium();`  

Hier gibt es das UpperTypeCast-Verfahren, welches daf?r sorgt das nur die Variablen der Eltern Klasse bei der Instanz verwendet werden kann, die Inszanz ist aber immer noch vom Typ der Tochter-Klasse. Die Variablen die nur in der Tochter-Klasse vorkommen sind zwar da, haben aber tempor?r keinen Zugriff.  

Jetzt kann man also durch s?mtliche Instanzen mit bspw. einem Array durch iteriern die sowohl direkt von der Klasse erzeugt wurden, als auch die, die von den vererbten Klassen erzeugt worden sind.  
`Schule youtube = new Schule();`  
`Gymnasium g = new Gymnasium();`  
`Schule g2 = g;`  


Nun gibt es auch den DownTypeCast, welcher mei?tens einen Typ zu gewiesen bekommen muss.  
`Schule youtube = new Schule();`  
`Gymnasium g = new Gymnasium();`  
`Schule g2 = g;`  
`Gymnasium g3 = (Gymnasium)g2;`  
`Schule[] schulen = {youtube, g, g2, g3};`  
`foreach (var item in schulen)`  
`{`  
    `i.neuerSchueler();`  
`}`  

Diese Verfahren kann zu einem Absturz des Programms f?hren, wenn die Variable der Eltern-KLasse zuvor mit dem `new`-Schl?sselwort instanziiert wurde.  
## instanceof [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Das 'instanceof`-Schl?sselwort pr?ft ob eine Instanz von einer anderen Klasse bzw. deren Elternklassen instanziiert wurde. Dieses Schl?sselwort sollte man meiden zu nutzen, es macht aber sinn es anzuwenden bevor man einen TypeDownCast durchf?hrt, den man auch nciht durchf?hren sollte,da dies unsicher ist.
## typeof [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Das `typeof`-Schl?sselwort pr?ft ob eine Instanz von einer bestimmten Klasse instanziiert wurde.  
## ?berschreiben von Methoden [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Um eine Methode einer Oberklasse zu ?berschreiben, schreibt man eine Methode genau so in der Unterklasse auf.  

Dadurch erzeugt man eine dynamische Bindung die daf?r sorgt, dass wenn man durch ein Array gemischt aus Ober- und Unterklassen iterriert, man immer die deklariert bzw. die ?berschrieben Methode nutzt.  
`class Schule`  
`{`  
    `public int anzahlSchueler;`  
    `public void neuerSchueler()`  
    `{`  
        `anzahlSchueler += 1;`  
    `}`  
`}`  
`class Gymnasium : Schule`  
`{`  
    `private bool hasSchueler;`  
    `public bool HasSchueler{get; set;}`  
    `public Gymnasium()`  
    `{`  
        `HasSchueler = false;`  
    `}`  
    `public void neuerSchueler()`  
    `{`  
        `if (HasSchueler)`  
        `{`  
            `anzahlSchueler += 1;`  
        `}`  
    `}`  
`}`  
`Gymnasium g = new Gymnasium();`  
`Schule meineSchule = g;`  
`Gymnasium g2 = new Gymnasium();`  
`Schule[] meineSchulen = {g, meineSchule, g2};`  
`foreach (var item in meineSchulen)`  
`{`  
    `item.neuerSchueler();`  
`}`  
## Enums [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Enum ist die Abk?rzung von Enumeration was Aufz?hlung heisst.  

Dieses Konstrukt erm?glichtes es eine aufeinanderfolgende Menge von zusammenh?ngenden Werten gruppieren zu k?nnen, dies sorgt f?r eine bessere Lesbarkeit des Codes.  
`enum Richtung`  
`{`  
    `HOCH, RUNTER, LINKS, RECHTS`  
`}`  

Hier bennent man also einfach seine Aufz?hlung `enum Richtung` und schreibt einfach seine Werte mit einem Komma getrennt auf. Diese Werte sind unter der Haube Integer und werden standardm??ig wie beim Index bei Datenstrukturen beginnend mit dem Wert 0, 1, 2... usw. zugewiesen.  
## Operatoren ?berschreiben [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Das ?berschreiben von Operatoren wird h?ufig bei komplexen Zahlen genutzt und wird wie eine Methode in eine Klasse geschrieben inkl. des Operators der ?berschrieben werden soll.  
`class Complex{`  
    `public int real;`  
    `public int imagin?r;`  
    `// real + i * imagin?r`  
    `public static Complex operator +(Complex a, Complex b)`  
    `{`  
        `return new Complex(a.real + b.real, a.imagin?r + b.imagin?r);`  
    `}`  
`}`  
## Super [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Das `Super`-Schl?sselwort nutzt man um in einer Unterklasse eine Methode der Oberklasse aufzurufen.  
`class Schule{`  
    `public int anzahlSchueler;`  
    `public void neuerSchueler(){`  
        `anzahlSchueler += 1;`  
    `}`  
`}`  
`class Gymnasium : Schule{`  
    `public bool hasGrundschulabschluss;`  
    `public new void neuerSchueler(){`  
        `if (hasGrundschulabschluss){`  
            `anzahlSchueler += 1;`  
        `}`  
    `}`  
    `public void vipKid(){`  
        `Super.neuerSchueler();`  
    `}`  
`}`  
Hier wird bspw. das `Super`-Schl?sselwort benutzt um klar zu stellen das man die Methode der Oberklasse verwenden m?chte und nicht die ?berschrieben Methode in der selben Klasse.  
## Interfaces [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Das `interface`-Schl?sselwort wird dazu verwendet ein Interface zu definieren, wovon ?hnlich wie bei einer normalen Klasse vererbt werden kann.  

Ein Interface selbst kann nicht instanziiert werden und es werden nur Methodenk?pfe innerhalb eines Interfaces definiert die, wenn man sie an eine Klasse vererbt zwingend definiert werden m?ssen.  
`interface BildungInstanz{`  
    `public function void neuerSchueler();`  
`}`  
`class Schule implements BildungsInstanz{`  
    `public function void neuerSchueler(){`  
        `anzahlSchueler += 1;`  
    `}`  
`}`  

Nun kann man wie bei den Klassen ein Array vom Typ des definierten interfaces erstellen und durch alle Klassen die von dem Interface geerbt haben iteriieren.  
`BildungsInstanz[] meinArray = {Schule, Gymnasium};`  
`for (BildungsInstanz i in meinArray){`  
    `i.neuerSchuler();`  
`}`  

Mei?tens wird nur eine Methode pro Interface definiert damit es ?bersichtlicher ist.
## Mehrfachvererbung und das Diamantenproblem [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Bei der Mehrfachvererbung kann das Problem entstehen, das wenn man eine Methode aufruft die mehrfach in der Vererbungshierarchie definiert wurde nicht klar ist, welche nun ausgef?hrt werden soll.  

Deswegen verbieten viele Programmiersprachen die Mehrfachvererbung, man kann also in diesen nur von einer Klasse erben. Es ist aber m?glich von mehreren Interfaces zu erben, da hier ja keine Definition gegeben ist.  
`interface IBildung{`  
    `public int AnzahlSchueler { get; set; }`  
    `void neuerSchueler();`  
`}`  
`class Schule : IBildung{`  
    `public int AnzahlSchueler { get; set; }`  
    `public void neuerSchueler(){`  
        `AnzahlSchueler += 1;`  
    `}`  
`}`  
`class Gymnasium : Schule, IBildung{`  
    `public int AnzahlSchueler { get; set; }`  
    `public void neuerSchueler(){`  
        `AnzahlSchueler += 1;`  
    `}`  
`}`  

In C++ ist dies einfach erlaubt und w?rde zum Absturz des Programms f?hren wenn die mehrfach definierte Methode aufgerufen wird.  

In Python ist die Reihenfolge der aufgeschrieben Klassen relevant, da immer die erste Methode mit dem gew?hlten Name f?r den Methodenaufruf ausgew?hlt wird die in den jeweiligen Klassen gefunden werden und dann wird der Methodenaufruf durchgef?hrt, ohne dass in den weiteren Klassen danach geschaut wird.  
## Abstrakte Klassen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Das `abstract`-Schl?sselwort sorgt bei einer Klasse daf?r das man wie bei den Interfaces nicht nicht von ihnen instanziieren kann und man Methodenk?pfe definieren kann. Man kann aber auch ganz normal wie bei Klassen auch Variablen und vollst?ndige Methoden definieren. Hierbei ist gar keine Mehrfachvererbung m?glich.  
`abstract class Schule{`  
    `public int anzahlSchueler;`  
    `public void neuerSchueler();`  
    `public void zeigeAnzahlSchueler(){`  
        `print($"Die aktuelle Schueleranzahl lautet {AnzahlSchueler}");`  
    `}`  
`}`  
`class Gymnasium : Schule{`  
    `public int anzahlSchueler;`  
    `public void neuerSchueler(){`  
        `anzahlSchueler += 1;`  
    `}`  
`}`  
## Der Zugriffsmodifikator protected [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Das `protected`-Schl?sselwort kann an den selben stellen wie die Schl?sselw?rter `public` und `private` eingesetzt werden. Es sorgt daf?r, dass die damit modifizierten Variblen und Methoden nur innerhalb der Klassenhierarchie aufgerufen werden k?nnen, also nur innerhalb der selben Klasse oder innerhalb der vererbten Unterklassen.  
## Statische innere Klassen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Die statischen inneren Klassen k?nnen dazu verwendet werden, selbst definierte Objekte an eine Klasse zu binden, also man kann nur Objekte dieser Klasse erzuegen wenn die ?u?ere Klasse bereits instanziiert wurde.  
`class Schule{`  
    `// innere Klasse`  
    `public static class Schueler{`  
        `int alter;`  
        `string name;`  
    `}`  
`}`  
`Schule.Schueler hans = Shcule.new Schueler();`  

Hier kann man nun auch innerhalb der ?u?eren Klasse von der inneren Klasse Objekte erzeugen.  
`class Schule{`  
    `// innere Klasse`  
    `public static class Schueler{`  
        `int alter;`  
    `}`  
    `public function void neuerSchueler(){`  
        `... new Schueler();`  
    `}`  
`}`  
## Innere Klassen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Mit den normalen inneren Klassen kann man das Objekt welches instanziiert wird an die ?u?ere Klasse binden.  
`class Schule{`  
    `public class Schueler{`  
        `int alter;`  
        `string name;`  
        `public void anKursTeilnehmen(){`  
            `print(Schule.this.name);`  
        `}`  
    `}`  
    `protected int anzahlSchueler;`  
    `public void neuerSchueler(){`  
        `anzahlSchueler += 1;`  
        `Schueler hans = this.new Schueler();`  
        `hans.anKursTeilnehmen();`  
    `}`  
`}`  
## Anonyme innere Klassen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Die anonymen inneren Klassen werden bspw. im Zusammenhang mit den Methodenk?pfen in einer abstrakten Klasse verwendet und werden nur ein einziges mal initalisiert, deklrariert, verwendet und dann wieder vom Speicher freigegeben.   
`abstract class Schule{`  
    `public string name;`  
    `protected int anzahlSchueler;`  
    `public function void neuerSchueler(){`  
        `anzahlSchueler += 1;`  
    `}`  
    `pubic function void schuleAus();`  
`}`  
`Schule x = new Schule(){`  
    `public function void schuleAus(){`  
        `print("yeeey");`  
    `}`  
`};`  
`x.SchuleAus();`  
## Module [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Die Module kapseln den Code so, dass man ihn in anderen Projekten verwenden kann.  
`namespace`(C#) o. `package`(Java) o. "Datei"(Python)  

Diese Module k?nnen unterschiedlich eingebunden werden.  
`#include`(C/C++) o. `import`(Java) o. `using`(C#)

Wenn man ein bestimmtes Modul einbindet, kann man direkt von diesem erben. Man kann auch Funktionen und Methoden verwenden, als w?ren sie im eigenen Projekt.  

String sind bspw- nicht standardm??ig in jeder Programmiersprache integriert, weswegen hier Module eingebunden werden m?ssen.  
## Dynamic vs Static Scoping [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Beim Static Scoping werden immer erst die Variablen und Inhalte verwendet, die innerhalb des selben Scopes(Codeblock) liegen.  
`int a = 42;`  
`int function foo(){`  
    `int res = a + 42;`  
`}`  
`int function bar(){`  
    `int a = 1337;`  
    `return foo();`  
`}`  
`foo();`  
`bar();`  

Hier wird in der `foo();`-Funktion die Variable `a` aus dem kompletten Datei-Scope verwendet, da dies die naheliegenste Initialisierung und Deklaration von `a` ist. Also `a = 42`.  

Beim Dynamic-Scoping w?rde hier die Variable tats?chlich ?berschrieben werden. Es w?rde also in der Funktion `bar();` die Variable `a` mit dem Wert `a = 1337` verwendet werden.  
## Mixins [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Bei Mixins kann eine Klasse ohn Type Casting mit zwei oder mehr Klassentypen deklarriert werden, sodass man bspw. in einer Funktion die verscheiden Klassentypen zur?ckggeben kann.  
`class Maybe(a) = Just(a) | Nothing;`  
`class Just {`  
    `float a;`  
`}`  
`class Nothing {`  
`}`  
`Maybe function div(float a, float b){`  
    `if (b == 0) {`  
        `return new Nothing();`  
    `}`  
    `else {`  
        `return new Just (a/b);`  
    `}`  
`}`  

Hier wird das neue Objekt `Nothing();` zur?ck gegeben, falls diue Variable `b` einen Wert von 0 hat und damit nicht durch 0 geteilt wird. Ist die Variable `b` nicht 0 so ist der R?ckgabewert ein neues Objket der Klasse `Just();`.  
## Generics [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Generische Klassen haben Typparameter `<T>`, die immer einen anderen Typ haben k?nnen, bspw. den Typ `int`.  

Man kann also je nach dem welchen Typparameter man ?bergibt, unterschiedlich mit dem Objekt innerhalb der Klasse arbeiten, was bspw. einzelne Sortierverfahren aus?erhalb der Klasse erspart.  
`class Container<T>{`  
`}`  
`Container<int> tonne = Container<int>();`  

Bei Java musste man bei der Initalisierung iener generischen Klasse die Wrapperklassen verwenden um das Typargument zu ?bergeben, da die Standarddatentypen hier nicht funktionieren, hier muss also bspw. die Wrapperklasse `Integer` verwendet werden.  

Man k?nnte hiermit also auch eigene generische Datenstrukturen erstellen, die bspw. innerhalb der Klasse die Struktur sortiert statt sie ?ber einen extra Methodenaufruf sortieren zu m?ssen.  

`class Container<T>{`  
    `T[] meinArray;`  
    `private function void sortierung(){`  
        `if (T[0].equals.(T[1])){`  
            `///...`  
        `}`  
    `}`  
`}`  
## Generische Funktionen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Generische Funktionen nutzt man so wie normal Methoden, man hier aber den Typ `<T>` sowohl als Parameter als auch als R?ckgabewert verwenden.  
`function T[] sort<T> (T[] elements){`  
    `//...`  
`}`  
`String[] meinArray = {"verstecke champion", ";", "seit 1958"};`  
`meinArray = sort(meinArray);`  

Hier muss kein Variablentyp ùbergeben werden, da dieser unter der Haube mit ?bergeben wird.  
## Typschranken [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Mit Typschranken kann man den Typen `T` den man bei Generics ùbergibt auf eine Auswahl von Typen begrenzen.  
`function T[] sort<T extends String>(T element){`  
    `return element.split(' ');`  
    `//...`  
`}`  

Hier wird der Typ `T` auf das Objekt `String` und deren verebten Klassen begrenzt, es kann also nur einer dieser Typen an die generische Funktion ùbergeben werden. Dadurch kann man hier auch die `split()`-Methode aus der String-Klasse verwenden, da man sicher sein kann das diese exisitert.  
## Prozesse und Threads [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Normalerweise startet ein Programm auf einem Computer als Prozess mit bspw. folgenden Inhalten.  `CODE|DATA|FILES|`  

Diese Inhalte kùnnen auch auf Threads mit folgendne Inhalten aufgeteilt und quasi parallel ausgefùhrt werden.  
`THREAD1: REGISTER|STACK`
`THREAD2: REGISTER|STACK`

Es gibt Programmiersprachen die nur mehrere Prozesse erzeugen ("Forken") und keine Threads erzeugen und umgekehrt genauso.  

Threads haben an sich immer einen Status.  
`new Thread()-----> New`  
`<----start()-----> Runnable`  
`<----run()-------> Running`  
`<----sleep()-----> Waiting // Hier kann die feste Dauer ùbergeben werden`  
`<----wait()-----> Waiting // Hier wird so lange gewartet bis wieder der Befehl notifiy() ausgefùhrt wird`  
`<----notify()-----> Running`  
`<----return/SIGKILL()-----> DEAD // Thread wird gelùscht/entfernt`  
## Threads erstellen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Um Threads erstellen zu kùnnen, benùtigt man meistens eine Bibliothek.  
`Runnable`(Java) o. `Thread`(Python) o. `Threading`(C#)  

In Java muss man von `Runnable` erben und die `run()`-Methode ùberschreiben.  
`import Thread`  
`class MyThread implements Thread{`  
    `public function void run(){`  
        `for(int i = 0;i < 1000000;i++){`  
            `print(i);`  
        `}`  
    `}`  
`}`  
`Thread t = new MyThread(); // Erstellt den Thread und startet ihn automatisch.`  
`t.run(); // ùndert den Status zu Running`  
`exit(0); // Beendet den Thread`  

Je nach Programmierpsrach muss man den Thread nach der Initialisierung manuel starten und meistens lùuft eine zweiter Thread der mit erstellt wurde nach dem beenden des ersten Threads weiter.  
## Nebenlùufigkeit von Threads [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Falls man mehrere Threads gleichzeitig instanziiert, kann man als Programmierer nicht sicher sein, welcher jetzt wann und an welcher Stelle durchlùuft, da diese immer unterschiedlich druchlaufen werden.  
`import Thread`  
`class MyThread implements Thread{`  
    `public function void run(){`  
        `for(int i = 0;i < 10;i++){`  
            `print(i);`  
        `}`  
    `}`  
`}`  
`Thread t = new MyThread();`  
`Thread t12 = new MyThread();`  
`t.run();`  
`exit(0);`  
`Ausgabe: 01234012356897894567`  
## Atomare Operationen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Atomare Operationen sorgen daf¸r, dass wenn eine globale Variable innerhalb eines Threads gelesen oder ersetzt wird, der Thread nicht unterbrochen wird.  

Das gilt auch f¸r alle primitiven Datentypen, die bereits in der Programmiersprache enthalten sind.
## synchronized [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Eine `synchronized`-Funktion sorgt innerhalb eines Threads daf¸r, dass der komplette Inhalt der Funktion im ganzen ausgef¸hrt wird. Dieses Konzept wird auch "Thread save" genannt.
## locks [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Ein `Lock`-Objekt sorgt auch daf¸r, dass der geschriebene Code nur aif einem Thread ausgef¸hrt wird, stoppt aber auch alle anderen Threads.  

Das kann dzau f¸hren, dass die Laufzeit l‰nger dauert, als wenn man nur einen Thread erstellt, der den Code ausf¸hrt.  
`import Thread`  
`class MyThread implements Thread{`  
    `public function void run(){`  
        `for (int i = 0;i < 10;i++>){`  
            `l.acquire();`  
            `print(i);`  
            `l.release();`  
        `}`  
    `}`  
`}`  
`Lock l = new Lock();`
## Semaphoren [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Mit dem `Semaphoren`-Objekt kann man bestimmen, auf wie viele Threads man gerade zugreifen kann bzw. wie viele man gerade verwenden mˆchte. Man hat also `Lock`-Objkete, was wiederum heisst, das 1 `Semaphor`-Objekt == `Lock`-Objekt ist.  

Dieses Konzept nutzt man wenn man bspw. ein System nicht mit zu vielen Threads ¸berlasten mˆchte.
## Deadlocks [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Ein Deadlock also ein nicht verwendebarer Thread entsteht bspw. wenn man das selbe `Lock`-Objekt doppelt erwirbt. Dadruch kann man n‰mlich das erste erworbene `Lock`-Objekt nicht verˆffentlichen.  

Am besten sollte man also immer erst ein `Lock`-Objekten verˆffentlichen, bevor man ein neues oder das selbe `Lock`-Objekt erwirbt.  
## Concurrent Programming Languages [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Nebenl‰ufige Programmierpsrachen wie bspw. OpenCL werden direkt mit Multithreading ausgef¸hrt, dass heisst man muss angeben wie viele Threads man nutzen mˆchte und man muss Locks bzw. Semaphoren nutzen um einen selbstgesteuerten und nicht zuf‰lligen Programmablauf zu haben.  

Die Threads kˆnnen in solchen Programmiersprachen meistens schnell erstellet werden.  
## Actors und Message Passing [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Actors werden meistens von der Programmiersprache mit geliefert und werden dazu genutzt um Message Passing zu betreiben, also um Nachricht zu senden.  
`class MyActor extends Actor{`  
    `void function onReceive(object o){`  
        `String nachricht = (String)o;`  
    `}`  
`}`  
`MyActor m = new MyActor();`  
`m.send("Hallo");`  

Hier wird ein `String` an den `Actor` gesendet, sodass er innerhalb der von Actor geerbten Klasse verwendet werden kann.  

Unter der Haube hat der Actor seinen eigenen Thread und wartet permanent auf eine gesendete Nachricht, um sie zu bearbeiten.  
## Events [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Events werden dazu gebraucht um zwischen Threads hin und her signalisieren zu kˆnnen.  

Hierbei wird die `wait()`-Methode dazu verwendent, einen Thread zu pausieren, was daf¸r sorgt, dass diese dauerhaft aquired ist. `notify()` wird dazu verwendet um Threads zu benachrichtigen, dass bspw. ein neues Element folgt. Mit `sleep()` wird wie bei `wait()` pausiert nur kann man hier angeben wie lange pausiert werden soll. Und `join()` sorgt daf¸r das der Parenthread(der Thread auﬂerhalb des derzeit benutzten Threads), gestoppt wird, bis der gerade aufgerufene Thread durchlaufen wurde.  

Letzteres funktioniert also ‰hnlich wie ein `sleep()`, deswegen sollte man auch nur eins von beiden verwenden, da man sonst ein Deadlock konstruiert.  
## Event Driven Development [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Event Driven Development muss von der Porgrammiersprach unterst¸tzt werden und wird in hraphischen Oberfl‰chen dzau genutzt, dass Methoden ausgef¸hrt werden, wenn sich irgend etwas in der GUI ‰ndert bzw. wenn etwas geklickt wird.  
`class Main extend GUI{`  
    `onKeyEnter(Key c){`  
        `print(Key.toString());`  
    `}`  
`}`  

Hier wird `Key c` ausgeben, wenn sie gedr¸ckt wird.  
## Debugging und Breakpoints [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Mit einem Debugger kann man in so gut wie jeder IDE mit Breakpoints seinen Code Zeile f¸r Zeile debuggen. Dadurch kann man sehr gut Fheler in seinem Code finden.  

Breakpoints kann man meistens einmal pro Zeile setzten, sodass man wenn man das Debugging startet, direkt zu dem 1. Breakpoint springt.  

Ab hier kann man verschiedene Mˆglichkeiten weiter fortzufahren. Man kann bspw. den Code nochmal ausf¸hren, den Code weiter ausf¸hren, die Ausf¸hrung des Codes abbrechen und sogar Variablenihnalte einsehen und zur Laufzeit f¸r die weiter Codedurchf¸hrung ab ‰ndern.  
## Testen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Um seine Code zu testen, kann man verschiedene Testarten einsetzten. 

Die bekannteste Testart ist Unittesting. Diese Testart testet die Funktionalit‰ten von Klassen.  

Hier sollte man spezielle Testf‰lle je Objekt inkl. deren Zusammenh‰nge schreiben, um sich keinen unnˆtigen Aufwand zu machen.  
`class MyTest extends TestCase{`  
    `public void teste_meineFkt(){`  
        `assert(meineFkt(), "irgendwas");`  
    `}`  
`}`  
## Exceptions [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Exceptions nutzt man um Fehler die zur Laufzeit passieren abfangen zu kˆnnen.  
`int meinArray = {1,2};`  
`try{`  
    `print(meinArray[2]);`  
`}`  
`catch Exception e{`  
    `print("exception");`  
`}`  
`finally{`  
    `print("Hallo");`  
`}`  

Hier wird ein Fehler geworfen, da auf ein Index im Array zugegriffen wird, der nicht definiert ist.  

Es gibt verschiedene Exception-Typen wie z.B. FileNotFoundException, IOExeption, usw. um den Fehler differenzieren zu kˆnnen.  
## Eigene Exceptions [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Man kann auch eigen Exceptions bauen, in dem man einfach von der Klasse `Excpetion` erbt.  

Je nach Programmiersprache wirft man dann diesen Fehler mit einem Schl¸sselwort `throw` o. `rasie`.  
`class meinFehler extends Exception{`  
    `public meinFehler(String msg){`  
        `super(msg);`  
    `}`  
`}`  
`function void meinFkt(int[]) meinArray){`  
    `if(meinArray.length == 0){`  
        `throw new meinFehler("Fehler: Array ist leer");`  
    `}`  
`}`  
## RegEx - Regul‰re Ausdr¸cke [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Regul‰re AUsdr¸cke (kurz RegEx) werden dazu verwendet um den richtigen Inhalt eines Strings zu ermitteln, man verleicht also kruz gesagt Strings.  
`regex("").match(String);`  

In so einem Ausdruck kann man jetzt verschieden Dinge definieren.  
* [Hh] => groﬂes oder kleines H
* [^Hh] => alles was nicht groﬂes oder kleines H ist
* [a-z] => alle kleinen Buchstaben von a-z
* \s => Whitespace
* \S => alles was kein Whitespace ist
* \d => Zahl
* \D => alles was keine Zahl ist
* ...{2} =>Anzahl wie oft der Ausdruck hintereinander stehen soll.
* ...|... => Zum veroderen der Ausdr¸cke
* a? => Ein a oder kein a
* a* => Beliebig oft a
* a+ => Mindestens ein a
* a{1,} => Mindestens 1 a
* a{3,5} => Je nach Programmiersprache 3-5 o. 3 u.5 mal a
* \# => Route Symbol
`\#([a-f]|[A-F]|[0-9]){3,6}`
Dies ist ein regul‰rer Ausdruck um eine Hexadezimalzahl ermitteln zu kˆnnen.