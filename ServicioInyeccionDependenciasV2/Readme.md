# Inyeccion de Dependencias

La inyección de dependencias es un patrón de diseño que se utiliza para reducir la dependencia entre los objetos y hacer que el código sea más mantenible y flexible. En lugar de crear una instancia de una clase dentro de otra clase, se pasa la instancia de la clase como un parámetro al constructor de la clase. Esto se conoce como inyección de dependencias.

## TODO 1: Refactor

| [1] Se puede usar diferentes...                                         | [2] Crea la interfaz...                            | [3] Inyéctala en el constructor de...                           |
|----------------------------------------------|---------------------------------|--------------------------------|
|  Servicios de mensajerías (Email, SMS) |  ISender |  CommunicationService |
| Repositorios (DataBase, Archivos, Curls)    | IRepository  | CustomerService |
| Conexiones (MySQL, Oracle)                  | IDbConnection | CustomerRepository |

### Pasos:
1. [2] Crea la interfaz. Y haz que las clases implementen de ellas [1].
2. Inyecta la interfaz en el constructor de la clase que la necesite [3]. Y pasa la instancia de la interfaz como argumento al constructor (en program.cs).


Infraestructura seleccionada:
* Tras ello, usa SMS y Oracle.

## TODO 2: Git
Realiza Pull Request a la rama `master` y mergea los cambios por `fastforward`.

## TODO 3: Diagrama UML
Muestra 2 diagramas UML: el antes y después. Se debe mostrar las asociaciones e Interfaces.

## TODO 4: Unit Test
Crea otra rama haz un test a CustomerService, inyecta una dependencia de Test.
