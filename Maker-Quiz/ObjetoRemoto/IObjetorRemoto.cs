using System.Runtime.Serialization;
using System.Collections.Generic;
using System.ServiceModel;
using System.Linq;
using System.Text;
using System;

namespace ObjetoRemoto
{
    [ServiceContract]
    public interface IObjetorRemoto
    {
        [OperationContract]
        int obtenerID_Usuario(int id);
        [OperationContract]
        List<Usuario> agregarUsuario(List<Usuario> lista_usuario);
        [OperationContract]
        List<Usuario> consultaDatosUsuario(List<Usuario> lista_usuario);
        [OperationContract]
        List<Usuario> eliminarUsuario(List<Usuario> lista_usuario);
        [OperationContract]
        List<Usuario> modificarUsuario(List<Usuario> lista_usuario);
        [OperationContract]
        List<Usuario> mostrarUsuario(List<Usuario> lista_usuario);
        [OperationContract]
        List<Usuario> compararUsuario(List<Usuario> lista_usuario);
        [OperationContract]
        int obtenerID_Pregunta(int id);
        [OperationContract]
        int obtenerID_Examen(int id);
        [OperationContract]
        List<Preguntas> agregarPreguntas(List<Preguntas> lista_preguntas);
        [OperationContract]
        List<Preguntas> modificarPreguntas(List<Preguntas> lista_preguntas);
        [OperationContract]
        List<Preguntas> eliminarPreguntas(List<Preguntas> lista_preguntas);
        [OperationContract]
        List<Preguntas> mostrarPreguntas(List<Preguntas> lista_preguntas);
        [OperationContract]
        List<Preguntas> mostrarExamenes(List<Preguntas> lista_preguntas);
        [OperationContract]
        List<Preguntas> buscarPreguntas_Codigo(List<Preguntas> lista_preguntas);
        [OperationContract]
        List<Preguntas> buscarPreguntas_Materia(List<Preguntas> lista_preguntas);
        [OperationContract]
        List<Preguntas> buscarPreguntas_Pregunta(List<Preguntas> lista_preguntas);
        [OperationContract]
        List<Preguntas> buscarPreguntas_Examen(List<Preguntas> lista_preguntas);
        [OperationContract]
        List<Preguntas> eliminar_Examen(List<Preguntas> lista_preguntas);
    }
}