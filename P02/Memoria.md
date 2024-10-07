# Memoria Práctica P02 - Interfaces Inteligentes
## Autor: Juan Aday Siverio González

### Descripción:

---

1. *Crea un script asociado a un objeto en la escena que inicialice un vector de 3 posiciones con valores entre 0.0 y 1.0, para tomarlo como un vector de color (Color). Cada 120 frames se debe cambiar el valor de una posición aleatoria y asignar el nuevo color al objeto. Parametrizar la cantidad de frames de espera para poderlo cambiar desde el inspector.*

![Texto alternativo](RecursosVisuales/1.gif)



---

2. *Crea una escena simple en la que ubiques un plano y sobre él un cubo, una esfera y un cilindro. Cada uno de los objetos debe estar en un color diferente. En la consola cada objeto debe mostrar su nombre*

![Texto alternativo](RecursosVisuales/2.gif)

Todos los que tengal el Tag de "FigurasMuestra" serán utilizadas
para mostrar el nombre.

---

3. *Crea un script asociado a la esfera con dos variables Vector3 públicas. Dale valor a cada componente de los vectores desde el inspector. Muestra en la consola:*
- *La magnitud de cada uno de ellos*
- *El ángulo que forman*
- *La distancia entre ambos.*
- *Un mensaje indicando qué vector está a una altura mayor.*
*Muestra en el inspector cada uno de esos valores.*

![Texto alternativo](RecursosVisuales/3.gif)

Se ha encapsulado cada cálculo en un método para poder ser utilizados en otra situación.

Además a parte de mostrar el resultado por pantalla(Debugger) se muestra en el propio inspector.

---

4. *Muestra en pantalla el vector con la posición de la esfera.*

![Texto alternativo](RecursosVisuales/4.gif)

Simplemente se toma el transform del objeto donde está el script instanciado y se imprime la posición.

---

5. *Crea un script para la esfera que muestre en consola la distancia a la que están el cubo y el cilindro.*

![Texto alternativo](RecursosVisuales/5.gif)

Para este ejercicio, he creado una variable que hay que rellenar desde el inspector, en la cual se solicitan los objetos a los que quieres calcular la distancia.

Haciendo que sea más eficiente, ya que realizar un método como FindGameObjectsWithTag resulta más ineficiente ya que tiene que hacer busquedas sobre todos los objetos, a diferencia de tenerlo asociado directamente antes de ejecutar.

---

6. *Selecciona tres posiciones en tu escena a través de un objeto invisible (marcador) que incluya 3 vectores numéricos para configurar posiciones en las que quieres ubicar los objetos en respuesta a pulsar la barra espaciadora. Estos vectores representan un desplazamiento respecto a la posición original del objeto. Crea un script que ubique en las posiciones configuradas cuando el usuario pulse la barra espaciadora.*

![Texto alternativo](RecursosVisuales/6.gif)

Para este caso como hay que utilizar el GetAxis, he decidido crear un nuevo "Axis" que me permita calcular cuando se presiona el espacio.

---

7. *Cambia el color del cilindro cuando el usuario pulse la tecla C, cambia el color del cubo cuando el usuario pulse la flecha arriba.*

![Texto alternativo](RecursosVisuales/7.gif)

Este es un poco más enrevesado, aunque siento que es bastante eficiente. Realmente no estoy haciendo referencia al objeto que quiero cambiarle el color, le estoy haciendo referencia al script "ChangeColor" que tiene ese objeto (Si lo tiene), ya que ese tiene un método que me permite cambiarle el color aleatoriamente.
Aprovechando el código y haciendo que sea más eficiente.
Por eso, el método ChangeRandomColorComponent() lo puse como public, para poder ser accedido desde otros objetos. 

---

8. *Agrega 5 esferas más en la escena. Crea un grupo de 2 , asígnales la misma etiqueta para indicar esferas de tipo 1 y a las restantes otra etiqueta diferente a ésta para indicar esferas de grupo 2. En la escena también habrá un cubo. Implementa un script que aumente la altura de la esfera de tipo 2 más cercana al cubo. Cambia el color de la más lejana cuando el jugador pulsa la tecla espacio.*

![Texto alternativo](RecursosVisuales/8.gif)

Quizás el ejercicio más complejo, he hecho un método que me devuelve el objeto más lejano y más cercano respecto al objeto que tiene el script (en este caso el cubo). Por último, he realizado las comprobaciones concretas para ambos casos, para la esfera más cercana y la más lejana.

---

### Conclusión:
Me ha dado curiosidad saber que el método FindGameObjectsWithTag no busca entre los objetos hijos.

Pero de resto ha estado entretenido :)