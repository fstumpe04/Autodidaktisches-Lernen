# Lerntagebuch 11.07.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. TypeCasts
## TypeCasts [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Beim TypeCast wird eine Instanz einer Klasse in ihrer vererbten Klasse erzeugt und weiter verwendet.  
`class Schule{`  
`}`  
`class Gymnasium extends Schule{`  
    `public string abschluss = "Abitur";`  
`}`  
`Schule g = new Gymnasium();`  

Hier gibt es das UpperTypeCast-Verfahren, welches dafür sorgt das nur die Variablen der Eltern Klasse bei der Instanz verwendet werden kann, die Inszanz ist aber immer noch vom Typ der Tochter-Klasse. Die Variablen die nur in der Tochter-Klasse vorkommen sind zwar da, haben aber temporär keinen Zugriff.  

Jetzt kann man also durch sämtliche Instanzen mit bspw. einem Array durch iteriern die sowohl direkt von der Klasse erzeugt wurden, als auch die, die von den vererbten Klassen erzeugt worden sind.  
`Schule youtube = new Schule();`  
`Gymnasium g = new Gymnasium();`  
`Schule g2 = g;`  


Nun gibt es auch den DownTypeCast, welcher meißtens einen Typ zu gewiesen bekommen muss.  
`Schule youtube = new Schule();`  
`Gymnasium g = new Gymnasium();`  
`Schule g2 = g;`  
`Gymnasium g3 = (Gymnasium)g2;`  
`Schule[] schulen = {youtube, g, g2, g3};`  
`foreach (var item in schulen)`  
`{`  
    `i.neuerSchueler();`  
`}`  

Diese Verfahren kann zu einem Absturz des Programms führen, wenn die Variable der Eltern-KLasse zuvor mit dem `new`-Schlüsselwort instanziiert wurde.  