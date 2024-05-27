using FluentValidation;

namespace Gestao_de_Clientes.Models.AddCustomer
{
    public class AddCustomerInputValidator : AbstractValidator<AddCustomerInput>
    {
        public AddCustomerInputValidator()
        {
            RuleFor(c => c.NomeFantasia).NotEmpty();
            RuleFor(c => c.Codigo).NotEmpty();
            RuleFor(c => c.CpfCnpj).NotEmpty();
            RuleFor(c => c.Tipo).NotEmpty();
            RuleFor(c => c.Cep).NotEmpty();
            RuleFor(c => c.Telefone).NotEmpty();
            RuleFor(c => c.Email).EmailAddress();
           // RuleFor(c => c.Document).IsValidCPF().WithMessage("'Document' é um CPF inválido.");
        }
    }
}
