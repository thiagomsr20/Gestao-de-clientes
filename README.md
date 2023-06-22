
# Gestao de clientes em ASP.NET com suporte para CRUD

API REST de gestão de clientes em cache. Projeto para aplicar conhecimentos estudados sobre desenvolvimento de API no padrão REST com ASP.NET.
## Como usar

Clonando e rodando pelo git:

```bash
    $ git clone https://github.com/thiagomsr20/Gestao-de-clientes.git
    $ cd Gestao-de-clientes
    $ cd cs-files
    $ dotnet watch
```
    
## Documentação da API




#### Retornar todos os clientes cadastrados:
```http
  GET /Clientes
```
| Parâmetro       | Tipo do parâmetro | Retorno       |
| :----------     | :----------       |:----------    |
| -               | -                 | `List<object>`|



#### Retornar um cliente pelo id:
```http
  GET /Clientes/{id}
```
| Parâmetro       | Tipo do parâmetro | Retorno    |
| :----------     | :----------       |:---------- |
| `{id}`          | `int`             | `object`   |




#### Cadastrar um novo cliente:
```http
  POST /Clientes
```
| Parâmetro        | Tipo do parâmetro | Retorno       |
| :----------      | :----------       |:----------    |
| `{Cliente}`      | `object`          | `ActionResult`|



#### Atualizar um cliente cadastrado:
```http
  PUT /Clientes/{id}
```
| Parâmetro        | Tipo do parâmetro | Retorno       |
| :----------      | :----------       |:----------    |
| `{id}, {Cliente}`| `int, object`     | `ActionResult`|


###
