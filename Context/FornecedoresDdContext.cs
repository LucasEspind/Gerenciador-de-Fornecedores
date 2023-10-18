using Microsoft.EntityFrameworkCore;
using Sistema_de_Cadastro_de_Fornecedor.Models;

namespace Sistema_de_Cadastro_de_Fornecedor.Context
{
    public class FornecedoresDdContext : DbContext
    {
        public FornecedoresDdContext(DbContextOptions<FornecedoresDdContext> options) : base(options)
        {
            
        }

        public DbSet<FornecedoresModel> Fornecedores { get; set; } 
    }
}
