using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IClienteCuentaRepository : IRepository<ClienteCuenta>
    {
        List<ClienteCuenta> FindByClienteId(int clienteId);
        List<ClienteCuenta> FindByCuentaId(int cuentaId);
        ClienteCuenta FindByClienteCuentaId(int clienteId, int cuentaId);
    }
}
