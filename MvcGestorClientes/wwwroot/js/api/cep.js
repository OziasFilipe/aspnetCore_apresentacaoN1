function BuscarCep() {

    let cep = document.getElementById("cep").value;
   
    if (cep && cep.length >= 8) { 
 
        fetch(`https://viacep.com.br/ws/${cep}/json/`)
            .then(response => {
               
                if (!response.ok) {
                    throw new Error('Erro ao buscar o CEP');
                }
               
                return response.json();
            })
            .then(data => {
               
                if (data.cep) {
                   
                    let endereco = data;
                    ImplantarCampos(endereco);
                   
                } else {
                    console.log('CEP não encontrado');
                }
            })
            .catch(error => {
                console.error('Ocorreu um erro:', error);
            });
    } else {
        console.error('O CEP fornecido é inválido');
    }
}


function ImplantarCampos(endereco)
{
    console.log(endereco); // Exibe os dados do endereço no console

    document.getElementById("logradouro").value = endereco.logradouro;
    document.getElementById("bairro").value = endereco.bairro;
    document.getElementById("complemento").value = endereco.complemento;
    document.getElementById("unidade-federativa").value = endereco.uf; 
    document.getElementById("municipio").value =  endereco.localidade

}