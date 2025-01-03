using basic_fra_hw_02.Services;

var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddControllers();

// Register TicketService as a Singleton
builder.Services.AddSingleton<TicketService>();

// Configure Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
