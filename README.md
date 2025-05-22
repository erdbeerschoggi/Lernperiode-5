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
- [x] Reflexion über Ihre Arbeitsweise
- [x] Beschreibung des fertigen Projekts mit .gif etc.

Heute habe ich nach der Ursache gesucht, wieso mein Programm nicht funktioniert. Ich habe herausgefunden, dass ich die Tabelle im Code falsch benannt habe und änderte das und löschte unnötigen Code, der die Funktion blockierte, und dann lief der Code wieder. Sobald ich die DB neu geladen hatte, waren alle Daten drinnen.

## Fertiges Projekt

In dieser Lernperiode habe ich eine Datenbank für meinen Essensgenerator erstellt. Bevor ich die Datenbank erkläre, hier noch eine Erklärung zum Essensgenerator: Der Essensgenerator enthält 3 Kategorien, aus denen man auswählen kann. In jeder Kategorie wählt man eine Option aus. Nachdem man alle 3 Optionen ausgewählt hat, klickt man auf "OK", um die Eingabe zu speichern und die Gerichte zu generieren. Danach erhält man einen Schlüssel für die ausgewählten Optionen und bekommt Gerichtsvorschläge in einer Messagebox angezeigt. Wenn man fertig ist, klickt man auf "OK" in der Messagebox, um zur Form zurückzukehren. Wenn man erneut Gerichte generieren möchte, muss man auf "Restart" klicken, um die Auswahl zurückzusetzen und erneut Optionen auszuwählen. 
Die Datenbank habe ich erstellt, sodass alle Optionen und alle Gerichte dazu, die es hat, im code automatisch in die DB gespeichert werden. Also jedes einzelne Gericht wird separat in der DB gespeichert.

https://github.com/user-attachments/assets/29a6a3c6-2a8b-41c8-a7b7-4324123f1a92



## Reflexion

Ich fand die Erstellung der Datenbank, jedoch war die Verbindung ein wenig kompliziert. Ich wusste nicht genau, wie das geht, und folgte einfach dem Code vom Herrn Colic. Doch es gab Fehler und dann, wenn es keine hatte, konnte mein code nicht gestartet werden. Ich kann nicht sehr viel zu dieser Lernperiode sagen, weil es sich so anfühlt, als ob ich nicht vieles gemacht habe. Durch die ersten 3 male habe ich nicht wirklich viel machen können, doch beim 4. mal fand ich es fertig und deswegen fand ich meine Arbeit in dieser Lernperiode ein wenig schlecht. Die Lernpakete von dieser Lernperiode fand ich eigentlich sehr gut.
