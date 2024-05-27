namespace Gestao_de_Clientes.Models.AddCustomer
{

    public class AddCustomerInput
    {
        public int id { get; }
        public string Codigo { get;  set; } = string.Empty;
        public string NomeFantasia { get;  set; } = string.Empty;
        public string RazaoSocial { get;  set; } = string.Empty;
        public string CpfCnpj { get;  set; } = string.Empty;
        public string RG_IE { get;  set; } = string.Empty;
        public string Tipo { get;  set; } = string.Empty;
        public string Cep { get;  set; } = string.Empty;
        public string Logradouro { get;  set; } = string.Empty;
        public string Numero { get;  set; } = string.Empty;
        public string Complemento { get; set; } = string.Empty;
        public string Bairro { get;  set; } = string.Empty;
        public string Municipio { get;  set; } = string.Empty;
        public string UnidadeFederativa { get;  set; } = string.Empty;
        public string Email { get;  set; } = string.Empty;
        public string Telefone { get;  set; } = string.Empty;
        public DateTime DataInclusao { get; }
        public DateTime DataAlteracao { get;  }


        public bool IsValid()
        {
            return
                Codigo != string.Empty && Codigo != null &&
                Email != string.Empty && Email.Contains("@") && Email.Contains(".") &&
                Tipo != string.Empty && Tipo != null &&
                CpfCnpj != string.Empty && CpfCnpj != null &&
                RazaoSocial != string.Empty && RazaoSocial != null &&
                Cep != string.Empty && Cep != null &&
                Telefone != string.Empty && Telefone != null;
               
        }
    }
}
