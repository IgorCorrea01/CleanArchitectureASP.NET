# CleanArchitectureAsp.Net

Bem-vindo ao repositório do projeto **CleanArchitectureAsp.Net**! Este projeto foi desenvolvido por mim, com o objetivo de implementar os princípios da Clean Architecture em uma aplicação ASP.NET.

## Sobre o Projeto

Este projeto exemplifica a aplicação dos conceitos de Clean Architecture, promovendo uma separação clara de responsabilidades e facilitando a manutenção e escalabilidade do código. A estrutura do projeto está organizada da seguinte forma:

- **Domain**: Contém as entidades centrais do domínio e as interfaces, garantindo que as regras de negócio sejam independentes de frameworks e implementações externas.
- **Application**: Inclui a lógica de aplicação, como casos de uso, interfaces de serviços e validadores, garantindo a separação entre regras de negócios e infraestrutura.
- **Infrastructure**: Abriga a implementação de repositórios, serviços externos, configurações do banco de dados e integrações com APIs de terceiros.
- **WebUI**: Responsável pela interface com o usuário, configurada com ASP.NET MVC, e a injeção de dependências para conectar todas as camadas de forma eficiente.
- **Tests**: Contém testes unitários e de integração para garantir a confiabilidade e estabilidade do sistema.

## Tecnologias Utilizadas

- **.NET Core**: Framework principal para o desenvolvimento da aplicação.
- **Entity Framework Core**: Para mapeamento objeto-relacional e acesso ao banco de dados.
- **MediatR**: Implementação do padrão Mediator para gerenciar a comunicação entre componentes.
- **AutoMapper**: Para mapeamento automático entre objetos.
- **FluentValidation**: Biblioteca para validação de modelos de forma fluente.
- **xUnit**: Para escrita e execução de testes unitários.
- **Moq**: Para simulação de dependências nos testes unitários.

## Como Executar o Projeto

1. **Clone o repositório**:
   ```bash
   git clone https://github.com/IgorCorrea01/CleanArchitectureAsp.Net.git
   ```
2. **Navegue até o diretório do projeto**:
   ```bash
   cd CleanArchitectureAsp.Net
   ```
3. **Restaure as dependências**:
   ```bash
   dotnet restore
   ```
4. **Atualize o banco de dados**:
   ```bash
   dotnet ef database update --project CleanArchMVC.Infra.Data
   ```
5. **Execute a aplicação**:
   ```bash
   dotnet run --project CleanArchMVC.WebUI
   ```
6. **Executar os testes**:
   ```bash
   dotnet test
   ```
