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
    public partial class RegistrosCliente : Form
    {
        public RegistrosCliente()
        {
            InitializeComponent();
        }

        private void RegistrosCliente_Load(object sender, EventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Llenar(ClientesBLL.Buscar(int.Parse(ClienteIdtextBox.Text)));

        }

        private void Llenar(Clientes clientes)
        {
            throw new NotImplementedException();
        }

        public void LLenar( Clientes clientes)
        {
            var t = TiposTelefonosBLL.Buscar(int.Parse(ClienteIdtextBox.Text));
            ClienteIdtextBox.Text = cliente.ClienteId.ToString();
            NombrestextBox.Text = cliente.Nombres;
            FechaNacimientomaskedTextBox.Text = cliente.FechaNacimiento;
            TelefonotextBox.Text = cliente.Telefono;
            LimiteCreditotextBox.Text= cliente.LimiteCredito.ToString();
            TiposTelefonosdataGridView.DataSource = null;
            TiposTelefonosdataGridView.DataSource = cliente.TiposTelefonos;

        }
        Clientes cliente = new Clientes();
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {
            ClienteIdtextBox.Clear();
            FechaNacimientomaskedTextBox.Clear();
            LimiteCreditotextBox.Clear();
            TelefonotextBox.Clear();
            NombrestextBox.Clear();
            TiposTelefonosdataGridView.DataSource = null;
        }

  
        public void LLenarClase(Clientes clientes)
        {
        
            cliente.Nombres = NombrestextBox.Text;
            cliente.FechaNacimiento = FechaNacimientomaskedTextBox.Text;
            cliente.Telefono = TelefonotextBox.Text;
            cliente.LimiteCredito = double.Parse(LimiteCreditotextBox.Text);
           
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
           
                 LLenarClase(cliente);
                ClientesBLL.Insertar(cliente);
                Limpiar();
                MessageBox.Show("-_-Guardado Con Exito-_-");
            
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            ClientesBLL.Eliminar(int.Parse(ClienteIdtextBox.Text));
            Limpiar();
            MessageBox.Show("Se Elimino Corretamente");
        }
    }
}
