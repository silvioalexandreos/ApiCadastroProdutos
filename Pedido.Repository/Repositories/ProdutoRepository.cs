using Pedido.Domain.Dtos;
using Pedido.Domain.Entities;
using Pedido.Interface.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pedido.Repository
{
    public class ProdutoRepository : BaseRepository, IProdutoRepository
    {
        public ProdutoRepository(ApplicationDbContext context) : base(context)
        {
        }

        public List<Produto> Get()
        {
            return _context.Produtos.ToList();
        }

        public Produto GetId(long id)
        {
            if (id <= 0) return null;

            var query = _context.Produtos.Where(x => x.Ativo == true && x.Id == id).FirstOrDefault();
            return query;
        }

        public Produto GetDescricao(string descricao)
        {
            if (descricao == null) return null;

            var query = _context.Produtos.Where(x => x.Ativo == true && x.Descricao == descricao).FirstOrDefault();
            return query;
        }

        public List<Produto> GetCategoria(string categoria)
        {
            if (categoria == null) return null;

            var query = _context.Produtos.Where(x => x.Categoria.ToUpper() == categoria.ToUpper()).ToList();
            List<Produto> produtos = new List<Produto>();

            foreach (var item in query)
            {
                produtos.Add(item);
            }
            return produtos.ToList();
        }

        public long Alterar(ProdutoDTO produto)
        {
            var entity = _context.Produtos.Find(produto.Id);

            if (entity == null)
            {
                return 0;
            }

            entity.Descricao = produto.Descricao;
            entity.Categoria = produto.Categoria;
            entity.QtdeProduto = produto.QtdeProduto;
            entity.Preco = produto.Preco;
            entity.Ativo = produto.Ativo;
            entity.DataAtualizacao = DateTime.Now;

            try
            {
                _context.Produtos.Update(entity);
                _context.SaveChanges();

                return entity.Id;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public long Criar(ProdutoDTO produto)
        {
            var entity = new Produto()
            {
                Descricao = produto.Descricao.ToUpper(),
                Categoria = produto.Categoria.ToUpper(),
                QtdeProduto = produto.QtdeProduto,
                Preco = produto.Preco,
                DataCadastro = DateTime.Now,
                Ativo = true
            };

            try
            {
                _context.Produtos.Add(entity);
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
            if (id <= 0)
            {
                return false;
            }

            var entity = _context.Produtos.Find(id);

            if (entity == null)
            {
                return false;
            }

            try
            {
                entity.Ativo = false;
                _context.Produtos.Update(entity);
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
