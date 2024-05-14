# Inyeccion de Dependencias

La inyección de dependencias es un patrón de diseño que se utiliza para reducir la dependencia entre los objetos y hacer que el código sea más mantenible y flexible. En lugar de crear una instancia de una clase dentro de otra clase, se pasa la instancia de la clase como un parámetro al constructor de la clase. Esto se conoce como inyección de dependencias.

## TODO 1: Refactor

| Se puede usar diferentes...                                         | Crea la interfaz...                            | Inyéctala en el constructor de...                           |
|----------------------------------------------|---------------------------------|--------------------------------|
|  Servicios de mensajerías (Email, SMS) |  ISender |  CommunicationService |
| Repositorios (DataBase, Archivos, Curls)    | IRepository  | CustomerService |
| Conexiones (MySQL, Oracle)                  | IDbConnection | CustomerRepository |

### Pasos:
1. Crea la interfaz. Y haz que las clases implementen de ellas.
2. Inyecta la interfaz en el constructor de la clase que la necesite. Y pasa la instancia de la interfaz como argumento al constructor.


Infraestructura seleccionada:
* Tras ello, usa SMS y Oracle.

## TODO 2: Git
Realiza Pull Request a la rama `master` y mergea los cambios por `fastforward`.

## TODO 3: Diagrama UML
Actualiza el archivo con el diagrama UML. Muestra 2 diagramas: el antes y después.

## TODO 4: Unit Test
Crea otra rama haz un test a CustomerService con una dependencia de Test
