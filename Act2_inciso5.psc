Algoritmo Conversor
    Definir opcion Como Entero
    Definir valor Como Real
    
    Escribir "1 Metros"
    Escribir "2 Pies"
    Escribir "3 Centimetros"
    Escribir "4 Pulgadas"
    Leer opcion
    
    Escribir "Ingrese valor:"
    Leer valor
    
    Segun opcion Hacer
        1:
            Escribir "En pies: ", valor * 3.281
        2:
            Escribir "En metros: ", valor / 3.281
        3:
            Escribir "En pulgadas: ", valor / 2.54
        4:
            Escribir "En centimetros: ", valor * 2.54
        De Otro Modo:
            Escribir "Opcion invalida"
    FinSegun
FinAlgoritmo