using Microsoft.EntityFrameworkCore;
using bookapp.Models;

namespace bookapp.Data;


public class ApplicationDbContext: DbContext{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options){

    }

    public DbSet<Author> Authors {get; set;}
    public DbSet<Book> Books {get; set;}
}