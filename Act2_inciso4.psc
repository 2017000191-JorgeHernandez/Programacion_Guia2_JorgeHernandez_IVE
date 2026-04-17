Algoritmo VentaImpresoras
    Definir cantidad, opcion Como Entero
    Definir precio, precioIVA, subtotal, descuento, total Como Real
    Definir formaPago Como Caracter
	
    precio <- 650
    precioIVA <- precio + (precio * 0.12)
	
    Escribir "Ingrese cantidad de impresoras:"
    Leer cantidad
	
    Escribir "Seleccione forma de pago"
    Escribir "1. Efectivo (10%)"
    Escribir "2. Tarjeta de credito (5%)"
    Escribir "3. Vale de regalo (15%)"
    Leer opcion
	
    subtotal <- cantidad * precioIVA
	
    Segun opcion Hacer
        1:
            descuento <- subtotal * 0.10
            formaPago <- "Efectivo"
        2:
            descuento <- subtotal * 0.05
            formaPago <- "Tarjeta de credito"
        3:
            descuento <- subtotal * 0.15
            formaPago <- "Vale de regalo"
        De Otro Modo:
            descuento <- 0
            formaPago <- "Invalido"
    FinSegun
	
    total <- subtotal - descuento
	
    Escribir "Cantidad: ", cantidad
    Escribir "Precio unitario con IVA: Q", precioIVA
    Escribir "Total sin descuento: Q", subtotal
    Escribir "Forma de pago: ", formaPago
    Escribir "Descuento: Q", descuento
    Escribir "Total a pagar: Q", total
FinAlgoritmo