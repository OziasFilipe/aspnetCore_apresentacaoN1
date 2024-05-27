using Domain.Entities;

namespace Domain.Contracts.Repositories.AddCustomer
{
    public interface IAddCustomerRepository
    {
        void AddCustomer(Customer customer);
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        Customer GetCustomerByCodigo(string codigo);
        Customer GetCustomerByCpfCnpj(string cpfcnpj);
        Customer GetCustomerByRazaoSocial(string razaoSocial);
        void DeleteCustomerById(int id);


    }
}
