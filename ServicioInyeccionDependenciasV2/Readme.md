# Inyeccion de Dependencias

La inyección de dependencias es un patrón de diseño que se utiliza para reducir la dependencia entre los objetos y hacer que el código sea más mantenible y flexible. En lugar de crear una instancia de una clase dentro de otra clase, se pasa la instancia de la clase como un parámetro al constructor de la clase. Esto se conoce como inyección de dependencias.

## TODO 1

| Se puede usar diferentes...                                         | Crea la interfaz...                            | Inyéctala en el constructor de...                           |
|----------------------------------------------|---------------------------------|--------------------------------|
|  Servicios de mensajerías (Email, SMS) |  ISender |  CommunicationService |
| Repositorios (DataBase, Archivos, Curls)    | IRepository  | CustomerService |
| Conexiones (MySQL, Oracle)                  | IDbConnection | CustomerRepository |

* Tras ello, usa SMS y Oracle.

## TODO 2
Realiza Pull Request a la rama `master` y mergea los cambios.

## TODO 3
Actualiza el archivo con el diagrama UML

## TODO 2 
Crea otra rama haz un test a CustomerService con una dependencia de Test
