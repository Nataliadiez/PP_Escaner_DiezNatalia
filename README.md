
#PP_Escaner_ApellidoNombre
##Descripción del Proyecto
Este proyecto es una solución para el primer parcial del curso de Programación II del primer cuatrimestre de 2024. El objetivo es crear un sistema para escanear y gestionar documentos en una biblioteca, abarcando dos tipos de documentos: libros y mapas. La solución consta de dos proyectos: una biblioteca de clases y una consola para pruebas.

#Estructura del Proyecto
La solución se llama PP_Escaner_ApellidoNombre y está desarrollada en .NET 7.0. Contiene los siguientes proyectos:

Entidades: Biblioteca de clases que contiene la lógica principal del programa.
Test: Aplicación de consola utilizada para probar y verificar la funcionalidad del programa.
Requisitos del Sistema
Estados del Proceso de Escaneo
Los documentos pueden encontrarse en uno de los siguientes estados:

1- Inicio: Valor por defecto.
2- Distribuido: Documento asignado al escáner correspondiente.
3- EnEscaner: Documento siendo escaneado.
4- EnRevision: Documento en proceso de revisión.
5- Terminado: Documento escaneado y aprobado.

#Criterios de Identificación de Documentos
Libros:
Mismo barcode, o
Mismo ISBN, o
Mismo título y autor.

Mapas:
Mismo barcode, o
Mismo título, autor, año y superficie.
Funcionalidades Principales

Documento y derivados:
Propiedad NumNormalizado accesible solo desde clases derivadas.
Estado inicial "Inicio".
Método ToString() utilizando StringBuilder para mostrar todos los datos.
Método AvanzarEstado() para cambiar al siguiente estado. Devuelve false si ya está en "Terminado".
Sobrecarga del operador == para comparar documentos.
En libros, ISBN muestra NumNormalizado.
Los mapas calculan superficie como alto por ancho.

Escáner:
Constructor inicializa la lista de documentos y asigna la locación según el tipo de documento.
Sobrecarga del operador == para verificar si un documento ya está en la lista.
Sobrecarga del operador + para añadir documentos a la lista si no están ya presentes y están en estado "Inicio".
Método CambiarEstadoDocumento() para cambiar el estado de un documento en la lista.

Informes:
Extensión: Total de páginas en libros o cm² en mapas según el estado.
Cantidad: Número total de ítems únicos procesados según el estado.
Resumen: Datos de cada ítem en una lista según el estado.

#Criterios de Corrección
##Motivos de Desaprobación Directa (nota = 2):
La solución no compila.
Warnings no permitidos.
Excepciones no controladas en el código de testing.
Último commit posterior a la fecha límite.

##Requisitos para llegar al 4:
La salida del test es similar en un 80% a la esperada.
No hay errores graves en el código.

##Requisitos para llegar al 6:
La salida del test es exactamente igual a la esperada.

##Requisitos para llegar al 8:
La salida del test es exactamente igual a la esperada.
El código sigue los principios de POO.

##OPCIONAL: +2 puntos:
Solo si se tiene un 6 de partida.
Incluir una excepción controlada y defenderla oralmente.
