using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gestao_de_Clientes.Conexao;
using Gestao_de_Clientes.Models;

namespace Gestao_de_Clientes.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ConexaoBD _context;

        public ClienteController(ConexaoBD context)
        {
            _context = context;
        }

        // GET: Cliente
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clientes.ToListAsync());
        }

        // GET: Cliente/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clienteModel = await _context.Clientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clienteModel == null)
            {
                return NotFound();
            }

            return View(clienteModel);
        }

        // GET: Cliente/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Codigo,NomeFantasia,NomeRazaoSocial,CPFCNPJ,RGIE,Tipo,CEP,Logradouro,Numero,Complemento,Bairro,Municipio,UnidadeFederativa,Email,Telefone,Inclusao,Alteracao")] ClienteModel clienteModel)
        {
            if (ModelState.IsValid)
            {
                
                clienteModel.Inclusao = DateTime.Today;
                clienteModel.Alteracao = DateTime.Today;

                _context.Add(clienteModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clienteModel);
        }


        // GET: Cliente/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clienteModel = await _context.Clientes.FindAsync(id);
            if (clienteModel == null)
            {
                return NotFound();
            }
            return View(clienteModel);
        }

        // POST: Cliente/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Codigo,NomeFantasia,NomeRazaoSocial,CPFCNPJ,RGIE,Tipo,CEP,Logradouro,Numero,Complemento,Bairro,Municipio,UnidadeFederativa,Email,Telefone,Inclusao,Alteracao")] ClienteModel clienteModel)
        {
            if (id != clienteModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clienteModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteModelExists(clienteModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(clienteModel);
        }

        // GET: Cliente/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clienteModel = await _context.Clientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clienteModel == null)
            {
                return NotFound();
            }

            return View(clienteModel);
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clienteModel = await _context.Clientes.FindAsync(id);
            if (clienteModel != null)
            {
                _context.Clientes.Remove(clienteModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteModelExists(int id)
        {
            return _context.Clientes.Any(e => e.Id == id);
        }

        [HttpGet]
        public IActionResult Pesquisar(string filtroCodigo, string filtroCPFCNPJ, string filtroNomeRazaoSocial)
        {
            var clientes = _context.Clientes.Where(c =>
                (string.IsNullOrEmpty(filtroCodigo) || c.Codigo.Contains(filtroCodigo)) &&
                (string.IsNullOrEmpty(filtroCPFCNPJ) || c.CPFCNPJ.Contains(filtroCPFCNPJ)) &&
                (string.IsNullOrEmpty(filtroNomeRazaoSocial) || c.NomeRazaoSocial.Contains(filtroNomeRazaoSocial))
            ).ToList();

            return Json(clientes);
        }


    }
}
