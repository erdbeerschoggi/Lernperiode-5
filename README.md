# Lernperiode 5

2.5 bis 23.5

## Grob-Planung

Wie können Sie Ihr Projekt aus der Lernperiode 4 um eine Persistenz-Lösung erweitern? Was gibt es zu speichern, was für Tabellen brauchen Sie und wie muss der bestehende Code mit diesen interagieren? 

Meine Idee, um mein Projekt mit einer Persistenz-Lösung zu erweitern, ist, indem ich eine Tabelle für die Gerichte erstelle, eine für alle Optionen und dann noch eine Tabelle, die Gerichte und die Optionen verbindet. Also die Tabelle Gerichte beinhaltet dann alle Gerichte, die es hat und hat dazu eine ID, bei der Tabelle Optionen wird es dann ähnlich funktionieren, und zwar für jede Option hat es eine Spalte und dann wie bei den Gerichten eine ID und dann noch die 3te Tabelle Verbindung diese beinhaltet dann die ID von den Gerichten und die ID von den Optionen. Der Sinn dahinter ist, dass man alle Optionen und ihre Gerichte sehen kann.

## 2.5

- [x] Grob Planen welche Tabellen ich erstellen muss
- [x] Alle Tabellen erstellen

Heute habe ich grob geplant, wie ich die Tabellen und den bestehenden Code interagieren möchte. Am Anfang hatte ich Mühe, eine Lösung dazu zu finden, doch nach langem Nachdenken kam ich zu folgender Idee: Ich würde 3 Tabellen erstellen, die 1 für die Gerichte, also wie sie heissen. Die 2te Tabelle würde für die Optionen, die man Auswählen kann, beim Generator und dann sind die Optionen in der Tabelle notiert, die ich im code vorhanden habe. Die 3te Tabelle würde die erste und zweite zusammen mit ihrer ID verbinden. Nachdem ich auf diese Idee gekommen bin, setzte ich sie in SQL um und erstellte die 3 Tabellen.


## 9.5 Kernfunktionalität

- [x] Code mit der SQL Tabelle verbinden
- [ ] Wenn man ein neues Gericht hinzufügt im code, dass es in die Tabelle kommt.
- [x] Nachschauen ob ich alle Spalten in der Tabelle habe die nötig sind.

Heute habe ich SQLite mit Visual Studio verknüpft. Danach war es notwendig, die Tabellen auf SQLite zu erstellen, wie ich es bereits letztes Mal auf ms sql getan habe. Ich habe bemerkt, dass eine Tabelle ausreichend wäre, daher löschte ich die vorherige und erstellte lediglich eine Tabelle. Diese hat eine ID, die Gerichte und Optionen. Ich konnte nicht sehr viel coden, ich habe bloss den SQLite verbunden. Ich konnte noch nicht richtig schauen, ob neue Gerichte hinzugefügt werden können, da ich noch nicht die Werte in der Tabelle speichern kann. Ich habe versucht herauszufinden  wie das gehen könnte, aber habe noch keine Lösung gefunden.

## 16.5 Kernfunktionalität und Ausbau

- [ ] Daten in Tabelle speichern
- [ ] Wenn man ein neues Gericht hinzufügt im code, dass es in die Tabelle kommt.
- [ ] Die Kernfunktionalität programmieren.
- [x] Die angezeigte Warnung in vs verstehen & lösen, sodass das Programm problemlos funktioniert.

Heute habe ich wieder einmal nicht gut arbeiten können. Als ich eine Warnung aufgelöst habe, zeigte sich bloss eine neue Warnung. Also muss ich meistens eine nach der anderen Warnung lösen. Als ich dann alle Warnungen weggebracht hatte und keine Fehler mehr im Code hatte, dachte ich mir, es wird funktionieren, doch das tat es nicht. Denn als ich auf Start drückte, passierte nichts. Ich dachte, es könnte sein, dass ich das habe, weil ich meine Datasource falsch angegeben hatte. Doch als ich das endlich korrigiert habe, blieb es genau gleich. Ich beschäftigte mich mit dem Fehler und bin deshalb noch nicht so weit gekommen. Ich bin mir unsicher, ob die Kernfunktionalität funktioniert, da nichts startet, deswegen kreuze ich das nicht an.

## 23.5 Abschluss

- [x] Programm zum laufen bringen
- [x] Tabelle auf SQLite wieder finden
- [ ] Reflexion über Ihre Arbeitsweise
- [ ] Beschreibung des fertigen Projekts mit .gif etc.

Heute habe ich nach der Ursache gesucht wieso mein Programm nicht funktioniert



## Fertiges Projekt



https://github.com/user-attachments/assets/f54b6d70-b3d8-4480-a6ec-7a5a5b5562fd




## Reflexion

✍️ Was ging gut, was ging weniger gut? Was haben Sie gelernt, und was würden Sie bei der nächsten Lernperiode versuchen besser zu machen? Fassen Sie auch einen übergeordneten Vorsatz für Ihr nächstes Jahr im Lernatelier (100 bis 200 Wörter).
