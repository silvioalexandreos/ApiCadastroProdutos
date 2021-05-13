using Pedido.Domain.Dtos;
using Pedido.Domain.Entities;
using System.Collections.Generic;

namespace Pedido.Interface.Repositories
{
    public interface IProdutoRepository
    {
        List<Produto> Get();

        Produto GetId(long id);
        Produto GetDescricao(string descricao);
        List<Produto> GetCategoria(string categoria);

        long Criar(ProdutoDTO produto);

        long Alterar(ProdutoDTO produto);

        bool Deletar(long id);
    }
}
