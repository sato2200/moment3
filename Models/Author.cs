using bookapp.Models;

public class Author{
    //Properties
    public int Id {get; set;}
    public string? Name {get; set;}

    //Lista med böcker som författaren skrivit. Nullable, listan kan vara tom om inga böcker finns.
    public List <Book>? Books {get; set;}
}