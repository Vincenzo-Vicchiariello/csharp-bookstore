// See https://aka.ms/new-console-template for more information
//Dichiaro le variabili
string bookTitle = "Clean Code: A Handbook of Agile Software Craftsmanship";
string bookAuthor = "Robert C. Martin";
long bookISBNCode = 9780132350884;
int bookPages = 431;
int bookWeight = 800;
float bookHeight = 2.79f;
float bookWidth = 17.78f;
float bookDepth = 23.37f;
float avgRating = 4.7f;
int reviewNumber = 5414;




//Stampo in console le variabili
Console.WriteLine("--------IL LIBRO DI OGGI: " + bookTitle + " di " + bookAuthor + " ------------");
Console.WriteLine("ISBN:" + bookISBNCode);
Console.WriteLine("Numero di pagine: " + bookPages);
Console.WriteLine("Peso del libro: " + bookWeight + " gr");
Console.WriteLine("Dimensioni del libro (LxAxP): " + bookWidth + " X " + bookHeight + " X " + bookDepth + " cm");
Console.WriteLine("Valutazione media: " + avgRating + " su 5.");
Console.WriteLine("Ha ricevuto " + reviewNumber + " recensioni.");
Console.WriteLine("Disponibile in versione Kindle");
Console.WriteLine("Disponibile con copertina flessibile");