using System;

namespace UserApi.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid(); // Genera un UUID v4 único automáticamente
        public string Nombre { get; set; } = string.Empty; // Máximo 15 caracteres
        public string Correo { get; set; } = string.Empty; // Máximo 100 caracteres, único
        public string Apellidos { get; set; } = string.Empty; // Máximo 100 caracteres
        public string PasswordHash { get; set; } = string.Empty; // Almacena la contraseña hasheada
        public bool EstaEliminado { get; set; } = false; // Indica si el usuario está eliminado
    }
}
