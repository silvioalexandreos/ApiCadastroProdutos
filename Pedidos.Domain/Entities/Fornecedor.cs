using Pedido.Domain.Infarces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedido.Domain.Entities
{
    public class Fornecedor : Entity, IExclusaoLogic
    {
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public bool Ativo { get; set; }

        public ICollection<Produto> Produtos { get; set; }
    }
}
