using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public partial class ClienteCuenta
    {
        public int id { get; set; }
        public int clienteId { get; set; }
        public int cuentaId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Cuenta Cuenta { get; set; }
    }
}
