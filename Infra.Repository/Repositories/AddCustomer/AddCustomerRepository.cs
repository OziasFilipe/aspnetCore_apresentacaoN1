using Dapper;
using Domain.Contracts.Repositories.AddCustomer;
using Domain.Entities;
using Infra.Repository.DbContext;
using System.Data.SqlClient;

namespace Infra.Repository.Repositories.AddCustomer
{
    public class AddCustomerRepository : IAddCustomerRepository
    {
        private readonly IDbContext _dbContext;

        public AddCustomerRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddCustomer(Customer customer)
        {
            var query =
                "INSERT INTO Clientes(Codigo, NomeAbrevido_Fantasia, Nome_RazaoSocial, CPF_CNPJ, RG_IE, Tipo, Cep, Logradouro, Numero, Complemento, Bairro, Municipio, Unidade_Federativa, Email, Telefone, Data_Inclusao, Data_Alteracao)" +
                " VALUES (@codigo, @nomeFantasia, @nomeRazaoSocial, @cpfcnpj, @rgIe, @tipo, @cep, @logradouro, @numero, @complemento, @bairro, @municipio, @unidadeFederativa, @email, @telefone, @criacao, @alteracao)";
            // var query = "INSERT INTO Cliente(NomeAbrevido_Fantasia, Email) VALUES(@name, @email)";

            var parameters = new DynamicParameters();
            parameters.Add("codigo", customer.Codigo, System.Data.DbType.String);
            parameters.Add("nomeFantasia", customer.NomeFantasia, System.Data.DbType.String);
            parameters.Add("nomeRazaoSocial", customer.RazaoSocial, System.Data.DbType.String);
            parameters.Add("cpfcnpj", customer.CpfCnpj, System.Data.DbType.String);
            parameters.Add("rgIe", customer.RG_IE, System.Data.DbType.String);
            parameters.Add("tipo", customer.Tipo, System.Data.DbType.String);
            parameters.Add("cep", customer.Cep, System.Data.DbType.String);
            parameters.Add("logradouro", customer.Logradouro, System.Data.DbType.String);
            parameters.Add("numero", customer.Numero, System.Data.DbType.String);
            parameters.Add("complemento", customer.Complemento, System.Data.DbType.String);
            parameters.Add("bairro", customer.Bairro, System.Data.DbType.String);
            parameters.Add("municipio", customer.Municipio, System.Data.DbType.String);
            parameters.Add("unidadeFederativa", customer.UnidadeFederativa, System.Data.DbType.String);
            parameters.Add("email", customer.Email, System.Data.DbType.String);
            parameters.Add("telefone", customer.Telefone, System.Data.DbType.String);

            parameters.Add("alteracao", DateTime.Now, System.Data.DbType.DateTime);
            parameters.Add("criacao", DateTime.Now, System.Data.DbType.DateTime);

            using var connection = _dbContext.CreateConnection();

            connection.Execute(query, parameters);
        }

        public void PutCustomer(Customer customer)
        {
            var query = "UPDATE Clientes SET " +  "NomeAbrevido_Fantasia = @nomeFantasia, " + "Nome_RazaoSocial = @nomeRazaoSocial, " + "CPF_CNPJ = @cpfcnpj, " +
                        "RG_IE = @rgIe, " + "Tipo = @tipo, " + "Cep = @cep, " + "Logradouro = @logradouro, " +  "Numero = @numero, " +
                        "Complemento = @complemento, " +  "Bairro = @bairro, " +  "Municipio = @municipio, " + "Unidade_Federativa = @unidadeFederativa, " +  "Email = @email, " + "Telefone = @telefone, " +  "Data_Alteracao = @alteracao " +  "WHERE Id = @id";

            var parameters = new DynamicParameters();
            parameters.Add("id",customer.Id, System.Data.DbType.String);
            parameters.Add("codigo", customer.Codigo, System.Data.DbType.String);
            parameters.Add("nomeFantasia", customer.NomeFantasia, System.Data.DbType.String);
            parameters.Add("nomeRazaoSocial", customer.RazaoSocial, System.Data.DbType.String);
            parameters.Add("cpfcnpj", customer.CpfCnpj, System.Data.DbType.String);
            parameters.Add("rgIe", customer.RG_IE, System.Data.DbType.String);
            parameters.Add("tipo", customer.Tipo, System.Data.DbType.String);
            parameters.Add("cep", customer.Cep, System.Data.DbType.String);
            parameters.Add("logradouro", customer.Logradouro, System.Data.DbType.String);
            parameters.Add("numero", customer.Numero, System.Data.DbType.String);
            parameters.Add("complemento", customer.Complemento, System.Data.DbType.String);
            parameters.Add("bairro", customer.Bairro, System.Data.DbType.String);
            parameters.Add("municipio", customer.Municipio, System.Data.DbType.String);
            parameters.Add("unidadeFederativa", customer.UnidadeFederativa, System.Data.DbType.String);
            parameters.Add("email", customer.Email, System.Data.DbType.String);
            parameters.Add("telefone", customer.Telefone, System.Data.DbType.String);

            parameters.Add("alteracao", DateTime.Now, System.Data.DbType.DateTime);
            parameters.Add("criacao", DateTime.Now, System.Data.DbType.DateTime);

            using var connection = _dbContext.CreateConnection();

            connection.Execute(query, parameters);
        }
        public IEnumerable<Customer> GetAllCustomers()
        {
            string query = "SELECT * FROM Clientes";
            using var connection = _dbContext.CreateConnection();

            return connection.Query<Customer>(query);
        }

        public Customer GetCustomerById(int id)
        {
            string query = "SELECT * FROM Clientes WHERE Id = @Id";
            using var connection = _dbContext.CreateConnection();
            return connection.QuerySingleOrDefault<Customer>(query, new { Id = id });
        }

        public Customer GetCustomerByCodigo(string codigo)
        {
            string query = "SELECT * FROM Clientes WHERE Codigo = @Cod";
            using var connection = _dbContext.CreateConnection();
            return connection.QuerySingleOrDefault<Customer>(query, new { Cod = codigo });
        }


        public Customer GetCustomerByRazaoSocial(string razaoSocial)
        {
            string query = "SELECT * FROM Clientes WHERE Nome_RazaoSocial = @RazaoSocial";
            using var connection = _dbContext.CreateConnection();
            return connection.QuerySingleOrDefault<Customer>(query, new { RazaoSocial = razaoSocial });
        }

        public Customer GetCustomerByCpfCnpj(string cpfCnpj)
        {
            string query = "SELECT * FROM Clientes WHERE CPF_CNPJ = @CnpjCpf";
            using var connection = _dbContext.CreateConnection();
            return connection.QuerySingleOrDefault<Customer>(query, new { CnpjCpf = cpfCnpj });
        }

      
        public void DeleteCustomerById(int id)
        {
            string query = "DELETE FROM Clientes WHERE Id = @Id";
            using var connection = _dbContext.CreateConnection();
            connection.Execute(query, new { Id = id });
        }
        
    }
}
