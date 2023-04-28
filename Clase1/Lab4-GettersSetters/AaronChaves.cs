namespace Labs.Lab4_GettersSetters;

    public class VideoGames
{
    private string _name;
    private string _company;
    private string _type;

    public VideoGames() { }

    public VideoGames(string name, string company, string type)
    {
        _name = name;
        _company = company;
        _type = type;
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Company
    {
        get { return _company; }
        set { _company = value; }
    }

    public string Type
    {
        get { return _type; }
        set { _type = value; }
    }
}

public class AaronChavesProgram
{
    public static void Run()
    {
        // 1st Example:
        VideoGames videogame1 = new VideoGames();
        videogame1.Name = "The Last Of Us";
        videogame1.Company = "Naughty Dog";
        videogame1.Type = "Adventure and Action";
        Console.WriteLine("Name: " + videogame1.Name);
        Console.WriteLine("Company: " + videogame1.Company);
        Console.WriteLine("Type: " + videogame1.Type);

        // 2nd Example:
        VideoGames videogame2 = new VideoGames("The Last Of Us", "Naughty Dog", "Adventure and Action");
        Console.WriteLine("Name: " + videogame2.Name);
        Console.WriteLine("Company: " + videogame2.Company);
        Console.WriteLine("Type: " + videogame2.Type);
    }
}  
