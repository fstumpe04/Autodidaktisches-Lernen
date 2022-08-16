# Lerntagebuch 16.08.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Law of Demeter
## Law of Demeter [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Law of Demeter bedeutet, dass Objekte nur mit Objeketen aus ihrer unmittelbaren Umgebung kommunizieren sollen.  
<s>`int i = getObjectA().getObjectB().getSomeOtherObject().getArray()[0];`</s>  

Lange Messagechains sollten vermieden werden.  
`int i = getObjectA();`

`myMethod(param){`  
    `this.*`  
    `* = new ...`  
    `params`  
    `this.myVariable.*`  
    `// sonst nur static oder Methodenaufrufe.`
`}`  