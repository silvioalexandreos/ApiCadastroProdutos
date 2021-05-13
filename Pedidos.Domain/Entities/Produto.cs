using Pedido.Domain.Enums;
using Pedido.Domain.Infarces;

namespace Pedido.Domain.Entities
{
    public class Produto : Entity, IExclusaoLogic
    {
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public int QtdeProduto { get; set; }
        public double Preco { get; set; }
        public bool Ativo { get; set; }

        public int IdFornecedor { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}
