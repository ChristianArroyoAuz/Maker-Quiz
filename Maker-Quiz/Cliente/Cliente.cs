using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.ServiceModel;
using System.Collections;
using System.Threading;
using System.Drawing;
using ObjetoRemoto;
using System.Data;
using System.Linq;
using System.Text;
using System;

namespace Cliente
{
    public partial class Cliente : Form
    {
        Thread servidor = new Thread(ObjetoRemoto.Servidor.Main);
        ChannelFactory<ObjetoRemoto.IObjetorRemoto> canal = new ChannelFactory<ObjetoRemoto.IObjetorRemoto>(new NetTcpBinding(), "net.tcp://localhost:8080");
        ObjetoRemoto.IObjetorRemoto interfaz;
        ObjetoRemoto.ObjetoRemoto objetoremotoUsuario = new ObjetoRemoto.ObjetoRemoto();
        List<Preguntas> recibir = new List<Preguntas>();
        public string nombreUsuario;
        public string origen_destino;
        string materia;
        int numeroPreguntas, idExamen, contador = 1;
        bool examen = false;
        bool eliminarExamen = false;

        public Cliente()
        {
            InitializeComponent();
            servidor.IsBackground = true;
            servidor.Start();
            Thread.Sleep(1000);
            interfaz = canal.CreateChannel();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            etiquetaUsuario.Text = nombreUsuario;
            iniciarFormulario();
            limpiarCampos();
        }

        public void iniciarFormulario()
        {
            groupBox_numeroPreguntas.Enabled = false;
            groupBox_ingresoPreguntas.Enabled = false;
            groupBox_Administracion.Enabled = false;
            dataGridView_Datos.Enabled = false;
            dataGridView_PreguntaBuscada.Enabled = false;
            dataGridView_Datos.DataSource = null;
            dataGridView_PreguntaBuscada.DataSource = null;
            txtCodigo.Enabled = true;
            txtMateria.Enabled = true;
            boton_Imprimir.Enabled = false;
            boton_Imprimir.Visible = false;
            boton_Cancelar.Enabled = false;
            boton_Cancelar.Visible = false;
            boton_Terminar.Enabled = false;
            boton_Terminar.Visible = false;
            examen = false;
        }

        public void iniciarFormularioAgregado()
        {
            groupBox_numeroPreguntas.Enabled = false;
            groupBox_ingresoPreguntas.Enabled = false;
            groupBox_Administracion.Enabled = false;
            dataGridView_Datos.Enabled = false;
            dataGridView_PreguntaBuscada.Enabled = false;
            dataGridView_PreguntaBuscada.DataSource = null;
            txtCodigo.Enabled = true;
            txtMateria.Enabled = true;
            boton_Imprimir.Enabled = true;
            boton_Imprimir.Visible = true;
        }

        public void iniciarFormulariAdministracion()
        {
            boton_Agregar.Enabled = true;
            boton_Modificar.Enabled = false;
            boton_Eliminar.Enabled = true;
            boton_Mostrar.Enabled = false;
            boton_Buscar.Enabled = false;
            radioButton_Codigo.Enabled = false;
            radioButton_Materia.Enabled = false;
            radioButton_Pregunta.Enabled = false;
            txtBuscar.Enabled = false;
            groupBox_Administracion.Enabled = true;
        }

        public void cargarTodasPreguntas()
        {
            foreach (Preguntas item in interfaz.mostrarPreguntas(recibir))
            {
                dataGridView_PreguntaBuscada.DataSource = interfaz.mostrarPreguntas(recibir).Select(x => x).Select(y => new
                {
                    ID = y.Id,
                    CODIGO = y.Codigo,
                    MATERIA = y.Materia,
                    PREGUNTA = y.Pregunta,
                    RESPUESTA_1 = y.Respuesta_1,
                    RESPUESTA_2 = y.Respuesta_2,
                    RESPUESTA_3 = y.Respuesta_3,
                    RESPUESTA_4 = y.Respuesta_4,
                    EXAMEN = y.Examen
                }).ToList();
            }
            dataGridView_PreguntaBuscada.SelectionMode = DataGridViewSelectionMode.CellSelect;
            limpiarCamposAgregados();
            recibir.Clear();
        }

        public void cargarExamenes()
        {
            foreach (Preguntas item in interfaz.mostrarExamenes(recibir))
            {
                dataGridView_Datos.DataSource = interfaz.mostrarExamenes(recibir).Select(x => x).Select(y => new
                {
                    CODIGO = y.Codigo,
                    MATERIA = y.Materia,
                    EXAMEN = y.Examen
                }).ToList();
            }
            dataGridView_Datos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            limpiarCamposAgregados();
            recibir.Clear();
        }

        public void buscarPregunta()
        {
            if (radioButton_Codigo.Checked == true)
            {
                (objetoremotoUsuario as IObjetorRemoto).buscarPreguntas_Codigo(recibir);
            }
            if (radioButton_Materia.Checked == true)
            {
                (objetoremotoUsuario as IObjetorRemoto).buscarPreguntas_Materia(recibir);
            }
            if (radioButton_Pregunta.Checked == true)
            {
                (objetoremotoUsuario as IObjetorRemoto).buscarPreguntas_Pregunta(recibir);
            }
            if (recibir.Count() > 0)
            {
                foreach (Preguntas item in recibir)
                {
                    dataGridView_PreguntaBuscada.DataSource = objetoremotoUsuario.mostrarPreguntasUsuario.Select(x => x).Select(y => new
                    {
                        ID = y.Id,
                        CODIGO = y.Codigo,
                        MATERIA = y.Materia,
                        PREGUNTA = y.Pregunta,
                        RESPUESTA_1 = y.Respuesta_1,
                        RESPUESTA_2 = y.Respuesta_2,
                        RESPUESTA_3 = y.Respuesta_3,
                        RESPUESTA_4 = y.Respuesta_4,
                        EXAMEN = y.Examen
                    }).ToList();
                }
                dataGridView_PreguntaBuscada.SelectionMode = DataGridViewSelectionMode.CellSelect;
                recibir.Clear();
                dataGridView_PreguntaBuscada.ClearSelection();
            }
            else
            {
                MessageBox.Show("No hubo resultados en la busqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void eliminarDatos()
        {
            (objetoremotoUsuario as IObjetorRemoto).eliminarPreguntas(recibir);
            foreach (Preguntas item in recibir)
            {
                dataGridView_PreguntaBuscada.DataSource = objetoremotoUsuario.mostrarPreguntasUsuario.Select(x => x).Select(y => new
                {
                    ID = y.Id,
                    CODIGO = y.Codigo,
                    MATERIA = y.Materia,
                    PREGUNTA = y.Pregunta,
                    RESPUESTA_1 = y.Respuesta_1,
                    RESPUESTA_2 = y.Respuesta_2,
                    RESPUESTA_3 = y.Respuesta_3,
                    RESPUESTA_4 = y.Respuesta_4,
                    EXAMEN = y.Examen
                }).ToList();
            }
            dataGridView_PreguntaBuscada.SelectionMode = DataGridViewSelectionMode.CellSelect;
            recibir.Clear();
        }

        public void modificarDatos()
        {
            (objetoremotoUsuario as IObjetorRemoto).modificarPreguntas(recibir);
            foreach (Preguntas item in recibir)
            {
                dataGridView_PreguntaBuscada.DataSource = objetoremotoUsuario.mostrarPreguntasUsuario.Select(x => x).Select(y => new
                {
                    ID = y.Id,
                    CODIGO = y.Codigo,
                    MATERIA = y.Materia,
                    PREGUNTA = y.Pregunta,
                    RESPUESTA_1 = y.Respuesta_1,
                    RESPUESTA_2 = y.Respuesta_2,
                    RESPUESTA_3 = y.Respuesta_3,
                    RESPUESTA_4 = y.Respuesta_4,
                    EXAMEN = y.Examen
                }).ToList();
            }
            dataGridView_PreguntaBuscada.SelectionMode = DataGridViewSelectionMode.CellSelect;
            recibir.Clear();
        }

        public void agregarDatos()
        {
            (objetoremotoUsuario as IObjetorRemoto).agregarPreguntas(recibir);
            foreach (Preguntas item in recibir)
            {
                dataGridView_Datos.DataSource = objetoremotoUsuario.mostrarPreguntasUsuario.Select(x => x).Select(y => new
                {
                    ID = y.Id,
                    CODIGO = y.Codigo,
                    MATERIA = y.Materia,
                    PREGUNTA = y.Pregunta,
                    RESPUESTA_1 = y.Respuesta_1,
                    RESPUESTA_2 = y.Respuesta_2,
                    RESPUESTA_3 = y.Respuesta_3,
                    RESPUESTA_4 = y.Respuesta_4,
                    EXAMEN = y.Examen
                }).ToList();
            }
            dataGridView_Datos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            recibir.Clear();
        }

        public void agregarDatosAdministracion()
        {
            (objetoremotoUsuario as IObjetorRemoto).agregarPreguntas(recibir);
            foreach (Preguntas item in recibir)
            {
                dataGridView_PreguntaBuscada.DataSource = objetoremotoUsuario.mostrarPreguntasUsuario.Select(x => x).Select(y => new
                {
                    ID = y.Id,
                    CODIGO = y.Codigo,
                    MATERIA = y.Materia,
                    PREGUNTA = y.Pregunta,
                    RESPUESTA_1 = y.Respuesta_1,
                    RESPUESTA_2 = y.Respuesta_2,
                    RESPUESTA_3 = y.Respuesta_3,
                    RESPUESTA_4 = y.Respuesta_4,
                    EXAMEN = y.Examen
                }).ToList();
            }
            dataGridView_PreguntaBuscada.SelectionMode = DataGridViewSelectionMode.CellSelect;
            recibir.Clear();
        }

        public void limpiarCampos()
        {
            txt_numeroPregunta.Text = "0";
            txtnumeroPregunta.Text = "0";
            txtCodigo.Clear();
            txtMateria.Clear();
            txtPregunta.Clear();
            txtRespuesta1.Clear();
            txtRespuesta2.Clear();
            txtRespuesta3.Clear();
            txtRespuesta4.Clear();
        }

        public void limpiarCamposAgregados()
        {
            txtPregunta.Clear();
            txtRespuesta1.Clear();
            txtRespuesta2.Clear();
            txtRespuesta3.Clear();
            txtRespuesta4.Clear();
            txtPregunta.Focus();
        }

        public void buscarExamen()
        {
            if (dataGridView_Datos.SelectedCells.Count > 0)
            {
                (objetoremotoUsuario as IObjetorRemoto).buscarPreguntas_Examen(recibir);
                foreach (Preguntas item in recibir)
                {
                    dataGridView_PreguntaBuscada.DataSource = objetoremotoUsuario.mostrarPreguntasUsuario.Select(x => x).Select(y => new
                    {
                        ID = y.Id,
                        CODIGO = y.Codigo,
                        MATERIA = y.Materia,
                        PREGUNTA = y.Pregunta,
                        RESPUESTA_1 = y.Respuesta_1,
                        RESPUESTA_2 = y.Respuesta_2,
                        RESPUESTA_3 = y.Respuesta_3,
                        RESPUESTA_4 = y.Respuesta_4,
                        EXAMEN = y.Examen
                    }).ToList();
                }
                dataGridView_PreguntaBuscada.SelectionMode = DataGridViewSelectionMode.CellSelect;
                recibir.Clear();
                dataGridView_PreguntaBuscada.ClearSelection();
            }
            else
            {
                dataGridView_PreguntaBuscada.DataSource = null;
            }
        }

        private void botonAdministar_Usuarios_Click(object sender, EventArgs e)
        {
            (interfaz as ICommunicationObject).Close();
            ObjetoRemoto.Servidor.StopServer();
            Registro cambio = new Registro();
            Hide();
            cambio.origen_destino = "cliente_registro";
            cambio.usuario = nombreUsuario;
            cambio.ShowDialog();
            limpiarCampos();
        }

        private void botonAdministar_Examen_Click(object sender, EventArgs e)
        {
            botonUsuarios.Enabled = false;
            botonExamen.Enabled = false;
            iniciarFormulario();
            dataGridView_Datos.Enabled = true;
            boton_Terminar.Enabled = true;
            boton_Terminar.Visible = true;
            examen = true;
            cargarExamenes();
        }

        private void botonCrear_examen_Click(object sender, EventArgs e)
        {
            dataGridView_Datos.DataSource = null;
            botonUsuarios.Enabled = false;
            botonExamen.Enabled = false;
            groupBox_numeroPreguntas.Enabled = true;
            groupBox_ingresoPreguntas.Enabled = false;
            groupBox_Administracion.Enabled = false;
            dataGridView_Datos.Enabled = false;
            dataGridView_PreguntaBuscada.Enabled = false;
            boton_Imprimir.Enabled = false;
            boton_Imprimir.Visible = false;
            boton_Cancelar.Enabled = true;
            boton_Cancelar.Visible = true;
        }

        private void botonNumeroPreguntas_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_numeroPregunta.Text) == 0)
            {
                MessageBox.Show("El numero de preguntas debe ser mayor a 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtCodigo.Focus();
                idExamen = interfaz.obtenerID_Examen(0);
                txtnumeroPregunta.Text = Convert.ToString(contador);
                groupBox_numeroPreguntas.Enabled = false;
                groupBox_ingresoPreguntas.Enabled = true;
                groupBox_Administracion.Enabled = true;
                dataGridView_PreguntaBuscada.Enabled = true;
                radioButton_Codigo.Enabled = true;
                radioButton_Materia.Enabled = true;
                radioButton_Pregunta.Enabled = true;
                radioButton_Codigo.Checked = true;
                boton_Buscar.Enabled = true;
                txtBuscar.Enabled = true;
                boton_Agregar.Enabled = true;
                boton_Modificar.Enabled = false;
                boton_Eliminar.Enabled = false;
                boton_Mostrar.Enabled = true;
            }
        }

        private void boton_Agregar_Click(object sender, EventArgs e)
        {
            materia = txtMateria.Text;
            if (examen == true)
            {
                try
                {
                    if (txtCodigo.Text == "" || txtMateria.Text == "" || txtPregunta.Text == "" || txtRespuesta1.Text == "" || txtRespuesta2.Text == "" || txtRespuesta3.Text == "" || txtRespuesta4.Text == "")
                    {
                        MessageBox.Show("Debe ingresar todos los datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        objetoremotoUsuario.identificadorPregunta = interfaz.obtenerID_Pregunta(0);
                        objetoremotoUsuario.codigo = txtCodigo.Text;
                        objetoremotoUsuario.materia = txtMateria.Text;
                        objetoremotoUsuario.pregunta = txtPregunta.Text;
                        objetoremotoUsuario.respuesta_1 = txtRespuesta1.Text;
                        objetoremotoUsuario.respuesta_2 = txtRespuesta2.Text;
                        objetoremotoUsuario.respuesta_3 = txtRespuesta3.Text;
                        objetoremotoUsuario.respuesta_4 = txtRespuesta4.Text;
                        objetoremotoUsuario.examen = idExamen;
                        agregarDatosAdministracion();
                        dataGridView_PreguntaBuscada.ClearSelection();
                        MessageBox.Show("Se han agregado la pregunta corectamente.");
                        limpiarCamposAgregados();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo guardar los datos debido a un error.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                if (contador > 0 && txtCodigo.Text != "" && txtMateria.Text != "")
                {
                    txtCodigo.Enabled = false;
                    txtMateria.Enabled = false;
                }
                if (contador == numeroPreguntas)
                {
                    try
                    {
                        if (txtCodigo.Text == "" || txtMateria.Text == "" || txtPregunta.Text == "" || txtRespuesta1.Text == "" || txtRespuesta2.Text == "" || txtRespuesta3.Text == "" || txtRespuesta4.Text == "")
                        {
                            MessageBox.Show("Debe ingresar todos los datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            contador = contador + 1;
                            txtnumeroPregunta.Text = contador.ToString();
                            objetoremotoUsuario.identificadorPregunta = interfaz.obtenerID_Pregunta(0);
                            objetoremotoUsuario.codigo = txtCodigo.Text;
                            objetoremotoUsuario.materia = txtMateria.Text;
                            objetoremotoUsuario.pregunta = txtPregunta.Text;
                            objetoremotoUsuario.respuesta_1 = txtRespuesta1.Text;
                            objetoremotoUsuario.respuesta_2 = txtRespuesta2.Text;
                            objetoremotoUsuario.respuesta_3 = txtRespuesta3.Text;
                            objetoremotoUsuario.respuesta_4 = txtRespuesta4.Text;
                            objetoremotoUsuario.examen = idExamen;
                            agregarDatos();
                            dataGridView_Datos.ClearSelection();
                            limpiarCampos();
                            limpiarCamposAgregados();
                            MessageBox.Show("Se han agregado las " + numeroPreguntas + " preguntas corectamente.");
                            botonUsuarios.Enabled = true;
                            botonExamen.Enabled = true;
                            contador = 1;
                            iniciarFormularioAgregado();
                            limpiarCampos();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se pudo guardar los datos debido a un error.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    try
                    {
                        if (txtCodigo.Text == "" || txtMateria.Text == "" || txtPregunta.Text == "" || txtRespuesta1.Text == "" || txtRespuesta2.Text == "" || txtRespuesta3.Text == "" || txtRespuesta4.Text == "")
                        {
                            MessageBox.Show("Debe ingresar todos los datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            contador = contador + 1;
                            txtnumeroPregunta.Text = contador.ToString();
                            objetoremotoUsuario.identificadorPregunta = interfaz.obtenerID_Pregunta(0);
                            objetoremotoUsuario.codigo = txtCodigo.Text;
                            objetoremotoUsuario.materia = txtMateria.Text;
                            objetoremotoUsuario.pregunta = txtPregunta.Text;
                            objetoremotoUsuario.respuesta_1 = txtRespuesta1.Text;
                            objetoremotoUsuario.respuesta_2 = txtRespuesta2.Text;
                            objetoremotoUsuario.respuesta_3 = txtRespuesta3.Text;
                            objetoremotoUsuario.respuesta_4 = txtRespuesta4.Text;
                            objetoremotoUsuario.examen = idExamen;
                            agregarDatos();
                            dataGridView_Datos.ClearSelection();
                            limpiarCamposAgregados();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se pudo guardar los datos debido a un error.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void boton_Modificar_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("Seguro desea modificar el elemnto?", "Confirmacion", MessageBoxButtons.YesNo);
            if (pregunta == DialogResult.Yes)
            {
                objetoremotoUsuario.identificadorPregunta = Convert.ToInt32(txtnumeroPregunta.Text);
                objetoremotoUsuario.codigo = txtCodigo.Text;
                objetoremotoUsuario.materia = txtMateria.Text;
                objetoremotoUsuario.pregunta = txtPregunta.Text;
                objetoremotoUsuario.respuesta_1 = txtRespuesta1.Text;
                objetoremotoUsuario.respuesta_2 = txtRespuesta2.Text;
                objetoremotoUsuario.respuesta_3 = txtRespuesta3.Text;
                objetoremotoUsuario.respuesta_4 = txtRespuesta4.Text;
                objetoremotoUsuario.examen = idExamen;
                modificarDatos();
                objetoremotoUsuario.busqueda = Convert.ToString(idExamen);
                buscarExamen();
                limpiarCampos();
                iniciarFormulariAdministracion();
                dataGridView_Datos.ClearSelection();
            }
            else
            {
                return;
            }
        }

        private void boton_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("Seguro desea eliminar el elemnto?", "Confirmacion", MessageBoxButtons.YesNo);
            if (pregunta == DialogResult.Yes)
            {
                if (eliminarExamen == true)
                {
                    objetoremotoUsuario.examen = idExamen;
                    (objetoremotoUsuario as IObjetorRemoto).eliminar_Examen(recibir);
                    recibir.Clear();
                    cargarExamenes();
                    dataGridView_Datos.ClearSelection();
                    dataGridView_PreguntaBuscada.ClearSelection();
                    dataGridView_PreguntaBuscada.DataSource = null;
                }
                else
                {
                    objetoremotoUsuario.identificadorPregunta = Convert.ToInt32(txtnumeroPregunta.Text);
                    eliminarDatos();
                    objetoremotoUsuario.busqueda = Convert.ToString(idExamen);
                    buscarExamen();
                    cargarExamenes();
                    limpiarCampos();
                    iniciarFormulariAdministracion();
                    dataGridView_Datos.ClearSelection();
                    dataGridView_PreguntaBuscada.ClearSelection();
                }
            }
            else
            {
                return;
            }
        }

        private void boton_Mostrar_Click(object sender, EventArgs e)
        {
            cargarTodasPreguntas();
        }

        private void boton_Buscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Debe ingresar un parametro para la busqueda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    objetoremotoUsuario.busqueda = txtBuscar.Text;
                    buscarPregunta();
                    txtBuscar.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo buscar los datos debido a un error.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void boton_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult salir = MessageBox.Show("Seguro desea Salir?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (salir == DialogResult.OK)
                {
                    Application.Exit();
                    (interfaz as ICommunicationObject).Close();
                    ObjetoRemoto.Servidor.StopServer();
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {
                System.Environment.Exit(0);
                (interfaz as ICommunicationObject).Close();
                ObjetoRemoto.Servidor.StopServer();
            }
        }

        private void boton_Volver_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult salir = MessageBox.Show("Seguro desea volver al login?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (salir == DialogResult.OK)
                {
                    (interfaz as ICommunicationObject).Close();
                    ObjetoRemoto.Servidor.StopServer();
                    Login cambio = new Login();
                    Hide();
                    cambio.ShowDialog();
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {
                (interfaz as ICommunicationObject).Close();
                ObjetoRemoto.Servidor.StopServer();
            }
        }

        private void boton_Ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quiz Maker: es una  aplicacion que te permite crear y administar examenes." + "\n" +
                            "En el menu de USUARIOS podras administar: Crear, Leer, Administar y Borrar usuarios." + "\n" +
                            "En el menu EXAMENES podras crear los examenes y tambien administrarlos.");
        }

        private void boton_Imprimir_Click(object sender, EventArgs e)
        {
            if (examen == true)
            {
                ImprimirPrueba doc = new ImprimirPrueba(this.dataGridView_PreguntaBuscada, this.dataGridView_PreguntaBuscada.Font, true);
                doc.DocumentName = "Vista de Prueba";
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.ClientSize = new Size(400, 300);
                printPreviewDialog.Location = new Point(29, 29);
                printPreviewDialog.Name = "Cuadro de Dialogo Vista Previa";
                printPreviewDialog.UseAntiAlias = true;
                printPreviewDialog.Document = doc;
                printPreviewDialog.ShowDialog();
                doc.Dispose();
                doc = null;
            }
            else
            {
                ImprimirPrueba doc = new ImprimirPrueba(this.dataGridView_Datos, this.dataGridView_Datos.Font, true);
                doc.DocumentName = "Vista de Prueba";
                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.ClientSize = new Size(400, 300);
                printPreviewDialog.Location = new Point(29, 29);
                printPreviewDialog.Name = "Cuadro de Dialogo Vista Previa";
                printPreviewDialog.UseAntiAlias = true;
                printPreviewDialog.Document = doc;
                printPreviewDialog.ShowDialog();
                doc.Dispose();
                doc = null;
            }
        }

        private void boton_Cancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            iniciarFormulario();
            botonUsuarios.Enabled = true;
            botonExamen.Enabled = true;
            examen = false;
            boton_Imprimir.Enabled = false;
            boton_Imprimir.Visible = false;
        }

        private void boton_Terminar_Click(object sender, EventArgs e)
        {
            botonExamen.Enabled = true;
            botonUsuarios.Enabled = true;
            limpiarCampos();
            iniciarFormulario();
            examen = false;
            eliminarExamen = false;
            boton_Imprimir.Enabled = false;
            boton_Imprimir.Visible = false;
        }

        private void dataGridView_Datos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (examen == true)
            {
                buscarExamen();
                iniciarFormulariAdministracion();
                boton_Imprimir.Enabled = true;
                boton_Imprimir.Visible = true;
                eliminarExamen = true;
            }
        }

        private void dataGridView_PreguntaBuscada_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (examen == true)
            {
                txtnumeroPregunta.Text = dataGridView_PreguntaBuscada.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCodigo.Text = dataGridView_PreguntaBuscada.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMateria.Text = dataGridView_PreguntaBuscada.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPregunta.Text = dataGridView_PreguntaBuscada.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtRespuesta1.Text = dataGridView_PreguntaBuscada.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtRespuesta2.Text = dataGridView_PreguntaBuscada.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtRespuesta3.Text = dataGridView_PreguntaBuscada.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtRespuesta4.Text = dataGridView_PreguntaBuscada.Rows[e.RowIndex].Cells[7].Value.ToString();
                idExamen = Convert.ToInt32(dataGridView_PreguntaBuscada.Rows[e.RowIndex].Cells[8].Value);
                eliminarExamen = false;
            }
        }

        private void dataGridView_Datos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (examen == true)
            {
                txtnumeroPregunta.Text = Convert.ToString(interfaz.obtenerID_Pregunta(0));
                txtMateria.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCodigo.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[1].Value.ToString();
                objetoremotoUsuario.busqueda = dataGridView_Datos.Rows[e.RowIndex].Cells[2].Value.ToString();
                idExamen = Convert.ToInt32(dataGridView_Datos.Rows[e.RowIndex].Cells[2].Value);
            }
        }

        private void dataGridView_PreguntaBuscada_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (examen == true)
            {
                dataGridView_PreguntaBuscada.Enabled = true;
                groupBox_ingresoPreguntas.Enabled = true;
                boton_Agregar.Enabled = false;
                boton_Modificar.Enabled = true;
                boton_Eliminar.Enabled = true;
                txtCodigo.Enabled = false;
                txtMateria.Enabled = false;
                txtPregunta.Enabled = true;
                txtRespuesta1.Enabled = true;
                txtRespuesta2.Enabled = true;
                txtRespuesta3.Enabled = true;
                txtRespuesta4.Enabled = true;
            }
            else
            {
                txtPregunta.Text = dataGridView_PreguntaBuscada.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtRespuesta1.Text = dataGridView_PreguntaBuscada.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtRespuesta2.Text = dataGridView_PreguntaBuscada.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtRespuesta3.Text = dataGridView_PreguntaBuscada.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtRespuesta4.Text = dataGridView_PreguntaBuscada.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
        }

        private void ScrollBarNumero_Scroll(object sender, ScrollEventArgs e)
        {
            txt_numeroPregunta.Text = ScrollBarNumero.Value.ToString();
            numeroPreguntas = ScrollBarNumero.Value;
        }

        private void boton_Ayuda_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip_Ayuda = new System.Windows.Forms.ToolTip();
            ToolTip_Ayuda.SetToolTip(this.boton_Ayuda, "Ayuda.");
        }

        private void boton_Volver_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip_Login = new System.Windows.Forms.ToolTip();
            ToolTip_Login.SetToolTip(this.boton_Volver, "Volver al Login.");
        }

        private void boton_Salir_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip_Salir = new System.Windows.Forms.ToolTip();
            ToolTip_Salir.SetToolTip(this.boton_Salir, "Salir de la Aplicación.");
        }

        private void boton_Imprimir_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip_Imprimir = new System.Windows.Forms.ToolTip();
            ToolTip_Imprimir.SetToolTip(this.boton_Imprimir, "Imprimir");
        }

        private void boton_Cancelar_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip_Cancelar = new System.Windows.Forms.ToolTip();
            ToolTip_Cancelar.SetToolTip(this.boton_Cancelar, "Salir Menu Principal");
        }

        private void boton_Terminar_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip_Terminar = new System.Windows.Forms.ToolTip();
            ToolTip_Terminar.SetToolTip(this.boton_Terminar, "Salir de Administracion.");
        }

        private void Cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            (interfaz as ICommunicationObject).Close();
            ObjetoRemoto.Servidor.StopServer();
        }
    }
}