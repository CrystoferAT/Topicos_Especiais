using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.SignalR;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://localhost:5000");

builder.Services.AddDbContext<AppDbContext>();

// Força a porta 5000
builder.WebHost.UseUrls("http://localhost:5000");

var app = builder.Build();

app.MapPost("/produtos", async (AppDbContext db, Produto produto) =>
{
    db.Produtos.Add(produto);
    await db.SaveChangesAsync();

    return Results.Created($"/produtos/{produto.Id}", produto);
});

app.MapGet("/produtos" , async(AppDbContext db) =>
{
    var produtos = await db.Produtos.ToListAsync();
    return Results.Ok(produtos);
});

app.MapPut("/produtos/{id}", async(AppDbContext db, int id, Produto produtoAlterado) =>
{
    var produto = await db.Produtos.FindAsync(id);

    if(produto is null) return Results.NotFound();

    produto.Nome = produtoAlterado.Nome;
    produto.Preco = produtoAlterado.Preco;

    await db.SaveChangesAsync();
    return Results.Ok(produto);
});

app.MapDelete("/produtos/{Id}", async (AppDbContext db, int id)=>
{
   var produto = await db.Produtos.FindAsync(id);
    if (produto is null) return Results.NotFound();

    db.Produtos.Remove(produto);
    await db.SaveChangesAsync();
    return Results.Ok(produto);
});

app.Run();

public class Produto
{
    public int Id{get; set;}
    public required string Nome{get; set;}
    public decimal Preco{get; set;}
}
public class AppDbContext : DbContext
{
    public DbSet <Produto> Produtos => Set<Produto>();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlite("Data Source=loja.db");
}