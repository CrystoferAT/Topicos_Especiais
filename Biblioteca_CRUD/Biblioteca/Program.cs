using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.SignalR;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://localhost:5000");

builder.Services.AddDbContext<AppDbContext>();

using (var scope = app.Services.CreateScope() )
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.EnsureCreated();
}

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/livros",
async(Livro livro, AppDbContext db)=>
{
    db.Livros.Add(livro);
    await db.SaveChangesAsync();
    return Results.Created(
        $"/livros/{livro.Id}",livro);
    
});

app.Run();

public class Livro
{
    public int Id{get;set;}
    public string Nome{get;set;}
    
    public string Autor{get;set;}

    public int AnoPublicacao{get;set;}
}

public class AppDbContext : DbContext
{
    public DbSet<Livro> Livros => Set<Livro>();

    protected override void OnConfiguring(DbContextOptionsBuilder option) 
    =>options.UseSqlite("Data Source=bibioteca.db");
}
