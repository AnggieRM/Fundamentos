namespace ElectroHouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos obj = new formProductos();
            obj.Show();
        }

        private void registrarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProveedor proveedor = new formProveedor();
            proveedor.Show();
        }

        private void reportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formReportes reporte = new formReportes();
            reporte.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();

        }
    }
}