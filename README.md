# Prueba Técnica Fullstack

Este repositorio contiene la solución a la prueba técnica Fullstack:  
- **Backend:** 
- **Frontend:** 
- **Base de datos:**   

## Carpeta Database
- Abrir SQL server management studio y ejecutar los scripts:
  - 01.create.sql
  - 02.spGetClienteByIdentificacion.sql
  - 03.insert_database.sql

## Carpeta ApiClientesSolution
- Copiar la carpeta ApiClientesSolution en la ubicación deseada
- Ejecutar el archivo ApiClientesSolution.sln
- Una vez abierto el proyecto en VS2022, abrir el archivo appsettings.json y ajustar la cadena de conexión a la base de datos como corresponda a la configuración local, modificando Server User Id y Password.
"DefaultConnection": "Server=LAPTOP-E9NLE39H\\SQLEXPRESS;Database=DBClientes;User Id=sa;Password=mst2020;TrustServerCertificate=True;"
- Ejecutar el proyecto en Vs2022 con F5
- Dirigirse en el browser a la página que se abre y que tiene la estructura "http://localhost:5000/swagger". Tomar nota del puerto (en este caso 5000).
- Si se desea se puede probar en el swagger el endpoint GET /api/clientes/{identificacion}, reemplazando {identificacion} por el número registrado en la base de datos (79000000) y cualquiera otro para verificar los resultados cuando encuentra un cliente y cuando la identificación no se encuentra en la base de datos.

## Carpeta ClientesFrontEnd
- Copiar la carpeta ClientesFrontEnd a la ubicación deseada
- Abrir el proyecto en VS code
- Ejecutar el comando npm install para restaurar node_modules
- Abrir el archivo cliente.service.ts en la ruta src/app/services y ajustar el número de puerto en la línea 10 (private apiUrl = 'https://localhost:7157/api/Clientes';), al número de puerto en el que se ejecuta la api.
- Levantar la aplicación con ng serve -o. El browser debe mostrar una imagen en blanco inicialmente, probar con la identificación 79000000 para obtener los datos del cliente, y otro número diferente para verificar el mensaje de error. 
<img width="1125" height="602" alt="image" src="https://github.com/user-attachments/assets/608fd65b-b62f-44b7-9fc7-c702bca8beeb" />


  




