using Domain.Interface.Services;
using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ClienteServices : IClienteServices
    {
        public Task<ClienteViewModel> Create(CreateClienteViewModel cliente)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public ClienteViewModel GetByCpf(string cpf)
        {
            throw new NotImplementedException();
        }

        public Task<ClienteViewModel> Update(Guid id, CreateClienteViewModel cliente)
        {
            throw new NotImplementedException();
        }
    }
}
