# Usar Node LTS como base
FROM node:lts-bullseye

# Establecer directorio de trabajo en el contenedor
WORKDIR /app

# Copiar package.json y package-lock.json antes de instalar dependencias
COPY package*.json ./

# Instalar Angular CLI globalmente y dependencias del proyecto
RUN npm install -g @angular/cli@16 && npm install

# Copiar el resto del código después de instalar dependencias
COPY . .

# Exponer el puerto 4200
EXPOSE 4200

# Evitar problemas de caché y permisos
RUN chmod -R 777 /app

# Ejecutar el servidor Angular
CMD ["npx", "ng", "serve", "--host", "0.0.0.0"]

