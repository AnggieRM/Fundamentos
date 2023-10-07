using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectroHouse
{
    public partial class formProductos : Form
    {
        public formProductos()
        {
            InitializeComponent();
        }

        private void formProductos_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigo = txtcodigoproducto.Text;
            string nombre = txtnombreproducto.Text;
            string proveedor = txtproveedorproducto.Text;
            string tipoProducto = cmbTipoProducto.SelectedItem?.ToString();
            string estadoProducto = cmbEstadoProducto.SelectedItem?.ToString();


            if (!decimal.TryParse(txtPrecioProducto.Text, out decimal precio) || !int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("El precio y la cantidad deben ser valores numéricos válidos.");
                return;
            }

            DateTime fechaEntrega = dtpproductos.Value;

            List<string> entrega = new List<string>
            {
                codigo,
                nombre,
                precio.ToString("C"),
                estadoProducto,
                proveedor,
                tipoProducto,
                cantidad.ToString(),
                fechaEntrega.ToString("yyyy-MM-dd") // Formato de fecha deseado (puedes personalizarlo)
            };

            ListViewItem item = new ListViewItem(entrega.ToArray());
            listView1.Items.Add(item);

            // Limpia los campos de entrada
            txtcodigoproducto.Clear();
            txtnombreproducto.Clear();
            txtproveedorproducto.Clear();
            txtPrecioProducto.Clear();
            txtCantidad.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
