from pickle import INT


def ejer1():
    nombre = input("Ingrese su nombre: ")
    carrera = input("Ingrese su carrera: ")

    print(f"\n{nombre}, bienvenido al curso de Fundamentos de Algoritmos de la carrera de {carrera}")


def ejer2():
    print("\"Cristian\"")

def ejer3():
    num1 = int(input("Ingrese numero 1: "))
    num2 = int(input("Ingrese numero 2: "))

    print("Suma: ", (num1+num2))
    print("Resta: ", (num1-num2))
    print("Multiplicacion: ", (num1*num2))
    print("Division: ", (num1/num2))

ejer3()