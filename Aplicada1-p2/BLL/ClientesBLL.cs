using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aplicada1_p2.Entidades;
using Aplicada1_p2.DAL;

using System.Windows.Forms;

namespace Aplicada1_p2.BLL
{
    public class ClientesBLL
    {
        public static bool Insertar(Clientes c)
        {
            bool retorno = false;
            try
            {
                var db = new Parcial2Db();

                db.Clientes.Add(c);
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
        public static Clientes Buscar(int id)
        {
            Clientes cliente = new Clientes();
            var db = new Parcial2Db();
            return cliente = db.Clientes.Find(id);
        }

        public static void Eliminar(int id)
        {
            var db = new Parcial2Db();
            Clientes Es = db.Clientes.Find(id);

            db.Clientes.Remove(Es);
            db.SaveChanges();
        }


        public static List<Clientes> GetLista()
        {
            var lista = new List<Clientes>();

            var db = new Parcial2Db();

            lista = db.Clientes.ToList();

            return lista;
        }

    }
}
