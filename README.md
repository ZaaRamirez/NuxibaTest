
# EVALUACIÓN TÉCNICA NUXIBA #

Prueba: **DESARROLLADOR JR**

Deadline: **1 día**

Nombre: Zaa Ribe Jazmín Ramírez Grajeda

------
## Clona y crea tu repositorio para la evaluación ##
* Clona este repositorio en tu máquina local
* Crear un repositorio público en tu cuenta personal de GitHub, BitBucket o Gitlab
* Cambia el origen remoto para que apunte al repositorio público que acabas crear en tu cuenta
* Coloca tu nombre en este archivo README.md y realiza un push al repositorio remoto

------
## Prueba 1 ##
* Lee la documentación del API de [JSONPlaceholder](http://jsonplaceholder.typicode.com/guide/) y crea una aplicación (dentro del directorio **Prueba_1**) en el lenguaje de tu preferencia que realice lo siguiente:
	* Listar a los 10 usuarios **_(10 puntos)_**
	* Al seleccionar un usuario muestra algunos campos con su información(name, username, email, etc.) y coloca 2 botones para poder seleccionar los "posts" y "todos" que estén relacionados con el usuario. **_(15 puntos)_**
	* Al dar click en el botón de "posts" muestra todas las publicaciones que ha realizado el usuario, cada publicación deberá tener anidados sus comentarios. **_(15 puntos)_**
	* Al dar click en el botón de "todos" muestra las tareas del usuario ordenadas por la propiedad "id" de mayor a menor. **_(15 puntos)_**
	* En la sección de "todos", crea un formulario para poder agregar una nueva tarea al usuario, este debe de contener una caja de texto (title), un checkbox (completed) y un botón de guardar. Al dar click en el botón, manda la información necesaria al API con el método HTTP correcto para que la tarea quede guardada. **_(25 puntos)_**


> *Nota: al hacer la petición de la nueva tarea, el API no la guardará y solo regresará un objeto JSON con la propiedad **id** de la nueva tarea agregada (id: 201), esto indica que todo se realizó de forma correcta*


Algunos endpoints que puedes utilizar:

* https://jsonplaceholder.typicode.com/users 
* https://jsonplaceholder.typicode.com/users/(userId)
* https://jsonplaceholder.typicode.com/users/(userId)/posts
* https://jsonplaceholder.typicode.com/post/(postId)/comments
* https://jsonplaceholder.typicode.com/users/(userId)/todos

Objeto que espera el servidor para guardar la nueva tarea:


```javascript
{
  "userId": <int>,
  "title": <string>
  "completed": <bool>
}
```

**PLUS: Si conoces algún patrón de diseño de software no dudes en usarlo** **_(+ 10 puntos)_**

------
## Prueba 2 ##

Para esta prueba será necesario agregar (al directorio **Prueba_2**) las sentencias de SQL con las que se creo el esquema(base de datos y tablas) y las consultas realizadas para responder a los siguientes puntos:

> *Nota: Para realizar esta prueba es necesario tener una instancia de [SQL Server Developer, SQL Server Express](https://www.microsoft.com/es-mx/sql-server/sql-server-downloads) o [MySQL Community](https://dev.mysql.com/downloads/mysql/) instalada en tu equipo, si por algún motivo no puedes instalar una versión de las anteriores, puedes entrar a [db-fiddle](https://www.db-fiddle.com/) para realizarla*

* Construye una base de datos y crea las siguientes tablas dentro de ella:
	* **logDial** con las siguientes columnas
		* **idLlamada** varchar(10)
		* **fechaDeLlamada** dateTime
		* **tiempoDialogo** smallint
		* **telefono** varchar(10)
		* **tipoDeLlamada** varchar(15)
	* **costos** con las siguientes columnas
		* **tipoDeLlamada** varchar(15)
		* **costo** decimal(10,4)
		
* Con las tablas contruidas, inserta los datos proporcionados en el archivo de excel **DatosPracticaSQL.xlsx** que se encuentran en la carpeta **Prueba_2** (revisar las dos hojas del archivo)
* Genera las sentencias SQL que respondan lo siguiente:
	* Que muestre los registros con tipo de llamada **Cel LD** durante el **mes febrero** **_(5 puntos)_**
	* Que indique el promedio de tiempo de dialogo de las llamadas con tipo **Cel LD** durante el **mes de febrero** **_(5 puntos)_**
	* Que muestre el **número en minutos de dialogo** (tomando tiempoDialogo que está en segundos) y el **costo** de todas las llamadas del **mes de enero** **_(10 puntos)_**

------
### Realiza el push del código de tus pruebas y compártenos el link a tu repositorio remoto 😊 

------
Si tienes alguna duda sobre la evaluación puedes mandar un correo electrónico a [Rodrigo Acevedo](mailto:racevedo@nuxiba.com?subject=Dudas%20sobre%20evaluación%20técnica)

Manda la liga de tu repositorio público a [Verónica Llerenas](mailto:vllerenas@nuxiba.com?subject=[EvaluaciónDesarrollo]%20Este%20es%20mi%20repositorio)