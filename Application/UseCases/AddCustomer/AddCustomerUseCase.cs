using Domain.Contracts.Repositories.AddCustomer;
using Domain.Contracts.UseCases.AddCustomer;
using Domain.Entities;

namespace Application.UseCases.AddCustomer
{
    public class AddCustomerUseCase : IAddCustomerUseCase
    {
        private readonly IAddCustomerRepository _addCustomerRepository;

        public AddCustomerUseCase(IAddCustomerRepository addCustomerRepository)
        {
            _addCustomerRepository = addCustomerRepository;
        }

        public void AddCustomer(Customer customer)
        {
            _addCustomerRepository.AddCustomer(customer);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _addCustomerRepository.GetAllCustomers();
        }

        public Customer GetCustomerById(int id)
        {
            return _addCustomerRepository.GetCustomerById(id);
        }
        public Customer GetCustomerByCodigo(string codigo)
        {
            return _addCustomerRepository.GetCustomerByCodigo(codigo);
        }
        public Customer GetCustomerByCpfCnpj(string cpfcnpj)
        {
            return _addCustomerRepository.GetCustomerByCpfCnpj(cpfcnpj);
        }
        public Customer GetCustomerByRazaoSocial(string razaoSocial)
        {
            return _addCustomerRepository.GetCustomerByRazaoSocial(razaoSocial);
        }

        public void  DeleteCustomerById(int id)
        {
             _addCustomerRepository.DeleteCustomerById(id);
        }
    }
}
