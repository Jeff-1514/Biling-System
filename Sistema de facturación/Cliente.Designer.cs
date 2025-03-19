
namespace Sistema_de_facturación
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.btnSalirC = new System.Windows.Forms.PictureBox();
            this.btnImprimirC = new System.Windows.Forms.PictureBox();
            this.btnEliminarC = new System.Windows.Forms.PictureBox();
            this.btnEditarC = new System.Windows.Forms.PictureBox();
            this.btnGuardarC = new System.Windows.Forms.PictureBox();
            this.btnNuevoC = new System.Windows.Forms.PictureBox();
            this.BuscarC = new System.Windows.Forms.TextBox();
            this.btnBuscarC = new System.Windows.Forms.PictureBox();
            this.TotalC = new System.Windows.Forms.TextBox();
            this.CorreoC = new System.Windows.Forms.TextBox();
            this.DireccionC = new System.Windows.Forms.TextBox();
            this.ContactoC = new System.Windows.Forms.TextBox();
            this.SectorC = new System.Windows.Forms.TextBox();
            this.NombreC = new System.Windows.Forms.TextBox();
            this.CodigoC = new System.Windows.Forms.TextBox();
            this.lblTotalC = new System.Windows.Forms.Label();
            this.lblCorreoC = new System.Windows.Forms.Label();
            this.lblContactoC = new System.Windows.Forms.Label();
            this.lblProvinciaC = new System.Windows.Forms.Label();
            this.lblSectorC = new System.Windows.Forms.Label();
            this.lblDirC = new System.Windows.Forms.Label();
            this.lblNombreC = new System.Windows.Forms.Label();
            this.lblCodC = new System.Windows.Forms.Label();
            this.DgvCliente = new System.Windows.Forms.DataGridView();
            this.codCliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apecliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secCliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proCliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conCliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturacionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturacionDataSet = new Sistema_de_facturación.FacturacionDataSet();
            this.ProvinciaC = new System.Windows.Forms.ComboBox();
            this.ApellidoC = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articuloTableAdapter = new Sistema_de_facturación.FacturacionDataSetTableAdapters.ArticuloTableAdapter();
            this.clienteTableAdapter = new Sistema_de_facturación.FacturacionDataSetTableAdapters.ClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalirC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimirC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardarC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevoC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirC
            // 
            this.btnSalirC.BackColor = System.Drawing.Color.Transparent;
            this.btnSalirC.Image = ((System.Drawing.Image)(resources.GetObject("btnSalirC.Image")));
            this.btnSalirC.Location = new System.Drawing.Point(720, 443);
            this.btnSalirC.Name = "btnSalirC";
            this.btnSalirC.Size = new System.Drawing.Size(87, 75);
            this.btnSalirC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalirC.TabIndex = 49;
            this.btnSalirC.TabStop = false;
            this.btnSalirC.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // btnImprimirC
            // 
            this.btnImprimirC.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimirC.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirC.Image")));
            this.btnImprimirC.Location = new System.Drawing.Point(578, 443);
            this.btnImprimirC.Name = "btnImprimirC";
            this.btnImprimirC.Size = new System.Drawing.Size(87, 75);
            this.btnImprimirC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnImprimirC.TabIndex = 48;
            this.btnImprimirC.TabStop = false;
            this.btnImprimirC.Click += new System.EventHandler(this.btnImprimirC_Click);
            // 
            // btnEliminarC
            // 
            this.btnEliminarC.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarC.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarC.Image")));
            this.btnEliminarC.Location = new System.Drawing.Point(436, 443);
            this.btnEliminarC.Name = "btnEliminarC";
            this.btnEliminarC.Size = new System.Drawing.Size(87, 75);
            this.btnEliminarC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEliminarC.TabIndex = 47;
            this.btnEliminarC.TabStop = false;
            this.btnEliminarC.Click += new System.EventHandler(this.btnEliminarC_Click);
            // 
            // btnEditarC
            // 
            this.btnEditarC.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarC.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarC.Image")));
            this.btnEditarC.Location = new System.Drawing.Point(294, 443);
            this.btnEditarC.Name = "btnEditarC";
            this.btnEditarC.Size = new System.Drawing.Size(87, 75);
            this.btnEditarC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEditarC.TabIndex = 46;
            this.btnEditarC.TabStop = false;
            this.btnEditarC.Click += new System.EventHandler(this.btnEditarC_Click);
            // 
            // btnGuardarC
            // 
            this.btnGuardarC.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarC.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarC.Image")));
            this.btnGuardarC.Location = new System.Drawing.Point(152, 443);
            this.btnGuardarC.Name = "btnGuardarC";
            this.btnGuardarC.Size = new System.Drawing.Size(87, 75);
            this.btnGuardarC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGuardarC.TabIndex = 45;
            this.btnGuardarC.TabStop = false;
            this.btnGuardarC.Click += new System.EventHandler(this.btnGuardarC_Click);
            // 
            // btnNuevoC
            // 
            this.btnNuevoC.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoC.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoC.Image")));
            this.btnNuevoC.Location = new System.Drawing.Point(10, 443);
            this.btnNuevoC.Name = "btnNuevoC";
            this.btnNuevoC.Size = new System.Drawing.Size(87, 75);
            this.btnNuevoC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNuevoC.TabIndex = 44;
            this.btnNuevoC.TabStop = false;
            this.btnNuevoC.Click += new System.EventHandler(this.btnNuevoC_Click);
            // 
            // BuscarC
            // 
            this.BuscarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarC.Location = new System.Drawing.Point(539, 17);
            this.BuscarC.Name = "BuscarC";
            this.BuscarC.Size = new System.Drawing.Size(331, 36);
            this.BuscarC.TabIndex = 42;
            this.BuscarC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxBuscarC_KeyPress);
            // 
            // btnBuscarC
            // 
            this.btnBuscarC.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarC.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarC.Image")));
            this.btnBuscarC.Location = new System.Drawing.Point(478, 13);
            this.btnBuscarC.Name = "btnBuscarC";
            this.btnBuscarC.Size = new System.Drawing.Size(55, 40);
            this.btnBuscarC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscarC.TabIndex = 42;
            this.btnBuscarC.TabStop = false;
            // 
            // TotalC
            // 
            this.TotalC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalC.Location = new System.Drawing.Point(555, 387);
            this.TotalC.Name = "TotalC";
            this.TotalC.Size = new System.Drawing.Size(315, 36);
            this.TotalC.TabIndex = 43;
            this.TotalC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxTotalC_KeyPress);
            // 
            // CorreoC
            // 
            this.CorreoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoC.Location = new System.Drawing.Point(139, 378);
            this.CorreoC.Name = "CorreoC";
            this.CorreoC.Size = new System.Drawing.Size(303, 36);
            this.CorreoC.TabIndex = 41;
            this.CorreoC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxCorreoC_KeyPress);
            // 
            // DireccionC
            // 
            this.DireccionC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DireccionC.Location = new System.Drawing.Point(139, 169);
            this.DireccionC.Name = "DireccionC";
            this.DireccionC.Size = new System.Drawing.Size(221, 36);
            this.DireccionC.TabIndex = 37;
            this.DireccionC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxDirC_KeyPress);
            // 
            // ContactoC
            // 
            this.ContactoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactoC.Location = new System.Drawing.Point(139, 326);
            this.ContactoC.Name = "ContactoC";
            this.ContactoC.Size = new System.Drawing.Size(221, 36);
            this.ContactoC.TabIndex = 40;
            this.ContactoC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxCelularC_KeyPress);
            // 
            // SectorC
            // 
            this.SectorC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectorC.Location = new System.Drawing.Point(139, 221);
            this.SectorC.Name = "SectorC";
            this.SectorC.Size = new System.Drawing.Size(221, 36);
            this.SectorC.TabIndex = 38;
            this.SectorC.TextChanged += new System.EventHandler(this.txtboxSectorC_TextChanged);
            this.SectorC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxSectorC_KeyPress);
            // 
            // NombreC
            // 
            this.NombreC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NombreC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreC.Location = new System.Drawing.Point(139, 65);
            this.NombreC.Name = "NombreC";
            this.NombreC.Size = new System.Drawing.Size(303, 36);
            this.NombreC.TabIndex = 35;
            this.NombreC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxNombreC_KeyPress);
            // 
            // CodigoC
            // 
            this.CodigoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoC.Location = new System.Drawing.Point(139, 13);
            this.CodigoC.Name = "CodigoC";
            this.CodigoC.Size = new System.Drawing.Size(221, 36);
            this.CodigoC.TabIndex = 34;
            this.CodigoC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxCodC_KeyPress);
            // 
            // lblTotalC
            // 
            this.lblTotalC.AutoSize = true;
            this.lblTotalC.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalC.Location = new System.Drawing.Point(473, 394);
            this.lblTotalC.Name = "lblTotalC";
            this.lblTotalC.Size = new System.Drawing.Size(74, 29);
            this.lblTotalC.TabIndex = 33;
            this.lblTotalC.Text = "Total";
            // 
            // lblCorreoC
            // 
            this.lblCorreoC.AutoSize = true;
            this.lblCorreoC.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCorreoC.Location = new System.Drawing.Point(38, 384);
            this.lblCorreoC.Name = "lblCorreoC";
            this.lblCorreoC.Size = new System.Drawing.Size(95, 29);
            this.lblCorreoC.TabIndex = 32;
            this.lblCorreoC.Text = "Correo";
            // 
            // lblContactoC
            // 
            this.lblContactoC.AutoSize = true;
            this.lblContactoC.BackColor = System.Drawing.Color.Transparent;
            this.lblContactoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactoC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblContactoC.Location = new System.Drawing.Point(11, 333);
            this.lblContactoC.Name = "lblContactoC";
            this.lblContactoC.Size = new System.Drawing.Size(122, 29);
            this.lblContactoC.TabIndex = 31;
            this.lblContactoC.Text = "Contacto";
            // 
            // lblProvinciaC
            // 
            this.lblProvinciaC.AutoSize = true;
            this.lblProvinciaC.BackColor = System.Drawing.Color.Transparent;
            this.lblProvinciaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvinciaC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblProvinciaC.Location = new System.Drawing.Point(6, 280);
            this.lblProvinciaC.Name = "lblProvinciaC";
            this.lblProvinciaC.Size = new System.Drawing.Size(127, 29);
            this.lblProvinciaC.TabIndex = 30;
            this.lblProvinciaC.Text = "Provincia";
            // 
            // lblSectorC
            // 
            this.lblSectorC.AutoSize = true;
            this.lblSectorC.BackColor = System.Drawing.Color.Transparent;
            this.lblSectorC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectorC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblSectorC.Location = new System.Drawing.Point(41, 228);
            this.lblSectorC.Name = "lblSectorC";
            this.lblSectorC.Size = new System.Drawing.Size(92, 29);
            this.lblSectorC.TabIndex = 29;
            this.lblSectorC.Text = "Sector";
            // 
            // lblDirC
            // 
            this.lblDirC.AutoSize = true;
            this.lblDirC.BackColor = System.Drawing.Color.Transparent;
            this.lblDirC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDirC.Location = new System.Drawing.Point(5, 176);
            this.lblDirC.Name = "lblDirC";
            this.lblDirC.Size = new System.Drawing.Size(128, 29);
            this.lblDirC.TabIndex = 28;
            this.lblDirC.Text = "Dirección";
            this.lblDirC.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblNombreC
            // 
            this.lblNombreC.AutoSize = true;
            this.lblNombreC.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblNombreC.Location = new System.Drawing.Point(24, 72);
            this.lblNombreC.Name = "lblNombreC";
            this.lblNombreC.Size = new System.Drawing.Size(109, 29);
            this.lblNombreC.TabIndex = 27;
            this.lblNombreC.Text = "Nombre";
            // 
            // lblCodC
            // 
            this.lblCodC.AutoSize = true;
            this.lblCodC.BackColor = System.Drawing.Color.Transparent;
            this.lblCodC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCodC.Location = new System.Drawing.Point(34, 20);
            this.lblCodC.Name = "lblCodC";
            this.lblCodC.Size = new System.Drawing.Size(99, 29);
            this.lblCodC.TabIndex = 26;
            this.lblCodC.Text = "Código";
            // 
            // DgvCliente
            // 
            this.DgvCliente.AllowUserToOrderColumns = true;
            this.DgvCliente.AutoGenerateColumns = false;
            this.DgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DgvCliente.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codCliDataGridViewTextBoxColumn,
            this.nomCliDataGridViewTextBoxColumn,
            this.apecliDataGridViewTextBoxColumn,
            this.secCliDataGridViewTextBoxColumn,
            this.proCliDataGridViewTextBoxColumn,
            this.conCliDataGridViewTextBoxColumn});
            this.DgvCliente.DataSource = this.clienteBindingSource;
            this.DgvCliente.Location = new System.Drawing.Point(478, 67);
            this.DgvCliente.Name = "DgvCliente";
            this.DgvCliente.RowHeadersWidth = 51;
            this.DgvCliente.RowTemplate.Height = 24;
            this.DgvCliente.Size = new System.Drawing.Size(705, 306);
            this.DgvCliente.TabIndex = 25;
            // 
            // codCliDataGridViewTextBoxColumn
            // 
            this.codCliDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codCliDataGridViewTextBoxColumn.DataPropertyName = "Cod_Cli";
            this.codCliDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codCliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codCliDataGridViewTextBoxColumn.Name = "codCliDataGridViewTextBoxColumn";
            // 
            // nomCliDataGridViewTextBoxColumn
            // 
            this.nomCliDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomCliDataGridViewTextBoxColumn.DataPropertyName = "Nom_Cli";
            this.nomCliDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nomCliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomCliDataGridViewTextBoxColumn.Name = "nomCliDataGridViewTextBoxColumn";
            // 
            // apecliDataGridViewTextBoxColumn
            // 
            this.apecliDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apecliDataGridViewTextBoxColumn.DataPropertyName = "Ape_cli";
            this.apecliDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apecliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apecliDataGridViewTextBoxColumn.Name = "apecliDataGridViewTextBoxColumn";
            // 
            // secCliDataGridViewTextBoxColumn
            // 
            this.secCliDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.secCliDataGridViewTextBoxColumn.DataPropertyName = "Sec_Cli";
            this.secCliDataGridViewTextBoxColumn.HeaderText = "Sector";
            this.secCliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.secCliDataGridViewTextBoxColumn.Name = "secCliDataGridViewTextBoxColumn";
            // 
            // proCliDataGridViewTextBoxColumn
            // 
            this.proCliDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.proCliDataGridViewTextBoxColumn.DataPropertyName = "Pro_Cli";
            this.proCliDataGridViewTextBoxColumn.HeaderText = "Provincia";
            this.proCliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.proCliDataGridViewTextBoxColumn.Name = "proCliDataGridViewTextBoxColumn";
            // 
            // conCliDataGridViewTextBoxColumn
            // 
            this.conCliDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.conCliDataGridViewTextBoxColumn.DataPropertyName = "Con_Cli";
            this.conCliDataGridViewTextBoxColumn.HeaderText = "Contacto";
            this.conCliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.conCliDataGridViewTextBoxColumn.Name = "conCliDataGridViewTextBoxColumn";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.facturacionDataSetBindingSource;
            // 
            // facturacionDataSetBindingSource
            // 
            this.facturacionDataSetBindingSource.DataSource = this.facturacionDataSet;
            this.facturacionDataSetBindingSource.Position = 0;
            // 
            // facturacionDataSet
            // 
            this.facturacionDataSet.DataSetName = "FacturacionDataSet";
            this.facturacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProvinciaC
            // 
            this.ProvinciaC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ProvinciaC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProvinciaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProvinciaC.FormattingEnabled = true;
            this.ProvinciaC.Items.AddRange(new object[] {
            "Santiago",
            "Puerto Plata",
            "La Vega ",
            "Bonao ",
            "Mao"});
            this.ProvinciaC.Location = new System.Drawing.Point(139, 273);
            this.ProvinciaC.Name = "ProvinciaC";
            this.ProvinciaC.Size = new System.Drawing.Size(221, 37);
            this.ProvinciaC.TabIndex = 39;
            this.ProvinciaC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBoxProvincia_KeyPress);
            // 
            // ApellidoC
            // 
            this.ApellidoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidoC.Location = new System.Drawing.Point(139, 117);
            this.ApellidoC.Name = "ApellidoC";
            this.ApellidoC.Size = new System.Drawing.Size(221, 36);
            this.ApellidoC.TabIndex = 36;
            this.ApellidoC.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblApellido.Location = new System.Drawing.Point(21, 124);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(112, 29);
            this.lblApellido.TabIndex = 50;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.Click += new System.EventHandler(this.label1_Click);
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataMember = "Articulo";
            this.articuloBindingSource.DataSource = this.facturacionDataSetBindingSource;
            // 
            // articuloTableAdapter
            // 
            this.articuloTableAdapter.ClearBeforeFill = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1195, 531);
            this.Controls.Add(this.ApellidoC);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.ProvinciaC);
            this.Controls.Add(this.btnSalirC);
            this.Controls.Add(this.btnImprimirC);
            this.Controls.Add(this.btnEliminarC);
            this.Controls.Add(this.btnEditarC);
            this.Controls.Add(this.btnGuardarC);
            this.Controls.Add(this.btnNuevoC);
            this.Controls.Add(this.BuscarC);
            this.Controls.Add(this.btnBuscarC);
            this.Controls.Add(this.TotalC);
            this.Controls.Add(this.CorreoC);
            this.Controls.Add(this.DireccionC);
            this.Controls.Add(this.ContactoC);
            this.Controls.Add(this.SectorC);
            this.Controls.Add(this.NombreC);
            this.Controls.Add(this.CodigoC);
            this.Controls.Add(this.lblTotalC);
            this.Controls.Add(this.lblCorreoC);
            this.Controls.Add(this.lblContactoC);
            this.Controls.Add(this.lblProvinciaC);
            this.Controls.Add(this.lblSectorC);
            this.Controls.Add(this.lblDirC);
            this.Controls.Add(this.lblNombreC);
            this.Controls.Add(this.lblCodC);
            this.Controls.Add(this.DgvCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Clientes";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalirC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimirC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardarC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevoC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnSalirC;
        private System.Windows.Forms.PictureBox btnImprimirC;
        private System.Windows.Forms.PictureBox btnEliminarC;
        private System.Windows.Forms.PictureBox btnEditarC;
        private System.Windows.Forms.PictureBox btnGuardarC;
        private System.Windows.Forms.PictureBox btnNuevoC;
        private System.Windows.Forms.TextBox BuscarC;
        private System.Windows.Forms.PictureBox btnBuscarC;
        private System.Windows.Forms.TextBox TotalC;
        private System.Windows.Forms.TextBox CorreoC;
        private System.Windows.Forms.TextBox DireccionC;
        private System.Windows.Forms.TextBox ContactoC;
        private System.Windows.Forms.TextBox SectorC;
        private System.Windows.Forms.TextBox NombreC;
        private System.Windows.Forms.TextBox CodigoC;
        private System.Windows.Forms.Label lblTotalC;
        private System.Windows.Forms.Label lblCorreoC;
        private System.Windows.Forms.Label lblContactoC;
        private System.Windows.Forms.Label lblProvinciaC;
        private System.Windows.Forms.Label lblSectorC;
        private System.Windows.Forms.Label lblDirC;
        private System.Windows.Forms.Label lblNombreC;
        private System.Windows.Forms.Label lblCodC;
        private System.Windows.Forms.DataGridView DgvCliente;
        private System.Windows.Forms.ComboBox ProvinciaC;
        private System.Windows.Forms.TextBox ApellidoC;
        private System.Windows.Forms.Label lblApellido;
        private FacturacionDataSet facturacionDataSet;
        private System.Windows.Forms.BindingSource facturacionDataSetBindingSource;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private FacturacionDataSetTableAdapters.ArticuloTableAdapter articuloTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private FacturacionDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apecliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secCliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proCliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conCliDataGridViewTextBoxColumn;
    }
}