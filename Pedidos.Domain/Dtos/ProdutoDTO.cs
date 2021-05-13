using Pedido.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedido.Domain.Dtos
{
    public class ProdutoDTO
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public Categoria Categoria { get; set; }
        public int QtdeProduto { get; set; }
        public double Preco { get; set; }
        public bool Ativo { get; set; }
    }
}
