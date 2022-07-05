# Lerntagebuch 04.07.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Listen
2. Mehrdimensionale Listen
3. Strings
4. Unicode-Zeichensatz
5. Arithmetische Operatoren
6. IF-Verzweigungen
## Listen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Im Gegensatz zu den Arrays muss bei den Listen der Speicher der belegt werden soll nicht vorher definiert werden.  

`a = [42, 1337, 128, 256]`

Um nun einer Liste einen Wert hinzuzufügen bentuzt man die Add-Funktion.  

Mit der Len-Funktion gibt man die Anzahl an Elementen die sich in der Liste befinden zurück.

Funktionen wie Push() und Pop() können der Liste ebenfalls eine Element hinzufügen bzw. ein Element aus der Liste entfernen.  

Grundsätzlich sind Listen langsamer als Arrays, da sie eine längere Zugriffzeit benötigen um auf ein Element zugreifen zu können.

Bei einer Liste bekommt ein Element immer die Speicheraddresse des nächsten Element zugewiesen, diese Datenstruktur nennt man auuch Linked List.

42-->1337-->128-->256

Um hier also an die 256 zu kommen muss man also durch die gesamte Liste durchgehen, man hat also 4 Zugriffszeiten.

Es gibt auch eine Double Linked List, bei der auch die Speicheraddresse des vorherigen Elements im Element gespeichert wird und sogar das erste mit dem letzten verkettet ist.

42<-->1337<-->128<-->256  
<----------------------------->  
## Mehrdimensionale Listen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Mehrdimensionale Listen funktionieren genau so wie die mehrdimensionalen Arrays, heisst es werden Listen in Listen gespeichert.
## Strings [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Strings sind Zeichenketten, also nicht anderes als variabel Große Char-Arrays bzw. Listen aus Chars.  

`string a = "irgendwas";`

Falls hier von der Programmiersprache ein Array genutzt wird, wird unter der Haube von der Programmiersprache selbst immer ein neues Array angelegt falls sich die Größe des Arrays ändert.  

Die einzelnen Chars in einem String können also auch mit einem Index behandelt werden.  

Der Backslash (umgekehrten Schrägstrich) hat in einem String eine besondere Bedeutung und zwar dient dieser als Markierungszeichen um ein Special-Char nutzen zu können.  

Diese Special-Chars sind bspw. `"\n"` um einen Zeilenumbruch druchzufügren oder `"\t"` um einen Tabulator einzufügen.

Falls man nun einen Backslash in seinen String schreiben möchte, schreibt man einfach einen weiteren Backslash davor damit derKompiler diesen wieder als Backslash identifizieren kann.

Um einen String an sich zu identifizeren schreib man doppelte Anführungszeichen (") vor und hinter die Zeichenkette, falls auch hier das doppelte Anführungszeichen innerhalb der zeichenkette genutzt werden soll, schreibt man auch ein Backslash davor.
## Unicode-Zeichensatz [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Mit dem Unicode Zeichensatz kann man durch Special-Chars nun bspw. Smiles in seinen Strings einfügen.  

Dies tut man in dem man \u gefolgt von der gewünschten Hexadezimalzahl in den String schreibt.  

Diese Hexadezimalzahl steht bspw. für ein Herz:  
`"\u2665"`

Eine Tabelle mit sämtlichen Unicode-Zeichen inkl. Hexadezimalenzahlen findet man hier:  
https://unicode-table.com/de/
## Arithmetische Operatoren [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Es gibt 5 arithmetische Operatoren. Plus, Minus, Mal, Geteilt und Modulo.  
`a = x+y;`  
`a = x-y;`  
`a = x*y;`  
`a = x/y;`  
`a = x%y;`  

Auch hier kann ein Overflow im Speicher entstehen wenn man nach der Berechnung die Range des Datentypen über- bzw. unterschreitet.

Bei dem Geteilt-Operator muss beachtet werden, das nich durch 0 geteilt wird da der zurückgegebene Wert sonst NaN ist und für Fehler im Programm sorgen kann.

Der Modulo-Operator wird dazu verwendet um nur den Rest einer Division in einer Variablen zu speichern. Dies wird häufig bei Grafikprogrammierung genutzt.

`int x = 5;`  
`int y = 3;`  
`int z = x % y;`  
5/3 = 1 R = 2 also ist Z = 2

Es gibt auch die Möglichkeit Variablen mit einem anderen Wert zu verändern, was mit allen arithmetischen Operatoren funktioniert.  
`y += 1;` oder `y = y + 1;`  
`y -= 1;` oder `y = y - 1;`  
`y *= 1;` oder `y = y * 1;`  
`y /= 1;` oder `y = y / 1;`  
`y %= 1;` oder `y = y % 1;`  

Um einen Wert um eine Stufe zu vergrößern bzw. zu verkleinern (Inkrementierung/Dekrementierung), kann man auch eine vereinfachte Schreibweise verwenden.  
y++; u. y--;  

Hier gilt zu beachten, dass wenn man den inkrementierten Wert übergeben will die Varaible hinter die Operatoren schreiben muss.  

`int x= 5;`  
`int y= 3;`  
`int z= y++;`  
`// z = 3, y = 4`  
`int w= ++x;`  
`// w = 6, x = 6`  
Expontenten werden wie folgt gekennzeichnet:  
`int z = x**y;` oder `int z = x^y;` oder `int z = Math.Pow(x, y);`
## IF-Verzweigungen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Wird dazu benötigt seinen Code zu strukturieren und um mit Bedingungen arbeiten zu können. 

Um einen if-Block zu beginnen, schreibt man das if-Schlüsselwort, gefolgt von der Bedingung, gefolgt von den gescheiften Klammern in dem der Code steht der ausgeführt werden soll, wenn die Bedingung erfüllt worden ist.  
`if (BEDINGUNG)`  
`{`  
  `// irgendwelcher Code`  
`}`  

bei Bedingungen werden Vergleichüberprüfung vor genommen die mit einem doppelten Gleichheitszeichen geschrieben werden.  
`if (x == 42)`  

Das else-Schlüsselwort sorgt dafür, dass immer etwas ausgeführt wird falls keine der vorherigen if-Bedingungen erfüllt worden sind.  
`if (BEDINGUNG)`  
`{`  
  `// irgendwelcher Code`  
`}`  
`else`  
`{`  
  `// irgend ein ausnahme Code`  
`}` 

In der Verbindung mit beiden Schlüsselwörtern also `else if` kann man nun auch weitere Bedingungen in dem IF-Block hinzufügen, um andere Bedingungen ablaufen zu können.

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