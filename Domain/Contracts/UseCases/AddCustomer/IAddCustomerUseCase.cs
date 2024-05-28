using Domain.Entities;

namespace Domain.Contracts.UseCases.AddCustomer
{
    public interface IAddCustomerUseCase
    {
        void AddCustomer(Customer customer);
        void PutCustomer(Customer customer);
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        Customer GetCustomerByCodigo(string codigo);
        Customer GetCustomerByCpfCnpj(string cpfcnpj);
        Customer GetCustomerByRazaoSocial(string razaoSocial);

        void DeleteCustomerById(int id);
    }
}
