namespace Domain.Entities
{
    public class Customer
    {
        public Customer() { } // Construtor sem parâmetros

        public Customer(int id, string codigo, string nomeFantasia, string razaoSocial, string cpfCnpj, string rG_IE, string tipo, string cep, string logradouro, string numero, string complemento, string bairro, string municipio, string unidadeFederativa, string email, string telefone, DateTime dataInclusao, DateTime dataAlteracao)
        {
            Id = id;
            Codigo = codigo;
            NomeFantasia = nomeFantasia;
            RazaoSocial = razaoSocial;
            CpfCnpj = cpfCnpj;
            RG_IE = rG_IE;
            Tipo = tipo;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Municipio = municipio;
            UnidadeFederativa = unidadeFederativa;
            Email = email;
            Telefone = telefone;
            DataInclusao = dataInclusao;
            DataAlteracao = dataAlteracao;


        }

        public int Id { get; private set; }
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
