async function consultarCNPJ() {
    // cnpj teste = 02484348000127

    let cnpj = document.getElementById("cpf-cnpj").value;
    cnpj = cnpj.replace(/\D/g, '');
    const apiUrl = `/api/consulta-cnpj/${cnpj}` ;

    try {
        const response = await fetch(apiUrl);
        if (!response.ok) {
            throw new Error('Erro na consulta da API');
        }
        const data = await response.json();

        if (data.status != "ERROR")
        {
            ImplantarCampos(data);

        }
        console.log(data);

        document.getElementById('resultado').textContent = JSON.stringify(data, null, 2);
    } catch (error) {
        console.error('Erro:', error);
        document.getElementById('resultado').textContent = 'Erro ao consultar CNPJ: ' + error.message;
    }
}



function ImplantarCampos(dados) {
    console.log(dados); // Exibe os dados do endere�o no console

    document.getElementById("razao-social").value = dados.nome == undefined ? "" : dados.nome;
    document.getElementById("logradouro").value = dados.logradouro == undefined ? "" : dados.logradouro;;
    document.getElementById("bairro").value = dados.bairro == undefined ? "" : dados.bairro;;
    document.getElementById("complemento").value = dados.complemento == undefined ? "" : dados.complemento;
    document.getElementById("unidade-federativa").value = dados.uf == undefined ? "" : dados.uf;
    document.getElementById("municipio").value = dados.municipio == undefined ? "" : dados.municipio;
    document.getElementById("numero").value = dados.numero == undefined ? "" : dados.numero;
    document.getElementById("cep").value = dados.cep == undefined ? "" : dados.cep;
    document.getElementById("email").value = dados.email == undefined ? "" : dados.email;
    document.getElementById("telefone").value = dados.telefone == undefined ? "" : dados.telefone;
}


