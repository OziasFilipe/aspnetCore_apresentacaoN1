function BuscarCNPJ() {
    var cnpj = document.getElementById("cpf/cnpj"); // CNPJ para buscar
    fetch(`https://www.receitaws.com.br/v1/cnpj/${cnpj}`, {
        method: 'GET',
        mode: 'cors',
        headers: {
            'Content-Type': 'application/json',
            'Access-Control-Allow-Origin': '*'
        }
    })
        .then(response => {
            if (!response.ok) {
                throw new Error('Erro ao buscar CNPJ: ' + response.status);
            }
            return response.json();
        })
        .then(data => {
            console.log(data);
            // Faça o que desejar com os dados da resposta
        })
        .catch(error => {
            console.error('Erro ao buscar CNPJ:', error);
        });
}