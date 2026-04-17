using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.SignalR;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://localhost:5000");

builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();


app.MapGet("/", () => "API rodando ! Aula C# 10/04");

app.MapPost("/produtos", async(AppDbContext db , Produto produto) =>
{
    db.Produtos.Add(produto);
    await db.SaveChangesAsync();
    return Results.Created($"/produtos/{produto.Id}", produto);
});

app.MapGet("/produtos", async(AppDbContext db) => await db.Produtos.ToListAsync());

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