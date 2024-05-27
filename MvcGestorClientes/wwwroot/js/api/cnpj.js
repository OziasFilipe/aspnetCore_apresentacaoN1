/**
 * Consulta um CNPJ
 */
consultaCNPJ("02.484.348/0001-27");
function consultaCNPJ(cnpj) {
    // Limpa o CNPJ para conter somente numeros, removendo traços e pontos
    cnpj = cnpj.replace(/\D/g, '');

    // Consulta o CNPJ na ReceitaWS com 60 segundos de tempo limite
    return jsonp('https://www.receitaws.com.br/v1/cnpj/' + encodeURI(cnpj), 60000)
        .then((json) => {
            if (json['status'] === 'ERROR') {
                return Promise.reject(json['message']);
            } else {
                return Promise.resolve(json);
            }
        });
}