using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using E
using System.Threading.Tasks;

namespace DAL
{
    public class Parcial2Db
    {

        public Parcial2Db() : base("name=ConStr")
        {

        }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<TiposTelefonos> TiposTelefono { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TiposTelefonos>()
                 .HasMany<Clientes>(t => t.Clientes)
                 .WithMany(t => t.TiposTelefonos)
                 .Map(ct =>
                 {
                     ct.MapLeftKey("ClienteId");
                     ct.MapRightKey("Tipos");
                     ct.ToTable("ClientesTelefonos");
                 });

        }
    }
