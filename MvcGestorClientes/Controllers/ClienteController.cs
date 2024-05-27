
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
		public async Task<IActionResult> Index()
        {
		var customers = _addCustomerUseCase.GetAllCustomers();
			
			return View(customers);
        }

       
        // GET: Cliente/Create
        public IActionResult Create()
        {
            return View();
        }


    

    }
}
