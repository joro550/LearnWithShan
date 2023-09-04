// See https://aka.ms/new-console-template for more information

// Another example of generics 
var books = new Dictionary<string, Book>();
books.Add("ISBN-123", new Book {Title = "A feast for crows"});
books.Add("ISBN-124", new Book {Title = "A feast for crows2 "});

var book = books["ISBN-123"];
Console.WriteLine(book.Title);

var book2 = books["ISBN-124"];
Console.WriteLine(book2.Title);


// using types to get books out of the dictionary
// Type is a c# class
var typeDictionary = new Dictionary<Type, Book>();
typeDictionary.Add(typeof(Book), new Book());
var bookType = typeDictionary[typeof(Book)];

public class Book
{
    public string Title { get; set; }
}