using Pedido.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedido.Domain.Dtos
{
    public class FornecedorDTO
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public bool Ativo { get; set; }
    }
}
