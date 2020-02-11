namespace Cliente
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.botonLogin = new System.Windows.Forms.Button();
            this.etiquetaRegistro = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.etiquetaPassword = new System.Windows.Forms.Label();
            this.etiquetaUser = new System.Windows.Forms.Label();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonInformacion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonLogin
            // 
            this.botonLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.botonLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonLogin.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonLogin.Location = new System.Drawing.Point(370, 379);
            this.botonLogin.Name = "botonLogin";
            this.botonLogin.Size = new System.Drawing.Size(172, 39);
            this.botonLogin.TabIndex = 4;
            this.botonLogin.Text = "INICIAR SESIÓN";
            this.botonLogin.UseVisualStyleBackColor = false;
            this.botonLogin.Click += new System.EventHandler(this.botonLogin_Click);
            // 
            // etiquetaRegistro
            // 
            this.etiquetaRegistro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.etiquetaRegistro.AutoSize = true;
            this.etiquetaRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.etiquetaRegistro.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaRegistro.ForeColor = System.Drawing.Color.Red;
            this.etiquetaRegistro.Location = new System.Drawing.Point(216, 439);
            this.etiquetaRegistro.Name = "etiquetaRegistro";
            this.etiquetaRegistro.Size = new System.Drawing.Size(383, 19);
            this.etiquetaRegistro.TabIndex = 6;
            this.etiquetaRegistro.Text = "¿No dispones de una cuenta? Regístrate ahora.";
            this.etiquetaRegistro.Click += new System.EventHandler(this.etiquetaRegistro_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPassword.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(317, 332);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(282, 41);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtUser.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(317, 276);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(282, 41);
            this.txtUser.TabIndex = 2;
            // 
            // etiquetaPassword
            // 
            this.etiquetaPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.etiquetaPassword.AutoSize = true;
            this.etiquetaPassword.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaPassword.Location = new System.Drawing.Point(106, 339);
            this.etiquetaPassword.Name = "etiquetaPassword";
            this.etiquetaPassword.Size = new System.Drawing.Size(205, 34);
            this.etiquetaPassword.TabIndex = 1;
            this.etiquetaPassword.Text = "PASSWORD:";
            // 
            // etiquetaUser
            // 
            this.etiquetaUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.etiquetaUser.AutoSize = true;
            this.etiquetaUser.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaUser.Location = new System.Drawing.Point(201, 283);
            this.etiquetaUser.Name = "etiquetaUser";
            this.etiquetaUser.Size = new System.Drawing.Size(110, 34);
            this.etiquetaUser.TabIndex = 0;
            this.etiquetaUser.Text = "USER:";
            // 
            // botonSalir
            // 
            this.botonSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botonSalir.BackColor = System.Drawing.Color.RoyalBlue;
            this.botonSalir.BackgroundImage = global::Cliente.Properties.Resources.Salir;
            this.botonSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonSalir.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.botonSalir.FlatAppearance.BorderSize = 0;
            this.botonSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.botonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.botonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonSalir.Location = new System.Drawing.Point(659, 439);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(53, 51);
            this.botonSalir.TabIndex = 7;
            this.botonSalir.UseVisualStyleBackColor = false;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            this.botonSalir.MouseHover += new System.EventHandler(this.botonSalir_MouseHover);
            // 
            // botonInformacion
            // 
            this.botonInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botonInformacion.BackColor = System.Drawing.Color.RoyalBlue;
            this.botonInformacion.BackgroundImage = global::Cliente.Properties.Resources.Informacion;
            this.botonInformacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonInformacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonInformacion.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.botonInformacion.FlatAppearance.BorderSize = 0;
            this.botonInformacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.botonInformacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.botonInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonInformacion.Location = new System.Drawing.Point(12, 439);
            this.botonInformacion.Name = "botonInformacion";
            this.botonInformacion.Size = new System.Drawing.Size(53, 51);
            this.botonInformacion.TabIndex = 5;
            this.botonInformacion.UseVisualStyleBackColor = false;
            this.botonInformacion.Click += new System.EventHandler(this.botonInformacion_Click);
            this.botonInformacion.MouseHover += new System.EventHandler(this.botonInformacion_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cliente.Properties.Resources.Presentacion;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(722, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(746, 499);
            this.Controls.Add(this.botonLogin);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonInformacion);
            this.Controls.Add(this.etiquetaRegistro);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.etiquetaPassword);
            this.Controls.Add(this.etiquetaUser);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botonLogin;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonInformacion;
        private System.Windows.Forms.Label etiquetaRegistro;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label etiquetaPassword;
        private System.Windows.Forms.Label etiquetaUser;
    }
}