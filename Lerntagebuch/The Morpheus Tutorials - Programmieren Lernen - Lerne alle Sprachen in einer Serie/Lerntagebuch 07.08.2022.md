# Lerntagebuch 07.08.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Datenbanken
2. Fortgeschrittene Funktionale ProgrammierungInferierte Typen
3. Typinferenz von Funktionen
4. Funktionen höherer Ordnung
5. Currying
## Datenbanken [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Datenbanken sind eine weitere Möglichkeit um Daten speichern zu können. Sie sind im Endeffekt eine Ansammlung von Tabellen, die mithilfe der SQL Abfragesprache genutzt werden können.  

Datenbank 1  
Tabelle 1 T2 T3 ...  
ID(Key) | Name | Adresse | Tel  
1      
2 

`import db`  
`Connection c = new Connection("localhost", "morpheus");`  
`Statement stmt = c.createStatement();`  
`int result = stmt.executeUpdate("USE DB1");`  
`ResultSet rs = stmt.executeQuery("SELECT * FROM Tabelle1");`  
`while(rs.next()){`  
    `print(rs.getInt("ID") + rs.getString("Name"));`  
`}`  
## Fortgeschrittene Funktionale ProgrammierungInferierte Typen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Bei Inferierten Typen wird der Typ einer Variablen automatisch ermittelt, meistens kann dieser Typ nach der Initialisierung nicht mehr geändert werden.  
`var meineVar = "MeineVariable";`  
## Typinferenz von Funktionen [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Bei der Typinferenz von Funktionen muss man sowohl für den Rückgabewert, als auch für die parameter keinen festen Typen angeben.  
`function foo(param){`  
    `return param;`  
`}`  

Wenn man hier mehrere Parameter übergeben will die typinferent sind, müssen sie wie der selbe Typ in der Funktion behandelt werden.
## Funktionen höherer Ordnung [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Höheren Funktionen ermöglichen es einen anderen Typen aus einer typinferierten Funktion zurückgeben, als man als Parameter übergben hat. Man kann hier sogar FUnktionen zurückgeben.  
(a->(b->c)->(b->c))  
`function foo(param, f){`  
    `return f;`  
`}`  
(c->c)  
`function bar(param){`  
    `return param;`  
`}`  
`var a = foo(42, bar);`  
## Currying [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Beim Currying ruft man eine Funktion in einer Funktion auf, ohne alle Parameter setzen zu müssen.  
(number->number->number)  
`function addieren(a, b){`  
    `return a+b;`  
`}`  
`function add_three(param){`  
    `return addieren(3, param); // return 3 + param`  
`}`  
`add_three = addieren(3);`  