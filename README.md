# TRILHA .NET

---

# :pushpin: Índece

- [Projeto](#-Projeto)
- [Instalação](#construction_worker-instalação)
- [Características](#-Características)
- [Exemplo de Request](#-Exemplo-de-Request)
- [Tecnologias e Ferramentas utilizadas](#-tecnologias-e-ferramentas-utilizadas)
- [Autor](#-Autor)
- [Testado no Sistema Operacional](#-Testado-no-Sistema-Operacional)

---

## 💻 Projeto

 Crud Web Api com Postgres 🚀

---

# :construction_worker: Instalação

**Você precisa instalar o [Visual Studio 2019](https://visualstudio.microsoft.com/pt-br/vs/community/), [Postgres](https://www.postgresql.org/download/), [dotnet 5.0](https://dotnet.microsoft.com/download/dotnet/5.0) e o [Pgadmin](https://www.pgadmin.org/download/) e em seguida, para clonar o projeto via HTTPS, execute este comando :**

```
git clone https://github.com/SilvaTs/TrilhaEspecificaAula2.git
```

Após você clonar o projeto na sua máquina,você vai no caminho do projeto pelo
o terminal e rodar esses comandos abaixo para gerar a migrations e rodar
a migrations.

```
criar migrations
dotnet ef migrations add "Primeiro Migrations" --context=LocalDbContext

atualizar a tabela
dotnet ef database update

rodar a migrations
dotnet ef database update
```

---

## 📋 Características

### Documentação

- [x] cadastrar carros
- [x] atualizar carro
- [x] deletar carro por id
- [x] listar carro por id
- [x] listar todos carros
- [x] Persistência de dados
- [x] Teste no postman
- [x] Testes Unitários

---

## 🚀 Exemplo de Request

### Adicionar Carro
POST http://localhost:5000/carro

#### exemplo de request.body, Informando marca,modelo e combustivel do carro:
```
{
  "marca": "bmw",
  "modelo": "x5",
  "combustivel": "gasolina"
}
```
<hr/>

### Atualizar Carro

PUT http://localhost:5000/carro
   
#### exemplo de request.body, Informando marca,modelo e combustivel do carro: 
```
  {
    "id": 1,
    "marca": "fiat",
    "modelo": "toro",
    "combustivel": "alcool"
  }
 ```
 <hr/>
 
 ### Deletar Carro

 DELETE http://localhost:5000/carro/2
   
#### exemplo do request.response :
```
   "msg": "Removido com sucesso"
  
 ``` 

  <hr/>

  ### Listar Carro Por id

GET http://localhost:5000/carro/2
   
#### exemplo do request.response :
```
  {
    "id": 2,
    "marca": "fiat",
    "modelo": "toro",
    "combustivel": "alcool"
  }
 ``` 
 <hr />

 ### Listar todos Carros
 GET http://localhost:5000/carro/
   
#### exemplo do request.response :
```
 [
  {
    "id": 1,
    "marca": "fiat",
    "modelo": "toro",
    "combustivel": "alcool"
  },
  {
    "id": 3,
    "marca": "fiat",
    "modelo": "siena",
    "combustivel": "gasolina"
  },
  {
    "id": 4,
    "marca": "crevrolet",
    "modelo": "onix",
    "combustivel": "gasolina"
  },
  {
    "id": 5,
    "marca": "fiat",
    "modelo": "fiat argo",
    "combustivel": "gasolina"
  },
  {
    "id": 6,
    "marca": "bmw",
    "modelo": "x5",
    "combustivel": "gasolina"
  }
]
 ```
  
---

## 🚀 Tecnologias e Ferramentas utilizadas

- [Postgres](https://www.postgresql.org/download/)
- [Visual Studio 2019](https://visualstudio.microsoft.com/pt-br/vs/community/)
- [dotnet 5.0](https://dotnet.microsoft.com/download/dotnet/5.0)
- [Pgadmin](https://www.pgadmin.org/download/)

---

## 👤 Autor

**Daniel Silva**

Entre em contato comigo em um dos seguintes lugares!

- Twitter: [@DanielSilva](https://twitter.com/danielsilvatsi)
- Github: [@DanielSilva](https://github.com/SilvaTs)
- Linkedin: [@DanielSilva](https://www.linkedin.com/in/daniel-silva-tsi/)

---

## 🧪 Testado no Sistema Operacional

- Windows (por @danielsilva)
