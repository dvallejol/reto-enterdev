## # Proyecto reto Enterdev Payment

Al momento de descargar el proyecto del repositorio se debe hacer la clonación.
Después de abre la solución del proyecto

Se compila el proyecto y de ahí se procede a configurar Swagger que es un visor de Apis con una interfaz de usuario más amigable.

Botón derecho sobre la solución, propiedades, le damos clic en la pestaña de Build, desmarcamos la opción XML documentation para actualizar donde se encuentra el proyecto o solución a nivel local


## Configuración de la cadena a bases de datos

Al momento de abrir la solución lo primero que se debe de realizar es la configuración de la cadena de la base de datos en el archivo appsetting.json
"ConnectionStrings": {
    "ApplicationContext": "Server=DESKTOP-85EBF5D\\SQLEXPRESS;Database=db_api_rest;Trusted_Connection=True;MultipleActiveResultSets=true"
  },

El proyecto contiene 4 capas en las cuales en las cuales se expone para crear y consultar productos

### Reto.Payment.API
Es la capa que se encarga de procesar el procesamiento de datos entre un servidor web y un navegador web
Manejando funciones GET (para obtener información), POST(para ingresar información)
Utilizando un protocolo para el intercambio de datos HTTP



### Reto.Payment.BL
Es donde se genera toda la lógica del negocio 

### Reto.Payment_DAL
Es donde se genera el acceso a los datos
La parte del context, para la configuración a la base de datos.

### Reto.Payment.Models
Se generan las clases

Client

Factura

Producto

### Configuración de los paquetes de Nuget

Se deben de instalar paquetes de Nuget

Microsoft:entityframework core 
Microsoft:entityframework core .design
Microsoft:entityframework core.tools
Microsoft:entityframeworksqlserver

### Creación de la base de datos
Abrir el Package Manager Console y ejecutar el siguiente comando sobre el proyecto 
Add-migration Nombre

Una vez ejecutado se asignan las siguientes tablas

Products
Client
factura

Se utiliza un ORM, como entityframework


Por efectos de tiempo no se alcance a crear un diagrama entidad relación completo para poder realizar el ejercicio planteado
Por ejemplo, como agregar un maestro detalle para la diferente cantidad de productos y sus respectivos cálculos, teniendo en cuenta el tipo de relacion  de muchos a muchos se pueden manejar tablas auxiliares
