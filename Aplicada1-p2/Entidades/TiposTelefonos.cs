using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Aplicada1_p2.Entidades
{
    public class TiposTelefonos
    {
        //[Key]
        public int TipoId { get; set; }
        public string Despcricion { get; set; }

       public List<Clientes> Clientes { get; set; }

        public TiposTelefonos()
        {
            this.Clientes = new List<Clientes>();
        }


        public TiposTelefonos(int tipoId, string Descripcion)
        {
            this.TipoId = TipoId;
            this.Despcricion = Despcricion;
            this.Clientes = new List<Clientes>();
        }

    }
}
