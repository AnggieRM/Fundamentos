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

            //Form1 obj = new Form1();
            //obj.Show();
            //this.Hide();

            //obj.FormClosing += frm_closing;

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

        //private void frm_closing(object sender, FormClosingEventArgs e)
        //{
        //    this.Show();

        //}
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
