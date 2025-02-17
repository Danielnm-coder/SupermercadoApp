# SupermercadoApp

**SupermercadoApp** é uma API desenvolvida em .NET 8 para a gestão de produtos em um supermercado. O projeto segue uma arquitetura em camadas, com as seguintes divisões:

- **API**: Camada responsável por expor os endpoints da API.
- **Domain**: Camada de domínio, onde estão localizadas as regras de negócio.
- **Infra.Data**: Camada de infraestrutura e acesso a dados, incluindo a configuração do Entity Framework.

## Tecnologias Utilizadas

O projeto utiliza as seguintes tecnologias e bibliotecas:

- **.NET 8 API**: Framework principal para desenvolvimento da API RESTful. Saiba mais em [.NET 8](https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-8).
- **Swagger**: Utilizado para documentação interativa da API, facilitando o teste e a visualização dos endpoints. Saiba mais em [Swagger](https://swagger.io/).
- **CORS (Cross-Origin Resource Sharing)**: Configurado para permitir o compartilhamento de recursos entre diferentes origens, garantindo segurança e flexibilidade na comunicação entre o front-end e a API. Saiba mais em [CORS](https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS).
- **Entity Framework Core**: Ferramenta ORM para mapeamento dos objetos da aplicação com o banco de dados. Saiba mais em [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/).

## Estrutura do Projeto

- **SupermercadoApp.API**: Camada de apresentação, onde estão configurados os endpoints e o Swagger.
- **SupermercadoApp.Domain**: Camada onde ficam as entidades e as regras de negócio.
- **SupermercadoApp.Infra.Data**: Camada responsável pelo acesso ao banco de dados e pela implementação do Entity Framework Core.

## Funcionalidades

- CRUD completo para gerenciamento de produtos.
- Endpoint para listar todas as categorias pré-cadastradas.
- Documentação da API com Swagger.
- Configuração de CORS para comunicação segura entre front-end e API.
- Integração com o banco de dados usando Entity Framework Core.

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

