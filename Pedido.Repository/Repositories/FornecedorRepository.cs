using Pedido.Domain.Dtos;
using Pedido.Domain.Entities;
using Pedido.Interface.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pedido.Repository
{
    public class FornecedorRepository : BaseRepository, IFornecedorRepository
    {
        public FornecedorRepository(ApplicationDbContext context) : base(context)
        {
        }

        public List<Fornecedor> Get()
        {
            return _context.Fornecedores.ToList();
        }

        public Fornecedor GetId(long id)
        {
            return _context.Fornecedores.Where(x => x.Id == id).FirstOrDefault();
        }

        public Fornecedor GetNome(string nome)
        {
            return _context.Fornecedores.Where(x => x.Nome == nome).FirstOrDefault();
        }

        public List<Produto> GetProduto(long Id)
        {
            var query = _context.Produtos.Where(x => x.IdFornecedor == Id).ToList();

            List<Produto> produtosFornecedor = new List<Produto>();

            foreach (var item in query)
            {
                produtosFornecedor.Add(item);
            }

            return produtosFornecedor.ToList();
        }

        public long Criar(FornecedorDTO fornecedor)
        {

            var entity = new Fornecedor()
            {
                Nome = fornecedor.Nome,
                NomeFantasia = fornecedor.NomeFantasia,
                DataCadastro = DateTime.Now,
                Ativo = true
            };
            try
            {
                _context.Fornecedores.Add(entity);
                _context.SaveChanges();

                return entity.Id;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public long Alterar(FornecedorDTO fornecedor)
        {
            var entity = _context.Fornecedores.Find(fornecedor.Id);
            if (entity.Id <= 0)
            {
                return 0;
            }

            entity.Nome = fornecedor.Nome;
            entity.NomeFantasia = fornecedor.NomeFantasia;
            entity.Ativo = fornecedor.Ativo;
            entity.DataAtualizacao = DateTime.Now;

            try
            {
                _context.Fornecedores.Update(entity);
                _context.SaveChanges();

                return entity.Id;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Deletar(long id)
        {
            var query = _context.Fornecedores.Find(id);

            if (query.Id <= 0)
            {
                return false;
            }

            try
            {
                _context.Fornecedores.Remove(query);
                _context.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
