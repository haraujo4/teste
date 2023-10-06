using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.Services
{
    public interface IClienteServices
    {
        IEnumerable<ClienteViewModel> GetAll();
        ClienteViewModel GetByCpf(string cpf);
        Task<ClienteViewModel> Create(CreateClienteViewModel cliente);
        Task<ClienteViewModel> Update(Guid id, CreateClienteViewModel cliente);
        Task Delete(Guid id);
    }
}
