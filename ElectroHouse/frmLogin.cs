using ElectroHouse.Clases;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasenia = txtContraseña.Text;

            // Realizar la verificación de las credenciales
            if (VerificarCredenciales(usuario, contrasenia))
            {
                MessageBox.Show("Inicio de sesión exitoso");
                // Aquí puedes redirigir al usuario a la página principal o realizar otras acciones
                Form1 form1 = new Form1();

                // Mostrar Form2 utilizando el método Show
                form1.Show();

                // Opcionalmente, ocultar el formulario actual (Form1) si deseas
                this.Hide();

            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }

        private bool VerificarCredenciales(string usuario, string contrasenia)
        {
            string connectionString = "";
            SqlConnection connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;User ID=User001;Initial Catalog=dbtest;Data Source=LAPTOP-31D55N99");

            try
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM datos WHERE usuario = @Usuario AND contrasenia = @Contrasenia";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Contrasenia", contrasenia);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir durante la verificación
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
            //private void frm_closing(object sender, FormClosingEventArgs e)
            //{
            //    this.Show();

            //}
        }
           private void label1_Click(object sender, EventArgs e)
            {

            }
        
    }
}
