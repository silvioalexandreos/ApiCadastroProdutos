using CadProdutoBusiness.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace CadProdutoData
{
    public class Connection : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-HU6IVHI5;Initial Catalog=EstoqueProduto;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
