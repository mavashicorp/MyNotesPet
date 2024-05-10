using MyNotesPet.DataAccess;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen();
builder.Services.AddConnections();//�������� ��������� ������������
builder.Services.AddScoped<NotesDbContext>();//�������� DbContext � ��������� ������������

var app = builder.Build(); 

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
