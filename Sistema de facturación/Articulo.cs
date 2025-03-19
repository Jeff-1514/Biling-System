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
    public partial class Articulo : Form
    {
        public Articulo()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Articulo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'facturacionDataSet.Articulo' Puede moverla o quitarla según sea necesario.
            this.articuloTableAdapter.Fill(this.facturacionDataSet.Articulo);
            // TODO: esta línea de código carga datos en la tabla 'facturacionDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.facturacionDataSet.Cliente);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            Menu_principal form = new Menu_principal();
            form.Show();
            this.Close();
        }

        private void txtboxCodA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                using (SqlConnection conn = Conexion.Conectar())
                {
                    try
                    {
                        conn.Open();
                        string query1 = "SELECT * FROM Articulo WHERE Cod_Art = @codigo";
                        using (SqlCommand cmd = new SqlCommand(query1, conn))
                        {
                            cmd.Parameters.AddWithValue("@codigo", CodigoA.Text.Trim());

                            using (SqlDataReader leer = cmd.ExecuteReader())
                            {
                                if (leer.Read() == true)
                                {
                                    DescripcionA.Text = leer["Des_Art"].ToString();
                                    CostoA.Text = leer["Cos_Art"].ToString();
                                    PrecioA.Text = leer["Pre_Art"].ToString();
                                    CanMinimaA.Text = leer["Can_Min"].ToString();
                                    ExistenciaA.Text = leer["Exi_Art"].ToString();
                                    btnGuardarA.Enabled = false;
                                }
                                else
                                {
                                    btnGuardarA.Enabled = false;
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

        private void txtboxDesA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxDesA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtboxCostoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtboxPrecioA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtboxCantidadA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtboxExistenciaA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtboxCanMinimaA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtboxBuscarA_KeyPress(object sender, KeyPressEventArgs e)
        {
            using (SqlConnection conn = Conexion.Conectar())
            {
                conn.Open();
                DataTable dt = new DataTable();
                string ConsultarA = "Select * from Articulo where Des_Art like @buscar + '%' ";
                using (SqlCommand cmd = new SqlCommand(ConsultarA, conn))
                {
                    cmd.Parameters.AddWithValue("@buscar", BuscarA.Text.Trim());

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                        DgvArticulos.DataSource = dt;
                    }
                }

            }
        }

        private void txtboxTotalA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void btnNuevoA_Click(object sender, EventArgs e)
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
                this.DescripcionA.Focus();

                using (SqlConnection conn = Conexion.Conectar())
                {
                    conn.Open();
                    string query = "select isnull(max(cast(Cod_Art as int)),0) +1 from Articulo";
                    SqlDataAdapter sda = new SqlDataAdapter(query,conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    CodigoA.Text = dt.Rows[0][0].ToString();
                    
                }
            }
        }
        public DataTable actualizararticulos()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Articulo order by Cod_Art desc";
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

        private void btnGuardarA_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO Articulo(Cod_Art,Des_Art,Cos_Art,Pre_Art,Exi_Art,Can_Min) " +
                "VALUES (@Cod_Art,@Des_Art,@Cos_Art,@Pre_Art,@Exi_Art,@Can_Min)";
            using (SqlConnection conn = Conexion.Conectar())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("@Cod_Art", CodigoA.Text);
                    cmd.Parameters.AddWithValue("@Des_Art", DescripcionA.Text);
                    cmd.Parameters.AddWithValue("@Cos_Art", CostoA.Text);
                    cmd.Parameters.AddWithValue("@Pre_Art", PrecioA.Text);
                    cmd.Parameters.AddWithValue("@Exi_Art", ExistenciaA.Text);
                    cmd.Parameters.AddWithValue("@Can_Min", CanMinimaA.Text);

                    cmd.ExecuteNonQuery();
                    DgvArticulos.DataSource = actualizararticulos();
                    MessageBox.Show("Datos agregados con exito");
                }
            }
            int total = int.Parse(DgvArticulos.RowCount.ToString());
            TotalA.Text = Convert.ToString(total - 1);
        }

        private void txtboxCodA_TextChanged(object sender, EventArgs e)
        {

        }

        private void BuscarA_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btnEditarA_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Articulo SET Des_Art = @Descripcion, Cos_Art = @Costo, Pre_Art = @Precio, " +
                           "Exi_Art = @Existencia, Can_Min = @Minima WHERE Cod_Art = @Codigo";

            using (SqlConnection conn = Conexion.Conectar())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Descripcion", DescripcionA.Text.Trim());
                    cmd.Parameters.AddWithValue("@Costo", int.Parse(CostoA.Text.Trim())); 
                    cmd.Parameters.AddWithValue("@Precio", int.Parse(PrecioA.Text.Trim())); 
                    cmd.Parameters.AddWithValue("@Existencia", int.Parse(ExistenciaA.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Minima", int.Parse(CanMinimaA.Text.Trim())); 
                    cmd.Parameters.AddWithValue("@Codigo",CodigoA.Text.Trim());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Los datos fueron actualizados correctamente.");
                        DgvArticulos.DataSource = actualizararticulos();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el artículo para actualizar.");
                    }
                }
            }
            int total = int.Parse(DgvArticulos.RowCount.ToString());
            TotalA.Text = Convert.ToString(total - 1);
        }

        private void btnEliminarA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Eliminar el registro?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string eliminar = "DELETE FROM Articulo WHERE Cod_Art = @Codigo";
                using (SqlConnection conn = Conexion.Conectar())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(eliminar, conn))
                    {
                        cmd.Parameters.AddWithValue("@Codigo", int.Parse(CodigoA.Text.Trim()));
                        cmd.ExecuteNonQuery();
                        DgvArticulos.DataSource = actualizararticulos();
                    }
                }
            }
            int total = int.Parse(DgvArticulos.RowCount.ToString());
            TotalA.Text = Convert.ToString(total - 1);
        }

        private void btnImprimirA_Click(object sender, EventArgs e)
        {
            RCA rca = new RCA();
            rca.Show();
        }
    }
}
