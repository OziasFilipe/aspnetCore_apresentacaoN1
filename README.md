<h4>Estudo Clean Architecture</h4>

Este projeto visa explorar a Clean Architecture. Foi simplificadamente estruturado em camadas: domínio, infraestrutura de repositório e aplicação, com duas implementações: uma API ASP.NET Core e uma aplicação ASP.NET Core MVC. Além disso, foram adicionados recursos como Dapper para a conexão com o banco de dados. A abordagem simplificada foi adotada, onde o código SQL foi diretamente incorporado ao repositório para lidar com operações na tabela. Por exemplo, para o cadastro de clientes, o SQL correspondente foi incluído no repositório. Alternativamente, poderiam ter sido usadas stored procedures para manipular a tabela e suas colunas. Algumas validações simplificadas foram implementadas. Como este projeto é uma exploração da arquitetura de software, foram introduzidas algumas preferências. Apesar das dificuldades encontradas, o projeto pode ser refinado para uma abordagem mais complexa, distribuindo de forma mais clara as responsabilidades entre as camadas.
Além disso, foram utilizados dois recursos externos: uma API de CEP e outra de CNPJ, para trazer os dados do cliente quando necessário. Como observado, o serviço de CEP será acessado diretamente no JavaScript, enquanto para o CNPJ, foi criado um arquivo .CS para lidar com questões de CORS no navegador, permitindo seu funcionamento.

Recursos Utilizados:

Dapper
FluentValidation
Swashbuckle
ASP.NET Core API
ASP.NET Core MVC
Poderiam ser Utilizados:

EntityFramework em substituição ao Dapper, ADO.NET, entre outros recursos.

OBS: Por se tratar de um estudo de Clean Architecture, é possível encontrar muitos erros; no entanto, ao longo do tempo, será refinada e construída uma base mais sólida.

IMAGEM REFERENTE AO PROJETO NO ANEXO ABAIXO!

![index](https://github.com/OziasFilipe/aspnetCore_apresentacaoN1/assets/43150504/88e887c6-4d09-4598-b7e3-7c16b5b34f61)

![novo](https://github.com/OziasFilipe/aspnetCore_apresentacaoN1/assets/43150504/f573e0b6-3032-48b0-994c-4a769c3f6592)

![atualizar](https://github.com/OziasFilipe/aspnetCore_apresentacaoN1/assets/43150504/3a999d47-4d1f-401e-828c-0d328a308143)

![filtros avancados](https://github.com/OziasFilipe/aspnetCore_apresentacaoN1/assets/43150504/1ad042ca-d984-411d-b88c-84ce0f3301ac)

![deletar](https://github.com/OziasFilipe/aspnetCore_apresentacaoN1/assets/43150504/37c4b7fb-6488-47d1-b5ae-10277fbb84e7)

![api](https://github.com/OziasFilipe/aspnetCore_apresentacaoN1/assets/43150504/8cad4ba3-669f-4745-a027-e0dcbe0ccd65)






