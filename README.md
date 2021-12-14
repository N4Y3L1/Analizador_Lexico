# Analizador_Lexico
Analizador Léxico en C#
Nayeli Esmeralda Aceves Angulo
¿Que es el analizador Léxico y para que funciona?
El analizador léxico es la primera fase de un compilador. Su principal función consiste en leer los caracteres de entrada y elaborar como salida una secuencia de componentes léxicos que utiliza el analizador sintáctico para hacer el análisis. Esta interacción, suele aplicarse convirtiendo al analizador léxico en una subrutina o corrutina del analizador sintáctico.

¿Como Funciona?
Recibida la orden “Dame el siguiente componente léxico” del analizador sintáctico, el analizador léxico lee los caracteres de entrada hasta que pueda identificar el siguiente componente léxico. Otras funciones que realizan se listan a continuación:

Eliminar los comentarios del programa.
Eliminar espacios en blanco, tabuladores, retorno de carro, etc, y en general, todo aquello que carezca de significado según la sintaxis del lenguaje.
Reconocer los identificadores de usuario, números, palabras reservadas del lenguaje y tratarlos correctamente con respecto a la tabla de símbolos (solo en los casos que debe de tratar con la tabla de símbolos).
Llevar la cuenta del número de línea por la que va leyendo, por si se produce algún error, dar información sobre donde se ha producido.
Avisar de errores léxicos.
Por ejemplo, si @ no pertenece al lenguaje, avisar de un error. Puede hacer funciones de preprocesador.
