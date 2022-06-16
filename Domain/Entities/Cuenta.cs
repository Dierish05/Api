using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public partial class Cuenta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cuenta()
        {
            this.ClienteCuentas = new HashSet<ClienteCuenta>();
        }

        public int id { get; set; }
        public System.DateTime FechaDeposito { get; set; }
        public decimal saldoDepositado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteCuenta> ClienteCuentas { get; set; }
    }
}
