using Domain.Contracts.UseCases.AddCustomer;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.AddCustomer;
using WebApi.Models.Error;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddCustomerController : ControllerBase
    {
        private readonly IAddCustomerUseCase _addCustomerUseCase;
        private readonly IValidator<AddCustomerInput> _addCustomerInputValidator;

        public AddCustomerController(IAddCustomerUseCase addCustomerUseCase, IValidator<AddCustomerInput> addCustomerInputValidator)
        {
            _addCustomerUseCase = addCustomerUseCase;
            _addCustomerInputValidator = addCustomerInputValidator;
        }

        [HttpPost]
        public IActionResult AddCustomer(AddCustomerInput input)
        {
            var validationResult = _addCustomerInputValidator.Validate(input);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors.ToCustomValidationFailure());
            }
           
            var customer = new Domain.Entities.Customer(input.Codigo, input.NomeFantasia,input.CpfCnpj, input.RG_IE, input.Tipo, input.Cep, input.Logradouro, input.Numero, input.Complemento, input.Bairro, input.Municipio, input.UnidadeFederativa, input.Email, input.Telefone, input.Telefone);

            _addCustomerUseCase.AddCustomer(customer);

            return Created("", customer);
        }

        [HttpGet]
        public IActionResult GetAllCustomer()
        {
            var customers = _addCustomerUseCase.GetAllCustomers();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public IActionResult GetCustomer(int id)
        {
            var customer = _addCustomerUseCase.GetCustomerById(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [HttpGet("codigo/{codigo}")]
        public IActionResult GetCustomerByCodigo(string codigo)
        {
            var customer = _addCustomerUseCase.GetCustomerByCodigo(codigo);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [HttpGet("documento/{cpfcnpj}")]
        public IActionResult GetCustomerByCpfCnpj(string cpfcnpj)
        {
            var customer = _addCustomerUseCase.GetCustomerByCpfCnpj(cpfcnpj);
            if(customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }
        [HttpGet("RazaoSocial/{razaoSocial}")]
        public IActionResult GetCustomerByRazaoSocial(string razaoSocial)
        {
            var customer = _addCustomerUseCase.GetCustomerByRazaoSocial(razaoSocial);
            return Ok(customer);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            _addCustomerUseCase.DeleteCustomerById(id);
            return NoContent();
        }
    }


}

