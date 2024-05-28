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
    console.log(dados); // Exibe os dados do endereço no console

    document.getElementById("razao-social").value = dados.nome;
    document.getElementById("logradouro").value = dados.logradouro;
    document.getElementById("bairro").value = dados.bairro;
    document.getElementById("complemento").value = dados.complemento;
    document.getElementById("unidade-federativa").value = dados.uf;
    document.getElementById("municipio").value = dados.municipio;
    document.getElementById("numero").value = dados.numero;
    document.getElementById("cep").value = dados.cep;
    document.getElementById("email").value = dados.email;
    document.getElementById("telefone").value = dados.telefone;
}


