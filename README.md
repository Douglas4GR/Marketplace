# Marketplace
Este projeto é uma API com estrutura simples com apenas duas Entidades e duas Tabelas, podendo servir como base para APIs mais complexas.
Nesse caso específico a estrutura gira em torno de um sistema de gestão de pedidos e estoque de produtos de um marketplace.
É uma aplicação ASP.NET Core que utiliza o Entity Framework Core para acessar um banco de dados SQL Server.

> ### Palavras-Chave:
>  - C#
>  - AspNet Core
>  - Entity Framework Core
>  - SqlServer
>  - .NET 8

## Swagger

![Operações](Imagens/Swagger1.png)

![Esquemas](Imagens/Swagger2.png)

### As operações atuais incluem:
  - Inserir pedido
  - Trazer histórico de pedidos concluídos
  - Trazer o status de um pedido específico
  - Processar pedidos pendentes
  - Atualizar o estoque de produtos ou inserir novos produtos

### E os esquemas:
  - Order
  - Product

# Estrutura do Projeto
```plaintext
.
├── Marketplace
│   ├── Controllers
│   │   ├── OrderController.cs
│   │   └── ProductController.cs
│   ├── Data
│   │   └── MarketplaceContext.cs
│   ├── Models
│   │   ├── Order.cs
│   │   ├── OrderStatus.cs
│   │   └── Product.cs
│   ├── Properties
│   │   └── launchSettings.json
│   ├── Marketplace.csproj
│   ├── Marketplace.http
│   ├── Program.cs
│   ├── appsettings.Development.json
│   ├── appsettings.json
│   └── exemplos.json
├── .gitattributes
├── .gitignore
├── Imagens
├── LICENSE
├── Marketplace.sln
└── README.md
```

### Detalhes dos Arquivos e Pastas
- **Marketplace**: Diretório principal do projeto.
  - **Controllers**: Contém os controladores do projeto.
    - `OrderController.cs`: Controlador responsável pelas operações relacionadas a -pedidos.
    - `ProductController.cs`: Controlador responsável pelas operações relacionadas a produtos.
  - **Data**: Contém os arquivos de contexto e configuração do banco de dados.
    - `MarketplaceContext.cs`: Classe de contexto do banco de dados.
  - **Models**: Contém os modelos do projeto.
    - `Order.cs`: Classe de entidade do pedido.
    - `OrderStatus.cs`: Enum para status dos pedidos.
    - `Product.cs`: Classe de entidade do produto.
  - **Properties**: Contém arquivos de configuração do projeto.
    - `launchSettings.json`: Configurações de lançamento do projeto.
  - `Marketplace.csproj`: Arquivo de projeto do .NET.
  - `Marketplace.http`: Arquivo para testar as APIs.
  - `Program.cs`: Ponto de entrada do aplicativo.
  - `appsettings.Development.json`: Configurações de ambiente de desenvolvimento.
  - `appsettings.json`: Configurações do aplicativo.
  - `exemplos.json`: Exemplo de arquivo de configuração ou dados.
- `.gitattributes`: Arquivo de atributos do Git.
- `.gitignore`: Arquivo de exclusões do Git.
- `LICENSE`: Licença do projeto.
- `Marketplace.sln`: Solução do projeto.
- `README.md`: Este arquivo.

## Instalação
1. Clone o Repositório
```
  git clone https://github.com/douglas4GR/Marketplace.git
```
2. Navegue até o diretório do projeto:
```
  cd PortalAdminEmpregados
```
3. Restaure as dependências do projeto:
```
  dotnet restore
```
4. Atualize o banco de dados para a última versão de migração:
```
  dotnet ef database update
```

## Uso
Para iniciar a aplicação, use o comando:
```
dotnet run
```

## Contribuição
1. Faça um fork do projeto.
2. Crie uma nova branch:
```
git checkout -b minha-nova-feature
```
3. Faça suas alterações e commit:
```
git commit -m 'Adiciona nova feature'
```
4. Envie para a branch original:
```
git push origin minha-nova-feature
```
5. Crie um pull request.

## Tecnologias utilizadas
- ASP.NET Core 6.6.2
- Entity Framework Core (SQL Server) 8.0.6
- Entity Framework Core Tools 8.0.6

## Licença
Este projeto está licenciado sob a Licença MIT - veja o arquivo [LICENSE](LICENSE) para mais detalhes.
