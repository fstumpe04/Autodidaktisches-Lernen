# Lerntagebuch 27.07.2022
Heute habe ich etwas zu den folgenden Themen gelernt:
1. Events
## Events [Programmieren Lernen - Lerne alle Sprachen in einer Serie]
Events werden dazu gebraucht um zwischen Threads hin und her signalisieren zu können.  

Hierbei wird die `wait()`-Methode dazu verwendent, einen Thread zu pausieren, was dafür sorgt, dass diese dauerhaft aquired ist. `notify()` wird dazu verwendet um Threads zu benachrichtigen, dass bspw. ein neues Element folgt. Mit `sleep()` wird wie bei `wait()` pausiert nur kann man hier angeben wie lange pausiert werden soll. Und `join()` sorgt dafür das der Parenthread(der Thread außerhalb des derzeit benutzten Threads), gestoppt wird, bis der gerade aufgerufene Thread durchlaufen wurde.  

Letzteres funktioniert also ähnlich wie ein `sleep()`, deswegen sollte man auch nur eins von beiden verwenden, da man sonst ein Deadlock konstruiert.  