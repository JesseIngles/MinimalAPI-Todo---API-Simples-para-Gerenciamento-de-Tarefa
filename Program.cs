using Minimotest;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
// Listar todas tarefas
app.MapGet("/v1/todas", (AppDbContext context) =>
{
    var Todos = context.Todos.ToList();
    return Results.Ok(Todos);
});
//Apagar alguma tarefa
app.MapDelete("/v1/apagar/{id:guid}", (AppDbContext context, Guid id) => 
{
    context.Todos.Remove(context.Todos.Where(x => x.Id == id).First());
    context.SaveChanges();
    return Results.Ok("Tarefa Apagada");
});
//Apagar várias tarefas
app.MapDelete("/v1/apagar/varias", (AppDbContext context, Guid[] id_s) =>
{
    foreach(var id in id_s)
    {
        var registro = context.Todos.Where(x => x.Id == id).First();
        if (registro != null)
            context.Todos.Remove(registro);
            context.SaveChanges();
    }

    return Results.Ok("Apagados");
});
//Cadastrar uma tarefa
app.MapPost("/v1/cadastrar", (AppDbContext context, Todo todo) =>
{
    var tarefa = new Todo(Guid.NewGuid(), "Ir Dormir", true);
    context.Add(tarefa);
    context.SaveChanges();
    return Results.Ok($"Cadastrado{tarefa.Title}");
});
//Atualizar uma Tarefa
app.MapPut("/v1/Atualizar", (AppDbContext context, Todo todo) =>
{
    var tarefa = context.Todos.Where(x => x.Id == todo.Id).First();
    try
    {
        if (tarefa != null)
            context.Remove(tarefa);
            context.Add(todo);
    }catch (Exception) { }
    context.SaveChanges();
    return Results.Ok("Atualizado");
});
app.Run();