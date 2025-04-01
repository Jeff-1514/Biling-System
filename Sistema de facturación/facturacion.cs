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
    public partial class facturacion : Form
    {
        public facturacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void facturacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'facturacionDataSet.Temdetallefactura' Puede moverla o quitarla según sea necesario.
            this.temdetallefacturaTableAdapter.Fill(this.facturacionDataSet.Temdetallefactura);
            // TODO: esta línea de código carga datos en la tabla 'facturacionDataSet.Temdetallefactura' Puede moverla o quitarla según sea necesario.
            this.temdetallefacturaTableAdapter.Fill(this.facturacionDataSet.Temdetallefactura);

            txtboxArticulo.Enabled = false;
            txtboxDesF.Enabled = false;
            txtboxPrecio.Enabled = false;
            txtboxCan.Enabled = false;
            txtSubtotal1.Enabled = false;
            btnGuardarF.Enabled = false;
            btnImprimirF.Enabled = false;
            txtboxDesc1.Text = "0";
            txtboxDesc2.Text = "0";
            txtboxItbis1.Text = "0";
            txtboxItbis2.Text = "0";
            llenardgvDF();
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
                txtboxDesc1.Text = "0";
                txtboxDesc2.Text = "0";
                txtboxItbis1.Text = "0";
                txtboxItbis2.Text = "0";

                using (SqlConnection conn = Conexion.Conectar())
                {
                    conn.Open();
                    string query = "select isnull(max(cast(num_fac as int)),0) +1 from factura";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    txtboxNoFac.Text = dt.Rows[0][0].ToString();
                    cmbBoxTipo.Text = "Efectivo";
                    txtboxCliente.Text = "1";
                    txtboxNombre.Text = "Generico";
                    txtboxArticulo.Focus();
                    timer1.Enabled = true;
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Menu_principal form = new Menu_principal();
            form.Show();
            this.Close();
        }

        private void txtboxNoFac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtboxFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtboxHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtboxCliente_TextChanged(object sender, EventArgs e)
        {

        }
        //Buscar Cliente de la DataBase
        private void txtboxCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                using (SqlConnection conn = Conexion.Conectar())
                {
                    try
                    {
                        conn.Open();
                        string query = "select * from Cliente where Cod_Cli = @codigo";
                        using (SqlCommand comando = new SqlCommand(query, conn))
                        {
                            comando.Parameters.AddWithValue("@codigo", txtboxCliente.Text.Trim());
                            using (SqlDataReader leer = comando.ExecuteReader())
                            {
                                if (leer.Read() == true)
                                {
                                    txtboxNombre.Text = leer["Nom_Cli"].ToString();
                                }
                                else
                                {
                                    btnGuardarF.Enabled = false;
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

        private void txtboxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        //Mostrar articulo de la base de datos
        private void txtboxArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                using (SqlConnection conn = Conexion.Conectar())
                {
                    try
                    {
                        conn.Open();
                        string query = "select * from Articulo where Cod_Art = @codigo";
                        using (SqlCommand comando = new SqlCommand(query, conn))
                        {
                            comando.Parameters.AddWithValue("@codigo", txtboxArticulo.Text.Trim());
                            using (SqlDataReader leer = comando.ExecuteReader())
                            {
                                if (leer.Read() == true)
                                {
                                    txtboxDesF.Text = leer["Des_Art"].ToString();
                                    txtboxPrecio.Text = leer["Pre_Art"].ToString();
                                }
                                else
                                {
                                    btnGuardarF.Enabled = false;
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

        private void txtboxDesF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxDesF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtboxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        //Actualizar DataGridView
        public DataTable llenardgvDF()
        {
            using (SqlConnection conn = Conexion.Conectar())
            {
                conn.Open();
                DataTable dt = new DataTable();
                string query = "Select * from Temdetallefactura order by cod_art desc";
                using (SqlCommand comando = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter Da = new SqlDataAdapter(comando))
                    {
                        Da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        private void txtboxCan_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Calcular el subtotal 
            if (e.KeyChar == (char)(Keys.Enter))
            {

                if (string.IsNullOrWhiteSpace(txtboxNoFac.Text) ||
                string.IsNullOrWhiteSpace(txtboxArticulo.Text) ||
                string.IsNullOrWhiteSpace(txtboxDesF.Text) ||
                string.IsNullOrWhiteSpace(txtboxCan.Text) ||
                string.IsNullOrWhiteSpace(txtboxPrecio.Text))
                {
                    MessageBox.Show("Todos los campos deben estar llenos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal pre = Convert.ToDecimal(txtboxPrecio.Text);
                decimal can = Convert.ToDecimal(txtboxCan.Text);

                decimal Subtotal = pre * can;
                txtSubtotal1.Text = Subtotal.ToString();

                //guardar de manera temporal en los detalles de factura y mostrar en DataGridView
                string query = "insert into Temdetallefactura (num_fac,cod_art,des_art,can_art,pre_art,sub_tot) values (@num_fac,@cod_art,@des_art,@can_art,@pre_art,@sub_tot)";
                using (SqlConnection conn = Conexion.Conectar())
                {
                    conn.Open();
                    using (SqlCommand comando = new SqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@num_fac", txtboxNoFac.Text);
                        comando.Parameters.AddWithValue("@cod_art", txtboxArticulo.Text);
                        comando.Parameters.AddWithValue("@des_art", txtboxDesF.Text.Trim());
                        comando.Parameters.AddWithValue("@can_art", txtboxCan.Text);
                        comando.Parameters.AddWithValue("@pre_art", txtboxPrecio.Text);
                        comando.Parameters.AddWithValue("@sub_tot", txtSubtotal1.Text);
                        comando.ExecuteNonQuery();
                    }
                }
                DgvFacturacion.DataSource = llenardgvDF();
                //Guardar en los detalles de factura
                query = "insert into Detallefactura (num_fac,cod_art,des_art,can_art,pre_art,sub_tot) values (@num_fac,@cod_art,@des_art,@can_art,@pre_art,@sub_tot)";

                using (SqlConnection conn = Conexion.Conectar())
                {
                    conn.Open();
                    using (SqlCommand comando = new SqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@num_fac", txtboxNoFac.Text.Trim());
                        comando.Parameters.AddWithValue("@cod_art", txtboxArticulo.Text.Trim());
                        comando.Parameters.AddWithValue("@des_art", txtboxDesF.Text.Trim());
                        comando.Parameters.AddWithValue("@can_art", txtboxCan.Text.Trim());
                        comando.Parameters.AddWithValue("@pre_art", txtboxPrecio.Text.Trim());
                        comando.Parameters.AddWithValue("@sub_tot", txtSubtotal1.Text.Trim());
                        comando.ExecuteNonQuery();
                    }
                }
                //Disminuir el inventario 
                using (SqlConnection conn = Conexion.Conectar())
                {
                    string query1 = "UPDATE Articulo SET Exi_Art = Exi_Art - @existencia WHERE cod_art = @cod_art";
                    conn.Open();
                    using (SqlCommand comando = new SqlCommand(query1, conn))
                    {
                        comando.Parameters.AddWithValue("@existencia", txtboxCan.Text);
                        comando.Parameters.AddWithValue("@cod_art", txtboxArticulo.Text);
                        comando.ExecuteNonQuery();
                    }
                }
                //sumar la columna subtotal
                double stf = 0;
                foreach (DataGridViewRow row in DgvFacturacion.Rows)
                    stf += Convert.ToDouble(row.Cells["sub_tot"].Value);
                txtboxSubtotal2.Text = Convert.ToString(stf);

                //sumar subtotal a total a pagar 
                double tap = 0;
                foreach (DataGridViewRow row in DgvFacturacion.Rows)
                    tap += Convert.ToDouble(row.Cells["sub_tot"].Value);
                txtboxTotalP.Text = Convert.ToString(tap);

                //limpiar textbox 
                txtboxArticulo.Text = "";
                txtboxDesF.Text = "";
                txtboxCan.Text = "";
                txtboxPrecio.Text = "";
                txtSubtotal1.Text = "";

                e.Handled = true;
                SendKeys.Send("{TAB}");
            }


        }

        private void txtSubtotal1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtboxSubtotal2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtboxDesc1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                decimal descuentoA = 0;
                decimal DescuentoF = 0;
                decimal subt = 0;
                decimal itb = 0;
                decimal TotalF = 0;
                subt = Convert.ToDecimal(txtboxSubtotal2.Text);
                descuentoA = Convert.ToDecimal(txtboxDesc1.Text);
                itb = Convert.ToDecimal(txtboxItbis1.Text);
                DescuentoF = subt * (descuentoA / 100);
                txtboxDesc2.Text = DescuentoF.ToString();
                TotalF = (subt - DescuentoF) + itb;
                txtboxTotalP.Text = TotalF.ToString();

                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtboxItbis1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                decimal pitb = 0;
                decimal iaf = 0;
                decimal daaf = 0;
                decimal stf = 0;
                decimal tif = 0;
                decimal tf = 0;
                decimal stnf = 0;

                daaf = Convert.ToDecimal(txtboxDesc2.Text);
                stf = Convert.ToDecimal(txtboxSubtotal2.Text);
                pitb = Convert.ToDecimal(txtboxItbis1.Text);
                iaf = stf - daaf;
                tif = iaf * (pitb / 100);
                txtboxItbis2.Text = tif.ToString();
                stnf = stf - daaf;
                tf = stnf + tif;
                txtboxTotalP.Text = tf.ToString();
                
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cmbBoxTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtboxTotalP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        //eliminar tabla temporal 

        public DataTable Eliminar_Grid()
        {
            using (SqlConnection conn = Conexion.Conectar())
            {
                conn.Open();
                DataTable dt = new DataTable();
                string query = "Delete Temdetallefactura";
                using (SqlCommand comando = new SqlCommand(query, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(dt);
                    return dt;
                }
            }
        }


        //Boton nuevo
        private void btnNuevoF_Click(object sender, EventArgs e)
        {
            txtboxArticulo.Enabled = true;
            txtboxDesF.Enabled = true;
            txtboxPrecio.Enabled = true;
            txtboxCan.Enabled = true;
            txtSubtotal1.Enabled = true;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
                txtboxDesc1.Text = "0";
                txtboxDesc2.Text = "0";
                txtboxItbis1.Text = "0";
                txtboxItbis2.Text = "0";

                using (SqlConnection conn = Conexion.Conectar())
                {
                    conn.Open();
                    string query = "select isnull(max(cast(num_fac as int)),0) +1 from factura";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    txtboxNoFac.Text = dt.Rows[0][0].ToString();
                    cmbBoxTipo.Text = "Efectivo";
                    txtboxCliente.Text = "1";
                    txtboxNombre.Text = "Generico";
                    txtboxArticulo.Focus();
                    timer1.Enabled = true;
                    btnGuardarF.Enabled = true;


                }
            }
            Eliminar_Grid();
        }
        private void Articulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarF_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtboxHora.Text = DateTime.Now.ToString("hh:mm:ss");
            txtboxFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btnGuardarF_Click_1(object sender, EventArgs e)
        {
            if (txtboxSubtotal2.Text == string.Empty)
            {
                MessageBox.Show("No hay factura para procesar");
                txtboxArticulo.Focus();
            }
            //guardar 
            else
            {
                using (SqlConnection conn = Conexion.Conectar())
                {
                    conn.Open();
                    string query = "insert into Factura (num_fac, tipo_fac, fec_fac, hor_fac, cod_cli, nom_cli, des_fac, itb_fac, tot_fac, pdf_fac, pit_fac) values (@num_fac, @tipo_fac, @fec_fac, @hor_fac, @cod_cli, @nom_cli, @des_fac, @itb_fac, @tot_fac, @pdf_fac, @pit_fac)";
                    using (SqlCommand comando = new SqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@num_fac", Convert.ToInt32(txtboxNoFac.Text));
                        comando.Parameters.AddWithValue("@tipo_fac", cmbBoxTipo.Text);
                        comando.Parameters.AddWithValue("@fec_fac", txtboxFecha.Text);
                        comando.Parameters.AddWithValue("@hor_fac", txtboxHora.Text);
                        comando.Parameters.AddWithValue("@cod_cli", Convert.ToInt32(txtboxCliente.Text));
                        comando.Parameters.AddWithValue("@nom_cli", txtboxNombre.Text);
                        //comando.Parameters.AddWithValue("@sub_tot_fac",Convert.ToDecimal(Subtotal1.Text));
                        comando.Parameters.AddWithValue("@des_fac", Convert.ToDecimal(txtboxDesc1.Text));
                        comando.Parameters.AddWithValue("@itb_fac", Convert.ToDecimal(txtboxItbis1.Text));
                        comando.Parameters.AddWithValue("@tot_fac", Convert.ToDecimal(txtboxTotalP.Text));
                        comando.Parameters.AddWithValue("@pdf_fac", Convert.ToDecimal(txtboxDesc2.Text));
                        comando.Parameters.AddWithValue("@pit_fac", Convert.ToDecimal(txtboxItbis2.Text));

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Registro Agregado");


                    }
                    Eliminar_Grid();
                }
            }
        }
        //btnBuscar Cliente
        private void btnBuscarC_Click_1(object sender, EventArgs e)
        {
            Cliente form = new Cliente();
            form.Show();
        }
        //btnBuscar articulo
        private void btnBuscarA_Click_1(object sender, EventArgs e)
        {
            Articulo form = new Articulo();
            form.Show();
        }
    }
}
