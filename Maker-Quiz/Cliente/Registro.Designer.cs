namespace Cliente
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.txtID = new System.Windows.Forms.Label();
            this.etiquetaID = new System.Windows.Forms.Label();
            this.dataGridView_Datos = new System.Windows.Forms.DataGridView();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.groupBox_Condiciones = new System.Windows.Forms.GroupBox();
            this.condicionesLista = new System.Windows.Forms.RichTextBox();
            this.checkBoxCondiciones = new System.Windows.Forms.CheckBox();
            this.etiquetaTitulo = new System.Windows.Forms.Label();
            this.txtConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.etiquetaConfirmar = new System.Windows.Forms.Label();
            this.etiquetaContraseña = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.etiquetaUsuario = new System.Windows.Forms.Label();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonActualizar = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Datos)).BeginInit();
            this.groupBox_Condiciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(422, 72);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(14, 13);
            this.txtID.TabIndex = 17;
            this.txtID.Text = "0";
            // 
            // etiquetaID
            // 
            this.etiquetaID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.etiquetaID.AutoSize = true;
            this.etiquetaID.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaID.Location = new System.Drawing.Point(256, 72);
            this.etiquetaID.Name = "etiquetaID";
            this.etiquetaID.Size = new System.Drawing.Size(24, 13);
            this.etiquetaID.TabIndex = 1;
            this.etiquetaID.Text = "ID:";
            // 
            // dataGridView_Datos
            // 
            this.dataGridView_Datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Datos.Location = new System.Drawing.Point(248, 339);
            this.dataGridView_Datos.Name = "dataGridView_Datos";
            this.dataGridView_Datos.Size = new System.Drawing.Size(540, 98);
            this.dataGridView_Datos.TabIndex = 104;
            this.dataGridView_Datos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Datos_RowEnter);
            this.dataGridView_Datos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView_Datos_MouseClick);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.botonEliminar.Location = new System.Drawing.Point(603, 289);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(186, 34);
            this.botonEliminar.TabIndex = 14;
            this.botonEliminar.Text = "ELIMINAR.";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.botonRegistrar.Location = new System.Drawing.Point(249, 288);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(170, 35);
            this.botonRegistrar.TabIndex = 12;
            this.botonRegistrar.Text = "REGISTRAR.";
            this.botonRegistrar.UseVisualStyleBackColor = true;
            this.botonRegistrar.Click += new System.EventHandler(this.botonRegistrar_Click);
            // 
            // groupBox_Condiciones
            // 
            this.groupBox_Condiciones.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox_Condiciones.Controls.Add(this.condicionesLista);
            this.groupBox_Condiciones.Controls.Add(this.checkBoxCondiciones);
            this.groupBox_Condiciones.Location = new System.Drawing.Point(425, 171);
            this.groupBox_Condiciones.Name = "groupBox_Condiciones";
            this.groupBox_Condiciones.Size = new System.Drawing.Size(363, 100);
            this.groupBox_Condiciones.TabIndex = 11;
            this.groupBox_Condiciones.TabStop = false;
            this.groupBox_Condiciones.Text = "Condiciones de Uso.";
            // 
            // condicionesLista
            // 
            this.condicionesLista.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.condicionesLista.Location = new System.Drawing.Point(6, 19);
            this.condicionesLista.Name = "condicionesLista";
            this.condicionesLista.Size = new System.Drawing.Size(351, 52);
            this.condicionesLista.TabIndex = 0;
            this.condicionesLista.Text = resources.GetString("condicionesLista.Text");
            // 
            // checkBoxCondiciones
            // 
            this.checkBoxCondiciones.AutoSize = true;
            this.checkBoxCondiciones.Location = new System.Drawing.Point(6, 77);
            this.checkBoxCondiciones.Name = "checkBoxCondiciones";
            this.checkBoxCondiciones.Size = new System.Drawing.Size(164, 17);
            this.checkBoxCondiciones.TabIndex = 1;
            this.checkBoxCondiciones.Text = "Aceptar Condiciones de Uso.";
            this.checkBoxCondiciones.UseVisualStyleBackColor = true;
            // 
            // etiquetaTitulo
            // 
            this.etiquetaTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.etiquetaTitulo.AutoSize = true;
            this.etiquetaTitulo.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaTitulo.Location = new System.Drawing.Point(300, 22);
            this.etiquetaTitulo.Name = "etiquetaTitulo";
            this.etiquetaTitulo.Size = new System.Drawing.Size(435, 36);
            this.etiquetaTitulo.TabIndex = 0;
            this.etiquetaTitulo.Text = "CREAR NUEVA CUENTA.";
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtConfirmarContraseña.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(425, 145);
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.PasswordChar = '*';
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(363, 20);
            this.txtConfirmarContraseña.TabIndex = 10;
            this.txtConfirmarContraseña.Leave += new System.EventHandler(this.txtConfirmarContraseña_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtContraseña.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(425, 119);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(363, 20);
            this.txtContraseña.TabIndex = 9;
            // 
            // etiquetaConfirmar
            // 
            this.etiquetaConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.etiquetaConfirmar.AutoSize = true;
            this.etiquetaConfirmar.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaConfirmar.Location = new System.Drawing.Point(256, 152);
            this.etiquetaConfirmar.Name = "etiquetaConfirmar";
            this.etiquetaConfirmar.Size = new System.Drawing.Size(163, 13);
            this.etiquetaConfirmar.TabIndex = 5;
            this.etiquetaConfirmar.Text = "CONFIRAR CONTRASEÑA:";
            // 
            // etiquetaContraseña
            // 
            this.etiquetaContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.etiquetaContraseña.AutoSize = true;
            this.etiquetaContraseña.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaContraseña.Location = new System.Drawing.Point(256, 122);
            this.etiquetaContraseña.Name = "etiquetaContraseña";
            this.etiquetaContraseña.Size = new System.Drawing.Size(95, 13);
            this.etiquetaContraseña.TabIndex = 4;
            this.etiquetaContraseña.Text = "CONTRASEÑA:";
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtUser.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(425, 93);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(363, 20);
            this.txtUser.TabIndex = 8;
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // etiquetaUsuario
            // 
            this.etiquetaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.etiquetaUsuario.AutoSize = true;
            this.etiquetaUsuario.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaUsuario.Location = new System.Drawing.Point(256, 96);
            this.etiquetaUsuario.Name = "etiquetaUsuario";
            this.etiquetaUsuario.Size = new System.Drawing.Size(43, 13);
            this.etiquetaUsuario.TabIndex = 3;
            this.etiquetaUsuario.Text = "USER:";
            // 
            // botonSalir
            // 
            this.botonSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonSalir.BackgroundImage = global::Cliente.Properties.Resources.Boton_Salir;
            this.botonSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonSalir.Location = new System.Drawing.Point(600, 443);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(188, 51);
            this.botonSalir.TabIndex = 15;
            this.botonSalir.UseVisualStyleBackColor = false;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // botonActualizar
            // 
            this.botonActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.botonActualizar.Location = new System.Drawing.Point(425, 288);
            this.botonActualizar.Name = "botonActualizar";
            this.botonActualizar.Size = new System.Drawing.Size(170, 35);
            this.botonActualizar.TabIndex = 13;
            this.botonActualizar.Text = "ACTUALIZAR.";
            this.botonActualizar.UseVisualStyleBackColor = true;
            this.botonActualizar.Click += new System.EventHandler(this.botonActualizar_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.botonVolver.BackgroundImage = global::Cliente.Properties.Resources.Boton_Volver;
            this.botonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVolver.Location = new System.Drawing.Point(248, 443);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(188, 51);
            this.botonVolver.TabIndex = 16;
            this.botonVolver.UseVisualStyleBackColor = false;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxImagen.Image = global::Cliente.Properties.Resources.RegistroUsu;
            this.pictureBoxImagen.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(199, 482);
            this.pictureBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagen.TabIndex = 105;
            this.pictureBoxImagen.TabStop = false;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(839, 518);
            this.Controls.Add(this.botonActualizar);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.etiquetaID);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.pictureBoxImagen);
            this.Controls.Add(this.dataGridView_Datos);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonRegistrar);
            this.Controls.Add(this.groupBox_Condiciones);
            this.Controls.Add(this.etiquetaTitulo);
            this.Controls.Add(this.txtConfirmarContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.etiquetaConfirmar);
            this.Controls.Add(this.etiquetaContraseña);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.etiquetaUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Datos)).EndInit();
            this.groupBox_Condiciones.ResumeLayout(false);
            this.groupBox_Condiciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label etiquetaID;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.DataGridView dataGridView_Datos;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonRegistrar;
        private System.Windows.Forms.GroupBox groupBox_Condiciones;
        private System.Windows.Forms.RichTextBox condicionesLista;
        private System.Windows.Forms.CheckBox checkBoxCondiciones;
        private System.Windows.Forms.Label etiquetaTitulo;
        private System.Windows.Forms.TextBox txtConfirmarContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label etiquetaConfirmar;
        private System.Windows.Forms.Label etiquetaContraseña;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label etiquetaUsuario;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonActualizar;

    }
}