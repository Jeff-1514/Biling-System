
namespace Sistema_de_facturación
{
    partial class F3P
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
            this.numero = new System.Windows.Forms.TextBox();
            this.CRV3P = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.V3p1 = new Sistema_de_facturación.V3p();
            this.SuspendLayout();
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(349, 31);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(100, 22);
            this.numero.TabIndex = 1;
            // 
            // CRV3P
            // 
            this.CRV3P.ActiveViewIndex = -1;
            this.CRV3P.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV3P.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.CRV3P.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRV3P.Location = new System.Drawing.Point(0, 0);
            this.CRV3P.Name = "CRV3P";
            this.CRV3P.ReportSource = this.V3p1;
            this.CRV3P.Size = new System.Drawing.Size(800, 450);
            this.CRV3P.TabIndex = 0;
            this.CRV3P.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // F3P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.CRV3P);
            this.Name = "F3P";
            this.Text = "Factura de 3 Pulgadas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV3P;
        public System.Windows.Forms.TextBox numero;
        private V3p V3p1;
    }
}