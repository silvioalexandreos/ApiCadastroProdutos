using Microsoft.AspNetCore.Mvc;
using Pedido.Domain.Dtos;
using Pedido.Domain.Entities;
using Pedido.Interface.Repositories;
using System.Collections.Generic;

namespace Pedido.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FornecedoresController : Controller
    {
        private IFornecedorRepository _fornecedor;
        public FornecedoresController(IFornecedorRepository fornecedor)
        {
            _fornecedor = fornecedor;
        }

        [HttpGet]
        public IEnumerable<Fornecedor> Get()
        {
            return _fornecedor.Get();
        }

        [HttpGet]
        [Route("{id}")]
        public Fornecedor GetId(long id)
        {
            return _fornecedor.GetId(id);
        }

        [HttpGet("nome")]
        public Fornecedor GetNome(string nome)
        {
            return _fornecedor.GetNome(nome);
        }

        [HttpGet("produtonomefornecedor")]
        public List<Produto> GetNomeFornecedor(long id)
        {
            return _fornecedor.GetProduto(id);

        }

        [HttpPost]
        public FornecedorDTO Incluir([FromBody] FornecedorDTO produto)
        {
            _fornecedor.Criar(produto);
            return produto;
        }

        [HttpPut]
        public FornecedorDTO Alterar([FromBody] FornecedorDTO produto)
        {
            _fornecedor.Alterar(produto);
            return produto;
        }

        [HttpDelete]
        [Route("{idDelete}")]
        public bool Deletar(long id)
        {
            _fornecedor.Deletar(id);
            return true;
        }
    }
}
