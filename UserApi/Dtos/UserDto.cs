namespace UserApi.Models
{
    public class UserDto
    {
        public string Nombre { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty; // Asegúrate de hashear la contraseña antes de guardarla
    }
}
