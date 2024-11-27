# Etapa de construcción: compila la aplicación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copiar el archivo de proyecto y restaurar dependencias
COPY UserApi.csproj ./
RUN dotnet restore

# Copiar el código fuente y compilar
COPY . ./
RUN dotnet publish -c Release -o out && \
    rm -rf /root/.nuget/packages

# Etapa de ejecución: usa una imagen ligera para ejecutar la aplicación
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copiar la salida publicada desde la etapa de construcción
COPY --from=build-env /app/out .

# Configurar la URL y exponer el puerto
ENV ASPNETCORE_URLS=http://+:80
EXPOSE 80

# Comando de inicio
ENTRYPOINT ["dotnet", "UserApi.dll"]
