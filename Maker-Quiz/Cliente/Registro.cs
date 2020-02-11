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
    public partial class Registro : Form
    {
        Thread servidor = new Thread(ObjetoRemoto.Servidor.Main);
        ChannelFactory<ObjetoRemoto.IObjetorRemoto> canal = new ChannelFactory<ObjetoRemoto.IObjetorRemoto>(new NetTcpBinding(), "net.tcp://localhost:8080");
        ObjetoRemoto.IObjetorRemoto interfaz;
        ObjetoRemoto.ObjetoRemoto objetoremotoUsuario = new ObjetoRemoto.ObjetoRemoto();
        List<Usuario> recibirDatosUsuario = new List<Usuario>();
        public string origen_destino;
        public string usuario;

        public Registro()
        {
            InitializeComponent();
            servidor.IsBackground = true;
            servidor.Start();
            Thread.Sleep(1000);
            interfaz = canal.CreateChannel();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            cargarElementos_Visuales();
            if (origen_destino == "login_registro")
            {
                cargarIdentificador();
            }

            if (origen_destino == "cliente_registro")
            {
                cargarDatos();
                cargarIdentificador();
            }
            limpiarCampos();
        }

        public void limpiarCampos()
        {
            txtUser.Clear();
            txtContraseña.Clear();
            txtConfirmarContraseña.Clear();
            checkBoxCondiciones.Checked = false;
        }

        public void cargarElementos_Visuales()
        {
            if (origen_destino == "login_registro")
            {
                etiquetaTitulo.Text = "CREAR NUEVA CUENTA.";
                botonRegistrar.Enabled = true;
                botonActualizar.Enabled = false;
                botonEliminar.Enabled = false;
                botonVolver.Enabled = true;
                botonSalir.Enabled = true;
                dataGridView_Datos.Enabled = false;
                dataGridView_Datos.Visible = false;
                groupBox_Condiciones.Enabled = true;
                condicionesLista.Enabled = true;
            }

            if (origen_destino == "cliente_registro")
            {
                etiquetaTitulo.Text = "ADMINISTRAR CUENTAS.";
                botonRegistrar.Enabled = true;
                botonActualizar.Enabled = false;
                botonEliminar.Enabled = false;
                botonVolver.Enabled = true;
                botonSalir.Enabled = false;
                dataGridView_Datos.Enabled = true;
                dataGridView_Datos.Visible = true;
                groupBox_Condiciones.Enabled = true;
            }
        }

        public void cargarIdentificador()
        {
            txtID.Text = Convert.ToString(interfaz.obtenerID_Usuario(0));
        }

        public void verificarUsuario()
        {
            objetoremotoUsuario.nombreUsuario = txtUser.Text;
            (objetoremotoUsuario as IObjetorRemoto).compararUsuario(recibirDatosUsuario);
            if (recibirDatosUsuario.Count() > 0)
            {
                MessageBox.Show("El usuario ya existe, escoja otro nombre...", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Clear();
                txtUser.Focus();
            }
            else
            {
                txtContraseña.Focus();
            }
            recibirDatosUsuario.Clear();
        }

        public void cargarDatos()
        {
            (objetoremotoUsuario as IObjetorRemoto).mostrarUsuario(recibirDatosUsuario);
            foreach (Usuario item in recibirDatosUsuario)
            {
                dataGridView_Datos.DataSource = objetoremotoUsuario.enviarUsuario.Select(x => x).Select(y => new
                {
                    ID = y.Id,
                    USER = y.Usuarios,
                    PASSWORD = y.Password
                }).ToList();
            }
            dataGridView_Datos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            recibirDatosUsuario.Clear();
        }

        public void eliminarDatos()
        {
            (objetoremotoUsuario as IObjetorRemoto).eliminarUsuario(recibirDatosUsuario);
            foreach (Usuario item in recibirDatosUsuario)
            {
                dataGridView_Datos.DataSource = objetoremotoUsuario.usuaurioCRUD.Select(x => x).Select(y => new
                {
                    ID = y.Id,
                    USER = y.Usuarios,
                    PASSWORD = y.Password
                }).ToList();
            }
            dataGridView_Datos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            recibirDatosUsuario.Clear();
            MessageBox.Show("Usuario" + "  " + txtUser.Text + "   " + "eliminado con exito...", "Felicidades.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cargarDatos();
            cargarIdentificador();
            dataGridView_Datos.ClearSelection();
            limpiarCampos();
        }

        public void modificarDatos()
        {
            objetoremotoUsuario.identificadorUsuario = Convert.ToInt32(txtID.Text);
            objetoremotoUsuario.nombreUsuario = txtUser.Text;
            objetoremotoUsuario.passwordUsuario = txtContraseña.Text;
            (objetoremotoUsuario as IObjetorRemoto).modificarUsuario(recibirDatosUsuario);
            foreach (Usuario item in recibirDatosUsuario)
            {
                dataGridView_Datos.DataSource = objetoremotoUsuario.usuaurioCRUD.Select(x => x).Select(y => new
                {
                    ID = y.Id,
                    USER = y.Usuarios,
                    PASSWORD = y.Password
                }).ToList();
            }
            dataGridView_Datos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            recibirDatosUsuario.Clear();
            MessageBox.Show("Usuario" + "  " + txtUser.Text + "   " + "actualizado con exito...", "Felicidades.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cargarDatos();
            cargarIdentificador();
            dataGridView_Datos.ClearSelection();
            limpiarCampos();
        }

        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            if (checkBoxCondiciones.Checked == true)
            {
                try
                {
                    if (origen_destino == "login_registro")
                    {
                        objetoremotoUsuario.identificadorUsuario = Convert.ToInt32(txtID.Text);
                        objetoremotoUsuario.nombreUsuario = txtUser.Text;
                        objetoremotoUsuario.passwordUsuario = txtContraseña.Text;
                        (objetoremotoUsuario as IObjetorRemoto).agregarUsuario(recibirDatosUsuario);
                        (interfaz as ICommunicationObject).Close();
                        ObjetoRemoto.Servidor.StopServer();
                        MessageBox.Show("Usuario" + "  " + txtUser.Text + "   " + "registrado con exito..." + "\n" + "Bienvenido" + "   " + txtUser.Text, "Felicidades.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        recibirDatosUsuario.Clear();
                        Cliente cambio = new Cliente();
                        Hide();
                        cambio.origen_destino = "registro_cliente";
                        cambio.nombreUsuario = txtUser.Text;
                        cambio.ShowDialog();
                        limpiarCampos();
                    }

                    if (origen_destino == "cliente_registro")
                    {
                        objetoremotoUsuario.identificadorUsuario = Convert.ToInt32(txtID.Text);
                        objetoremotoUsuario.nombreUsuario = txtUser.Text;
                        objetoremotoUsuario.passwordUsuario = txtContraseña.Text;
                        (objetoremotoUsuario as IObjetorRemoto).agregarUsuario(recibirDatosUsuario);
                        foreach (Usuario item in recibirDatosUsuario)
                        {
                            dataGridView_Datos.DataSource = objetoremotoUsuario.usuaurioCRUD.Select(x => x).Select(y => new
                            {
                                ID = y.Id,
                                USER = y.Usuarios,
                                PASSWORD = y.Password
                            }).ToList();
                        }
                        dataGridView_Datos.SelectionMode = DataGridViewSelectionMode.CellSelect;
                        recibirDatosUsuario.Clear();
                        MessageBox.Show("Usuario" + "  " + txtUser.Text + "   " + "registrado con exito...", "Felicidades.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarDatos();
                        cargarIdentificador();
                        dataGridView_Datos.ClearSelection();
                        limpiarCampos();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error en el registro...", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe aceptar las condiciones de uso...", "Advertencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void botonActualizar_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("Seguro desea modificar el usuario?", "Confirmacion", MessageBoxButtons.YesNo);
            if (pregunta == DialogResult.Yes)
            {
                modificarDatos();
                cargarElementos_Visuales();
            }
            else
            {
                return;
            }
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("Seguro desea eliminar el elemnto?", "Confirmacion", MessageBoxButtons.YesNo);
            if (pregunta == DialogResult.Yes)
            {
                objetoremotoUsuario.identificadorUsuario = Convert.ToInt32(txtID.Text);
                eliminarDatos();
                cargarElementos_Visuales();
            }
            else
            {
                return;
            }
        }

        private void botonSalir_Click(object sender, EventArgs e)
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

        private void botonVolver_Click(object sender, EventArgs e)
        {
            if (origen_destino == "login_registro")
            {
                (interfaz as ICommunicationObject).Close();
                ObjetoRemoto.Servidor.StopServer();
                Login cambio = new Login();
                Hide();
                cambio.ShowDialog();
                limpiarCampos();
            }
            if (origen_destino == "cliente_registro")
            {
                (interfaz as ICommunicationObject).Close();
                ObjetoRemoto.Servidor.StopServer();
                Cliente cambio = new Cliente();
                Hide();
                cambio.nombreUsuario = usuario;
                cambio.ShowDialog();
                limpiarCampos();
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            verificarUsuario();
        }

        private void txtConfirmarContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtConfirmarContraseña.Text)
            {
                botonRegistrar.Focus();
            }
            else
            {
                MessageBox.Show("Las Contraseñas no Coinciden", "Advertencia");
                txtContraseña.Clear();
                txtConfirmarContraseña.Clear();
                txtContraseña.Focus();
            }
        }

        private void dataGridView_Datos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUser.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtContraseña.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtConfirmarContraseña.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dataGridView_Datos_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView_Datos.SelectedCells.Count > 0)
            {
                botonActualizar.Enabled = true;
                botonEliminar.Enabled = true;
                botonRegistrar.Enabled = false;
                groupBox_Condiciones.Enabled = false;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento para modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}