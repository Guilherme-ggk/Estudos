nome = input("Qual é o seu nome? ")

print(f"Prazer em conhece-lo {nome}")

frutas = ["uva","abacaxi","laranja","melão"]

for fruta in frutas:
    print(f"eu gosto de {fruta}")


def Saudar(nome1):
    return f"que legal {nome1}"

mensagem = Saudar("Guilherme")
print(mensagem)

contador = 0

while contador < 11:
    print(contador)
    contador+=1

cachorro = {
    "nome: ":"Toizin",
    "idade: ":"5 anos",
    "porte: ":"pequeno"
}

print(cachorro)

print("< Limite de velocidade >")

velocidadeCarro = 50

if velocidadeCarro > 90:
    print("MULTADO")
elif velocidadeCarro == 0:
    print("GUINCHO")
elif velocidadeCarro < 90:
    print("BOA VIAGEM")
