# Scrollium
Scrollium es un entorno de escritura y publicación libre y de código abierto para obras de larga extensión.

Está diseñado para escritores que necesitan algo más que un procesador de textos tradicional: un espacio donde los manuscritos puedan estructurarse, revisarse, anotarse, analizarse, versionarse y, finalmente, compilarse en documentos preparados para su publicación.

Scrollium está inspirado en aplicaciones como Scrivener o Manuskript, pero su objetivo no es reproducir una aplicación existente característica por característica. El proyecto pretende construir un entorno más abierto, extensible y técnicamente ambicioso para la escritura de obras largas.

## ¿Por qué Scrollium?
El nombre combina *scroll*, en referencia al manuscrito antiguo o rollo, con el sufijo *-ium*, que evoca un lugar o medio.

El nombre también tiene un eco histórico inesperado: **Scrollium** fue el título de una demo para Amiga publicada en 1989 por el grupo de programación Escape.

## ¿Qué es Scrollium?
Scrollium pretende reunir en un único entorno todo el flujo de trabajo relacionado con la escritura y publicación.

Un proyecto puede contener capítulos, escenas, actos, notas, material de investigación, personajes, localizaciones, líneas temporales, revisiones y otros elementos de apoyo. Los documentos pueden organizarse mediante un árbol jerárquico flexible, mientras que cada pieza de escritura permanece editable y versionable de forma independiente.

El proyecto se basa en varios principios fundamentales:

* El manuscrito pertenece al escritor.
* Los archivos del proyecto deben seguir siendo comprensibles y recuperables sin depender de la aplicación.
* Los datos derivados nunca deben convertirse en la fuente de verdad.
* Guardar un documento nunca debe implicar realizar una confirmación de cambios en el control de versiones.
* Las operaciones prolongadas nunca deben bloquear la experiencia de escritura.
* Los análisis costosos deben ejecutarse de forma incremental y en segundo plano.
* La arquitectura debe ser extensible y favorecer las contribuciones de la comunidad.

## Texto enriquecido, texto plano y control de versiones
El texto enriquecido es la representación editable principal del documento. Scrollium utilizará **RTF** como formato persistente de texto enriquecido y generará automáticamente una representación canónica en **TXT**.

Ambas representaciones tienen objetivos diferentes:

* **RTF** conserva el documento enriquecido y su formato. Siempre será la fuente de verdad.
* **TXT** proporciona una representación limpia y legible, adecuada para diferencias (*diffs*) y control de versiones.

Ambas representaciones se generan a partir de la misma instantánea del documento y pueden mantenerse bajo control de versiones mediante Git.

Esto permite que un diff de Git muestre cambios textuales significativos sin sacrificar el formato necesario para restaurar fielmente el documento.

La estructura del proyecto y sus metadatos se almacenarán por separado del contenido de los documentos, utilizando un formato ligero y legible, como JSON. El formato exacto del proyecto estará versionado y se tratará como una especificación pública, no como un simple detalle de serialización de la implementación en C#.

## Escritura, revisiones y análisis
Scrollium pretende proporcionar tanto información inmediata como validaciones más profundas.

Las comprobaciones básicas de ortografía y tipografía podrán ejecutarse continuamente mientras se escribe. Los análisis más costosos podrán ejecutarse manualmente sobre instantáneas inmutables de los documentos.

Una pasada de validación podrá generar una vista de **Diagnósticos editoriales**, inspirada en la lista de errores de los IDE modernos. Los diagnósticos podrán incluir problemas ortográficos, gramaticales, tipográficos, estructurales y de compilación y, eventualmente, inconsistencias semánticas de mayor nivel.

No todos los problemas editoriales pueden determinarse mediante reglas deterministas. Por ello, las versiones futuras permitirán análisis basados en modelos de lenguaje para tareas como:

* coherencia de personajes y relaciones;
* comprobación de cronología y continuidad;
* detección de conceptos y patrones repetidos;
* análisis estilístico;
* detección de cacofonías y repeticiones no deseadas;
* sugerencias ortotipográficas dependientes del contexto;
* y otras formas de análisis editorial con contexto amplio.

Se prevé dar soporte para utilizar EXCLUSIVAMENTE modelos de lenguaje locales, como **Ollama**, como proveedores opcionales de análisis. La arquitectura de análisis será independiente del proveedor, de modo que puedan incorporarse otros modelos locales sin acoplar la aplicación a una plataforma concreta de IA.

Esto será algo totalmente opcional y será tarea del usuario configurarlo. Nunca se permitirá conectar la aplicación con proveedores de IA externos, por los problemas de autoría y plagio que conllevan.

Estas funcionalidades de IA en ningún caso se les permitirá modificar ningún texto o documento. Su única funcionalidad adicional es analizar localmente el contenido y proveer al autor información o posibles errores de continuidad.

## Compilación y publicación
Escribir es solo una parte del proceso.

Scrollium incorporará un motor de compilación capaz de transformar un proyecto en distintos formatos de publicación mediante perfiles de compilación configurables y duplicables.

A largo plazo se pretende admitir formatos en el siguiente orden:

* PDF;
* DOCX;
* Markdown;
* guiones y formatos orientados a guion cinematográfico;
* y otros formatos estructurados o destinados a publicación.

Los perfiles de compilación controlarán aspectos como la tipografía, las fuentes, los márgenes, la disposición de los párrafos, la estructura de los capítulos, las cabeceras y pies de página, los saltos de página y otras reglas de publicación.

El motor de compilación pretende ir más allá de una simple exportación. Con el tiempo deberá proporcionar suficiente control sobre la paginación y la tipografía como para preparar muchos libros para su publicación sin necesidad de recurrir a una aplicación de autoedición independiente para una maquetación básica.

El control de líneas viudas y huérfanas, la paginación determinista, las páginas iniciales y finales, los estilos específicos por sección y los perfiles de compilación reutilizables forman parte del diseño a largo plazo.

## Control de versiones
Scrollium incorporará integración con **Git** de base.

Git proporcionará el mecanismo subyacente de control de versiones sin convertirse en parte del modelo mental que el escritor tenga que manejar.

Por ello, el guardado normal y el versionado serán operaciones independientes:

**Guardar** significa que el estado actual del proyecto se ha almacenado de forma segura.

**Crear una revisión** significa que el escritor ha decidido registrar un punto significativo en la historia de la obra.

Esta distinción permite trabajar con normalidad mientras se mantiene un historial completo y fiable del manuscrito.

Inicialmente se admitirán repositorios Git locales, con integración con repositorios remotos prevista para versiones posteriores.

## Línea temporal y estructura del proyecto
Las obras de larga extensión suelen depender de información que existe fuera del texto inmediato.

Scrollium incorporará una línea temporal donde los escritores podrán registrar acontecimientos, hitos, fechas, anotaciones y otra información que pueda ser relevante durante la escritura.

La línea temporal estará diseñada para trabajar junto con el árbol del proyecto y el resto de la información estructurada, proporcionando una forma de razonar sobre la cronología y continuidad de la obra.

El árbol del proyecto permitirá organizar jerárquicamente capítulos, escenas, actos, revisiones, notas, material de investigación y otros elementos, con metadatos explícitos que controlen su estado y determinen si participan o no en la compilación.

## Tecnología
Scrollium está concebido como una aplicación de escritorio multiplataforma dirigida a:

* Windows
* Linux
* macOS

Las plataformas móviles quedan deliberadamente fuera del alcance del proyecto.

La pila tecnológica inicial será:

* **C# 14**
* **.NET 10**
* **Avalonia UI**
* **XAML**
* **System.Text.Json**
* **Git**
* **Diccionarios Hunspell compatibles con OpenOffice**

La interfaz se construirá utilizando Avalonia y XAML en lugar de un framework orientado principalmente a plataformas móviles. Esto mantiene el proyecto centrado en el escritorio al tiempo que proporciona una única tecnología de interfaz para Windows, Linux y macOS.

## Rendimiento
El rendimiento es un objetivo fundamental del diseño.

Scrollium debe mantenerse ágil incluso al trabajar con manuscritos muy grandes y proyectos que contengan un elevado número de documentos.

Por ello, la arquitectura tendrá en cuenta de forma deliberada las asignaciones de memoria, especialmente en las rutas críticas como edición de texto, análisis, búsqueda, comparación de versiones, renderizado y análisis incremental.

Cuando sea apropiado, la implementación utilizará ampliamente las capacidades modernas de .NET, entre ellas:

* `Span<T>` y `ReadOnlySpan<T>`;
* `Memory<T>` y abstracciones relacionadas;
* memoria reutilizable y `ArrayPool<T>`;
* tipos por valor y rutas sin asignaciones cuando resulte práctico;
* procesamiento incremental;
* instantáneas inmutables;
* procesamiento en segundo plano;
* virtualización;
* y optimización basada en pruebas de rendimiento.

"Zero allocation" no pretende ser una regla absoluta para todas las operaciones de la aplicación. El objetivo es identificar las rutas críticas, establecer presupuestos medibles de asignaciones y latencia para ellas y verificar dichos presupuestos mediante pruebas de rendimiento.

La aplicación no sacrificará corrección ni mantenibilidad por una optimización teórica. Las decisiones de rendimiento estarán guiadas por mediciones.

## Código abierto
Scrollium se distribuye bajo la licencia **GNU General Public License v3.0 (GPL-3.0)**.

El proyecto está concebido para desarrollarse de forma colaborativa. La arquitectura y la implementación iniciales proporcionarán los cimientos, pero la evolución a largo plazo de Scrollium dependerá de sus contribuidores y de su comunidad.

Por ello, el proyecto pretende mantener bien documentados sus formatos, interfaces y límites arquitectónicos, de manera que los contribuidores puedan trabajar en áreas concretas sin tener que comprender la totalidad de la aplicación.

Scrollium no pretende ser un producto cerrado acompañado de un repositorio abierto. El software, sus formatos y su ecosistema están pensados para permanecer abiertos y ser extensibles.

## Estado del proyecto
Scrollium se encuentra actualmente en una fase inicial de desarrollo y prueba de concepto.

La arquitectura se está diseñando antes de comenzar una implementación sustancial. Algunas decisiones técnicas podrán cambiar a medida que los prototipos, las pruebas de rendimiento y el uso real proporcionen información más fiable.

El primer objetivo no es implementar todas las funcionalidades de una vez, sino establecer unos cimientos sólidos para el motor de texto, el modelo de proyecto, la persistencia, la experiencia de edición y el sistema de compilación.

Se añadirá más documentación a medida que evolucione el proyecto.
