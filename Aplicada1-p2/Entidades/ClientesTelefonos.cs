using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Aplicada1_p2.Entidades
{
   public class ClientesTelefonos
    {
        [Key]
        public int Id{ get; set; }
        public int ClienteId { get; set; }
        public int TipoId { get; set; }

        public virtual List<Clientes> Clientes{ get; set; }
        public virtual List<TiposTelefonos> TiposTelefonos { get; set; }

    }
}
