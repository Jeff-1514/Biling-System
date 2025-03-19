
namespace Sistema_de_facturación
{
    partial class Articulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Articulo));
            this.DgvArticulos = new System.Windows.Forms.DataGridView();
            this.codArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cosArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exiArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canMinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturacionDataSet = new Sistema_de_facturación.FacturacionDataSet();
            this.lblCodA = new System.Windows.Forms.Label();
            this.lblDesA = new System.Windows.Forms.Label();
            this.lblCosA = new System.Windows.Forms.Label();
            this.lblPrecioA = new System.Windows.Forms.Label();
            this.lblCantidadA = new System.Windows.Forms.Label();
            this.lblExistenciaA = new System.Windows.Forms.Label();
            this.lblCanMinimaA = new System.Windows.Forms.Label();
            this.lblTotalA = new System.Windows.Forms.Label();
            this.CodigoA = new System.Windows.Forms.TextBox();
            this.DescripcionA = new System.Windows.Forms.TextBox();
            this.PrecioA = new System.Windows.Forms.TextBox();
            this.ExistenciaA = new System.Windows.Forms.TextBox();
            this.CantidadA = new System.Windows.Forms.TextBox();
            this.CostoA = new System.Windows.Forms.TextBox();
            this.CanMinimaA = new System.Windows.Forms.TextBox();
            this.TotalA = new System.Windows.Forms.TextBox();
            this.BtnBuscarA = new System.Windows.Forms.PictureBox();
            this.BuscarA = new System.Windows.Forms.TextBox();
            this.btnNuevoA = new System.Windows.Forms.PictureBox();
            this.btnGuardarA = new System.Windows.Forms.PictureBox();
            this.btnEditarA = new System.Windows.Forms.PictureBox();
            this.btnEliminarA = new System.Windows.Forms.PictureBox();
            this.btnImprimirA = new System.Windows.Forms.PictureBox();
            this.btnSalirA = new System.Windows.Forms.PictureBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Sistema_de_facturación.FacturacionDataSetTableAdapters.ClienteTableAdapter();
            this.articuloTableAdapter = new Sistema_de_facturación.FacturacionDataSetTableAdapters.ArticuloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevoA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimirA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalirA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvArticulos
            // 
            this.DgvArticulos.AutoGenerateColumns = false;
            this.DgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DgvArticulos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codArtDataGridViewTextBoxColumn,
            this.desArtDataGridViewTextBoxColumn,
            this.cosArtDataGridViewTextBoxColumn,
            this.preArtDataGridViewTextBoxColumn,
            this.exiArtDataGridViewTextBoxColumn,
            this.canMinDataGridViewTextBoxColumn});
            this.DgvArticulos.DataSource = this.articuloBindingSource;
            this.DgvArticulos.Location = new System.Drawing.Point(536, 67);
            this.DgvArticulos.Name = "DgvArticulos";
            this.DgvArticulos.RowHeadersWidth = 51;
            this.DgvArticulos.RowTemplate.Height = 24;
            this.DgvArticulos.Size = new System.Drawing.Size(580, 306);
            this.DgvArticulos.TabIndex = 0;
            // 
            // codArtDataGridViewTextBoxColumn
            // 
            this.codArtDataGridViewTextBoxColumn.DataPropertyName = "Cod_Art";
            this.codArtDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codArtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codArtDataGridViewTextBoxColumn.Name = "codArtDataGridViewTextBoxColumn";
            this.codArtDataGridViewTextBoxColumn.Width = 81;
            // 
            // desArtDataGridViewTextBoxColumn
            // 
            this.desArtDataGridViewTextBoxColumn.DataPropertyName = "Des_Art";
            this.desArtDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.desArtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.desArtDataGridViewTextBoxColumn.Name = "desArtDataGridViewTextBoxColumn";
            this.desArtDataGridViewTextBoxColumn.Width = 111;
            // 
            // cosArtDataGridViewTextBoxColumn
            // 
            this.cosArtDataGridViewTextBoxColumn.DataPropertyName = "Cos_Art";
            this.cosArtDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.cosArtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cosArtDataGridViewTextBoxColumn.Name = "cosArtDataGridViewTextBoxColumn";
            this.cosArtDataGridViewTextBoxColumn.Width = 73;
            // 
            // preArtDataGridViewTextBoxColumn
            // 
            this.preArtDataGridViewTextBoxColumn.DataPropertyName = "Pre_Art";
            this.preArtDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.preArtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.preArtDataGridViewTextBoxColumn.Name = "preArtDataGridViewTextBoxColumn";
            this.preArtDataGridViewTextBoxColumn.Width = 77;
            // 
            // exiArtDataGridViewTextBoxColumn
            // 
            this.exiArtDataGridViewTextBoxColumn.DataPropertyName = "Exi_Art";
            this.exiArtDataGridViewTextBoxColumn.HeaderText = "Existencia";
            this.exiArtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.exiArtDataGridViewTextBoxColumn.Name = "exiArtDataGridViewTextBoxColumn";
            // 
            // canMinDataGridViewTextBoxColumn
            // 
            this.canMinDataGridViewTextBoxColumn.DataPropertyName = "Can_Min";
            this.canMinDataGridViewTextBoxColumn.HeaderText = "Cantidad minima";
            this.canMinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.canMinDataGridViewTextBoxColumn.Name = "canMinDataGridViewTextBoxColumn";
            this.canMinDataGridViewTextBoxColumn.Width = 129;
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataMember = "Articulo";
            this.articuloBindingSource.DataSource = this.facturacionDataSet;
            // 
            // facturacionDataSet
            // 
            this.facturacionDataSet.DataSetName = "FacturacionDataSet";
            this.facturacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCodA
            // 
            this.lblCodA.AutoSize = true;
            this.lblCodA.BackColor = System.Drawing.Color.Transparent;
            this.lblCodA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCodA.Location = new System.Drawing.Point(92, 20);
            this.lblCodA.Name = "lblCodA";
            this.lblCodA.Size = new System.Drawing.Size(99, 29);
            this.lblCodA.TabIndex = 1;
            this.lblCodA.Text = "Código";
            // 
            // lblDesA
            // 
            this.lblDesA.AutoSize = true;
            this.lblDesA.BackColor = System.Drawing.Color.Transparent;
            this.lblDesA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDesA.Location = new System.Drawing.Point(6, 70);
            this.lblDesA.Name = "lblDesA";
            this.lblDesA.Size = new System.Drawing.Size(186, 29);
            this.lblDesA.TabIndex = 2;
            this.lblDesA.Text = "Descripción(*)";
            // 
            // lblCosA
            // 
            this.lblCosA.AutoSize = true;
            this.lblCosA.BackColor = System.Drawing.Color.Transparent;
            this.lblCosA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCosA.Location = new System.Drawing.Point(78, 128);
            this.lblCosA.Name = "lblCosA";
            this.lblCosA.Size = new System.Drawing.Size(113, 29);
            this.lblCosA.TabIndex = 3;
            this.lblCosA.Text = "Costo(*)";
            // 
            // lblPrecioA
            // 
            this.lblPrecioA.AutoSize = true;
            this.lblPrecioA.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPrecioA.Location = new System.Drawing.Point(71, 182);
            this.lblPrecioA.Name = "lblPrecioA";
            this.lblPrecioA.Size = new System.Drawing.Size(120, 29);
            this.lblPrecioA.TabIndex = 4;
            this.lblPrecioA.Text = "Precio(*)";
            // 
            // lblCantidadA
            // 
            this.lblCantidadA.AutoSize = true;
            this.lblCantidadA.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidadA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCantidadA.Location = new System.Drawing.Point(69, 236);
            this.lblCantidadA.Name = "lblCantidadA";
            this.lblCantidadA.Size = new System.Drawing.Size(122, 29);
            this.lblCantidadA.TabIndex = 5;
            this.lblCantidadA.Text = "Cantidad";
            // 
            // lblExistenciaA
            // 
            this.lblExistenciaA.AutoSize = true;
            this.lblExistenciaA.BackColor = System.Drawing.Color.Transparent;
            this.lblExistenciaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistenciaA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblExistenciaA.Location = new System.Drawing.Point(52, 290);
            this.lblExistenciaA.Name = "lblExistenciaA";
            this.lblExistenciaA.Size = new System.Drawing.Size(139, 29);
            this.lblExistenciaA.TabIndex = 6;
            this.lblExistenciaA.Text = "Existencia";
            // 
            // lblCanMinimaA
            // 
            this.lblCanMinimaA.AutoSize = true;
            this.lblCanMinimaA.BackColor = System.Drawing.Color.Transparent;
            this.lblCanMinimaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanMinimaA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCanMinimaA.Location = new System.Drawing.Point(24, 344);
            this.lblCanMinimaA.Name = "lblCanMinimaA";
            this.lblCanMinimaA.Size = new System.Drawing.Size(167, 29);
            this.lblCanMinimaA.TabIndex = 7;
            this.lblCanMinimaA.Text = "Can. Minima";
            // 
            // lblTotalA
            // 
            this.lblTotalA.AutoSize = true;
            this.lblTotalA.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalA.Location = new System.Drawing.Point(531, 394);
            this.lblTotalA.Name = "lblTotalA";
            this.lblTotalA.Size = new System.Drawing.Size(74, 29);
            this.lblTotalA.TabIndex = 8;
            this.lblTotalA.Text = "Total";
            // 
            // CodigoA
            // 
            this.CodigoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoA.Location = new System.Drawing.Point(197, 13);
            this.CodigoA.Name = "CodigoA";
            this.CodigoA.Size = new System.Drawing.Size(221, 36);
            this.CodigoA.TabIndex = 9;
            this.CodigoA.TextChanged += new System.EventHandler(this.txtboxCodA_TextChanged);
            this.CodigoA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxCodA_KeyPress);
            // 
            // DescripcionA
            // 
            this.DescripcionA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionA.Location = new System.Drawing.Point(197, 67);
            this.DescripcionA.Name = "DescripcionA";
            this.DescripcionA.Size = new System.Drawing.Size(303, 36);
            this.DescripcionA.TabIndex = 10;
            this.DescripcionA.TextChanged += new System.EventHandler(this.txtboxDesA_TextChanged);
            this.DescripcionA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxDesA_KeyPress);
            // 
            // PrecioA
            // 
            this.PrecioA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioA.Location = new System.Drawing.Point(197, 175);
            this.PrecioA.Name = "PrecioA";
            this.PrecioA.Size = new System.Drawing.Size(221, 36);
            this.PrecioA.TabIndex = 12;
            this.PrecioA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxPrecioA_KeyPress);
            // 
            // ExistenciaA
            // 
            this.ExistenciaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExistenciaA.Location = new System.Drawing.Point(197, 283);
            this.ExistenciaA.Name = "ExistenciaA";
            this.ExistenciaA.Size = new System.Drawing.Size(221, 36);
            this.ExistenciaA.TabIndex = 14;
            this.ExistenciaA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxExistenciaA_KeyPress);
            // 
            // CantidadA
            // 
            this.CantidadA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadA.Location = new System.Drawing.Point(197, 229);
            this.CantidadA.Name = "CantidadA";
            this.CantidadA.Size = new System.Drawing.Size(221, 36);
            this.CantidadA.TabIndex = 13;
            this.CantidadA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxCantidadA_KeyPress);
            // 
            // CostoA
            // 
            this.CostoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostoA.Location = new System.Drawing.Point(197, 121);
            this.CostoA.Name = "CostoA";
            this.CostoA.Size = new System.Drawing.Size(221, 36);
            this.CostoA.TabIndex = 11;
            this.CostoA.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.CostoA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxCostoA_KeyPress);
            // 
            // CanMinimaA
            // 
            this.CanMinimaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanMinimaA.Location = new System.Drawing.Point(197, 337);
            this.CanMinimaA.Name = "CanMinimaA";
            this.CanMinimaA.Size = new System.Drawing.Size(221, 36);
            this.CanMinimaA.TabIndex = 15;
            this.CanMinimaA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxCanMinimaA_KeyPress);
            // 
            // TotalA
            // 
            this.TotalA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalA.Location = new System.Drawing.Point(613, 387);
            this.TotalA.Name = "TotalA";
            this.TotalA.Size = new System.Drawing.Size(503, 36);
            this.TotalA.TabIndex = 18;
            this.TotalA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxTotalA_KeyPress);
            // 
            // BtnBuscarA
            // 
            this.BtnBuscarA.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscarA.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarA.Image")));
            this.BtnBuscarA.Location = new System.Drawing.Point(536, 13);
            this.BtnBuscarA.Name = "BtnBuscarA";
            this.BtnBuscarA.Size = new System.Drawing.Size(55, 40);
            this.BtnBuscarA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnBuscarA.TabIndex = 17;
            this.BtnBuscarA.TabStop = false;
            this.BtnBuscarA.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BuscarA
            // 
            this.BuscarA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarA.Location = new System.Drawing.Point(597, 17);
            this.BuscarA.Name = "BuscarA";
            this.BuscarA.Size = new System.Drawing.Size(519, 36);
            this.BuscarA.TabIndex = 16;
            this.BuscarA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxBuscarA_KeyPress);
            this.BuscarA.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BuscarA_KeyUp);
            // 
            // btnNuevoA
            // 
            this.btnNuevoA.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoA.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoA.Image")));
            this.btnNuevoA.Location = new System.Drawing.Point(68, 443);
            this.btnNuevoA.Name = "btnNuevoA";
            this.btnNuevoA.Size = new System.Drawing.Size(87, 75);
            this.btnNuevoA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNuevoA.TabIndex = 19;
            this.btnNuevoA.TabStop = false;
            this.btnNuevoA.Click += new System.EventHandler(this.btnNuevoA_Click);
            // 
            // btnGuardarA
            // 
            this.btnGuardarA.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarA.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarA.Image")));
            this.btnGuardarA.Location = new System.Drawing.Point(210, 443);
            this.btnGuardarA.Name = "btnGuardarA";
            this.btnGuardarA.Size = new System.Drawing.Size(87, 75);
            this.btnGuardarA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGuardarA.TabIndex = 20;
            this.btnGuardarA.TabStop = false;
            this.btnGuardarA.Click += new System.EventHandler(this.btnGuardarA_Click);
            // 
            // btnEditarA
            // 
            this.btnEditarA.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarA.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarA.Image")));
            this.btnEditarA.Location = new System.Drawing.Point(352, 443);
            this.btnEditarA.Name = "btnEditarA";
            this.btnEditarA.Size = new System.Drawing.Size(87, 75);
            this.btnEditarA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEditarA.TabIndex = 21;
            this.btnEditarA.TabStop = false;
            this.btnEditarA.Click += new System.EventHandler(this.btnEditarA_Click);
            // 
            // btnEliminarA
            // 
            this.btnEliminarA.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarA.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarA.Image")));
            this.btnEliminarA.Location = new System.Drawing.Point(494, 443);
            this.btnEliminarA.Name = "btnEliminarA";
            this.btnEliminarA.Size = new System.Drawing.Size(87, 75);
            this.btnEliminarA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEliminarA.TabIndex = 22;
            this.btnEliminarA.TabStop = false;
            this.btnEliminarA.Click += new System.EventHandler(this.btnEliminarA_Click);
            // 
            // btnImprimirA
            // 
            this.btnImprimirA.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimirA.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirA.Image")));
            this.btnImprimirA.Location = new System.Drawing.Point(636, 443);
            this.btnImprimirA.Name = "btnImprimirA";
            this.btnImprimirA.Size = new System.Drawing.Size(87, 75);
            this.btnImprimirA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnImprimirA.TabIndex = 23;
            this.btnImprimirA.TabStop = false;
            this.btnImprimirA.Click += new System.EventHandler(this.btnImprimirA_Click);
            // 
            // btnSalirA
            // 
            this.btnSalirA.BackColor = System.Drawing.Color.Transparent;
            this.btnSalirA.Image = ((System.Drawing.Image)(resources.GetObject("btnSalirA.Image")));
            this.btnSalirA.Location = new System.Drawing.Point(778, 443);
            this.btnSalirA.Name = "btnSalirA";
            this.btnSalirA.Size = new System.Drawing.Size(87, 75);
            this.btnSalirA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalirA.TabIndex = 24;
            this.btnSalirA.TabStop = false;
            this.btnSalirA.Click += new System.EventHandler(this.pictureBox7_Click_1);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.facturacionDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // articuloTableAdapter
            // 
            this.articuloTableAdapter.ClearBeforeFill = true;
            // 
            // Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1126, 544);
            this.Controls.Add(this.btnSalirA);
            this.Controls.Add(this.btnImprimirA);
            this.Controls.Add(this.btnEliminarA);
            this.Controls.Add(this.btnEditarA);
            this.Controls.Add(this.btnGuardarA);
            this.Controls.Add(this.btnNuevoA);
            this.Controls.Add(this.BuscarA);
            this.Controls.Add(this.BtnBuscarA);
            this.Controls.Add(this.TotalA);
            this.Controls.Add(this.CanMinimaA);
            this.Controls.Add(this.CostoA);
            this.Controls.Add(this.CantidadA);
            this.Controls.Add(this.ExistenciaA);
            this.Controls.Add(this.PrecioA);
            this.Controls.Add(this.DescripcionA);
            this.Controls.Add(this.CodigoA);
            this.Controls.Add(this.lblTotalA);
            this.Controls.Add(this.lblCanMinimaA);
            this.Controls.Add(this.lblExistenciaA);
            this.Controls.Add(this.lblCantidadA);
            this.Controls.Add(this.lblPrecioA);
            this.Controls.Add(this.lblCosA);
            this.Controls.Add(this.lblDesA);
            this.Controls.Add(this.lblCodA);
            this.Controls.Add(this.DgvArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Articulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Artículos";
            this.Load += new System.EventHandler(this.Articulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevoA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimirA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalirA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvArticulos;
        private System.Windows.Forms.Label lblCodA;
        private System.Windows.Forms.Label lblDesA;
        private System.Windows.Forms.Label lblCosA;
        private System.Windows.Forms.Label lblPrecioA;
        private System.Windows.Forms.Label lblCantidadA;
        private System.Windows.Forms.Label lblExistenciaA;
        private System.Windows.Forms.Label lblCanMinimaA;
        private System.Windows.Forms.Label lblTotalA;
        private System.Windows.Forms.TextBox CodigoA;
        private System.Windows.Forms.TextBox DescripcionA;
        private System.Windows.Forms.TextBox PrecioA;
        private System.Windows.Forms.TextBox ExistenciaA;
        private System.Windows.Forms.TextBox CantidadA;
        private System.Windows.Forms.TextBox CostoA;
        private System.Windows.Forms.TextBox CanMinimaA;
        private System.Windows.Forms.TextBox TotalA;
        private System.Windows.Forms.PictureBox BtnBuscarA;
        private System.Windows.Forms.TextBox BuscarA;
        private System.Windows.Forms.PictureBox btnNuevoA;
        private System.Windows.Forms.PictureBox btnGuardarA;
        private System.Windows.Forms.PictureBox btnEditarA;
        private System.Windows.Forms.PictureBox btnEliminarA;
        private System.Windows.Forms.PictureBox btnImprimirA;
        private System.Windows.Forms.PictureBox btnSalirA;
        private FacturacionDataSet facturacionDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private FacturacionDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private FacturacionDataSetTableAdapters.ArticuloTableAdapter articuloTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cosArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exiArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn canMinDataGridViewTextBoxColumn;
    }
}