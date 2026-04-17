Algoritmo TipoCaracter
    Definir c Como Caracter
    
    Escribir "Ingrese un caracter:"
    Leer c
    
    Si c="a" O c="e" O c="i" O c="o" O c="u" Entonces
        Escribir "Es vocal"
    Sino
        Si c >= "0" Y c <= "9" Entonces
            Escribir "Es digito"
        Sino
            Escribir "Ninguno de los anteriores"
        FinSi
    FinSi
FinAlgoritmo