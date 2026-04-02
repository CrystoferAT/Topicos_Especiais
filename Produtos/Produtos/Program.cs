using Microsoft.AspNetCore.Builder;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

List<Produto> estoque = new List<Produto>();
int proximoId = 1;

//Criar(POST)
app.MapGet("/", () =>"Hello World!");
app.MapPost("/produtos", (Produto Item) =>
{
    Item.Id = proximoId++;
    estoque.Add(Item);
    return Results.Created($"/produtos/{Item.Id}", Item);
})
.WithName("CreateProduto")
.WithOpenApi();

//Listar(GET)
app.MapGet("/produtos", () => estoque)
.WithName("GetProdutos")
.WithOpenApi();


//Atualizar(PUT)
app.MapPut("/produtos/{id}", (int id, Produto produtoAtualizado) =>
{
    var produtoExistente = estoque.Find(p => p.Id == id);
    if(produtoExistente is null) return Results.NotFound();

    produtoExistente.Nome = produtoAtualizado.Nome;
    produtoExistente.Preco = produtoAtualizado.Preco;

    return Results.NoContent();
})
.WithName("UpdateProduto")
.WithOpenApi();

//Deletar(DELETE)
app.MapDelete("/produtos/{id}", (int id )=>{
    var Item = estoque.Find(p => p.Id == id);
    if (Item is null) return Results.NotFound();

    estoque.Remove(Item);
    return Results.Ok(Item);
})
.WithName("DeleteProduto")
.WithOpenApi();

app.Run();

class Produto
{
    private static int _contadorId = 0;
    public int Id{ get; set; }
    public string Nome { get; set; } = string.Empty;
    public decimal Preco { get; set; }

}
