namespace WebApi.Models.AddCustomer
{
    public class AddCustomerInput
    {
        public int id { get; set; }
        public string Codigo { get;  set; } = string.Empty;
        public string NomeFantasia { get;  set; } = string.Empty;
        public string RazaoSocial { get; private set; } = string.Empty;
        public string CpfCnpj { get;  set; } = string.Empty;
        public string RG_IE { get;  set; } = string.Empty;
        public string Tipo { get;  set; } = string.Empty;
        public string Cep { get;  set; } = string.Empty;
        public string Logradouro { get; private set; } = string.Empty;
        public string Numero { get; private set; } = string.Empty;
        public string Complemento { get; private set; } = string.Empty;
        public string Bairro { get;  set; } = string.Empty;
        public string Municipio { get;  set; } = string.Empty;
        public string UnidadeFederativa { get;  set; } = string.Empty;
        public string Email { get;  set; } = string.Empty;
        public string Telefone { get;  set; } = string.Empty;
        public DateTime DataInclusao { get; set; }
        public DateTime DataAlteracao { get; set; }


        public bool IsValid()
        {
            return Codigo != string.Empty &&
                Email != string.Empty && Email.Contains("@") && Email.Contains(".");
                //Document != string.Empty;
        }
    }
}
