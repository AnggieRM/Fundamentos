using ElectroHouse.Clases;
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
            Login login = new Login();
            login.usuario = txtUsuario.Text;
            login.contrasenia = txtContraseña.Text;

            int result = Registro.AgregarUsuario(login);
            if (result == 0)
            {
                MessageBox.Show("Error al guardar");
            }
            else
            {
                MessageBox.Show("Exito al guardar");
            }
        }
    }
}
