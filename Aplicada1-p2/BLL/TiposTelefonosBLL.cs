using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aplicada1_p2.Entidades;
using Aplicada1_p2.DAL;
using System.Windows.Forms;

namespace Aplicada1_p2.BLL
{
    public class TiposTelefonosBLL
    {
        public static bool Insertar(TiposTelefonos t)
        {
            bool retorno = false;
            try
            {
                var db = new Parcial2Db();

                db.TiposTelefono.Add(t);
                db.SaveChanges();
                db.Dispose();

                retorno = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return retorno;
        }
        public static TiposTelefonos Buscar(int id)
        {
            TiposTelefonos tiposTelefonos = new TiposTelefonos();
            var db = new Parcial2Db();
            return tiposTelefonos = db.TiposTelefono.Find(id);
        }

        public static void Eliminar(int id)
        {
            var db = new Parcial2Db();
            TiposTelefonos t = db.TiposTelefono.Find(id);

            db.TiposTelefono.Remove(t);
            db.SaveChanges();
        }


        public static List<TiposTelefonos> GetLista()
        {
            var lista = new List<TiposTelefonos>();

            var db = new Parcial2Db();

            lista = db.TiposTelefono.ToList();

            return lista;
        }


    }
}
