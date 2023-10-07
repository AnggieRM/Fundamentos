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
    public partial class formProveedor : Form
    {
        public formProveedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoProveedor.Text;
            string nombre = txtNombreProveedor.Text;
            string ciudad = txtCiudad.Text;
            string direccion = txtDireccion.Text;


            if (!int.TryParse(txtRuc.Text, out int ruc) || !int.TryParse(txtTelefono.Text, out int telefono))
            {
                MessageBox.Show("El RUC y la Telefono deben ser valores numéricos válidos.");
                return;
            }

            List<string> info = new List<string>
            {
                codigo,
                nombre,
                ciudad,
                direccion,
                ruc.ToString(),
                telefono.ToString(),

            };

            ListViewItem item = new ListViewItem(info.ToArray());
            listView1.Items.Add(item);

            // Limpia los campos de entrada
            txtCodigoProveedor.Clear();
            txtNombreProveedor.Clear();
            txtRuc.Clear();
            txtCiudad.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
