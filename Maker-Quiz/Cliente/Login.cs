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
    public partial class Login : Form
    {
        Thread servidor = new Thread(ObjetoRemoto.Servidor.Main);
        ChannelFactory<ObjetoRemoto.IObjetorRemoto> canal = new ChannelFactory<ObjetoRemoto.IObjetorRemoto>(new NetTcpBinding(), "net.tcp://localhost:8080");
        ObjetoRemoto.IObjetorRemoto interfaz;
        ObjetoRemoto.ObjetoRemoto objetoremotoUsuario = new ObjetoRemoto.ObjetoRemoto();
        List<Usuario> recibirDatosUsuario = new List<Usuario>();
        bool existe = false;

        public Login()
        {
            InitializeComponent();
            servidor.IsBackground = true;
            servidor.Start();
            Thread.Sleep(1000);
            interfaz = canal.CreateChannel();
        }

        public void limpiarCampos()
        {
            txtUser.Clear();
            txtPassword.Clear();
            txtUser.Focus();
        }

        public void obtenerUsuario()
        {
            objetoremotoUsuario.usuarioLogin = txtUser.Text;
            objetoremotoUsuario.passwordLogin = txtPassword.Text;
            (objetoremotoUsuario as IObjetorRemoto).consultaDatosUsuario(recibirDatosUsuario);
            if (recibirDatosUsuario.Count() > 0)
            {
                existe = true;
            }
            else
            {
                existe = false;
            }
            recibirDatosUsuario.Clear();
        }

        private void botonInformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creador de Examenes." + "\n" +
                            "Aplicación desarrolada para crear una serie de examenes" + "\n" +
                            "Para crear un examen, solo tienes que registrarte o logearte." + "\n" +
                            "Gracias." + "\n" +
                            "Desarrollado por: Christian Xavier Arroyo Auz," + "\n" +
                            "                               EPN - 2017.", "Información");
        }

        private void etiquetaRegistro_Click(object sender, EventArgs e)
        {
            (interfaz as ICommunicationObject).Close();
            ObjetoRemoto.Servidor.StopServer();
            Registro cambio = new Registro();
            cambio.origen_destino = "login_registro";
            Hide();
            cambio.Show();
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

        private void botonLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtUser.Text == "")
            {
                MessageBox.Show("Debe LLenar Todos Los Espacios.", "Advertencia.");
                txtUser.Focus();
            }
            else
            {
                try
                {
                    obtenerUsuario();
                    if (existe == true)
                    {
                        (interfaz as ICommunicationObject).Close();
                        ObjetoRemoto.Servidor.StopServer();
                        MessageBox.Show("Bienvenido..." + "  " + txtUser.Text, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cliente cambio = new Cliente();
                        Hide();
                        cambio.origen_destino = "login_cliente";
                        cambio.nombreUsuario = txtUser.Text;
                        cambio.ShowDialog();
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No existen usuarios registrados...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiarCampos();
                    }
                }
                catch (Exception www)
                {
                    MessageBox.Show(www.ToString() + "\n" + "Ha ocurrido un error en la ejecucion...", "Advertencia");
                }
            }
        }

        private void botonInformacion_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip_Informacion = new System.Windows.Forms.ToolTip();
            ToolTip_Informacion.SetToolTip(this.botonInformacion, "Información Prgramadores.");
        }

        private void botonSalir_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip_Salir = new System.Windows.Forms.ToolTip();
            ToolTip_Salir.SetToolTip(this.botonSalir, "Salir de la Aplicación.");
        }
    }
}