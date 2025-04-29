using Homework_1.classes;
using System.Reflection.Metadata;



#region Task 1
//Write a program to create an interface Searchable with a method Search(string word) that searches for a given keyword in a text document. 
//Create two classes Document and WebPage that implement the Searchable interface and provide their own implementations of the Search() method.


WebPage webPage = new WebPage("This is a sample webpage text.");
Console.WriteLine("search a word from the webpage");
string word = Console.ReadLine();
Console.WriteLine(webPage.Search(word));


Documentt document = new Documentt("This is a sample document text.");
Console.WriteLine("search a word from the document");
string word2 = Console.ReadLine();

Console.WriteLine(document.Search(word2));





#endregion