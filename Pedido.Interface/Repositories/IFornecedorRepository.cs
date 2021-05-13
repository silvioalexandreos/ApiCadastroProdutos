using Pedido.Domain.Dtos;
using Pedido.Domain.Entities;
using System.Collections.Generic;

namespace Pedido.Interface.Repositories
{
    public interface IFornecedorRepository
    {
        List<Fornecedor> Get();

        Fornecedor GetId(long id);
        Fornecedor GetNome(string nome);
        List<Produto> GetProduto(long id);

        long Criar(FornecedorDTO fornecedor);

        long Alterar(FornecedorDTO produto);

        bool Deletar(long id);
    }
}
