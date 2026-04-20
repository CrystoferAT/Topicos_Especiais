using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.SignalR;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://localhost:5000");

builder.Services.AddDbContext<BibliotecaDbContext>();

var app = builder.Build();

app.MapPost("/livros", async(Livro livro, BibliotecaDbContext db)=>
{
    db.Livros.Add(livro);
    await db.SaveChangesAsync();
    return Results.Created($"/livros/{livro.Id}", livro);
    
});

app.MapGet("/livros", async(BibliotecaDbContext db)=>
{
    var livros = await db.Livros.ToListAsync();
    return Results.Ok(livros);
});

app.MapPut("/livros/{id}", async( BibliotecaDbContext db, int id, Livro livroAlterado)=>
{
    var livro = await db.Livros.FindAsync(id);

    if(livro is null) return Results.NotFound();

    livro.Nome = livroAlterado.Nome;
    livro.Autor = livroAlterado.Autor;
    livro.AnoPublicacao = livroAlterado.AnoPublicacao;

    await db.SaveChangesAsync();
    return Results.Ok(livro);

});

app.MapDelete("/livros/{id}", async(BibliotecaDbContext db, int id)=>
{
    var livro = await db.Livros.FindAsync(id);
    if(livro is null) return Results.NotFound();

    db.Livros.Remove(livro);
    await db.SaveChangesAsync();
    return Results.Ok(livro);
});

app.Run();

public class Livro
{
    public int Id{get;set;}
    public required string Nome{get;set;}
    
    public string? Autor{get;set;}

    public int AnoPublicacao{get;set;}
}

public class BibliotecaDbContext : DbContext
{
    public DbSet <Livro> Livros => Set<Livro>();

    protected override void OnConfiguring(DbContextOptionsBuilder options) 
    =>options.UseSqlite("Data Source=bibioteca.db");
}
