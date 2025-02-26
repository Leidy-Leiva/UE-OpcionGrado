# Imagen base para producción
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081
ENV ConnectionDB="Server=sqlserverdocker,1433;Database=UNIDADEMPRENDIMIENTO;User Id=sa;Password=UEUA2025mj!*;MultipleActiveResultSets=True;TrustServerCertificate=True;" 



FROM base AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copiar archivos de proyecto y restaurar dependencias
COPY ["API/Api.UnidadEmprendimiento/Api.UnidadEmprendimiento.csproj", "API/Api.UnidadEmprendimiento/"]
COPY ["Application/Api.UnidadEmprendimiento.Application/Api.UnidadEmprendimiento.Application.csproj","Application/Api.UnidadEmprendimiento.Application/"]
COPY ["Data/Api.UnidadEmprendimiento.Data/Api.UnidadEmprendimiento.Data.csproj", "Data/Api.UnidadEmprendimiento.Data/"]
COPY ["Domain/Api.UnidadEmprendimiento.Domain/Api.UnidadEmprendimiento.Domain.csproj", "Domain/Api.UnidadEmprendimiento.Domain/"]

RUN dotnet restore API/Api.UnidadEmprendimiento/Api.UnidadEmprendimiento.csproj

# Copiar el resto del código fuente
COPY . .

# Instalar dotnet-ef dentro del contenedor
RUN dotnet tool install --global dotnet-ef 
ENV PATH="${PATH}:/root/.dotnet/tools"

# Compilar la aplicación
WORKDIR "/src/API/Api.UnidadEmprendimiento"
RUN dotnet build "Api.UnidadEmprendimiento.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Fase de publicación
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Api.UnidadEmprendimiento.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false 


# Imagen final para ejecución
FROM base AS final
WORKDIR /app
# Copiar archivos de la publicación
COPY --from=publish /app/publish .
# Copiar código fuente para poder ejecutar migraciones dentro del contenedor
COPY --from=build /src /app/source
# Comando de inicio de la API
ENTRYPOINT ["dotnet", "Api.UnidadEmprendimiento.dll"]
