using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            this.ClienteCuentas = new HashSet<ClienteCuenta>();
        }

        public int id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public string cedula { get; set; }
        public string telefono { get; set; }
        public int numeroCuenta { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public decimal TasaInteres { get; set; }
        public decimal saldoDisponible { get; set; }
        public int moneda { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteCuenta> ClienteCuentas { get; set; }
    }
}
