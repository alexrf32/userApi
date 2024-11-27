using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using UserApi.Models;

namespace UserApi.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>());

            // Verifica si ya hay datos en la tabla Users
            if (context.Users.Any())
                return;

            // Generar 51 usuarios dinámicamente
            var users = new List<User>();
            for (int i = 1; i <= 51; i++)
            {
                users.Add(new User
                {
                    Nombre = $"Usuario {i}",
                    Apellidos = $"Apellido {i}",
                    Correo = $"usuario{i}@correo.com",
                    PasswordHash = $"hashedpassword{i}", // Contraseña simulada
                    EstaEliminado = i % 10 == 0 
                });
            }

            // Insertar usuarios en la base de datos
            context.Users.AddRange(users);
            context.SaveChanges();
        }
    }
}
