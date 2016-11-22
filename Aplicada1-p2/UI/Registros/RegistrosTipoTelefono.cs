using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aplicada1_p2.BLL;
using Aplicada1_p2.Entidades;

namespace Aplicada1_p2.UI.Registros
{
    public partial class RegistrosTipoTelefono : Form
    {
        public RegistrosTipoTelefono()
        {
            InitializeComponent();
        }
        TiposTelefonos tipos = new TiposTelefonos();

        private void button1_Click(object sender, EventArgs e)
        {
            tipos.Clientes.Add(new Clientes((int)ClientescomboBox.SelectedValue, ClientescomboBox.Text, ClientescomboBox.Text, ClientescomboBox.Text,(double)ClientescomboBox.SelectedValue));

            ClientesdataGridView.DataSource = null;
            ClientesdataGridView.DataSource = tipos.Clientes;

        }

        public void LLenarClase(TiposTelefonos tipos)
        {
            tipos.Despcricion = DescripciontextBox.Text;

        }
       public void LLenar(TiposTelefonos tipos)
        {
            var c = ClientesBLL.Buscar(int.Parse(TipoIdtextBox.Text));
            TipoIdtextBox.Text = tipos.TipoId.ToString();
            DescripciontextBox.Text = tipos.Despcricion;
        }


        private void LLenarCombo()
        {

             ClientescomboBox.DataSource = ClientesBLL.GetLista();
             ClientescomboBox.ValueMember = "ClienteId";
             ClientescomboBox.DisplayMember = "Nombres";

        }

        private void RegistrosTipoTelefono_Load(object sender, EventArgs e)
        {
            LLenarCombo();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            TipoIdtextBox.Clear();
            DescripciontextBox.Clear();
            ClientesdataGridView.DataSource = null;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            TiposTelefonosBLL.Eliminar(int.Parse(TipoIdtextBox.Text));
            Limpiar();
            MessageBox.Show("Se Elimino Corretamente");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            LLenar(TiposTelefonosBLL.Buscar(int.Parse(TipoIdtextBox.Text)));

        }
    }
}
