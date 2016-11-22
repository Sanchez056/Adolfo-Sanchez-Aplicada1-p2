using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Aplicada1_p2.Entidades
{
    public class Clientes
    {

        [Key]
        public int ClienteId { get; set; }

        public string Nombres { get; set; }

        public string FechaNacimiento { get; set; }

        public string Telefono { get; set; }

        public double LimiteCredito { get; set; }

        public List<TiposTelefonos> TiposTelefonos { get; set; }

        // public ICollection<TiposTelefonos> Clientes { get; internal set; }

        public Clientes()
        {
            this.TiposTelefonos = new List<TiposTelefonos>();
        }

        
        public Clientes(int clienteId, string nombres,string fechaNacimiento,string telefono,double LimiteCredito)
        {
            this.ClienteId = clienteId;
            this.Nombres = nombres;
            this.FechaNacimiento = fechaNacimiento;
            this.Telefono = telefono;
            this.LimiteCredito = LimiteCredito;
            this.TiposTelefonos = new List<TiposTelefonos>();
            
        }
    }
}
