Algoritmo Trigonometria
    Definir angulo, rad Como Real
    Definir opcion Como Entero
    
    Escribir "Ingrese angulo en grados:"
    Leer angulo
    
    rad <- angulo * PI / 180
    
    Escribir "1=Seno, 2=Coseno, 3=Tangente"
    Leer opcion
    
    Segun opcion Hacer
        1: Escribir "Seno: ", Sen(rad)
        2: Escribir "Coseno: ", Cos(rad)
        3: Escribir "Tangente: ", Tan(rad)
        De Otro Modo:
            Escribir "Opcion invalida"
    FinSegun
FinAlgoritmo