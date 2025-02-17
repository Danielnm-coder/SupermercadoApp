# SupermercadoApp

SupermercadoApp é uma API desenvolvida em .NET 8 para a gestão de produtos de um supermercado.
A API segue os padrões REST, utilizando arquitetura DDD (Domain-Driven Design) e os princípios SOLID.

## Tecnologias Utilizadas
- .NET 8
- Entity Framework Core
- SQL Server
- Padrões REST
- Arquitetura DDD
- Princípios SOLID

## Endpoints da API

### Categoria

#### Obter todas as categorias pré-cadastradas
**GET** `/api/categoria`

### Produtos

#### Criar um novo produto
**POST** `/api/produtos`

#### Atualizar um produto
**PUT** `/api/produtos`

#### Buscar todos produto
**GET** `/api/produtos`

#### Buscar um produto por ID
**GET** `/api/produtos/{id}`

#### Excluir um produto
**DELETE** `/api/produtos/{id}`

## Banco de Dados
A API utiliza o Entity Framework Core para interagir com o banco de dados SQL Server.

### Script de Criação da Tabela de Categorias
```sql
INSERT INTO CATEGORIAS (ID, Nome)
VALUES
    (NEWID(), 'BEBIDAS'),
    (NEWID(), 'HORTIFRUTI'),
    (NEWID(), 'PADARIA'),
    (NEWID(), 'LATICÍNIOS'),
    (NEWID(), 'CARNES'),
    (NEWID(), 'LIMPEZA');

SELECT * FROM CATEGORIAS
ORDER BY Nome ASC;
```
## Autor
Desenvolvido por Daniel Nascimento.

