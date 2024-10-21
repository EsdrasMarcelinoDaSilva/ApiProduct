# ApiProduct

## Descrição

**ApiProduct** é uma API desenvolvida em ASP.NET Core que utiliza Entity Framework Core para gerenciar dados e Swashbuckle (complemento do Swagger) para documentação da API. Esta API foi criada para facilitar a gestão e o acesso aos produtos de uma aplicação.

## Funcionalidades

- CRUD de produtos.
- Documentação automatizada da API utilizando Swagger/Swashbuckle.
- Integração com banco de dados SQL Server utilizando Entity Framework Core.

## Tecnologias Utilizadas

- **ASP.NET Core** - Framework para a criação de APIs web.
- **Entity Framework Core** - ORM para trabalhar com o banco de dados SQL Server.
- **Swashbuckle** - Geração automática de documentação para a API usando Swagger.

### Dependências

- `Microsoft.EntityFrameworkCore.SqlServer` (versão 8.0.10): Integração do Entity Framework Core com o SQL Server.
- `Microsoft.EntityFrameworkCore.Tools` (versão 8.0.10): Ferramentas adicionais para desenvolvimento com o Entity Framework Core.
- `Swashbuckle.AspNetCore` (versão 6.6.2): Geração de documentação para a API com Swagger.

## Requisitos

- .NET SDK 8.0 ou superior.
- SQL Server (local ou remoto).
  
## Instalação

1. Clone este repositório:
    ```bash
    git clone https://github.com/seu-usuario/ApiProduct.git
    ```

2. Navegue até o diretório do projeto:
    ```bash
    cd ApiProduct
    ```

3. Instale as dependências:
    ```bash
    dotnet restore
    ```

4. Configure a string de conexão do banco de dados no arquivo `appsettings.json`.

## Execução

1. Aplique as migrações ao banco de dados:
    ```bash
    dotnet ef database update
    ```

2. Execute a API:
    ```bash
    dotnet run
    ```

3. Acesse a documentação Swagger no navegador:
    ```
    http://localhost:5000/swagger
    ```

## Contribuição

Sinta-se à vontade para enviar pull requests ou relatar problemas no repositório.


