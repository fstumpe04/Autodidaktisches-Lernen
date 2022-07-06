# Lerntagebuch 05.07.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Booleans und Vergleichsoperatoren
2. Logische Operatoren
3. Bitweise Operatoren
4. While Schleifen
## Booleans und Vergleichsoperatoren [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Booleans werden häufig mit bool abgekürzt, sind 1 Bit groß und können sowohl 0=false als auch 1 = true sein.  

Bei einer IF-Verweigung kann man diesen Datentypen mit einem sogenannten Vergleichsoperator (==)verwenden, um einen bestimmte Bedingung zu definieren.  
`bool x = true;`  
`bool y = true;`  
`bool wahrheit = x == y;`  
`if (wahrheit){`
`}`

Hier wird also der Code in dem if-Block ausgeführt da x und y gleich sind.  

Es gibt auch noch Verlgeichssoperatoren die Abfragen ob etwas größer (>), kleiner (<), größergleich (>=) oder kleinergleich(<=) dem folgenden Wert ist.  

Falls man auch Ungleichheit prüfen möchte, gibt es auch noch die folgenden Schreibweisen:  
`x != y;` oder `x <> y;` oder `x ~= y;`  

Ein boolscher Wert kann auch negiert werden so das immer der gegenteilige Wert übergeben wird.  
`bool falschheit = !wahrheit;`
## Logische Operatoren [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Die logischen Operatoren können mit boolschen Werten verknüpft werden.  

Der Und-Operator (AND o. &&) ist nur wahr wenn beide Werte wahr sind.  
`bool log = true;`  
`bool log2 = true;`  
`bool ergebnis = log && log2;`  

Der Oder-Operator (OR o. || o. ^) gibt wahr zurück wenn mindestens ein Wert wahr ist, also gibt er nur falsch zürck wenn beide Werte falsch sind.  
`bool ergebnis = log || log2;`  

Falls man nun beide Operatoren in einer Bedingung verwenden möchte, hat der Und-Operator (AND o. &&) eine stärkere Gewichtung als der Oder-Operator (OR o. || o. ^). Dies ist vergleichbar mit der Punkt vor Strich-Rechnung aus der Mathematik.  
`if ((a && b) || (a && c)){`  
`}`  

Hier können aber auch Klammern gesetzt werden, um die Oder-Verknüpfung zuerst ausführen lassen zu können.  
`if (a && (b || a) && c){`  
`}`  
## Bitweise Operatoren [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Die Bitweisen Operatoren sind ähnlich wie die logischen operatoren, werden aber auf ganzzahlige Werte angewendet.  

Hier werden meistens Hexadezimale- (0x...) oder Binärzahlen(0b...) verwendet.  
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

Sowohl bei den logischen als auch bei den bitweisen Operatoren gibt es auch noch den Entweder/Oder-Operator (XOR o. ^), der immer dann wahr zurück gibt, wenn nur einer der beiden Werte wahr ist. Also wird hier immer wenn beide Werte gleich sind falsch zurück gegeben.  

Bitweiser Entweder/Oder-Operator (XOR o. ^):  
`int bitmaske = 0x000F;`  
`int wert = 0xAAAA;`  
`int ergebnis = wert ^ bitmaske;`  
1010 1010 1010 1010  
0000 0000 0000 1111  
1010 1010 1010 0101  
`int ergebnis = 0xAAA5;`  

Es gibt auch noch das Bitshiften, womit man eine vorgegebene Anzahl an Bits aus einer Bitreihe vorne oder hinten abkappt, die verleibenden Bits aufrücken lässt und die leeren Plätze mit den selben Bitwerten füllt wie der naheliegenste Bit.  
`int wert = 0xAAAA;`  
1010 1010 1010 1010  
`int ergebnis = wert >> 3;`  
1111 0101 0101 0101  

`int bitmaske = 0x000F;`  
0000 0000 0000 1111
`int ergebnis = bitmaske >> 3;`  
0000 0000 0000 0001  

Mit dem erweiterten Bitshift-Operator (>>>) kann man auch festlegen, dass die leeren Plätze immer mit 0 aufgefüllt werden sollen.  

`int wert = 0xAAAA;`   
1010 1010 1010 1010  
`int ergebnis = wert >> 3;`  
1111 0101 0101 0101  
`int ergebnis = 0xF555;`  

Das funktioniert aber nur die Rechte-Richtung!  

Das gleiche funktioniert auch in die andere Richtung, nur wird hier immer mit 0 aufgefüllt.

`int wert = 0xAAAA;`   
1010 1010 1010 1010  
`int ergebnis = wert << 3;`  
0101 0101 0101 0000  
`int ergebnis = 0x5550;`
## While Schleifen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Schleifen sorgen generell dafür Code mehrfach ausführen zu können.  

Bei der while Schleife wird der Code solange mehrfach ausgeführt, wie die Bedingung erfüllt also wahr ist.  
`while (BEDINGUNG){`  
`}`  
o.  
`while (BEDINGUNG){`  
`}`  

Wenn sich die Bedingung im Code nie ändert, erzeugt man eine Endlosschleife, die den Code permanent ausführt.  
`bool wahrheit = true;`  
`while (wahrheit){`  
    `// Endlose Code ausführung`  
`}`  

Um nun einen Code nur um eine bestimmte Anzahl nach wiederholt auszuführen, arbeitet man hier mit den kleiner o. größer als Vergleichoperator und einem ganzzahligen Wert als Bedingung und einer Inkrementierung/Dekrementierung des zuvor gennanten ganzzahligen Wertes.  
`int i = 0;`  
`while (i < 42){`  
    `print("hello");`  
    `i++;`  
`}`

Es gibt auch nich die do-while Schleife die man dann verwenden kann, wenn man den Code innerhalb der Schleife mindestens einmal ausführen will.  
`int i = 0;`  
`do {`  
    `print("hello");`  
    `i++;`  
`} while (i < 42);`