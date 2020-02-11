namespace Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.dataGridView_Datos = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.boton_Mostrar = new System.Windows.Forms.Button();
            this.boton_Modificar = new System.Windows.Forms.Button();
            this.boton_Eliminar = new System.Windows.Forms.Button();
            this.boton_Buscar = new System.Windows.Forms.Button();
            this.groupBox_Administracion = new System.Windows.Forms.GroupBox();
            this.radioButton_Pregunta = new System.Windows.Forms.RadioButton();
            this.radioButton_Materia = new System.Windows.Forms.RadioButton();
            this.radioButton_Codigo = new System.Windows.Forms.RadioButton();
            this.boton_Agregar = new System.Windows.Forms.Button();
            this.groupBox_ingresoPreguntas = new System.Windows.Forms.GroupBox();
            this.txtRespuesta4 = new System.Windows.Forms.TextBox();
            this.txtRespuesta3 = new System.Windows.Forms.TextBox();
            this.txtRespuesta2 = new System.Windows.Forms.TextBox();
            this.txtRespuesta1 = new System.Windows.Forms.TextBox();
            this.etiqueRespuesta4 = new System.Windows.Forms.Label();
            this.etiqueRespuesta3 = new System.Windows.Forms.Label();
            this.etiqueRespuesta2 = new System.Windows.Forms.Label();
            this.etiqueRespuesta1 = new System.Windows.Forms.Label();
            this.etiquetaId = new System.Windows.Forms.Label();
            this.txtnumeroPregunta = new System.Windows.Forms.Label();
            this.etoquetaCodigo = new System.Windows.Forms.Label();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.etiquetaMateria = new System.Windows.Forms.Label();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.etiquetaPregunta = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.menuOpciones = new System.Windows.Forms.MenuStrip();
            this.botonUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.botonAdministar_Usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.botonExamen = new System.Windows.Forms.ToolStripMenuItem();
            this.botonAdministar_Examen = new System.Windows.Forms.ToolStripMenuItem();
            this.botonCrear_examen = new System.Windows.Forms.ToolStripMenuItem();
            this.etiquetaSaludo = new System.Windows.Forms.Label();
            this.etiquetaUsuario = new System.Windows.Forms.Label();
            this.dataGridView_PreguntaBuscada = new System.Windows.Forms.DataGridView();
            this.groupBox_numeroPreguntas = new System.Windows.Forms.GroupBox();
            this.botonNumeroPreguntas = new System.Windows.Forms.Button();
            this.txt_numeroPregunta = new System.Windows.Forms.Label();
            this.ScrollBarNumero = new System.Windows.Forms.HScrollBar();
            this.etiqueNumPregunta = new System.Windows.Forms.Label();
            this.boton_Terminar = new System.Windows.Forms.Button();
            this.boton_Cancelar = new System.Windows.Forms.Button();
            this.boton_Imprimir = new System.Windows.Forms.Button();
            this.boton_Volver = new System.Windows.Forms.Button();
            this.boton_Salir = new System.Windows.Forms.Button();
            this.boton_Ayuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Datos)).BeginInit();
            this.groupBox_Administracion.SuspendLayout();
            this.groupBox_ingresoPreguntas.SuspendLayout();
            this.menuOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PreguntaBuscada)).BeginInit();
            this.groupBox_numeroPreguntas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Datos
            // 
            this.dataGridView_Datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Datos.Location = new System.Drawing.Point(370, 168);
            this.dataGridView_Datos.Name = "dataGridView_Datos";
            this.dataGridView_Datos.Size = new System.Drawing.Size(951, 219);
            this.dataGridView_Datos.TabIndex = 6;
            this.dataGridView_Datos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Datos_CellMouseClick);
            this.dataGridView_Datos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Datos_RowEnter);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(6, 196);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(339, 20);
            this.txtBuscar.TabIndex = 8;
            // 
            // boton_Mostrar
            // 
            this.boton_Mostrar.Location = new System.Drawing.Point(6, 106);
            this.boton_Mostrar.Name = "boton_Mostrar";
            this.boton_Mostrar.Size = new System.Drawing.Size(339, 23);
            this.boton_Mostrar.TabIndex = 3;
            this.boton_Mostrar.Text = "Mostrar Todas Las Preguntas";
            this.boton_Mostrar.UseVisualStyleBackColor = true;
            this.boton_Mostrar.Click += new System.EventHandler(this.boton_Mostrar_Click);
            // 
            // boton_Modificar
            // 
            this.boton_Modificar.Location = new System.Drawing.Point(6, 48);
            this.boton_Modificar.Name = "boton_Modificar";
            this.boton_Modificar.Size = new System.Drawing.Size(339, 23);
            this.boton_Modificar.TabIndex = 1;
            this.boton_Modificar.Text = "Modificar";
            this.boton_Modificar.UseVisualStyleBackColor = true;
            this.boton_Modificar.Click += new System.EventHandler(this.boton_Modificar_Click);
            // 
            // boton_Eliminar
            // 
            this.boton_Eliminar.Location = new System.Drawing.Point(6, 77);
            this.boton_Eliminar.Name = "boton_Eliminar";
            this.boton_Eliminar.Size = new System.Drawing.Size(339, 23);
            this.boton_Eliminar.TabIndex = 2;
            this.boton_Eliminar.Text = "Eliminar";
            this.boton_Eliminar.UseVisualStyleBackColor = true;
            this.boton_Eliminar.Click += new System.EventHandler(this.boton_Eliminar_Click);
            // 
            // boton_Buscar
            // 
            this.boton_Buscar.Location = new System.Drawing.Point(6, 167);
            this.boton_Buscar.Name = "boton_Buscar";
            this.boton_Buscar.Size = new System.Drawing.Size(339, 23);
            this.boton_Buscar.TabIndex = 7;
            this.boton_Buscar.Text = "Buscar Pregunta";
            this.boton_Buscar.UseVisualStyleBackColor = true;
            this.boton_Buscar.Click += new System.EventHandler(this.boton_Buscar_Click);
            // 
            // groupBox_Administracion
            // 
            this.groupBox_Administracion.Controls.Add(this.radioButton_Pregunta);
            this.groupBox_Administracion.Controls.Add(this.radioButton_Materia);
            this.groupBox_Administracion.Controls.Add(this.radioButton_Codigo);
            this.groupBox_Administracion.Controls.Add(this.txtBuscar);
            this.groupBox_Administracion.Controls.Add(this.boton_Mostrar);
            this.groupBox_Administracion.Controls.Add(this.boton_Modificar);
            this.groupBox_Administracion.Controls.Add(this.boton_Eliminar);
            this.groupBox_Administracion.Controls.Add(this.boton_Buscar);
            this.groupBox_Administracion.Controls.Add(this.boton_Agregar);
            this.groupBox_Administracion.Location = new System.Drawing.Point(12, 395);
            this.groupBox_Administracion.Name = "groupBox_Administracion";
            this.groupBox_Administracion.Size = new System.Drawing.Size(352, 224);
            this.groupBox_Administracion.TabIndex = 5;
            this.groupBox_Administracion.TabStop = false;
            this.groupBox_Administracion.Text = "Admiistracion";
            // 
            // radioButton_Pregunta
            // 
            this.radioButton_Pregunta.AutoSize = true;
            this.radioButton_Pregunta.Location = new System.Drawing.Point(255, 144);
            this.radioButton_Pregunta.Name = "radioButton_Pregunta";
            this.radioButton_Pregunta.Size = new System.Drawing.Size(90, 17);
            this.radioButton_Pregunta.TabIndex = 6;
            this.radioButton_Pregunta.TabStop = true;
            this.radioButton_Pregunta.Text = "Por Pregunta.";
            this.radioButton_Pregunta.UseVisualStyleBackColor = true;
            // 
            // radioButton_Materia
            // 
            this.radioButton_Materia.AutoSize = true;
            this.radioButton_Materia.Location = new System.Drawing.Point(140, 144);
            this.radioButton_Materia.Name = "radioButton_Materia";
            this.radioButton_Materia.Size = new System.Drawing.Size(82, 17);
            this.radioButton_Materia.TabIndex = 5;
            this.radioButton_Materia.TabStop = true;
            this.radioButton_Materia.Text = "Por Materia.";
            this.radioButton_Materia.UseVisualStyleBackColor = true;
            // 
            // radioButton_Codigo
            // 
            this.radioButton_Codigo.AutoSize = true;
            this.radioButton_Codigo.Location = new System.Drawing.Point(6, 144);
            this.radioButton_Codigo.Name = "radioButton_Codigo";
            this.radioButton_Codigo.Size = new System.Drawing.Size(80, 17);
            this.radioButton_Codigo.TabIndex = 4;
            this.radioButton_Codigo.TabStop = true;
            this.radioButton_Codigo.Text = "Por Codigo.";
            this.radioButton_Codigo.UseVisualStyleBackColor = true;
            // 
            // boton_Agregar
            // 
            this.boton_Agregar.Location = new System.Drawing.Point(6, 19);
            this.boton_Agregar.Name = "boton_Agregar";
            this.boton_Agregar.Size = new System.Drawing.Size(339, 23);
            this.boton_Agregar.TabIndex = 0;
            this.boton_Agregar.Text = "Agregar";
            this.boton_Agregar.UseVisualStyleBackColor = true;
            this.boton_Agregar.Click += new System.EventHandler(this.boton_Agregar_Click);
            // 
            // groupBox_ingresoPreguntas
            // 
            this.groupBox_ingresoPreguntas.Controls.Add(this.txtRespuesta4);
            this.groupBox_ingresoPreguntas.Controls.Add(this.txtRespuesta3);
            this.groupBox_ingresoPreguntas.Controls.Add(this.txtRespuesta2);
            this.groupBox_ingresoPreguntas.Controls.Add(this.txtRespuesta1);
            this.groupBox_ingresoPreguntas.Controls.Add(this.etiqueRespuesta4);
            this.groupBox_ingresoPreguntas.Controls.Add(this.etiqueRespuesta3);
            this.groupBox_ingresoPreguntas.Controls.Add(this.etiqueRespuesta2);
            this.groupBox_ingresoPreguntas.Controls.Add(this.etiqueRespuesta1);
            this.groupBox_ingresoPreguntas.Controls.Add(this.etiquetaId);
            this.groupBox_ingresoPreguntas.Controls.Add(this.txtnumeroPregunta);
            this.groupBox_ingresoPreguntas.Controls.Add(this.etoquetaCodigo);
            this.groupBox_ingresoPreguntas.Controls.Add(this.txtPregunta);
            this.groupBox_ingresoPreguntas.Controls.Add(this.etiquetaMateria);
            this.groupBox_ingresoPreguntas.Controls.Add(this.txtMateria);
            this.groupBox_ingresoPreguntas.Controls.Add(this.etiquetaPregunta);
            this.groupBox_ingresoPreguntas.Controls.Add(this.txtCodigo);
            this.groupBox_ingresoPreguntas.Location = new System.Drawing.Point(12, 162);
            this.groupBox_ingresoPreguntas.Name = "groupBox_ingresoPreguntas";
            this.groupBox_ingresoPreguntas.Size = new System.Drawing.Size(352, 227);
            this.groupBox_ingresoPreguntas.TabIndex = 4;
            this.groupBox_ingresoPreguntas.TabStop = false;
            this.groupBox_ingresoPreguntas.Text = "Ingreso de Datos";
            // 
            // txtRespuesta4
            // 
            this.txtRespuesta4.Location = new System.Drawing.Point(124, 196);
            this.txtRespuesta4.Name = "txtRespuesta4";
            this.txtRespuesta4.Size = new System.Drawing.Size(221, 20);
            this.txtRespuesta4.TabIndex = 15;
            // 
            // txtRespuesta3
            // 
            this.txtRespuesta3.Location = new System.Drawing.Point(124, 170);
            this.txtRespuesta3.Name = "txtRespuesta3";
            this.txtRespuesta3.Size = new System.Drawing.Size(221, 20);
            this.txtRespuesta3.TabIndex = 14;
            // 
            // txtRespuesta2
            // 
            this.txtRespuesta2.Location = new System.Drawing.Point(124, 144);
            this.txtRespuesta2.Name = "txtRespuesta2";
            this.txtRespuesta2.Size = new System.Drawing.Size(221, 20);
            this.txtRespuesta2.TabIndex = 13;
            // 
            // txtRespuesta1
            // 
            this.txtRespuesta1.Location = new System.Drawing.Point(123, 118);
            this.txtRespuesta1.Name = "txtRespuesta1";
            this.txtRespuesta1.Size = new System.Drawing.Size(222, 20);
            this.txtRespuesta1.TabIndex = 12;
            // 
            // etiqueRespuesta4
            // 
            this.etiqueRespuesta4.AutoSize = true;
            this.etiqueRespuesta4.ForeColor = System.Drawing.Color.Red;
            this.etiqueRespuesta4.Location = new System.Drawing.Point(3, 203);
            this.etiqueRespuesta4.Name = "etiqueRespuesta4";
            this.etiqueRespuesta4.Size = new System.Drawing.Size(112, 13);
            this.etiqueRespuesta4.TabIndex = 7;
            this.etiqueRespuesta4.Text = "Respuesta Incorrecta:";
            // 
            // etiqueRespuesta3
            // 
            this.etiqueRespuesta3.AutoSize = true;
            this.etiqueRespuesta3.ForeColor = System.Drawing.Color.Red;
            this.etiqueRespuesta3.Location = new System.Drawing.Point(3, 177);
            this.etiqueRespuesta3.Name = "etiqueRespuesta3";
            this.etiqueRespuesta3.Size = new System.Drawing.Size(112, 13);
            this.etiqueRespuesta3.TabIndex = 6;
            this.etiqueRespuesta3.Text = "Respuesta Incorrecta:";
            // 
            // etiqueRespuesta2
            // 
            this.etiqueRespuesta2.AutoSize = true;
            this.etiqueRespuesta2.ForeColor = System.Drawing.Color.Red;
            this.etiqueRespuesta2.Location = new System.Drawing.Point(3, 151);
            this.etiqueRespuesta2.Name = "etiqueRespuesta2";
            this.etiqueRespuesta2.Size = new System.Drawing.Size(112, 13);
            this.etiqueRespuesta2.TabIndex = 5;
            this.etiqueRespuesta2.Text = "Respuesta Incorrecta:";
            // 
            // etiqueRespuesta1
            // 
            this.etiqueRespuesta1.AutoSize = true;
            this.etiqueRespuesta1.ForeColor = System.Drawing.Color.SeaGreen;
            this.etiqueRespuesta1.Location = new System.Drawing.Point(3, 125);
            this.etiqueRespuesta1.Name = "etiqueRespuesta1";
            this.etiqueRespuesta1.Size = new System.Drawing.Size(104, 13);
            this.etiqueRespuesta1.TabIndex = 4;
            this.etiqueRespuesta1.Text = "Respuesta Correcta:";
            // 
            // etiquetaId
            // 
            this.etiquetaId.AutoSize = true;
            this.etiquetaId.Location = new System.Drawing.Point(3, 23);
            this.etiquetaId.Name = "etiquetaId";
            this.etiquetaId.Size = new System.Drawing.Size(108, 13);
            this.etiquetaId.TabIndex = 0;
            this.etiquetaId.Text = "Numero de Pregunta:";
            // 
            // txtnumeroPregunta
            // 
            this.txtnumeroPregunta.AutoSize = true;
            this.txtnumeroPregunta.Location = new System.Drawing.Point(120, 23);
            this.txtnumeroPregunta.Name = "txtnumeroPregunta";
            this.txtnumeroPregunta.Size = new System.Drawing.Size(13, 13);
            this.txtnumeroPregunta.TabIndex = 8;
            this.txtnumeroPregunta.Text = "0";
            // 
            // etoquetaCodigo
            // 
            this.etoquetaCodigo.AutoSize = true;
            this.etoquetaCodigo.Location = new System.Drawing.Point(3, 47);
            this.etoquetaCodigo.Name = "etoquetaCodigo";
            this.etoquetaCodigo.Size = new System.Drawing.Size(43, 13);
            this.etoquetaCodigo.TabIndex = 1;
            this.etoquetaCodigo.Text = "Codigo:";
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(123, 92);
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(222, 20);
            this.txtPregunta.TabIndex = 11;
            // 
            // etiquetaMateria
            // 
            this.etiquetaMateria.AutoSize = true;
            this.etiquetaMateria.Location = new System.Drawing.Point(3, 73);
            this.etiquetaMateria.Name = "etiquetaMateria";
            this.etiquetaMateria.Size = new System.Drawing.Size(45, 13);
            this.etiquetaMateria.TabIndex = 2;
            this.etiquetaMateria.Text = "Materia:";
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(123, 66);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(222, 20);
            this.txtMateria.TabIndex = 10;
            // 
            // etiquetaPregunta
            // 
            this.etiquetaPregunta.AutoSize = true;
            this.etiquetaPregunta.Location = new System.Drawing.Point(3, 99);
            this.etiquetaPregunta.Name = "etiquetaPregunta";
            this.etiquetaPregunta.Size = new System.Drawing.Size(53, 13);
            this.etiquetaPregunta.TabIndex = 3;
            this.etiquetaPregunta.Text = "Pregunta:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(123, 40);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(222, 20);
            this.txtCodigo.TabIndex = 9;
            // 
            // menuOpciones
            // 
            this.menuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botonUsuarios,
            this.botonExamen});
            this.menuOpciones.Location = new System.Drawing.Point(0, 0);
            this.menuOpciones.Name = "menuOpciones";
            this.menuOpciones.Size = new System.Drawing.Size(1333, 24);
            this.menuOpciones.TabIndex = 0;
            this.menuOpciones.Text = "menuStrip1";
            // 
            // botonUsuarios
            // 
            this.botonUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botonAdministar_Usuarios});
            this.botonUsuarios.Name = "botonUsuarios";
            this.botonUsuarios.Size = new System.Drawing.Size(64, 20);
            this.botonUsuarios.Text = "Usuarios";
            // 
            // botonAdministar_Usuarios
            // 
            this.botonAdministar_Usuarios.Name = "botonAdministar_Usuarios";
            this.botonAdministar_Usuarios.Size = new System.Drawing.Size(184, 22);
            this.botonAdministar_Usuarios.Text = "Administrar Usuarios";
            this.botonAdministar_Usuarios.Click += new System.EventHandler(this.botonAdministar_Usuarios_Click);
            // 
            // botonExamen
            // 
            this.botonExamen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botonAdministar_Examen,
            this.botonCrear_examen});
            this.botonExamen.Name = "botonExamen";
            this.botonExamen.Size = new System.Drawing.Size(71, 20);
            this.botonExamen.Text = "Examenes";
            // 
            // botonAdministar_Examen
            // 
            this.botonAdministar_Examen.Name = "botonAdministar_Examen";
            this.botonAdministar_Examen.Size = new System.Drawing.Size(187, 22);
            this.botonAdministar_Examen.Text = "Administar Examenes";
            this.botonAdministar_Examen.Click += new System.EventHandler(this.botonAdministar_Examen_Click);
            // 
            // botonCrear_examen
            // 
            this.botonCrear_examen.Name = "botonCrear_examen";
            this.botonCrear_examen.Size = new System.Drawing.Size(187, 22);
            this.botonCrear_examen.Text = "Crear Nuevo Examen";
            this.botonCrear_examen.Click += new System.EventHandler(this.botonCrear_examen_Click);
            // 
            // etiquetaSaludo
            // 
            this.etiquetaSaludo.AutoSize = true;
            this.etiquetaSaludo.Font = new System.Drawing.Font("Cooper Black", 21.75F);
            this.etiquetaSaludo.Location = new System.Drawing.Point(6, 35);
            this.etiquetaSaludo.Name = "etiquetaSaludo";
            this.etiquetaSaludo.Size = new System.Drawing.Size(178, 34);
            this.etiquetaSaludo.TabIndex = 1;
            this.etiquetaSaludo.Text = "Bienvenido";
            // 
            // etiquetaUsuario
            // 
            this.etiquetaUsuario.AutoSize = true;
            this.etiquetaUsuario.Font = new System.Drawing.Font("Cooper Black", 21.75F);
            this.etiquetaUsuario.Location = new System.Drawing.Point(190, 35);
            this.etiquetaUsuario.Name = "etiquetaUsuario";
            this.etiquetaUsuario.Size = new System.Drawing.Size(132, 34);
            this.etiquetaUsuario.TabIndex = 2;
            this.etiquetaUsuario.Text = "Usuario";
            // 
            // dataGridView_PreguntaBuscada
            // 
            this.dataGridView_PreguntaBuscada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_PreguntaBuscada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PreguntaBuscada.Location = new System.Drawing.Point(370, 401);
            this.dataGridView_PreguntaBuscada.Name = "dataGridView_PreguntaBuscada";
            this.dataGridView_PreguntaBuscada.Size = new System.Drawing.Size(951, 219);
            this.dataGridView_PreguntaBuscada.TabIndex = 7;
            this.dataGridView_PreguntaBuscada.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_PreguntaBuscada_CellClick);
            this.dataGridView_PreguntaBuscada.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_PreguntaBuscada_RowEnter);
            // 
            // groupBox_numeroPreguntas
            // 
            this.groupBox_numeroPreguntas.Controls.Add(this.botonNumeroPreguntas);
            this.groupBox_numeroPreguntas.Controls.Add(this.txt_numeroPregunta);
            this.groupBox_numeroPreguntas.Controls.Add(this.ScrollBarNumero);
            this.groupBox_numeroPreguntas.Controls.Add(this.etiqueNumPregunta);
            this.groupBox_numeroPreguntas.Location = new System.Drawing.Point(12, 72);
            this.groupBox_numeroPreguntas.Name = "groupBox_numeroPreguntas";
            this.groupBox_numeroPreguntas.Size = new System.Drawing.Size(352, 84);
            this.groupBox_numeroPreguntas.TabIndex = 3;
            this.groupBox_numeroPreguntas.TabStop = false;
            this.groupBox_numeroPreguntas.Text = "Número de Preguntas";
            // 
            // botonNumeroPreguntas
            // 
            this.botonNumeroPreguntas.Location = new System.Drawing.Point(6, 48);
            this.botonNumeroPreguntas.Name = "botonNumeroPreguntas";
            this.botonNumeroPreguntas.Size = new System.Drawing.Size(339, 23);
            this.botonNumeroPreguntas.TabIndex = 2;
            this.botonNumeroPreguntas.Text = "Ingresar el numero de preguntas";
            this.botonNumeroPreguntas.UseVisualStyleBackColor = true;
            this.botonNumeroPreguntas.Click += new System.EventHandler(this.botonNumeroPreguntas_Click);
            // 
            // txt_numeroPregunta
            // 
            this.txt_numeroPregunta.AutoSize = true;
            this.txt_numeroPregunta.Location = new System.Drawing.Point(332, 22);
            this.txt_numeroPregunta.Name = "txt_numeroPregunta";
            this.txt_numeroPregunta.Size = new System.Drawing.Size(13, 13);
            this.txt_numeroPregunta.TabIndex = 3;
            this.txt_numeroPregunta.Text = "0";
            // 
            // ScrollBarNumero
            // 
            this.ScrollBarNumero.LargeChange = 0;
            this.ScrollBarNumero.Location = new System.Drawing.Point(167, 16);
            this.ScrollBarNumero.Maximum = 20;
            this.ScrollBarNumero.Minimum = 1;
            this.ScrollBarNumero.Name = "ScrollBarNumero";
            this.ScrollBarNumero.Size = new System.Drawing.Size(148, 19);
            this.ScrollBarNumero.SmallChange = 0;
            this.ScrollBarNumero.TabIndex = 1;
            this.ScrollBarNumero.Value = 1;
            this.ScrollBarNumero.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBarNumero_Scroll);
            // 
            // etiqueNumPregunta
            // 
            this.etiqueNumPregunta.AutoSize = true;
            this.etiqueNumPregunta.Location = new System.Drawing.Point(3, 22);
            this.etiqueNumPregunta.Name = "etiqueNumPregunta";
            this.etiqueNumPregunta.Size = new System.Drawing.Size(156, 13);
            this.etiqueNumPregunta.TabIndex = 0;
            this.etiqueNumPregunta.Text = "Escoja el número de preguntas:";
            // 
            // boton_Terminar
            // 
            this.boton_Terminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boton_Terminar.BackColor = System.Drawing.Color.Gold;
            this.boton_Terminar.BackgroundImage = global::Cliente.Properties.Resources.Visto;
            this.boton_Terminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boton_Terminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_Terminar.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.boton_Terminar.FlatAppearance.BorderSize = 0;
            this.boton_Terminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.boton_Terminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.boton_Terminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_Terminar.Location = new System.Drawing.Point(656, 50);
            this.boton_Terminar.Name = "boton_Terminar";
            this.boton_Terminar.Size = new System.Drawing.Size(100, 100);
            this.boton_Terminar.TabIndex = 14;
            this.boton_Terminar.UseVisualStyleBackColor = false;
            this.boton_Terminar.Click += new System.EventHandler(this.boton_Terminar_Click);
            this.boton_Terminar.MouseHover += new System.EventHandler(this.boton_Terminar_MouseHover);
            // 
            // boton_Cancelar
            // 
            this.boton_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boton_Cancelar.BackColor = System.Drawing.Color.Gold;
            this.boton_Cancelar.BackgroundImage = global::Cliente.Properties.Resources.Cancelar;
            this.boton_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boton_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.boton_Cancelar.FlatAppearance.BorderSize = 0;
            this.boton_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.boton_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.boton_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_Cancelar.Location = new System.Drawing.Point(550, 53);
            this.boton_Cancelar.Name = "boton_Cancelar";
            this.boton_Cancelar.Size = new System.Drawing.Size(100, 100);
            this.boton_Cancelar.TabIndex = 13;
            this.boton_Cancelar.UseVisualStyleBackColor = false;
            this.boton_Cancelar.Click += new System.EventHandler(this.boton_Cancelar_Click);
            this.boton_Cancelar.MouseHover += new System.EventHandler(this.boton_Cancelar_MouseHover);
            // 
            // boton_Imprimir
            // 
            this.boton_Imprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boton_Imprimir.BackColor = System.Drawing.Color.Gold;
            this.boton_Imprimir.BackgroundImage = global::Cliente.Properties.Resources.Imprimir;
            this.boton_Imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boton_Imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_Imprimir.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.boton_Imprimir.FlatAppearance.BorderSize = 0;
            this.boton_Imprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.boton_Imprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.boton_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_Imprimir.Location = new System.Drawing.Point(370, 56);
            this.boton_Imprimir.Name = "boton_Imprimir";
            this.boton_Imprimir.Size = new System.Drawing.Size(174, 100);
            this.boton_Imprimir.TabIndex = 12;
            this.boton_Imprimir.UseVisualStyleBackColor = false;
            this.boton_Imprimir.Click += new System.EventHandler(this.boton_Imprimir_Click);
            this.boton_Imprimir.MouseHover += new System.EventHandler(this.boton_Imprimir_MouseHover);
            // 
            // boton_Volver
            // 
            this.boton_Volver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boton_Volver.BackColor = System.Drawing.Color.Gold;
            this.boton_Volver.BackgroundImage = global::Cliente.Properties.Resources.Volver_login;
            this.boton_Volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boton_Volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_Volver.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.boton_Volver.FlatAppearance.BorderSize = 0;
            this.boton_Volver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.boton_Volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.boton_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_Volver.Location = new System.Drawing.Point(1089, 56);
            this.boton_Volver.Name = "boton_Volver";
            this.boton_Volver.Size = new System.Drawing.Size(100, 100);
            this.boton_Volver.TabIndex = 9;
            this.boton_Volver.UseVisualStyleBackColor = false;
            this.boton_Volver.Click += new System.EventHandler(this.boton_Volver_Click);
            this.boton_Volver.MouseHover += new System.EventHandler(this.boton_Volver_MouseHover);
            // 
            // boton_Salir
            // 
            this.boton_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boton_Salir.BackColor = System.Drawing.Color.Gold;
            this.boton_Salir.BackgroundImage = global::Cliente.Properties.Resources.Boton_Salir_2;
            this.boton_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boton_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_Salir.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.boton_Salir.FlatAppearance.BorderSize = 0;
            this.boton_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.boton_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.boton_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_Salir.Location = new System.Drawing.Point(1221, 56);
            this.boton_Salir.Name = "boton_Salir";
            this.boton_Salir.Size = new System.Drawing.Size(100, 100);
            this.boton_Salir.TabIndex = 10;
            this.boton_Salir.UseVisualStyleBackColor = false;
            this.boton_Salir.Click += new System.EventHandler(this.boton_Salir_Click);
            this.boton_Salir.MouseHover += new System.EventHandler(this.boton_Salir_MouseHover);
            // 
            // boton_Ayuda
            // 
            this.boton_Ayuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boton_Ayuda.BackColor = System.Drawing.Color.Gold;
            this.boton_Ayuda.BackgroundImage = global::Cliente.Properties.Resources.Ayuda;
            this.boton_Ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boton_Ayuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton_Ayuda.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.boton_Ayuda.FlatAppearance.BorderSize = 0;
            this.boton_Ayuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.boton_Ayuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.boton_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_Ayuda.Location = new System.Drawing.Point(948, 50);
            this.boton_Ayuda.Name = "boton_Ayuda";
            this.boton_Ayuda.Size = new System.Drawing.Size(107, 106);
            this.boton_Ayuda.TabIndex = 8;
            this.boton_Ayuda.UseVisualStyleBackColor = false;
            this.boton_Ayuda.Click += new System.EventHandler(this.boton_Ayuda_Click);
            this.boton_Ayuda.MouseHover += new System.EventHandler(this.boton_Ayuda_MouseHover);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1333, 632);
            this.Controls.Add(this.boton_Terminar);
            this.Controls.Add(this.boton_Cancelar);
            this.Controls.Add(this.boton_Imprimir);
            this.Controls.Add(this.boton_Volver);
            this.Controls.Add(this.boton_Salir);
            this.Controls.Add(this.boton_Ayuda);
            this.Controls.Add(this.groupBox_numeroPreguntas);
            this.Controls.Add(this.dataGridView_PreguntaBuscada);
            this.Controls.Add(this.etiquetaUsuario);
            this.Controls.Add(this.etiquetaSaludo);
            this.Controls.Add(this.dataGridView_Datos);
            this.Controls.Add(this.groupBox_Administracion);
            this.Controls.Add(this.groupBox_ingresoPreguntas);
            this.Controls.Add(this.menuOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuOpciones;
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cliente_FormClosing);
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Datos)).EndInit();
            this.groupBox_Administracion.ResumeLayout(false);
            this.groupBox_Administracion.PerformLayout();
            this.groupBox_ingresoPreguntas.ResumeLayout(false);
            this.groupBox_ingresoPreguntas.PerformLayout();
            this.menuOpciones.ResumeLayout(false);
            this.menuOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PreguntaBuscada)).EndInit();
            this.groupBox_numeroPreguntas.ResumeLayout(false);
            this.groupBox_numeroPreguntas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Datos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button boton_Mostrar;
        private System.Windows.Forms.Button boton_Modificar;
        private System.Windows.Forms.Button boton_Eliminar;
        private System.Windows.Forms.Button boton_Buscar;
        private System.Windows.Forms.GroupBox groupBox_Administracion;
        private System.Windows.Forms.Button boton_Agregar;
        private System.Windows.Forms.GroupBox groupBox_ingresoPreguntas;
        private System.Windows.Forms.Label etiquetaId;
        private System.Windows.Forms.Label txtnumeroPregunta;
        private System.Windows.Forms.Label etoquetaCodigo;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.Label etiquetaMateria;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label etiquetaPregunta;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.MenuStrip menuOpciones;
        private System.Windows.Forms.ToolStripMenuItem botonUsuarios;
        private System.Windows.Forms.ToolStripMenuItem botonAdministar_Usuarios;
        private System.Windows.Forms.ToolStripMenuItem botonExamen;
        private System.Windows.Forms.ToolStripMenuItem botonAdministar_Examen;
        private System.Windows.Forms.ToolStripMenuItem botonCrear_examen;
        private System.Windows.Forms.Label etiquetaSaludo;
        private System.Windows.Forms.Label etiquetaUsuario;
        private System.Windows.Forms.Label etiqueRespuesta4;
        private System.Windows.Forms.Label etiqueRespuesta3;
        private System.Windows.Forms.Label etiqueRespuesta2;
        private System.Windows.Forms.Label etiqueRespuesta1;
        private System.Windows.Forms.TextBox txtRespuesta4;
        private System.Windows.Forms.TextBox txtRespuesta3;
        private System.Windows.Forms.TextBox txtRespuesta2;
        private System.Windows.Forms.TextBox txtRespuesta1;
        private System.Windows.Forms.DataGridView dataGridView_PreguntaBuscada;
        private System.Windows.Forms.RadioButton radioButton_Pregunta;
        private System.Windows.Forms.RadioButton radioButton_Materia;
        private System.Windows.Forms.RadioButton radioButton_Codigo;
        private System.Windows.Forms.GroupBox groupBox_numeroPreguntas;
        private System.Windows.Forms.Button botonNumeroPreguntas;
        private System.Windows.Forms.Label txt_numeroPregunta;
        private System.Windows.Forms.HScrollBar ScrollBarNumero;
        private System.Windows.Forms.Label etiqueNumPregunta;
        private System.Windows.Forms.Button boton_Ayuda;
        private System.Windows.Forms.Button boton_Salir;
        private System.Windows.Forms.Button boton_Volver;
        private System.Windows.Forms.Button boton_Imprimir;
        private System.Windows.Forms.Button boton_Cancelar;
        private System.Windows.Forms.Button boton_Terminar;
    }
}

