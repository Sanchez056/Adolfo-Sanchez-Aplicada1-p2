using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Aplicada1_p2.Entidades;
using Aplicada1_p2.BLL;


namespace Aplicada1_p2.DAL
{
    public class Parcial2Db : DbContext
    {

        public Parcial2Db() : base("name=ConStrs")
        {

        }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<TiposTelefonos> TiposTelefono { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TiposTelefonos>()
                 .HasMany<Clientes>(t => t.Clientes)
                 .WithMany(c => c.TiposTelefonos)
                 .Map(tc =>
                 {
                     tc.MapLeftKey("ClienteId");
                     tc.MapRightKey("TipoId");
                     tc.ToTable("ClientesTelefonos");
                 });





        }
    }
}
