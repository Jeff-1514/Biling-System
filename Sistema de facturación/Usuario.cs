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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Menu_principal form = new Menu_principal();
            form.Show();
            this.Close();
        }

        private void txtboxCodU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                using (SqlConnection conn = Conexion.Conectar())
                {
                    try
                    {
                        conn.Open();
                        string query1 = "SELECT * FROM Usuario WHERE Cod_Usu = @codigo";
                        using (SqlCommand cmd = new SqlCommand(query1, conn))
                        {
                            cmd.Parameters.AddWithValue("@codigo", CodigoU.Text.Trim());

                            using (SqlDataReader leer = cmd.ExecuteReader())
                            {
                                if (leer.Read() == true)
                                {
                                    NombreU.Text = leer["Nom_Usu"].ToString();
                                    ClaveU.Text = leer["Cla_Usu"].ToString();
                                    CelularU.Text = leer["Cel_Usu"].ToString();
                                    CorreoU.Text = leer["Cor_Usu"].ToString();
                                    btnGuardarU.Enabled = false;
                                }
                                else
                                {
                                    btnGuardarU.Enabled = false;
                                    MessageBox.Show("Registro no encontrado");

                                    foreach (Control ctrl in Controls)
                                    {
                                        if (ctrl is TextBox)
                                        {
                                            ctrl.Text = "";
                                        }
                                        if (ctrl is ComboBox)
                                        {
                                            ctrl.Text = "";
                                        }
                                    }
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    SendKeys.Send("{TAB}");
                }
            }
        }

        private void txtboxNombreU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtboxClaveU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtboxPrecioU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtboxConClaveU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtboxCelularU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtboxCorreoU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtboxBuscarU_KeyPress(object sender, KeyPressEventArgs e)
        {
            using (SqlConnection conn = Conexion.Conectar())
            {
                conn.Open();
                DataTable dt = new DataTable();
                string ConsultarA = "Select * from Usuario where Nom_Usu like @buscar + '%' ";
                using (SqlCommand cmd = new SqlCommand(ConsultarA, conn))
                {
                    cmd.Parameters.AddWithValue("@buscar", BuscarU.Text.Trim());
                    
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                        DgvUsuario.DataSource = dt;
                    }
                }

            }
        }

        private void txtboxTotalU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void btnNuevoU_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }

                if (ctrl is ComboBox)
                {
                    ctrl.Text = "";
                }
                this.NombreU.Focus();
                using (SqlConnection conn = Conexion.Conectar())
                {
                    conn.Open();
                    string query = "select isnull(max(cast(Cod_Usu as int)),0) +1 from Usuario";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);   
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    CodigoU.Text = dt.Rows[0][0].ToString();
                }
               
            }
        }
        public DataTable actualizarUsuario()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Usuario order by Cod_Usu desc";

            using (SqlConnection conn = Conexion.Conectar())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        private void btnGuardarU_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO Usuario(Cod_Usu,Nom_Usu, Cla_Usu, Cel_Usu, Cor_Usu) " +
                "VALUES (@Cod_Usu,@Nom_Usu, @Cla_Usu, @Cel_Usu, @Cor_Usu)";

            using (SqlConnection conn = Conexion.Conectar()) 
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@Cod_Usu", CodigoU.Text);
                    cmd.Parameters.AddWithValue("@Nom_Usu", NombreU.Text);
                    cmd.Parameters.AddWithValue("@Cla_Usu", ClaveU.Text);
                    cmd.Parameters.AddWithValue("@Cel_Usu", CelularU.Text);
                    cmd.Parameters.AddWithValue("@Cor_Usu", CorreoU.Text);

                    cmd.ExecuteNonQuery();
                    DgvUsuario.DataSource = actualizarUsuario();

                    MessageBox.Show("Datos agregados con exito");
                }
            }
            int total = int.Parse(DgvUsuario.RowCount.ToString());
            TotalU.Text = Convert.ToString(total - 1);
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'facturacionDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.facturacionDataSet.Usuario);

        }

        private void btnEditarU_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Usuario SET Nom_Usu = @nombre, Cla_Usu = @clave, Cel_Usu = @celular, Cor_Usu = @correo " +
                           "WHERE Cod_Usu = @codigo"; 

            using (SqlConnection conn = Conexion.Conectar())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", NombreU.Text.Trim());
                    cmd.Parameters.AddWithValue("@clave", ClaveU.Text.Trim());
                    cmd.Parameters.AddWithValue("@celular", CelularU.Text.Trim());
                    cmd.Parameters.AddWithValue("@correo", CorreoU.Text.Trim());
                    cmd.Parameters.AddWithValue("@codigo", int.Parse(CodigoU.Text.Trim()));

                    try
                    {
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Los datos fueron actualizados correctamente.");
                            DgvUsuario.DataSource = actualizarUsuario(); 
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el usuario para actualizar.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar usuario: " + ex.Message);
                    }
                }
            }

            int total = int.Parse(DgvUsuario.RowCount.ToString());
            TotalU.Text = Convert.ToString(total - 1);
        }

        private void btnEliminarU_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Eliminar el registro?","Message",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string eliminar = "DELETE FROM Usuario WHERE Cod_Usu = @Codigo";
                using (SqlConnection conn = Conexion.Conectar())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(eliminar, conn))
                    {
                        cmd.Parameters.AddWithValue("@Codigo", int.Parse(CodigoU.Text.Trim()));
                        cmd.ExecuteNonQuery();
                        DgvUsuario.DataSource = actualizarUsuario();
                    }
                }
            }
            int total = int.Parse(DgvUsuario.RowCount.ToString());
            TotalU.Text = Convert.ToString(total - 1);
        }

        private void btnImprimirU_Click(object sender, EventArgs e)
        {
            RCU rcu = new RCU();
            rcu.Show();
        }
    }
}
