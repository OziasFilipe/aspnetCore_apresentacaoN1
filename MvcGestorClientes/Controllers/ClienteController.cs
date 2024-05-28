
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain.Contracts.UseCases.AddCustomer;
using FluentValidation;
using Gestao_de_Clientes.Models.AddCustomer;



namespace Gestao_de_Clientes.Controllers
{
    public class ClienteController : Controller
    {


		private readonly IAddCustomerUseCase _addCustomerUseCase;
		private readonly IValidator<AddCustomerInput> _addCustomerInputValidator;

		public ClienteController(IAddCustomerUseCase addCustomerUseCase, IValidator<AddCustomerInput> addCustomerInputValidator)
		{
			_addCustomerUseCase = addCustomerUseCase;
			_addCustomerInputValidator = addCustomerInputValidator;
		}

		// GET: Cliente
		public  IActionResult Index()
        {
		var customers = _addCustomerUseCase.GetAllCustomers();
			
			return View(customers);
        }

       
      

        [HttpPost]
        public IActionResult Create(AddCustomerInput input)
        {
            var validationResult = _addCustomerInputValidator.Validate(input);

            if (!validationResult.IsValid)
            {
               // return BadRequest(validationResult.Errors.ToCustomValidationFailure());
            }

            var customer = new Domain.Entities.Customer(input.id, input.Codigo, input.NomeFantasia, input.RazaoSocial, input.CpfCnpj, input.RG_IE, input.Tipo, input.Cep, input.Logradouro, input.Numero, input.Complemento, input.Bairro, input.Municipio, input.UnidadeFederativa, input.Email, input.Telefone, input.DataInclusao, input.DataAlteracao);

            _addCustomerUseCase.AddCustomer(customer);

            return Redirect("./index");
        }

       
        public IActionResult Delete(int id)
        {
            _addCustomerUseCase.DeleteCustomerById(id);
            return RedirectToAction("Index", "Cliente");
        }


        public IActionResult GetEdit(int id)
        {
            var customer = _addCustomerUseCase.GetCustomerById(id);
            if (customer == null)
            {
                return NotFound();
            }

            return Json(customer);
        }

        [HttpPost]
        public IActionResult Update(AddCustomerInput input)
        {
            var validationResult = _addCustomerInputValidator.Validate(input);

            if (!validationResult.IsValid)
            {
                //return BadRequest(validationResult.Errors.ToCustomValidationFailure());
            }

            var customer = new Domain.Entities.Customer(input.id, input.Codigo, input.NomeFantasia, input.RazaoSocial, input.CpfCnpj, input.RG_IE, input.Tipo, input.Cep, input.Logradouro, input.Numero, input.Complemento, input.Bairro, input.Municipio, input.UnidadeFederativa, input.Email, input.Telefone, input.DataInclusao, input.DataAlteracao);

            _addCustomerUseCase.PutCustomer(customer);

            return RedirectToAction("Index", "Cliente");
        }


    }
}
