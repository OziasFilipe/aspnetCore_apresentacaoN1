namespace Domain.Entities
{
    public class Customer
    {
        public Customer() { } // Construtor sem parâmetros

        public Customer(string codigo, string nomeFantasia, string razaoSocial, string cpfCnpj, string rG_IE, string tipo, string cep, string logradouro, string numero, string complemento, string bairro, string municipio, string unidadeFederativa, string email, string telefone, DateTime dataInclusao, DateTime dataAlteracao)
        {
            Codigo = codigo ?? throw new ArgumentNullException(nameof(codigo));
            NomeFantasia = nomeFantasia ?? throw new ArgumentNullException(nameof(nomeFantasia));
            RazaoSocial = razaoSocial ?? throw new ArgumentNullException(nameof(razaoSocial));
            CpfCnpj = cpfCnpj ?? throw new ArgumentNullException(nameof(cpfCnpj));
            RG_IE = rG_IE ?? throw new ArgumentNullException(nameof(rG_IE));
            Tipo = tipo ?? throw new ArgumentNullException(nameof(tipo));
            Cep = cep ?? throw new ArgumentNullException(nameof(cep));
            Logradouro = logradouro ?? throw new ArgumentNullException(nameof(logradouro));
            Numero = numero ?? throw new ArgumentNullException(nameof(numero));
            Complemento = complemento ?? throw new ArgumentNullException(nameof(complemento));
            Bairro = bairro ?? throw new ArgumentNullException(nameof(bairro));
            Municipio = municipio ?? throw new ArgumentNullException(nameof(municipio));
            UnidadeFederativa = unidadeFederativa ?? throw new ArgumentNullException(nameof(unidadeFederativa));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Telefone = telefone ?? throw new ArgumentNullException(nameof(telefone));
            DataInclusao = dataInclusao;
            DataAlteracao = dataAlteracao;
        }

        public string Codigo { get; private set; }
        public string NomeFantasia { get; private set; }
        public string RazaoSocial { get; private set; }
        public string CpfCnpj { get; private set; }
        public string RG_IE { get; private set; }
        public string Tipo { get; private set; }
        public string Cep { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Municipio { get; private set; }
        public string UnidadeFederativa { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public DateTime DataInclusao { get; private set; }
        public DateTime DataAlteracao { get; private set; }
    }
}
