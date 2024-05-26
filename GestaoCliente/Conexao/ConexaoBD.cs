using Gestao_de_Clientes.Models;
using Microsoft.EntityFrameworkCore;

namespace Gestao_de_Clientes.Conexao
{
    public class ConexaoBD : DbContext
    {
      
            public ConexaoBD(DbContextOptions<ConexaoBD> options) : base(options)
            {
            }

            public DbSet<ClienteModel> Clientes { get; set; }
        
    }
}
