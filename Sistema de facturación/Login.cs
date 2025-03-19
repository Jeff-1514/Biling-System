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

namespace Sistema_de_facturación
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pboxLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pboxLogIn_Click(object sender, EventArgs e)
        {
            string query = "select * from Usuario where Nom_Usu = @nombre and Cla_Usu = @clave";
            using (SqlConnection conn = Conexion.Conectar())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtuser.Text.Trim());
                    cmd.Parameters.AddWithValue("@clave", txtpassword.Text.Trim());

                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        if (lector.HasRows == true)
                        {
                            MessageBox.Show("Bienvenido al sistema");
                            Menu_principal form = new Menu_principal();
                            form.Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario y/o contraseña incorrecta");
                            txtuser.Text = "";
                            txtpassword.Text = "";
                            txtuser.Focus();
                        }
                    }
                }
            }
           
        }

        private void pboxLogIn_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
