using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModel
{
    public class ClienteViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public bool Status { get; set; }
    }
    public class CreateClienteViewModel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public bool Status { get; set; }
    }
}
