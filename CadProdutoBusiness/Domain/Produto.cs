using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadProdutoBusiness.Domain
{
    public class Produto : Entity
    {
        public string Descricao { get; set; }
        public int QtdeProduto { get; set; }
        public double Valor { get; set; }
    }
}
