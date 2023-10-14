# __SISTEMA DE COLISIONES PARA UNA APP DE CONSOLA__

## __Objetivo General__
En la presente inventiva me propongo diseñar y desarrollar un sistema de colisiones destinado a una aplicación de consola de Windows con el lenguaje C# como base para el posterior desarrollo de videojuegos variados.

## __Objetivos específicos__

__Definir un estándar de entidades participantes del sistema:__

Es importante tener claro todos los aspectos que tendrán en común las entidades participantes del sistema, de este modo garantizamos la sencillez en el eventual acoplamiento de nuevas entidades de ser necesario, aportamos así a la escalabilidad por este medio.
Las preguntas planteadas para este objetivo son las siguientes: 
¿Qué requisitos debe cumplir una entidad para participar del sistema?

__Definir los criterios de declaración tipos/naturalezas para las colisiones propuestas:__

Es de esperar que las colisiones entre entidades no puedan reducirse a una naturaleza única, se espera poder discriminar entre tipos de colisiones a fin de corresponder la variedad de contextos en los cuales puedan llevarse a cabo, de hecho, es menester considerar la definición de un tipo genérico para dar libertad a la hora de declarar dicha naturaleza de la colisión, es decir, que sea cada entidad particular la que defina la naturaleza o tipo de colisión.
Las preguntas planteadas para este objetivo son las siguientes: 
¿Qué serie de pasos puede seguir una entidad para definir un tipo de colisión?
¿Qué implicaciones tiene la definición de un tipo para la entidad y, para el sistema?
¿Cuál es una forma óptima para que una entidad defina un tipo evento?

__Definir condiciones espaciales del sistema:__

El sistema desde su definición tiene una serie de presupuestos técnicos que actúan como restricciones o casos de uso potenciales que son necesarios tener en consideración a nivel de diseño, uno de ellos es su condición espacial, es decir, como encaja en el espacio dispuesto por la consola. La consola pone a disposición una cuadricula con celdas definidas en las cuales se espera que funcione el sistema, esta condición establece los términos en los cuales se ocupa este espacio.
Las preguntas planteadas para este objetivo son las siguientes: 
¿Cuál es el nivel de acceso del sistema para con el tablero de la consola?
En caso de haberla, ¿Qué tipo de dependencia tendrán el tablero y sistema? 

__Definir y desarrolar Entidades maestro del sistema:__

Las entidades maestro son todas las clases y/o estructuras de datos que soportan y participan de toda la lógica resultante del sistema. Son la base lógica y técnica; con ellas y para ellas serán desarrollados los múdulos mencionados en cada objetivo.

## __Generalidades__
Es importante dar claridad sobre ciertos conceptos presupuestos en la presente inventiva.
- Colisión: lacolisión es el encuentro fortuito o intencionado  entre dos entidades identificables que comparten un mismo espacio, se trata de un evento cualitativo, es decir, no puede describirse como un continuo numerable, solo se puede identificar o descartar como realizado, la colisión existe o no; no hay grados o niveles. La discriminación entre una colisión y otra es estrcitamente sustancial, no hay una colisión mayor o menor a otra, solo distinta. En el contexto de un sistema de colisiones.


corresponde a la realización de un ``Sistema de Colisiones``, esto abarca los aspectos relacionados 