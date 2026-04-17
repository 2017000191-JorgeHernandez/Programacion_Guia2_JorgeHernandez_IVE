Algoritmo Calculadora
    Definir n1, n2, op Como Entero
    
    Escribir "Ingrese primer numero:"
    Leer n1
    Escribir "Ingrese segundo numero:"
    Leer n2
    Escribir "1=Suma, 2=Resta, 3=Multiplicacion, 4=Division"
    Leer op
    
    Segun op Hacer
        1: Escribir "Resultado: ", n1 + n2
        2: Escribir "Resultado: ", n1 - n2
        3: Escribir "Resultado: ", n1 * n2
        4:
            Si n2 <> 0 Entonces
                Escribir "Resultado: ", n1 / n2
            SiNo
                Escribir "No se puede dividir entre cero"
            FinSi
        De Otro Modo:
            Escribir "Opcion invalida"
    FinSegun
FinAlgoritmo