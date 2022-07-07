# Lerntagebuch 07.07.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Rückgabewerte
2. Parameter
3. Rekursion
4. Default Argumente
## Rückgabewerte [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Rückgabewerte weerden dazu benötigt um etwas von einer Funktion zurückgeben zu können.  

Falls man keinen Rückgabewert verwenden möchte, nutzt man hier den Wert `void`.  
`void function foo(){`  
`}`  

Um nun einen Wert von einer Funktion zurückgeben zu können, gibt man hier statt `void` einen Datentyp wie z.B. `int` an und gibt den Wert mit dem Schlüsselwort `return` zurück.  
`int function foo(){`  
    `int ergebnis = 42*1337;`  
    `return ergebnis;`  
`}`  

Zu beachten gilt hier, das der Code nach dem `return` nicht mehr ausgeführt wird.  

Falls man nun eine IF-Verzweigung innerhalb der Funktion nutzen möchte, muss man immer daran denken ein `return` zurückzugeben, sonst würde ein Fehler entstehen.  
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

Nun kann man den Rückgabewert aus der Funktion in eine Variable schreiben. Dabei gilt zu beachten, dass die Varaible und die Funktion den selben Datentyp haben.  
`int meinInteger = foo();`  
## Parameter [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Parameter können über die runden Klammern an die Funktion übergeben werden.  
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

Der Parameter muss hier, ähnlich wie bei den Rückgabewerten, den selben Datentyp haben wie die übergebene Variable.  

Damit lassen sich auch Funktionen anandere zur Verwendung weitergeben.  

Man kann auch mehrere Parameter an eine Funktion übergeben und nutzen.  
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

Die Parameter sind also Platzhalter die für verschiedene Ergebnise einer Funktion sorgen kann.  
## Rekursion [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Rekursion bedeutet das sich eine Funktion selbst x mal aufruft. Damit lassen sich auch Funktionen wie die Fakultät 10! = 10*9*8*7...! oder die Fibonacci-Folge 0,1,1,2,3,5,8,13... aus der Mathematik berechnen und abbilden.  
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

Bie mehreren Parametern funktioniert das genau so, man kann aber nur in manchen Programmiersprachen einen ausgewählten Parameter setzen.  
`int function foo (int n = 10, bool b = true){`  
`}`  
`int meineVar = foo(b = false);`  