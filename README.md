# MinimalAPI-Todo---API-Simples-para-Gerenciamento-de-Tarefa
Bem-vindo ao Repositório MinimalAPI Todo, uma API minimalista construída em C# usando a tecnologia Minimal APIs do ASP.NET Core. Esta API oferece operações básicas para o gerenciamento de tarefas (Todo) - criar, listar, atualizar e excluir.  
Recursos Principais:

    Listar Todas as Tarefas (/v1/todas):
        Obtém todas as tarefas cadastradas no banco de dados.

    Apagar Tarefa por ID (/v1/apagar/{id:guid}):
        Remove uma tarefa específica com base no ID fornecido.

    Apagar Várias Tarefas (/v1/apagar/varias):
        Remove várias tarefas simultaneamente com base em uma lista de IDs.

    Cadastrar Nova Tarefa (/v1/cadastrar):
        Adiciona uma nova tarefa ao banco de dados.

    Atualizar Tarefa (/v1/Atualizar):
        Atualiza uma tarefa existente com base no ID fornecido.

Tecnologias Utilizadas:

    ASP.NET Core Minimal APIs
    Entity Framework Core para interação com o banco de dados SQLite
    Swagger para documentação e teste da API

Como Contribuir:

    Fique à vontade para forkar o repositório e enviar pull requests.
    Reporte problemas ou sugira melhorias na seção de issues.

Como Executar:

    Clone o repositório.
    Certifique-se de ter o SDK do .NET Core instalado.
    Navegue até a pasta do projeto e execute dotnet run.
    Acesse a API em https://localhost:5001.

Observações:

    Certifique-se de ajustar a string de conexão no arquivo AppDbContext para o ambiente de desenvolvimento ou produção.
    Este projeto utiliza SQLite como banco de dados padrão, mas pode ser alterado para outros provedores de banco de dados suportados pelo EF Core.

Fique à vontade para explorar, contribuir e adaptar este projeto conforme suas necessidades. Estamos abertos a colaborações e melhorias contínuas. Happy coding! 🚀
