using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_facturación
{
    public partial class Menu_principal : Form
    {
        public Menu_principal()
        {
            InitializeComponent();
        }

        private void Menu_principal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login form = new login();
            form.Show();
            this.Close();
        }

        private void artículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Articulo form = new Articulo();
            form.Show();
            this.Close();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente form = new Cliente();
            form.Show();
            this.Close();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario form = new Usuario();
            form.Show();
            this.Close();
        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            facturacion form = new facturacion();
            form.Show();
            this.Close();
        }
    }
}
