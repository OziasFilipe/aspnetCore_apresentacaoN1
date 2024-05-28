Estudo Clean Architecture

Este projeto visa explorar a Clean Architecture. Foi simplificadamente estruturado em camadas: domínio, infraestrutura de repositório e aplicação, com duas implementações: uma API ASP.NET Core e uma aplicação ASP.NET Core MVC. Além disso, foram adicionados recursos como Dapper para a conexão com o banco de dados. A abordagem simplificada foi adotada, onde o código SQL foi diretamente incorporado ao repositório para lidar com operações na tabela. Por exemplo, para o cadastro de clientes, o SQL correspondente foi incluído no repositório. Alternativamente, poderiam ter sido usadas stored procedures para manipular a tabela e suas colunas. Algumas validações simplificadas foram implementadas. Como este projeto é uma exploração da arquitetura de software, foram introduzidas algumas preferências. Apesar das dificuldades encontradas, o projeto pode ser refinado para uma abordagem mais complexa, distribuindo de forma mais clara as responsabilidades entre as camadas.


Recursos Utilizados:

Dapper
FluentValidation
Swashbuckle
ASP.NET Core API
ASP.NET Core MVC
Poderiam ser Utilizados:

EntityFramework em substituição ao Dapper, ADO.NET, entre outros recursos.

OBS: Por se tratar de um estudo de Clean Architecture, é possível encontrar muitos erros; no entanto, ao longo do tempo, será refinada e construída uma base mais sólida.


