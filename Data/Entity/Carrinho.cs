using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Carrinho
    {
        public Guid Id { get; set; }
        public Guid ClienteId { get; set; }
        public Guid ProdutoId { get; set; }
    }
}
