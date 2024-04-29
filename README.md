# LocaSimples
Projeto de uma API de uma Locadora de Veículos utilizando Asp.Net.Core e conexão com banco de dados em SQL Server.

## Alunos integrantes da equipe

* Luiz Filipe Marques Nascimento

## Professores responsáveis

* Leonardo Vilela Cardoso

## Instruções de utilização

Para utilizar este projeto, siga as instruções abaixo:

### Pré-requisitos

Antes de iniciar, certifique-se de ter instalado em sua máquina:

1. **Git**: Para clonar o repositório, você pode baixá-lo [aqui](https://git-scm.com/downloads).
2. **Visual Studio ou Visual Studio Code**: Para abrir e editar o código. Você pode baixar o Visual Studio [aqui](https://visualstudio.microsoft.com/pt-br/downloads/) e o Visual Studio Code [aqui](https://code.visualstudio.com/download).
3. **SQL Server**: Para armazenamento de dados. Você pode baixar o SQL Server [aqui](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads).

### Clonando o Repositório

Abra o terminal e execute o seguinte comando para clonar o repositório: [https://github.com/PSG-TADS/psg-tads-2024-1-back-bd-LuizFilipeMN.git]


### Configuração do Ambiente

1. Abra o projeto no Visual Studio ou Visual Studio Code.
2. Verifique se todas as dependências estão instaladas. Caso contrário, você pode instalá-las usando o NuGet Package Manager ou o .NET CLI.
3. Abra o SQL Server Management Studio (SSMS) e certifique-se de que o servidor está em execução.

### Executando a Aplicação

1. No Visual Studio, compile e execute o projeto.
2. No Visual Studio Code, abra um terminal na pasta raiz do projeto e execute o comando: dotnet run


### Testando a API

Após a execução da aplicação, você pode testar os endpoints da API usando qualquer cliente HTTP, como o Postman ou o Insomnia. Abaixo estão os métodos HTTP disponíveis:

- **GET**: Recupera informações.
- **POST**: Cria um novo recurso.
- **PUT**: Atualiza um recurso existente.
- **DELETE**: Remove um recurso.

Por exemplo, para listar todos os veículos, você pode enviar uma solicitação GET para `http://localhost:porta/veiculos`.

Certifique-se de consultar a documentação da API ou os arquivos de código-fonte para obter detalhes sobre os endpoints disponíveis e os parâmetros necessários.

Agora você está pronto para começar a usar a LocaSimples API!

