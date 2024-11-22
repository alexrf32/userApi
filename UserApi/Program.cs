using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using UserApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Configurar el contexto de la base de datos con SQLite
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Servicios para los controladores y Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "UserApi", Version = "v1" });
});

var app = builder.Build();

// Llamar al método SeedData.Initialize para poblar la base de datos con datos iniciales
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    SeedData.Initialize(services); // Este método se ejecutará automáticamente al iniciar la aplicación
}

// Configurar la canalización de solicitudes HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "UserApi v1"));
}

app.UseAuthorization();
app.MapControllers();
app.Run();
