function ValidationInputCPFCNPJ() {
    const input = document.getElementById("cpf-cnpj");


    input.addEventListener("input", function (e) {
        let value = e.target.value.replace(/\D/g, '');
        if (value.length <= 11) {
            value = value.replace(/(\d{3})(\d)/, "$1.$2");
            value = value.replace(/(\d{3})(\d)/, "$1.$2");
            value = value.replace(/(\d{3})(\d{1,2})$/, "$1-$2");
        } else {
            value = value.replace(/^(\d{2})(\d)/, "$1.$2");
            value = value.replace(/^(\d{2})\.(\d{3})(\d)/, "$1.$2.$3");
            value = value.replace(/\.(\d{3})(\d)/, ".$1/$2");
            value = value.replace(/(\d{4})(\d{1,2})$/, "$1-$2");
        }
        e.target.value = value;
    });
}


function ValidationCep() {
    const input = document.getElementById("cep");

    input.addEventListener("input", function (e) {
        let value = e.target.value.replace(/\D/g, '');
        if (value.length > 5) {
            value = value.replace(/^(\d{5})(\d)/, "$1-$2");
        }
        e.target.value = value;
    });
}


function ValidationTelefone() {
    const input = document.getElementById("telefone");

    input.addEventListener("input", function (e) {
        let value = e.target.value.replace(/\D/g, '');
        if (value.length > 10) {
            value = value.replace(/^(\d{2})(\d{5})(\d{4})$/, "($1) $2-$3");
        } else {
            value = value.replace(/^(\d{2})(\d{4})(\d{4})$/, "($1) $2-$3");
        }
        e.target.value = value;
    });
}


function EditValidationInputCPFCNPJ() {
    const input = document.getElementById("edit-cpf-cnpj");


    input.addEventListener("input", function (e) {
        let value = e.target.value.replace(/\D/g, '');
        if (value.length <= 11) {
            value = value.replace(/(\d{3})(\d)/, "$1.$2");
            value = value.replace(/(\d{3})(\d)/, "$1.$2");
            value = value.replace(/(\d{3})(\d{1,2})$/, "$1-$2");
        } else {
            value = value.replace(/^(\d{2})(\d)/, "$1.$2");
            value = value.replace(/^(\d{2})\.(\d{3})(\d)/, "$1.$2.$3");
            value = value.replace(/\.(\d{3})(\d)/, ".$1/$2");
            value = value.replace(/(\d{4})(\d{1,2})$/, "$1-$2");
        }
        e.target.value = value;
    });
}


function EditValidationCep() {
    const input = document.getElementById("edit-cep");

    input.addEventListener("input", function (e) {
        let value = e.target.value.replace(/\D/g, '');
        if (value.length > 5) {
            value = value.replace(/^(\d{5})(\d)/, "$1-$2");
        }
        e.target.value = value;
    });
}


function EditValidationTelefone() {
    const input = document.getElementById("edit-telefone");

    input.addEventListener("input", function (e) {
        let value = e.target.value.replace(/\D/g, '');
        if (value.length > 10) {
            value = value.replace(/^(\d{2})(\d{5})(\d{4})$/, "($1) $2-$3");
        } else {
            value = value.replace(/^(\d{2})(\d{4})(\d{4})$/, "($1) $2-$3");
        }
        e.target.value = value;
    });
}


function FiltroValidationInputCPFCNPJ() {
    const input = document.getElementById("filtroCPFCNPJ");


    input.addEventListener("input", function (e) {
        let value = e.target.value.replace(/\D/g, '');
        if (value.length <= 11) {
            value = value.replace(/(\d{3})(\d)/, "$1.$2");
            value = value.replace(/(\d{3})(\d)/, "$1.$2");
            value = value.replace(/(\d{3})(\d{1,2})$/, "$1-$2");
        } else {
            value = value.replace(/^(\d{2})(\d)/, "$1.$2");
            value = value.replace(/^(\d{2})\.(\d{3})(\d)/, "$1.$2.$3");
            value = value.replace(/\.(\d{3})(\d)/, ".$1/$2");
            value = value.replace(/(\d{4})(\d{1,2})$/, "$1-$2");
        }
        e.target.value = value;
    });
}

document.addEventListener("DOMContentLoaded", function () {
    ValidationInputCPFCNPJ();
    ValidationCep();
    ValidationTelefone();

    EditValidationInputCPFCNPJ();
    EditValidationCep();
    EditValidationTelefone();

    FiltroValidationInputCPFCNPJ();
});
