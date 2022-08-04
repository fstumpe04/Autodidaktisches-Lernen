# Lerntagebuch 04.08.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. XML und JSON
## XML und JSON [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
XML und JSON sind beliebte Dateiformate zur Serialisierung von Objekten in Dateien.  
`<xml>`  
    `<class name = "A">`  
        `<a>42</a>`  
        `<b>1337</b>`  
    `</A>`  
`<xml>`  
`class A{`  
    `int a = 42;`  
    `int b = 1337;`  
`}`  

XML wird nicht mehr oft benutzt, dafür aber JSON.  
`import json`  
`{`
    `"meineInstanz":`  
        `["A":{`  
            `"a":42,`  
            `"b":[1337,1338,1339]`  
        `}]`  
`}`  