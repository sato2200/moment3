namespace bookapp.Models;

public class Book {
    public int Id {get; set;}
    public string? Title {get; set;}
    public int? PubYear {get; set;}

    //FK för att koppla en bok till en författare. Nullable, dvs en bok kan ha en okänd författare
    public int? AuthorId {get; set;}

    //Referens till författaren av boken
    public Author? Author {get; set;}
}