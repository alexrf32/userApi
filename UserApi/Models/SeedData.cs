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

            // Si ya hay usuarios, no se agrega más
            if (context.Users.Any())
                return;

            // Crear usuarios de ejemplo
            var users = new List<User>
            {
                new User { Nombre = "Usuario 1", Correo = "usuario1@correo.com", Apellidos = "Apellido 1", PasswordHash = "hashedpassword1" },
                new User { Nombre = "Usuario 2", Correo = "usuario2@correo.com", Apellidos = "Apellido 2", PasswordHash = "hashedpassword2" },
                // Agregar hasta 51 usuarios o más según sea necesario
                new User { Nombre = "Usuario 51", Correo = "usuario51@correo.com", Apellidos = "Apellido 51", PasswordHash = "hashedpassword51" }
            };

            context.Users.AddRange(users);
            context.SaveChanges();
        }
    }
}
