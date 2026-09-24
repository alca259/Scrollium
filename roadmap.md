# Roadmap de Scrollium

## Objetivos generales

Principios que deben mantenerse durante todo el desarrollo:

- El manuscrito pertenece al escritor.
- Los formatos deben ser abiertos y recuperables.
- El RTF es la fuente de verdad documental.
- El TXT canónico es una representación derivada para control de versiones y análisis.
- Guardado y versionado son operaciones distintas.
- Ninguna operación costosa debe bloquear la escritura.
- Todo análisis debe poder ejecutarse de forma incremental.
- Las funcionalidades de IA son opcionales, locales y exclusivamente analíticas.
- El rendimiento debe medirse y verificarse.
- La arquitectura debe favorecer extensibilidad y contribuciones externas.

---

# Fase 0 - Fundamentos arquitectónicos

## Objetivos

Definir las bases que condicionarán el resto del proyecto.

## Entregables

### Solución inicial

- Configuración básica del proyecto.
- Estructura de carpetas.
- Convenciones de código.
- Sistema de registro y telemetría local.
- Pruebas unitarias iniciales.

### Modelo de dominio

Definir:

- Proyecto.
- Documento.
- Carpeta.
- Capítulo.
- Escena.
- Nota.
- Recurso.
- Revisión.

### Persistencia

Diseñar:

- Formato del proyecto.
- Versionado del formato.
- Serialización.
- Migraciones futuras.

### Infraestructura

- Sistema de comandos.
- Sistema de eventos.
- Servicio de tareas en segundo plano.
- Contenedor de dependencias.

---

# Fase 1 - Proyecto y persistencia

## Objetivos

Poder crear, abrir, guardar y recuperar proyectos.

## Entregables

### Gestión de proyectos

- Crear proyecto.
- Abrir proyecto.
- Guardar proyecto.
- Guardar como.
- Recuperación automática.

### Árbol de proyecto

- Carpetas.
- Reordenación.
- Arrastrar y soltar.
- Renombrado.
- Eliminación.

### Persistencia documental

- RTF como fuente de verdad.
- Generación automática de TXT canónico al guardar.
- Gestión de identificadores internos estables.

### Recursos

- Carpeta de recursos.
- Imágenes.
- Gestión de referencias.

---

# Fase 2 - Editor de texto

## Objetivos

Disponer de un editor funcional para escritura diaria.

## Entregables

### Editor enriquecido

- Negrita.
- Cursiva.
- Subrayado.
- Estilos de párrafo.
- Reglas y sangrías.
- Alineación.
- Tamaño de papel (predefinidos A4 / A5) + Personalizados.
- Márgenes.

### Navegación

- Búsqueda y reemplazo en el documento.
- Buscar y reemplazar en: Todos los documentos abiertos. Todos los ficheros.

### Edición

- Deshacer.
- Rehacer.
- Portapapeles.

### Imágenes

- Inserción y eliminación.
- Escalado.
- Posicionamiento básico.

### Rendimiento

- Carga diferida.
- Virtualización.
- Gestión eficiente de memoria.

---

# Fase 3 - Diagnósticos básicos

## Objetivos

Introducir análisis editorial inmediato.

## Entregables

### Ortografía

- Diccionarios Hunspell.
- Resaltado de errores.
- Sugerencias.

### Tipografía

- Espacios duplicados.
- Comillas incorrectas.
- Signos de puntuación.
- Separaciones anómalas.

### Estadísticas

- Palabras.
- Caracteres.
- Párrafos.
- Tiempo de lectura estimado.

### Panel de diagnósticos

Inspirado en IDEs modernos.

- Lista de incidencias.
- Navegación rápida.
- Agrupación por categoría.

---

# Fase 4 - Sistema de revisiones

## Objetivos

Incorporar control de versiones transparente.

## Entregables

### Integración Git local

- Inicialización automática.
- Repositorio local.
- Configuración mínima.

### Revisiones

- Crear revisión.
- Etiquetar revisión.
- Añadir comentario.

### Historial

- Navegación temporal.
- Restauración.
- Comparación.

### Diferencias

A partir del TXT canónico.

- Cambios añadidos.
- Cambios eliminados.
- Cambios modificados.

---

# Fase 5 - Compilación inicial

## Objetivos

Generar documentos publicables.

## Entregables

### Motor de compilación

- Pipeline de compilación.
- Instantáneas inmutables.

### PDF

- Generación básica.
- Índice.
- Saltos de capítulo.

### DOCX

- Exportación.
- Estilos.

### Perfiles

- Crear perfil.
- Duplicar perfil.
- Exportar perfil.

---

# Fase 6 - Universo narrativo

## Objetivos

Gestionar información estructurada asociada al manuscrito.

## Entregables

### Personajes

- Fichas.
- Metadatos.
- Notas.

### Localizaciones

- Registro.
- Descripciones.

### Objetos y conceptos

- Elementos recurrentes.
- Etiquetado.

### Relación con documentos

- Referencias cruzadas.
- Vínculos internos.

---

# Fase 7 - Línea temporal

## Objetivos

Representar la cronología de la obra.

## Entregables

### Eventos

- Fecha.
- Intervalos.
- Etiquetas.

### Visualización

- Cronología gráfica.
- Filtrado.

### Integración

- Relación con capítulos.
- Relación con personajes.
- Relación con localizaciones.

---

# Fase 8 - Diagnósticos avanzados

## Objetivos

Realizar análisis editoriales complejos.

## Entregables

### Consistencia documental

- Referencias rotas.
- Recursos faltantes.
- Errores de compilación.

### Estructura narrativa

- Capítulos vacíos.
- Escenas huérfanas.
- Inconsistencias de estructura.

### Repeticiones

- Palabras frecuentes.
- Frases repetidas.

### Análisis de estilo

- Longitud media de frases.
- Distribución léxica.
- Ritmo narrativo.

---

# Fase 9 - Sistema de extensiones

## Objetivos

Permitir crecimiento externo.

## Entregables

### API pública

- Eventos.
- Comandos.
- Documentos.

### Extensiones

- Descubrimiento.
- Carga dinámica.
- Aislamiento.

### SDK

- Documentación.
- Ejemplos.
- Plantillas.

---

# Fase 10 - IA local opcional

## Objetivos

Introducir análisis semántico local.

## Restricciones

- Exclusivamente local.
- Nunca modifica documentos.
- Nunca genera texto del manuscrito.
- Nunca utiliza servicios remotos.

## Entregables

### Proveedores

- Ollama.
- Arquitectura desacoplada.

### Diagnósticos semánticos

- Continuidad narrativa.
- Coherencia de personajes.
- Coherencia temporal.
- Relaciones entre entidades.

### Asistentes analíticos

- Explicación de incidencias.
- Navegación contextual.

---

# Fase 11 - Compilación avanzada

## Objetivos

Acercarse a capacidades de publicación profesional.

## Entregables

### Tipografía avanzada

- Viudas.
- Huérfanas.
- Ligaduras.
- Espaciado configurable.

### Paginación

- Determinista.
- Reproducible.

### Secciones

- Portadas.
- Créditos.
- Índices.
- Apéndices.

### Formatos adicionales

- Markdown.
- EPUB.
- Formatos de guion.

---

# Fase 12 - Ecosistema y madurez

## Objetivos

Preparar Scrollium para adopción amplia.

## Entregables

### Calidad

- Cobertura de pruebas elevada.
- Benchmarks automáticos.
- Validación continua.

### Documentación

- Manual de usuario.
- Manual técnico.
- Especificación pública de formatos.

### Comunidad

- Guías de contribución.
- Normas de revisión.
- Plantillas para incidencias.

### Estabilidad

- Compatibilidad entre versiones.
- Migraciones automáticas.
- Auditorías de rendimiento.

---

# Primera versión pública recomendada

La primera versión estable debería incluir:

- Gestión de proyectos.
- Árbol documental.
- Editor RTF.
- Imágenes.
- TXT canónico.
- Git local.
- Revisiones.
- Ortografía.
- Diagnósticos básicos.
- Exportación PDF.
- Exportación DOCX.

## Funcionalidades transversales pendientes

### Gestión de conflictos y control de versiones

La integración con Git no debe limitarse a crear revisiones.

#### Resolución de conflictos

- Detección de conflictos entre revisiones.
- Comparación visual lado a lado.
- Vista unificada de diferencias.
- Resolución manual de conflictos.
- Resolución asistida mediante selección de bloques.
- Restauración de revisiones anteriores.
- Recuperación de documentos eliminados.

#### Historial

- Historial completo del proyecto.
- Historial por documento.
- Historial por capítulo o escena.
- Filtrado por fecha y autor.
- Comparación entre revisiones seleccionadas.

#### Futuro

- Repositorios remotos.
- Sincronización opcional.
- Trabajo colaborativo asíncrono.

---

### Interfaz de usuario

La interfaz debe estar diseñada para minimizar distracciones y adaptarse a distintas fases del proceso editorial.

#### Disposición general

- Árbol de proyecto.
- Editor principal.
- Inspector de propiedades.
- Panel de diagnósticos.
- Panel de comentarios y revisiones.
- Panel de entidades (personajes, localizaciones, etc.).
- Panel de línea temporal.
- Barra de estado.

#### Diseño adaptable

- Paneles acoplables.
- Paneles ocultables.
- Distribuciones personalizables.
- Restauración de espacio de trabajo.

#### Temas

- Tema claro.
- Tema oscuro.
- Colores personalizables.
- Temas definidos mediante JSON.

---

### Sistema de menús y comandos

Toda funcionalidad debe exponerse mediante una infraestructura común de comandos.

#### Menús

- Archivo.
- Editar.
- Ver.
- Proyecto.
- Revisiones.
- Compilar.
- Herramientas.
- Ventana.
- Ayuda.

#### Acciones rápidas

- Paleta de comandos estilo IDE.
- Búsqueda de acciones.
- Ejecución mediante teclado.

#### Atajos

- Atajos configurables.
- Esquemas de atajos importables/exportables.

---

### Configuración de la aplicación

Configuración persistente en formatos abiertos.

#### Configuración global

- Idioma.
- Tema.
- Tipografía de la interfaz.
- Tipografía del editor.
- Directorios por defecto.
- Comportamiento de Git.
- Configuración de diagnósticos.
- Configuración de compilación.

#### Configuración de proyecto

- Metadatos de la obra.
- Objetivos de escritura.
- Diccionarios personalizados.
- Opciones de compilación predeterminadas.

#### Persistencia

```text
settings.json
```

Configuración legible y editable manualmente.

---

### Internacionalización (i18n)

La aplicación debe diseñarse como multiidioma desde el primer día.

#### Sistema de traducciones

Archivos JSON.

Ejemplo:

```json
{
    "File": "Archivo",
    "Save": "Guardar",
    "Compile": "Compilar"
}
```

#### Características

- Cambio de idioma sin recompilación.
- Detección automática del idioma del sistema.
- Traducciones aportadas por la comunidad.
- Fallback automático a inglés.

#### Idiomas iniciales

- Español.
- Inglés.

#### Futuro

- Francés.
- Alemán.
- Italiano.
- Portugués.

---

### Estadísticas y métricas avanzadas

Las métricas deben ayudar al escritor sin convertirse en una distracción.

#### Estadísticas básicas

- Palabras.
- Caracteres.
- Párrafos.
- Páginas estimadas.
- Tiempo de lectura.

#### Estadísticas avanzadas

- Palabras por capítulo.
- Palabras por escena.
- Evolución diaria.
- Evolución semanal.
- Evolución mensual.
- Ritmo medio de escritura.
- Días consecutivos escribiendo.

#### Objetivos

- Objetivo diario.
- Objetivo semanal.
- Objetivo mensual.
- Objetivo total del proyecto.

Ejemplo:

```text
Objetivo diario: 1.500 palabras
Progreso: 1.124 / 1.500
```

#### Visualización

- Gráficas.
- Calendario de actividad.
- Historial de progreso.

---

### Modos de trabajo

La aplicación debe diferenciar claramente las etapas de creación y revisión.

#### Modo Escritor

Orientado a producción de contenido.

Características:

- Interfaz simplificada.
- Menos distracciones.
- Diagnósticos mínimos.
- Sin marcas de revisión visibles.

#### Modo Revisor

Orientado a corrección y análisis.

Características:

- Comentarios.
- Sugerencias.
- Diagnósticos visibles.
- Navegación por incidencias.
- Comparación de revisiones.

---

### Sistema de comentarios y sugerencias

Inspirado en revisiones editoriales profesionales.

#### Comentarios

- Comentarios anclados a texto.
- Comentarios por documento.
- Comentarios por capítulo.
- Resolución de comentarios.

#### Sugerencias

- Texto propuesto.
- Aceptar sugerencia.
- Rechazar sugerencia.
- Historial de decisiones.

#### Estados

```text
Abierto
En revisión
Resuelto
Descartado
```

---

### Editor de texto enriquecido

Uno de los componentes más críticos del proyecto.

#### Requisitos mínimos

- Alto rendimiento.
- Manejo de documentos extensos.
- Renderizado incremental.
- Deshacer/Rehacer eficiente.
- Selecciones complejas.
- Copiar/Pegar enriquecido.
- Compatibilidad multiplataforma.

#### Opciones de implementación

##### Opción A: Control existente para Avalonia

Ventajas:

- Desarrollo inicial más rápido.
- Menor coste de mantenimiento.

Inconvenientes:

- Menor control.
- Dependencia externa.
- Limitaciones futuras.

##### Opción B: Editor propio sobre Avalonia

Ventajas:

- Control total.
- Integración completa con diagnósticos.
- Integración completa con comentarios.
- Integración completa con revisiones.
- Integración completa con renderizado incremental.
- Arquitectura alineada con Scrollium.

Inconvenientes:

- Mayor complejidad.
- Mayor esfuerzo de desarrollo.

#### Recomendación

Comenzar evaluando componentes existentes únicamente para prototipos y pruebas de concepto.

Para una visión a largo plazo, Scrollium debería disponer de un editor propio basado en:

- Modelo documental interno.
- Layout incremental.
- Renderizado virtualizado.
- Sistema propio de selección y edición.
- Integración nativa con diagnósticos, comentarios, revisiones y compilación.

El editor es el núcleo del producto y probablemente acabará siendo una de las piezas tecnológicas más importantes de toda la arquitectura.
