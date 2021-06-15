# tp7---2021-emybar
tp7---2021-emybar created by GitHub Classroom



## a) Objetos del tipo LinkedList y List, ¿Cuales son las diferencias que tienen?

 List <T> Representa una lista de objetos fuertemente tipados a la que se puede obtener acceso por índice Proporciona métodos para buscar, ordenar y manipular listas.
LinkedList<T> es, una lista enlazada. Dado que está doblemente vinculado, puede agregar elementos al frente o al reverso en O (1), pero la indexación es O (n)

## b) Objeto Diccionario
Es una estructura de datos o colección donde los elementos se representan con dos partes: una llave y un valor. Facilita la búsqueda, y es apropiada para listas ordenadas.

## c) Beneficios de usar una biblioteca, por que pondria una clase en una biblioteca y cuando agregaria
directamente la clase en su proyecto
Permite dividir funcionalidades útiles en módulos que pueden usar varias aplicaciones. También se pueden usar para cargar la funcionalidad no necesaria o no conocida al inicio de la aplicación.Una biblioteca de clases define los tipos y los métodos que se llaman desde una aplicación


## d) como se agrega la referencia a una biblioteca de clase en su proyecto
En un principio, el nuevo proyecto de aplicación de consola no tiene acceso a la biblioteca de clases. Para que pueda llamar a los métodos de la biblioteca de clases, cree una referencia de proyecto al proyecto de biblioteca de clases.

    En el Explorador de soluciones, haga clic con el botón derecho en el nodo Dependencias del proyecto ShowCase y seleccione Agregar referencia de proyecto.
    En el cuadro de diálogo Administrador de referencias, seleccione el proyecto StringLibrary y después Aceptar.
