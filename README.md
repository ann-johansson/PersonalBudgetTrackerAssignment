## Projekt beskrivning:
Jag började med att skriva ett klass diagram och flow chart. Efter detta har jag under projektets gång korigerat
mitt flow chart en del då jag har lärt mig om detta under projektets gång. Jag har även två versioner av mitt
klass diagram. Version 1 för hur det såg ut först och version 2 för hur det blev.
Jag har valt att skapa branches för olika delar och större ändringar. Jag började med att göra menyn och sedan
transaktions klassen. Det blev lite problem med pushandet av menyn till Git hub så transaktionen mergades först.
Sen skapade jag Budget Manager klassen och fixade de metoder som skulle va i den efter klass diagramet.
Efter detta så fixade jag menyn och flyttade över den till en metod för en renare main i ännu en branch.
Jag skapade även två branches som lade till VG grejer till koden som färg, validering, statistik (sortering
hade jag redan med från början när jag skapade budget manager klassen.
Slutligen gjorde jag en fixes branch som ändrade metoden som tar användaren tillbaka till menyn, förtydligade
remove transactions texten och fixade så quit faktiskt avslutar programmet.

## Hur kör man programmet?
Man startar det via PersonalBudgetTrackerAssignment.exe filen.
Sen kommer du till en meny där följande val gör:
1. Add Transaction
   Här kan användaren lägga till transaktioner.
2. All Transactions
   Visar alla transaktioner.
3. Total Balance
   Visar total balans.
4. Remove Transaction
   Tar bort transaktion genom att ange ID.
5. Show Transaction in Order
    Visar transaktionet i ordningen "amount" eller "category".
6. Statistics
    Visar hur många transaktioner användaren har och total inkoms och utgift.
7. Quit
    Avslutar program
Man använder programmet genom att ge respektive siffra för meny val och sen är det bara att skriva in information när
den efterfrågas.


## Av: Ann Johansson   2025-10-19

# Reflektions frågor:
Hur hjälpte klasser och metoder dig att organisera programmet?
De var väldigt effektiva. De gjorde det lätt att hitta information då det kategoriserade allt och det är trevligt när man
kan använda samma metoder flera gånger, som metoden ShowInfo() i Transaction klassen som jag använde flera gånger.

Vilken del av projektet var mest utmanande?
Jag tyckte remove transaction var svårast då man skulle hitta och ta bort ett vist objekt. Det var mer komplicerad kod
känner jag personligen. Och värst av allt var flow charten, vet inte riktigt vad eller hur jag skall skriva den men har
skrivit ner lopar och satser.
