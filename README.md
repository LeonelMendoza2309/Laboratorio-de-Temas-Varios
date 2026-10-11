<div align="center">

# UNIVERSIDAD TECNOLÓGICA DE PANAMÁ  
Facultad de Ingeniería en Sistemas y Computación  
Lic. en Ingeniería de Sistemas Computacionales

</div>

---

## Descripción del proyecto

Repositorio que contiene una colección de laboratorios sobre diversos temas en programación y bases de datos. Incluye ejercicios prácticos sobre cadenas, cálculos matemáticos, análisis de frecuencia y consultas SQL.

---

## Estructura del proyecto

```text
Laboratorio-de-Temas-Varios/
├── Cadenas/                         # Ejercicios de manipulación y análisis de cadenas
├── Factorial/                       # Implementación de cálculo de factorial
├── Frecuencia/                      # Ejercicios de frecuencia de datos
├── SobrecargaMetodos/               # Prácticas de sobrecarga de métodos en C#
├── Consultas SQL.sql                # Script con consultas y creación de base de datos
├── README.md                        # Documentación del repositorio
└── .gitignore                       # Archivos ignorados por Git
```

### Detalle de carpetas

- **Cadenas**: Ejercicios sobre manejo de cadenas, validación y transformación de texto.
- **Factorial**: Implementación de funciones para calcular el factorial.
- **Frecuencia**: Desarrollo de algoritmos para contar y analizar frecuencias.
- **SobrecargaMetodos**: Ejemplos de sobrecarga de métodos en C#.
- **Consultas SQL.sql**: Script SQL con la creación de la base de datos, tabla `productos`, inserción de datos y consultas prácticas.

---

## Tecnologías utilizadas

- **Lenguaje:** C#
- **Framework:** .NET Framework 4.7.2
- **Base de datos:** MySQL
- **Conector:** `MySql.Data`
- **Entorno recomendado:** Visual Studio 2019 o superior
- **Control de versiones:** Git y GitHub

---

## Base de datos - SQL

El archivo `Consultas SQL.sql` contiene la creación de la base de datos `ProdDB` y la estructura de la tabla `productos`.

### 1. Crear la base de datos y la tabla

```sql
CREATE DATABASE ProdDB;
USE ProdDB;

DROP TABLE IF EXISTS `productos`;

CREATE TABLE IF NOT EXISTS `productos` (
    `ID` INT NOT NULL AUTO_INCREMENT,
    `Nombre` VARCHAR(30),
    `Precio` FLOAT,
    `Cantidad` INT,
    `imagen` LONGBLOB,
    `fecha_creacion` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    `fecha_modificacion` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
    PRIMARY KEY (`ID`)
);
```

### 2. Inserción de datos de ejemplo

```sql
INSERT INTO `productos` (`ID`, `Nombre`, `Precio`, `Cantidad`, `imagen`) VALUES
(1, 'Teclado', 20.00, 2, NULL),
(2, 'Mouse', 15.70, 2, NULL),
(3, 'Portátil', 700.70, 2, LOAD_FILE('C:\Users\Usuario\Downloads\imagen.jpg'));
```

### 3. Consultas del laboratorio

```sql
-- Consulta con SQL injection (ejemplo educativo)
SELECT * FROM productos WHERE nombre = '' OR '1' = '1' AND Precio = '' OR '1' = '1';

-- Consulta con delay
SELECT * FROM productos WHERE id = 1 - SLEEP(5);

-- Consulta de búsqueda simple
SELECT * FROM productos WHERE nombre = 'Mouse';
```

> Estas consultas se usaron como ejemplo para estudiar vulnerabilidades SQL y la forma en que una consulta puede verse comprometida si no se valida la entrada del usuario.

---

## Requisitos

Para ejecutar los laboratorios se necesita:

- Windows 10 en adelante.
- Visual Studio 2019 o superior.
- .NET Framework 4.7.2.
- MySQL Server ejecutándose localmente.
- MySQL Workbench o una herramienta similar para crear y consultar la base de datos.

---

## Instalación

### Clonar el repositorio

```bash
git clone https://github.com/LeonelMendoza2309/Laboratorio-de-Temas-Varios.git
cd Laboratorio-de-Temas-Varios
```

### Abrir los proyectos

1. Iniciar Visual Studio.
2. Abrir la carpeta o proyecto del laboratorio que desees ejecutar.
3. Restaurar paquetes NuGet si se solicita.
4. Si el laboratorio usa MySQL, iniciar MySQL Server.
5. Ejecutar el script `Consultas SQL.sql` en MySQL Workbench.
6. Compilar y ejecutar el proyecto.

---

## Uso del repositorio

Cada carpeta del repositorio representa un laboratorio distinto:

1. **Cadenas**: trabajar con cadenas y validaciones.
2. **Factorial**: resolver cálculo factorial.
3. **Frecuencia**: analizar datos y repetición de elementos.
4. **SobrecargaMetodos**: practicar sobrecarga de métodos.
5. **Consultas SQL**: crear la base de datos y ejecutar consultas de prueba.

---

## Problemas comunes

| # | Problema | Solución |
|---:|---|---|
| 1 | No se conecta a MySQL | Verificar que el servidor esté activo y que las credenciales sean correctas. |
| 2 | La base de datos no se crea | Ejecutar el script completo en MySQL Workbench y comprobar permisos. |
| 3 | Las consultas no devuelven resultados | Confirmar que la estructura de la tabla sea correcta y que existan registros. |
| 4 | Error al compilar el proyecto | Restaurar paquetes NuGet y revisar las referencias del proyecto. |

---
## Imagenes
Cadenas
<img width="1115" height="211" alt="image" src="https://github.com/user-attachments/assets/49b890df-e62c-491f-9dfb-08741193d2b3" />

Factorial
<img width="1099" height="276" alt="image" src="https://github.com/user-attachments/assets/fb1d4268-9088-4f0c-9bd0-5ae17fdcd14b" />

Consultas SQL
<img width="689" height="265" alt="image" src="https://github.com/user-attachments/assets/38f9d031-0143-4ea5-a8f9-46d9ea310c73" />

Metodos Sobrecargados
<img width="560" height="249" alt="image" src="https://github.com/user-attachments/assets/01eb0e7c-13c1-4a05-91bb-2f08c6f47425" />

Frecuencia
<img width="1089" height="196" alt="image" src="https://github.com/user-attachments/assets/f1e1a35a-c341-4a54-abd3-0a090ab812c2" />


## Conclusiones

- Se trabajaron varios temas de programación y lógica aplicada.
- Se comprendió el uso de C# para distintos ejercicios.
- Se practicó la conexión con MySQL y la ejecución de consultas SQL.
- Se reforzaron conceptos esenciales de programación, validación y manejo de datos.
