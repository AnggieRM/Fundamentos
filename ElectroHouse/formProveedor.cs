using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            string ruc = txtRuc.Text;
            string telefono = txtTelefono.Text;

            //if (!int.TryParse(txtRuc.Text, out int ruc) || !int.TryParse(txtTelefono.Text, out int telefono))
            //{
            //    MessageBox.Show("El RUC y la Telefono deben ser valores numéricos válidos.");
            //    return;
            //}

            // Crear una conexión a la base de datos
            string connectionString = "Integrated Security=SSPI;Persist Security Info=False;User ID=User001;Initial Catalog=dbtest;Data Source=LAPTOP-31D55N99";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Escribir una consulta SQL INSERT
                    string insertQuery = "INSERT INTO Proveedores (Nombre, Ciudad, Direccion, RUC, Telefono, Codigo) " +
                     "VALUES (@Nombre, @Ciudad, @Direccion, @RUC, @Telefono, @Codigo)";


                    // Crear y configurar un comando SQL
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Codigo", codigo);
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Telefono", telefono);
                        command.Parameters.AddWithValue("@Ciudad", ciudad);
                        command.Parameters.AddWithValue("@Direccion", direccion);
                        command.Parameters.AddWithValue("@RUC", ruc);
                        

                        // Ejecutar la consulta INSERT
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Proveedor guardado en la base de datos con éxito.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el proveedor en la base de datos.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el proveedor en la base de datos: " + ex.Message);
                }
            }

            // Agregar los datos ingresados al ListView
            ListViewItem item = new ListViewItem(new string[] { codigo, nombre, ciudad, direccion, ruc.ToString(), telefono.ToString() });
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

        private void formProveedor_Load(object sender, EventArgs e)
        {
            // Establecer la cadena de conexión a tu base de datos
            string connectionString = "Integrated Security=SSPI;Persist Security Info=False;User ID=User001;Initial Catalog=dbtest;Data Source=LAPTOP-31D55N99";

            // Crear una conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Abrir la conexión
                    connection.Open();

                    // Crear una consulta SQL para seleccionar los datos
                    string query = "SELECT Codigo, Nombre, Ciudad, Direccion, RUC, Telefono FROM Proveedores";

                    // Crear un adaptador de datos y un conjunto de datos para almacenar los resultados
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataSet dataSet = new DataSet();

                    // Llenar el conjunto de datos con los datos de la base de datos
                    adapter.Fill(dataSet, "Proveedores");

                    // Iterar a través de las filas y agregar datos al ListView
                    foreach (DataRow row in dataSet.Tables["Proveedores"].Rows)
                    {
                        ListViewItem item = new ListViewItem(row["Codigo"].ToString());
                        item.SubItems.Add(row["Nombre"].ToString());
                        item.SubItems.Add(row["Ciudad"].ToString());
                        item.SubItems.Add(row["Direccion"].ToString());
                        item.SubItems.Add(row["RUC"].ToString());
                        item.SubItems.Add(row["Telefono"].ToString());

                        listView1.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos desde la base de datos: " + ex.Message);
                }
            }
        }
    }
}
