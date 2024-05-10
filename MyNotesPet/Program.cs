using MyNotesPet.DataAccess;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen();
builder.Services.AddConnections();//добавлет поддержку контроллеров
builder.Services.AddScoped<NotesDbContext>();//добавл€ю DbContext в контейнер зависимостей

var app = builder.Build(); 

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
