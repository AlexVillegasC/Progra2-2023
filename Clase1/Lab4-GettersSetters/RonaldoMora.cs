namespace Labs.Lab4;

public class Book
{
    private string _title;
    private string _author;
    private int _pages;

    public Book() { }

    public Book(string title, string author, int pages)
    {
        _title = title;
        _author = author;
        _pages = pages;
    }

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Author
    {
        get { return _author; }
        set { _author = value; }
    }

    public int Pages
    {
        get { return _pages; }
        set { _pages = value; }
    }
}

public class RonaldoMoraProgram
{
    public static void Run()
    {
        // 1st Example:
        Book book1 = new Book();
        book1.Title = "Mistborn: The Final Empire";
        book1.Author = "Brandon Sanderson";
        book1.Pages = 647;
        Console.WriteLine("Title: " + book1.Title);
        Console.WriteLine("Author: " + book1.Author);
        Console.WriteLine("Pages: " + book1.Pages);

        // 2nd Example:
        Book book2 = new Book("Red Rising", "Pierce Brown", 382);
        Console.WriteLine("Title: " + book2.Title);
        Console.WriteLine("Author: " + book2.Author);
        Console.WriteLine("Pages: " + book2.Pages);
    }
}
