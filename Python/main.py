def Calculadora():

    while True:

        print("< CALCULADORA >")
        print("")
        print("1 - SOMA")
        print("2 - SUBTRAÇÃO")
        print("3 - MULTIPLICAÇÃO")
        print("4 - DIVISÃO")
        print("5 - POTÊNCIA")

        print("")

        opcao = input("escolha de 1 a 5 a sua opção: ")

        if opcao == "0":
            print ("SAINDO...")
            break
        
        n1 = int(input("digite o primeiro número: "))
        n2 = int(input("digite o segundo número: "))

        if opcao == "1":
            resultado = n1 + n2
            print(f"o resultado de {n1} mais {n2} é {resultado}")
        elif opcao == "2":
            resultado = n1 - n2
            print(f"o resultado de {n1} menos {n2} é {resultado}")
        elif opcao == "3":
            resultado = n1 * n2
            print(f"o resultado de {n1} multiplicado por {n2} é {resultado}")
        elif opcao == "4":
            resultado = n1 / n2
            print(f"o resultado de {n1} dividido por {n2} é {resultado}")
        elif opcao == "5":
            resultado = n1 **  n2
            print(f"o resultado de {n1} com potência de {n2} é {resultado}")

Calculadora()