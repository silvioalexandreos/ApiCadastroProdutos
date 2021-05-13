using Microsoft.AspNetCore.Mvc;
using Pedido.Domain.Dtos;
using Pedido.Domain.Entities;
using Pedido.Interface.Repositories;
using System.Collections.Generic;

namespace Pedido.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidosController : Controller
    {
        private IProdutoRepository _produto;
        public PedidosController(IProdutoRepository produto)
        {
            _produto = produto;
        }

        [HttpGet]
        public IEnumerable<Produto> Get()
        {
            return _produto.Get();
        }

        [HttpGet]
        [Route("{id}")]
        public Produto GetId(long id)
        {
            return _produto.GetId(id);
        }

        [HttpGet("descricao")]
        public Produto GetDescricao(string descricao)
        {
            return _produto.GetDescricao(descricao);
        }

        [HttpGet("categoria")]
        public List<Produto> GetCategoria(string categoria)
        {
            return _produto.GetCategoria(categoria);
            
        }

        [HttpPost]
        public ProdutoDTO Incluir([FromBody] ProdutoDTO produto)
        {
            _produto.Criar(produto);
            return produto;
        }

        [HttpPut]
        public ProdutoDTO Alterar([FromBody] ProdutoDTO produto)
        {
            _produto.Alterar(produto);
            return produto;
        }

        [HttpDelete]
        [Route("{idDelete}")]
        public bool Deletar(long id)
        {
            if (id > 0)
            {
                _produto.Deletar(id);
                return true;
            }
            return false;
        }
    }
}
