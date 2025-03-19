
namespace Sistema_de_facturación
{
    partial class Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            this.btnSalirU = new System.Windows.Forms.PictureBox();
            this.btnImprimirU = new System.Windows.Forms.PictureBox();
            this.btnEditarU = new System.Windows.Forms.PictureBox();
            this.btnGuardarU = new System.Windows.Forms.PictureBox();
            this.btnNuevoU = new System.Windows.Forms.PictureBox();
            this.BuscarU = new System.Windows.Forms.TextBox();
            this.btnBuscarU = new System.Windows.Forms.PictureBox();
            this.TotalU = new System.Windows.Forms.TextBox();
            this.CorreoU = new System.Windows.Forms.TextBox();
            this.ClaveU = new System.Windows.Forms.TextBox();
            this.ConClaveU = new System.Windows.Forms.TextBox();
            this.CelularU = new System.Windows.Forms.TextBox();
            this.NombreU = new System.Windows.Forms.TextBox();
            this.CodigoU = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvUsuario = new System.Windows.Forms.DataGridView();
            this.codUsuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomUsuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claUsuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celUsuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corUsuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturacionDataSet = new Sistema_de_facturación.FacturacionDataSet();
            this.usuarioTableAdapter = new Sistema_de_facturación.FacturacionDataSetTableAdapters.UsuarioTableAdapter();
            this.btnEliminarU = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalirU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimirU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardarU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevoU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarU)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalirU
            // 
            this.btnSalirU.BackColor = System.Drawing.Color.Transparent;
            this.btnSalirU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirU.Image = ((System.Drawing.Image)(resources.GetObject("btnSalirU.Image")));
            this.btnSalirU.Location = new System.Drawing.Point(808, 431);
            this.btnSalirU.Name = "btnSalirU";
            this.btnSalirU.Size = new System.Drawing.Size(87, 75);
            this.btnSalirU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalirU.TabIndex = 49;
            this.btnSalirU.TabStop = false;
            this.btnSalirU.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // btnImprimirU
            // 
            this.btnImprimirU.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimirU.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirU.Image")));
            this.btnImprimirU.Location = new System.Drawing.Point(666, 431);
            this.btnImprimirU.Name = "btnImprimirU";
            this.btnImprimirU.Size = new System.Drawing.Size(87, 75);
            this.btnImprimirU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnImprimirU.TabIndex = 48;
            this.btnImprimirU.TabStop = false;
            this.btnImprimirU.Click += new System.EventHandler(this.btnImprimirU_Click);
            // 
            // btnEditarU
            // 
            this.btnEditarU.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarU.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarU.Image")));
            this.btnEditarU.Location = new System.Drawing.Point(382, 431);
            this.btnEditarU.Name = "btnEditarU";
            this.btnEditarU.Size = new System.Drawing.Size(87, 75);
            this.btnEditarU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEditarU.TabIndex = 46;
            this.btnEditarU.TabStop = false;
            this.btnEditarU.Click += new System.EventHandler(this.btnEditarU_Click);
            // 
            // btnGuardarU
            // 
            this.btnGuardarU.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarU.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarU.Image")));
            this.btnGuardarU.Location = new System.Drawing.Point(240, 431);
            this.btnGuardarU.Name = "btnGuardarU";
            this.btnGuardarU.Size = new System.Drawing.Size(87, 75);
            this.btnGuardarU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGuardarU.TabIndex = 45;
            this.btnGuardarU.TabStop = false;
            this.btnGuardarU.Click += new System.EventHandler(this.btnGuardarU_Click);
            // 
            // btnNuevoU
            // 
            this.btnNuevoU.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevoU.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoU.Image")));
            this.btnNuevoU.Location = new System.Drawing.Point(98, 431);
            this.btnNuevoU.Name = "btnNuevoU";
            this.btnNuevoU.Size = new System.Drawing.Size(87, 75);
            this.btnNuevoU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNuevoU.TabIndex = 44;
            this.btnNuevoU.TabStop = false;
            this.btnNuevoU.Click += new System.EventHandler(this.btnNuevoU_Click);
            // 
            // BuscarU
            // 
            this.BuscarU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarU.Location = new System.Drawing.Point(657, 10);
            this.BuscarU.Name = "BuscarU";
            this.BuscarU.Size = new System.Drawing.Size(331, 36);
            this.BuscarU.TabIndex = 41;
            this.BuscarU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxBuscarU_KeyPress);
            // 
            // btnBuscarU
            // 
            this.btnBuscarU.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarU.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarU.Image")));
            this.btnBuscarU.Location = new System.Drawing.Point(596, 6);
            this.btnBuscarU.Name = "btnBuscarU";
            this.btnBuscarU.Size = new System.Drawing.Size(55, 40);
            this.btnBuscarU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscarU.TabIndex = 42;
            this.btnBuscarU.TabStop = false;
            // 
            // TotalU
            // 
            this.TotalU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalU.Location = new System.Drawing.Point(673, 380);
            this.TotalU.Name = "TotalU";
            this.TotalU.Size = new System.Drawing.Size(315, 36);
            this.TotalU.TabIndex = 43;
            this.TotalU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxTotalU_KeyPress);
            // 
            // CorreoU
            // 
            this.CorreoU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoU.Location = new System.Drawing.Point(261, 280);
            this.CorreoU.Name = "CorreoU";
            this.CorreoU.Size = new System.Drawing.Size(329, 36);
            this.CorreoU.TabIndex = 40;
            this.CorreoU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxCorreoU_KeyPress);
            // 
            // ClaveU
            // 
            this.ClaveU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaveU.Location = new System.Drawing.Point(261, 118);
            this.ClaveU.Name = "ClaveU";
            this.ClaveU.Size = new System.Drawing.Size(221, 36);
            this.ClaveU.TabIndex = 36;
            this.ClaveU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxClaveU_KeyPress);
            // 
            // ConClaveU
            // 
            this.ConClaveU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConClaveU.Location = new System.Drawing.Point(261, 172);
            this.ConClaveU.Name = "ConClaveU";
            this.ConClaveU.Size = new System.Drawing.Size(221, 36);
            this.ConClaveU.TabIndex = 38;
            this.ConClaveU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxConClaveU_KeyPress);
            // 
            // CelularU
            // 
            this.CelularU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelularU.Location = new System.Drawing.Point(261, 226);
            this.CelularU.Name = "CelularU";
            this.CelularU.Size = new System.Drawing.Size(221, 36);
            this.CelularU.TabIndex = 39;
            this.CelularU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxCelularU_KeyPress);
            // 
            // NombreU
            // 
            this.NombreU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreU.Location = new System.Drawing.Point(261, 64);
            this.NombreU.Name = "NombreU";
            this.NombreU.Size = new System.Drawing.Size(303, 36);
            this.NombreU.TabIndex = 35;
            this.NombreU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxNombreU_KeyPress);
            // 
            // CodigoU
            // 
            this.CodigoU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoU.Location = new System.Drawing.Point(261, 10);
            this.CodigoU.Name = "CodigoU";
            this.CodigoU.Size = new System.Drawing.Size(221, 36);
            this.CodigoU.TabIndex = 34;
            this.CodigoU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxCodU_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(591, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 29);
            this.label8.TabIndex = 33;
            this.label8.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(148, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 29);
            this.label7.TabIndex = 32;
            this.label7.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(142, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 29);
            this.label6.TabIndex = 31;
            this.label6.Text = "Celular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(3, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 29);
            this.label5.TabIndex = 30;
            this.label5.Text = "Confirmar Clave(*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(130, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "Clave(*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(134, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(144, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Código";
            // 
            // DgvUsuario
            // 
            this.DgvUsuario.AutoGenerateColumns = false;
            this.DgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DgvUsuario.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codUsuDataGridViewTextBoxColumn,
            this.nomUsuDataGridViewTextBoxColumn,
            this.claUsuDataGridViewTextBoxColumn,
            this.celUsuDataGridViewTextBoxColumn,
            this.corUsuDataGridViewTextBoxColumn});
            this.DgvUsuario.DataSource = this.usuarioBindingSource;
            this.DgvUsuario.Location = new System.Drawing.Point(596, 60);
            this.DgvUsuario.Name = "DgvUsuario";
            this.DgvUsuario.RowHeadersWidth = 51;
            this.DgvUsuario.RowTemplate.Height = 24;
            this.DgvUsuario.Size = new System.Drawing.Size(447, 306);
            this.DgvUsuario.TabIndex = 25;
            // 
            // codUsuDataGridViewTextBoxColumn
            // 
            this.codUsuDataGridViewTextBoxColumn.DataPropertyName = "Cod_Usu";
            this.codUsuDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codUsuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codUsuDataGridViewTextBoxColumn.Name = "codUsuDataGridViewTextBoxColumn";
            this.codUsuDataGridViewTextBoxColumn.Width = 81;
            // 
            // nomUsuDataGridViewTextBoxColumn
            // 
            this.nomUsuDataGridViewTextBoxColumn.DataPropertyName = "Nom_Usu";
            this.nomUsuDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nomUsuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomUsuDataGridViewTextBoxColumn.Name = "nomUsuDataGridViewTextBoxColumn";
            this.nomUsuDataGridViewTextBoxColumn.Width = 87;
            // 
            // claUsuDataGridViewTextBoxColumn
            // 
            this.claUsuDataGridViewTextBoxColumn.DataPropertyName = "Cla_Usu";
            this.claUsuDataGridViewTextBoxColumn.HeaderText = "Clave";
            this.claUsuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.claUsuDataGridViewTextBoxColumn.Name = "claUsuDataGridViewTextBoxColumn";
            this.claUsuDataGridViewTextBoxColumn.Width = 72;
            // 
            // celUsuDataGridViewTextBoxColumn
            // 
            this.celUsuDataGridViewTextBoxColumn.DataPropertyName = "Cel_Usu";
            this.celUsuDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celUsuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.celUsuDataGridViewTextBoxColumn.Name = "celUsuDataGridViewTextBoxColumn";
            this.celUsuDataGridViewTextBoxColumn.Width = 81;
            // 
            // corUsuDataGridViewTextBoxColumn
            // 
            this.corUsuDataGridViewTextBoxColumn.DataPropertyName = "Cor_Usu";
            this.corUsuDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.corUsuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.corUsuDataGridViewTextBoxColumn.Name = "corUsuDataGridViewTextBoxColumn";
            this.corUsuDataGridViewTextBoxColumn.Width = 80;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.facturacionDataSet;
            // 
            // facturacionDataSet
            // 
            this.facturacionDataSet.DataSetName = "FacturacionDataSet";
            this.facturacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // btnEliminarU
            // 
            this.btnEliminarU.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarU.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarU.Image")));
            this.btnEliminarU.Location = new System.Drawing.Point(526, 431);
            this.btnEliminarU.Name = "btnEliminarU";
            this.btnEliminarU.Size = new System.Drawing.Size(87, 75);
            this.btnEliminarU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEliminarU.TabIndex = 50;
            this.btnEliminarU.TabStop = false;
            this.btnEliminarU.Click += new System.EventHandler(this.btnEliminarU_Click);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1055, 523);
            this.Controls.Add(this.btnEliminarU);
            this.Controls.Add(this.btnSalirU);
            this.Controls.Add(this.btnImprimirU);
            this.Controls.Add(this.btnEditarU);
            this.Controls.Add(this.btnGuardarU);
            this.Controls.Add(this.btnNuevoU);
            this.Controls.Add(this.BuscarU);
            this.Controls.Add(this.btnBuscarU);
            this.Controls.Add(this.TotalU);
            this.Controls.Add(this.CorreoU);
            this.Controls.Add(this.ClaveU);
            this.Controls.Add(this.ConClaveU);
            this.Controls.Add(this.CelularU);
            this.Controls.Add(this.NombreU);
            this.Controls.Add(this.CodigoU);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalirU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimirU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditarU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardarU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevoU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnSalirU;
        private System.Windows.Forms.PictureBox btnImprimirU;
        private System.Windows.Forms.PictureBox btnEditarU;
        private System.Windows.Forms.PictureBox btnGuardarU;
        private System.Windows.Forms.PictureBox btnNuevoU;
        private System.Windows.Forms.TextBox BuscarU;
        private System.Windows.Forms.PictureBox btnBuscarU;
        private System.Windows.Forms.TextBox TotalU;
        private System.Windows.Forms.TextBox CorreoU;
        private System.Windows.Forms.TextBox ClaveU;
        private System.Windows.Forms.TextBox ConClaveU;
        private System.Windows.Forms.TextBox CelularU;
        private System.Windows.Forms.TextBox NombreU;
        private System.Windows.Forms.TextBox CodigoU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvUsuario;
        private FacturacionDataSet facturacionDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private FacturacionDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codUsuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomUsuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claUsuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celUsuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corUsuDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox btnEliminarU;
    }
}