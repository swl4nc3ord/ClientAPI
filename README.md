# ClientAPI

Esse Projeto é uma API simples com CRUD de User para atender as necessidades de uma aplicação WEB, escrita em C# utilizando o framework ASP.NET Core e o banco de dados SQLServer.

Para insert da tabela de usuários, o script se encontra no arquivo "ScriptSqlServer"

# Instalação

1. Clone este repositório em sua máquina local: https://github.com/swl4nc3ord/ClientAPI

2. Instale o .NET Core SDK e o SQLServer em sua máquina local.

3. Configure a conexão com o banco de dados SQLServer no arquivo appsettingsDevelopment.json:
   
 "ConnectionStrings": { "SqlServer": "Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;TrustServerCertificate=True;" },

4. Execute o comando abaixo na pasta raiz do projeto para criar as tabelas no banco de dados:

# Utilização

1. Inicie a aplicação executando a solution pelo Visual Studio 2022
2. Ao executar irá abrir uma nova aba em seu navegador da documentação Swagger de métodos
