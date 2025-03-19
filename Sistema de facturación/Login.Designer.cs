
namespace Sistema_de_facturación
{
    partial class login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.lbluser = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.pboxLogIn = new System.Windows.Forms.PictureBox();
            this.pboxLogOut = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(248, 22);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(107, 29);
            this.lbluser.TabIndex = 0;
            this.lbluser.Text = "Usuario";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(202, 70);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(153, 29);
            this.lblpassword.TabIndex = 1;
            this.lblpassword.Text = "Contraseña";
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(361, 22);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(213, 36);
            this.txtuser.TabIndex = 2;
            this.txtuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtuser_KeyPress);
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(361, 70);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(213, 36);
            this.txtpassword.TabIndex = 3;
            this.txtpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpassword_KeyPress);
            // 
            // pboxLogIn
            // 
            this.pboxLogIn.Image = ((System.Drawing.Image)(resources.GetObject("pboxLogIn.Image")));
            this.pboxLogIn.InitialImage = null;
            this.pboxLogIn.Location = new System.Drawing.Point(271, 138);
            this.pboxLogIn.Name = "pboxLogIn";
            this.pboxLogIn.Size = new System.Drawing.Size(87, 78);
            this.pboxLogIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxLogIn.TabIndex = 4;
            this.pboxLogIn.TabStop = false;
            this.pboxLogIn.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pboxLogIn_LoadCompleted);
            this.pboxLogIn.Click += new System.EventHandler(this.pboxLogIn_Click);
            // 
            // pboxLogOut
            // 
            this.pboxLogOut.Image = ((System.Drawing.Image)(resources.GetObject("pboxLogOut.Image")));
            this.pboxLogOut.Location = new System.Drawing.Point(430, 138);
            this.pboxLogOut.Name = "pboxLogOut";
            this.pboxLogOut.Size = new System.Drawing.Size(87, 78);
            this.pboxLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxLogOut.TabIndex = 5;
            this.pboxLogOut.TabStop = false;
            this.pboxLogOut.Click += new System.EventHandler(this.pboxLogOut_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(184, 186);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 244);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pboxLogOut);
            this.Controls.Add(this.pboxLogIn);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lbluser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada al Sistema";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.PictureBox pboxLogIn;
        private System.Windows.Forms.PictureBox pboxLogOut;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

