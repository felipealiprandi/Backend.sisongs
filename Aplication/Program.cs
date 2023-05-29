var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

// Obtenha a porta da vari�vel de ambiente ou use a porta padr�o 5000
string port = Environment.GetEnvironmentVariable("PORT") ?? "5001";

// Inicie o aplicativo usando o host 0.0.0.0 e a porta fornecida pela vari�vel de ambiente
app.Run($"https://0.0.0.0:{port}");