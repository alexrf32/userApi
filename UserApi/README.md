# UserApi

UserApi es una API REST desarrollada en **.NET 8** para la gestión de usuarios. Incluye operaciones CRUD (Crear, Leer, Actualizar y Eliminar) y utiliza **SQLite** como base de datos. El proyecto está configurado con Swagger para probar y documentar los endpoints.

## Características

- CRUD completo de usuarios.
- Base de datos SQLite con datos iniciales (seeding).
- Documentación y pruebas de API mediante Swagger.
- Empaquetado y ejecución mediante Docker.
- Despliegue en **Render**.

## Tecnologías utilizadas

- **.NET 8**
- **Entity Framework Core** (con SQLite)
- **Swagger** (Swashbuckle)
- **Docker**
- **Render** (para el despliegue)

---

## Requisitos previos

Asegúrate de tener instalados los siguientes programas:

1. **.NET SDK 8**: [Descargar .NET SDK](https://dotnet.microsoft.com/download)
2. **Docker**: [Descargar Docker](https://www.docker.com/products/docker-desktop)
3. **Git**: [Descargar Git](https://git-scm.com/downloads)

---

## Configuración local

Sigue estos pasos para ejecutar el proyecto localmente:

### 1. Clonar el repositorio
```bash
git clone https://github.com/tu-usuario/tu-repositorio.git
cd tu-repositorio/UserApi
