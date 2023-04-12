//Chiedo all'utente le informazioni sul libro.
Console.WriteLine("Inserire il titolo del libro.");
var bookTitle = Console.ReadLine();
Console.WriteLine("Inserire il nome dell'autore del libro.");
var bookAuthor = Console.ReadLine();
Console.WriteLine("Inserire il codice ISBN del libro.");
var bookISBNCode = Console.ReadLine();
Console.WriteLine("Quante pagine ha il libro?");
var bookPages = Console.ReadLine();
Console.WriteLine("Quanto pesa il libro in grammi?");
var bookWeight = Console.ReadLine();
Console.WriteLine("Inserisci l'altezza del libro in centimetri");
var bookHeight = Console.ReadLine();
Console.WriteLine("Inserisci la larghezza del libro in centimetri");
var bookWidth = Console.ReadLine();
Console.WriteLine("Inserisci la profondità del libro in centimetri");
var bookDepth = Console.ReadLine();
Console.WriteLine("Inserisci il punteggio medio su Amazon.it");
var avgRating = Console.ReadLine();
Console.WriteLine("Inserisci il numero di recensioni che ha ricevuto il libro");
var reviewNumber = Console.ReadLine();
Console.WriteLine("È disponibile su Kindle?");
var questionKindleAvailability = Console.ReadLine();
Console.WriteLine("È disponibile con copertina flessibile?");
var questionPaperBackAvailability = Console.ReadLine();



//Stampo in console le variabili
Console.WriteLine("--------IL LIBRO DI OGGI: " + bookTitle + " di " + bookAuthor + " ------------");
Console.WriteLine("ISBN: " + bookISBNCode);
Console.WriteLine("Numero di pagine: " + bookPages);
Console.WriteLine("Peso del libro: " + bookWeight + " gr");
Console.WriteLine("Dimensioni del libro (LxAxP): " + bookWidth + " X " + bookHeight + " X " + bookDepth + " cm");
Console.WriteLine("Valutazione media: " + avgRating + " su 5.");
Console.WriteLine("Ha ricevuto " + reviewNumber + " recensioni.");



//Uso un if per chiedere all'utente se il libro è disponibile in versione Kindle

if (questionKindleAvailability == "si")
{
    Console.WriteLine("È disponibile su Kindle.");
}
else {
    Console.WriteLine("Non è disponibile su Kindle.");

}

//Funziona, quindi lo ripropongo per sapere se c'è con la copertina flessibile
if (questionPaperBackAvailability == "si")
{
    Console.WriteLine("È disponibile su con copertina flessibile.");
}
else
{
    Console.WriteLine("Non è disponibile con copertina flessibile.");

}