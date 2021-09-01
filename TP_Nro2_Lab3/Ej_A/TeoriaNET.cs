using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Nro2_Lab3.Ej_A {
    class TeoriaNET {

        /*
                    1. ¿Que es Microsoft Visual Studio .Net?
                    Es un entorno de desarrollo integrado (IDE) para Windows y macOS. Es compatible
                    con multiples lenguajes de programacion (C#, C++, Visual Basic, Java, Python, Ruby y PHP).
                    El Visual Studio .NET permite crear sitios y aplicaciones web, para cualquier entorno que
                    sea compatible con la plataforma .NET (por lo que se pueden programar aplicaciones, paginas
                    web, apps moviles, entre otras cosas). 
                    ************************************************************************************************************
                    2. ¿Qué es el Framework .Net?
                    Es un conjunto de estructuras y tecnologias proporcionada por Microsoft para una programacion
                    mas sencilla, orientada a las redes e internet, independiente de la plataforma hardware usada.
                    Para programar en .NET hay mas de 20 lenguajes de programacion, pero C· y Visual Basic son los
                    mas populares (no existe un lenguaje de .NET propio). 
                    ************************************************************************************************************
                    3. ¿Qué es el CLR? 
                    El Common Languaje Runtime (Entorno en tiempo de ejecucion) es un entorno de ejecucion para los
                    codigos de programas que corren sobre la plataforma Microsoft .NET
                    Es el encargado de compilar una forma de codigo intermedio (el CIL) a codigo maquina nativo, mediante
                    un compilador en tiempo de ejecucion. No es una maquina virtual, ya que una vez compilado el codigo
                    corre nativamente sin intervencion de una capa de abstraccion sobre el hardware. 
                    ************************************************************************************************************
                    4. ¿Qué es la BCL? 
                    La Base Class Library (BCL) es un conjunto de tipos de datos, que ofrecen soluciones rapidas a muchos
                    problemas que pueden aparecer a lo largo del desarrollo. Estos tipos de datos estan organizados de 
                    manera jerarquica. Cada nivel esta definido por un espacio de nombres (namespace) que identifica a un
                    grupo de tipos de datos. Los namespace se nombran concatenando el nombre del padre, el simbolo "." y su
                    propio nombre, y esto hace referencia a un conjunto de funcionalidades que se proveen conjuntamente.
                    Ejemplo--> System.Xml (agrupa un conjunto de clases que permiten procesar datos en formato XML).
                    Namespaces mas utilizados: 
                    _System: namespace raiz, para utilidades suministradas por el SO. COntiene la definicion de los tipos
                             primitivos alfanumericos y numericos. 
                    _System.Data: contiene el conjunto de tipos que permiten acceder a las bases
                    ************************************************************************************************************
                    5. Indique y explique el orden que se sigue en el proceso de compilación y ejecución en .net 
                    El codigo fuente es compilador por el CLR (Common Languaje Runtime), convirtiendo el codigo fuente
                    (en C# por ejemplo) a codigo CIL (Common Intermediate Language), que es un lenguaje de programacion
                    legible por humanos de mas bajo nivel en el .NET framework y que es un lenguaje ensamblador orientado 
                    a objetos, basado en pilas. Una vez pasado el codigo fuente a codigo CIL (ensamblado, lo cual se genera
                    en archivos EXE o DLL) este sera desplegado hacia la PC o servidor, donde la ejecucion queda en responsabilidad
                    del .NET Framework, el cual proporciona una serie de serivios que habilitan una ambiente seguro para
                    la ejecucion dentro del CLR (Common Languaje Runtime). Los servicios son los siguientes: 
                        _Motor de ejecucion JIT (Just In Time Activation): encargado de tomar la porcion de codigo que se
                        necesita ejecutar y lo convierte a lenguaje de maquina. 
                        _Garbage Collection: proceso que se encarga de ir monitoreando los recursos que ya no son empleados por 
                         la aplicacion, para ser depurados a partir del Heap del sistema.
                        _Seguridad: permite controlar el acceso a los recursos del ensamblado, ya sea a partir de la identidad
                        de otro ensamblado (Code Access Security - CAS) o la entidad de un usuario (Role Base Security - RBS)
                        para lo cual un ensamblado debe tener asociado un Nombre seguro (String Name).
                    ************************************************************************************************************
                    6. ¿Cuál es la signatura de Main? 
                    El metodo Main es el punto de entrada del programa, donde se inicia y finaliza el control del mismo. En C#
                    solo puede haber un solo punto de entrada (el cual se modifica de ser necesario en el IDE).
                    El metodo main debe ser declarado dentro de una clase o estructura, debe ser estatico y no deberia ser publico
                    (si no especificamos el acceso, es privado de manera predeterminada).
                    Se escribe de la siguiente manera:   static void Main(string[] args){}
                        Su parametro--> string[] args es una matriz de tipo string que representa los argumentos de la linea de
                        comandos. 
                        static---> porque puede llamarse sin tener que crear un objeto o instancia del mismo. 
                        void ---> porque no retorna nada, solo se encarga de iniciar y finalizar el programa (por lo que en el
                                  por lo general es donde creamos el objetos de otras clases para ser llamados).
                    ************************************************************************************************************
                    7. ¿Qué es un espacio de nombre (namespace)? 
                    El namespace es una forma de agrupar un conjunto de tipos de datos, o clases, en un espacio nominado propio.
                    Al generar un nuevo proyecto, tambien se genera un namespace por defeto en el cual se coloca nuestro primer
                    archivo (en las aplicaciones de consola). 
                    Son utiles para cuando tenemos muchas clases dentro de nuestro proyecto, ayudandonos a organizar mejor el
                    codigo, separandolas en namespaces. La palabra utilizada antes del namespace para hacer referencia es "using".
                    ************************************************************************************************************
                    8. ¿Cómo se incluye una librería en C#?
                    Para librerias pertenecientes a .NET Framework, al inicio de nuestro codigo, y con la palabra "using"
                    hacemos referencia al namespace que queremos hacer referencia para incluir la libreria. Por ejemplo:

                    using System.Math   (que sumistra los tipos que permiten ejecutar calculos complejos)

                    Para crear una libreria propia o descargar alguna y agregarla al Visual Studio debemos hacer lo siguiente:
                        -En el Explorador de Soluciones buscamos nuestro proyecto
                        -En Referencias hacemos click derecho y "Agregar referencia"
                        -Buscamos el archivo .dll de la biblioteca que queremos agregar
                        -Seleccionar el .dll y "Agregar"
                        -Con la libreria externa incluida, hacemos referencia en la parte superior del proyecto, con la palabra
                        ""using".
                    ************************************************************************************************************
                    9. ¿Qué indica la palabra clave params?
                    Se utiliza para especificar un parametro de un metodo, que puede tomar un numero variable de argumentos. El
                    parametro sera un vector y al utilizar la palabra params, solo se podra utilizar en el ultimo parametro al
                    realizar la llamada al metodo. 
                    Ejemplo:
                        public int Sumar(params int[] p) {
                            int su = 0;
                            for (var f = 0; f < p.Length; f++) {
                                su = su + p[f];
                            }
                            return su;
                         }
                    La diferencia fundamental de utilizar params y no usarlo, es que al usarla, desde donde llamamos al metodo
                    (Console.WriteLine(p.Sumar(3,4,5));) NO le pasamos un vector de enteros, sino una lista de parametros del tipo
                    entero. 
                     */
    }
}
