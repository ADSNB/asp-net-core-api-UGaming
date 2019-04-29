### Detalhes do projeto ###
Developer: Alan Nunes
UGaming API
Project Version: Core 1.0.0
VS Version: 2015 Community
Projeto desenvolvido no modelo DDD (Domain Driven Design)
Persistência: Micro ORM Dapper ( https://github.com/StackExchange/Dapper )
SGBD: PostGreSQL 9.6.5

OBS.: Para abrir e executar o projeto no vs 2015, deve-se instalar o SDK do core.

### Instruções para deploy banco de dados: ###

1 - O projeto usa conexão com banco de dados PostGreSQL 9.6.5 ( https://www.postgresql.org/download/windows/ )
2 - Após instalado o banco de dados postgres devemos executar os scripts do banco localizados na pasta " UGamingAPI/db " para criar a base de dados (tables game_result & leaderboard)

### Instruções para requisições no EndPoint: ###

Eu utilizei para os testes de requisições API o postman extansão para o chrome: (https://www.getpostman.com/)

Dentro da pasta " PostMan_Scripts ", tem um backup que realizei das chamadas na API, assim podendo fazer um restore direto das funcionalidades.

[POST - body (raw) ]
http://localhost:5000/api/UGaming/GameResult
example:
{
	"PlayerId" : 8,
	"GameId" : 1,
	"Win" : 97,
	"TimeStamp" : "2017-09-25 11:30:00"
}

[GET]
http://localhost:5000/api/UGaming/Leaderboard

### Porquê pesistência Dapper? ###

O dapper nos permite realizar consultas SQL's com respostas muito rápidas comparado a outros ORM's no mercado. Este orm foi criado por Marc Gravell e Sam Saffron enquanto trabalhavam no Stack Overflow, resolvendo problemas de desempenho da plataforma. 

### Porquê PostGreSQL? ###

É um banco de dados open source, que possui atualizações constantes e bons feedback's da comunidade.

### Consigo publicar no IIS? ###

Para publicar no IIS temos que instalar as seguintes bibliotecas:
*Windows Server Hosting (x86/x64) - https://www.microsoft.com/net/download/core#/runtime
*Http Platform Handler (x86 / x64) - https://www.iis.net/downloads/microsoft/httpplatformhandler#additionalDownloads

### Executando a aplicação: ###

Um dos modos que podemos executar a aplicação é ir na pasta " Project_Publish " e executar o " UGaming.API.exe ", que abrirá a aplicação por um console.
Outro modo é ir configurar no IIS, instalando os requisitos acima.
Lembrando, que o banco de dados tem que ser criado para a persistência e consultas poderem ocorrer.

Qualquer dúvida, podem me contatar.

=)