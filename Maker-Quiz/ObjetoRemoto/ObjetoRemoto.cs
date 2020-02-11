using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Linq;
using System.Text;
using System;

namespace ObjetoRemoto
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class ObjetoRemoto : MarshalByRefObject, IObjetorRemoto
    {
        miDB miBase = new miDB();
        public int identificadorUsuario, identificadorPregunta, examen;
        public string nombreUsuario, passwordUsuario;
        public string codigo, materia, pregunta, respuesta_1, respuesta_2, respuesta_3, respuesta_4;
        public string usuarioLogin, passwordLogin, busqueda;
        public List<Preguntas> mostrarPreguntasUsuario = new List<Preguntas>();
        public List<Usuario> enviarUsuario = new List<Usuario>();
        public List<Usuario> enviarPassword = new List<Usuario>();
        public List<Usuario> usuaurioCRUD = new List<Usuario>();
        int aleatorio;

        public int obtenerID_Usuario(int id)
        {
            var consulta = (from usuarios in miBase.Usuario
                            where usuarios.Id > id
                            orderby usuarios.Id descending
                            select (int)usuarios.Id).Take(1);
            foreach (var identificador in consulta)
            {
                id = identificador;
                identificadorUsuario = id;
            }
            return (identificadorUsuario + 1);
        }

        public List<Usuario> agregarUsuario(List<Usuario> lista_usuario)
        {
            Usuario nuevoUsuario = new Usuario(identificadorUsuario, nombreUsuario, passwordUsuario);
            nuevoUsuario.Id = identificadorUsuario;
            nuevoUsuario.Usuarios = nombreUsuario;
            nuevoUsuario.Password = passwordUsuario;
            miBase.Usuario.InsertOnSubmit(nuevoUsuario);
            miBase.SubmitChanges();
            var consulta = from usuario in miBase.Usuario
                           where usuario.Id == identificadorUsuario
                           select new
                           {
                               ID = usuario.Id,
                               USER = usuario.Usuarios,
                               PASSWORD = usuario.Password
                           };
            foreach (var item in consulta)
            {
                Usuario cargar = new Usuario(item.ID, item.USER, item.PASSWORD);
                lista_usuario.Add(cargar);
                usuaurioCRUD = lista_usuario;
            }
            return usuaurioCRUD;
        }

        public List<Usuario> consultaDatosUsuario(List<Usuario> lista_usuario)
        {
            var consulta = from usuarios in miBase.Usuario
                           where usuarios.Usuarios == usuarioLogin && usuarios.Password == passwordLogin
                           orderby usuarios.Id ascending
                           select new
                           {
                               ID = usuarios.Id,
                               USUARIO = usuarios.Usuarios,
                               PASSWORD = usuarios.Password
                           };
            foreach (var item in consulta)
            {
                Usuario cargar = new Usuario(item.ID, item.USUARIO, item.PASSWORD);
                lista_usuario.Add(cargar);
                enviarUsuario = lista_usuario;
            }
            return enviarUsuario;
        }

        public List<Usuario> eliminarUsuario(List<Usuario> lista_usuario)
        {
            miBase.ExecuteCommand("Delete from Usuario where Id = " + Convert.ToString(identificadorUsuario) + ";");
            miBase.SubmitChanges();
            mostrarUsuario(lista_usuario);
            return usuaurioCRUD;
        }

        public List<Usuario> modificarUsuario(List<Usuario> lista_usuario)
        {
            miBase.ExecuteCommand("Update Usuario set Id =" + "'" + Convert.ToString(identificadorUsuario) + "'" + "where Id =" + Convert.ToString(identificadorUsuario) + ";");
            miBase.ExecuteCommand("Update Usuario set Usuarios =" + "'" + Convert.ToString(nombreUsuario) + "'" + "where Id =" + Convert.ToString(identificadorUsuario) + ";");
            miBase.ExecuteCommand("Update Usuario set Password =" + "'" + Convert.ToString(passwordUsuario) + "'" + "where Id =" + Convert.ToString(identificadorUsuario) + ";");
            miBase.SubmitChanges();
            return usuaurioCRUD;
        }

        public List<Usuario> mostrarUsuario(List<Usuario> lista_usuario)
        {
            var consulta = from usuarios in miBase.Usuario
                           where usuarios.Id >= 0
                           orderby usuarios.Id ascending
                           select new
                           {
                               ID = usuarios.Id,
                               USUARIO = usuarios.Usuarios,
                               PASSWORD = usuarios.Password
                           };
            foreach (var item in consulta)
            {
                Usuario cargar = new Usuario(item.ID, item.USUARIO, item.PASSWORD);
                lista_usuario.Add(cargar);
                enviarUsuario = lista_usuario;
            }
            return enviarUsuario;
        }

        public List<Usuario> compararUsuario(List<Usuario> lista_usuario)
        {
            var consulta = from usuarios in miBase.Usuario
                           where usuarios.Usuarios == nombreUsuario
                           orderby usuarios.Id ascending
                           select new
                           {
                               ID = usuarios.Id,
                               USUARIO = usuarios.Usuarios,
                               PASSWORD = usuarios.Password
                           };
            foreach (var item in consulta)
            {
                Usuario cargar = new Usuario(item.ID, item.USUARIO, item.PASSWORD);
                lista_usuario.Add(cargar);
                enviarUsuario = lista_usuario;
            }
            return enviarUsuario;
        }

        public int obtenerID_Pregunta(int id)
        {
            var consulta = (from preguntas in miBase.Preguntas
                            where preguntas.Id > id
                            orderby preguntas.Id descending
                            select (int)preguntas.Id).Take(1);
            foreach (var identificador in consulta)
            {
                id = identificador;
                identificadorPregunta = id;
            }
            return (identificadorPregunta + 1);
        }

        public int obtenerID_Examen(int id)
        {
            var consulta = (from preguntas in miBase.Preguntas
                            where preguntas.Examen > id
                            orderby preguntas.Examen descending
                            select (int)preguntas.Examen).Take(1);
            foreach (var identificador in consulta)
            {
                id = identificador;
                examen = id;
            }
            return (examen + 1);
        }

        public List<Preguntas> agregarPreguntas(List<Preguntas> lista_preguntas)
        {
            Random r = new Random();
            aleatorio = r.Next(1, 5);
            if (aleatorio == 1)
            {
                Preguntas nuevaPregunta = new Preguntas(identificadorPregunta, codigo, materia, pregunta, respuesta_1, respuesta_2, respuesta_3, respuesta_4, examen);
                nuevaPregunta.Id = identificadorPregunta;
                nuevaPregunta.Codigo = codigo;
                nuevaPregunta.Materia = materia;
                nuevaPregunta.Pregunta = pregunta;
                nuevaPregunta.Respuesta_1 = respuesta_1;
                nuevaPregunta.Respuesta_2 = respuesta_2;
                nuevaPregunta.Respuesta_3 = respuesta_3;
                nuevaPregunta.Respuesta_4 = respuesta_4;
                nuevaPregunta.Examen = examen;
                miBase.Preguntas.InsertOnSubmit(nuevaPregunta);
                miBase.SubmitChanges();
                var consulta = from preguntas in miBase.Preguntas
                               where preguntas.Examen == examen
                               select new
                               {
                                   ID = preguntas.Id,
                                   CODIGO = preguntas.Codigo,
                                   MATERIA = preguntas.Materia,
                                   PREGUNTA = preguntas.Pregunta,
                                   RESPUESTA_1 = preguntas.Respuesta_1,
                                   RESPUESTA_2 = preguntas.Respuesta_2,
                                   RESPUESTA_3 = preguntas.Respuesta_3,
                                   RESPUESTA_4 = preguntas.Respuesta_4,
                                   EXAMEN = preguntas.Examen
                               };
                foreach (var item in consulta)
                {
                    Preguntas cargar = new Preguntas(item.ID, item.CODIGO, item.MATERIA, item.PREGUNTA, item.RESPUESTA_1, item.RESPUESTA_2, item.RESPUESTA_3, item.RESPUESTA_4, item.EXAMEN);
                    lista_preguntas.Add(cargar);
                    mostrarPreguntasUsuario = lista_preguntas;
                }
            }
            if (aleatorio == 2)
            {
                Preguntas nuevaPregunta = new Preguntas(identificadorPregunta, codigo, materia, pregunta, respuesta_2, respuesta_3, respuesta_4, respuesta_1, examen);
                nuevaPregunta.Id = identificadorPregunta;
                nuevaPregunta.Codigo = codigo;
                nuevaPregunta.Materia = materia;
                nuevaPregunta.Pregunta = pregunta;
                nuevaPregunta.Respuesta_1 = respuesta_2;
                nuevaPregunta.Respuesta_2 = respuesta_3;
                nuevaPregunta.Respuesta_3 = respuesta_4;
                nuevaPregunta.Respuesta_4 = respuesta_1;
                nuevaPregunta.Examen = examen;
                miBase.Preguntas.InsertOnSubmit(nuevaPregunta);
                miBase.SubmitChanges();
                var consulta = from preguntas in miBase.Preguntas
                               where preguntas.Examen == examen
                               select new
                               {
                                   ID = preguntas.Id,
                                   CODIGO = preguntas.Codigo,
                                   MATERIA = preguntas.Materia,
                                   PREGUNTA = preguntas.Pregunta,
                                   RESPUESTA_1 = preguntas.Respuesta_2,
                                   RESPUESTA_2 = preguntas.Respuesta_3,
                                   RESPUESTA_3 = preguntas.Respuesta_4,
                                   RESPUESTA_4 = preguntas.Respuesta_1,
                                   EXAMEN = preguntas.Examen
                               };
                foreach (var item in consulta)
                {
                    Preguntas cargar = new Preguntas(item.ID, item.CODIGO, item.MATERIA, item.PREGUNTA, item.RESPUESTA_2, item.RESPUESTA_3, item.RESPUESTA_4, item.RESPUESTA_1, item.EXAMEN);
                    lista_preguntas.Add(cargar);
                    mostrarPreguntasUsuario = lista_preguntas;
                }
            }
            if (aleatorio == 3)
            {
                Preguntas nuevaPregunta = new Preguntas(identificadorPregunta, codigo, materia, pregunta, respuesta_3, respuesta_4, respuesta_2, respuesta_1, examen);
                nuevaPregunta.Id = identificadorPregunta;
                nuevaPregunta.Codigo = codigo;
                nuevaPregunta.Materia = materia;
                nuevaPregunta.Pregunta = pregunta;
                nuevaPregunta.Respuesta_1 = respuesta_3;
                nuevaPregunta.Respuesta_2 = respuesta_4;
                nuevaPregunta.Respuesta_3 = respuesta_1;
                nuevaPregunta.Respuesta_4 = respuesta_2;
                nuevaPregunta.Examen = examen;
                miBase.Preguntas.InsertOnSubmit(nuevaPregunta);
                miBase.SubmitChanges();
                var consulta = from preguntas in miBase.Preguntas
                               where preguntas.Examen == examen
                               select new
                               {
                                   ID = preguntas.Id,
                                   CODIGO = preguntas.Codigo,
                                   MATERIA = preguntas.Materia,
                                   PREGUNTA = preguntas.Pregunta,
                                   RESPUESTA_1 = preguntas.Respuesta_3,
                                   RESPUESTA_2 = preguntas.Respuesta_4,
                                   RESPUESTA_3 = preguntas.Respuesta_1,
                                   RESPUESTA_4 = preguntas.Respuesta_2,
                                   EXAMEN = preguntas.Examen
                               };
                foreach (var item in consulta)
                {
                    Preguntas cargar = new Preguntas(item.ID, item.CODIGO, item.MATERIA, item.PREGUNTA, item.RESPUESTA_3, item.RESPUESTA_4, item.RESPUESTA_2, item.RESPUESTA_2, item.EXAMEN);
                    lista_preguntas.Add(cargar);
                    mostrarPreguntasUsuario = lista_preguntas;
                }
            }
            if (aleatorio == 4)
            {
                Preguntas nuevaPregunta = new Preguntas(identificadorPregunta, codigo, materia, pregunta, respuesta_4, respuesta_1, respuesta_2, respuesta_3, examen);
                nuevaPregunta.Id = identificadorPregunta;
                nuevaPregunta.Codigo = codigo;
                nuevaPregunta.Materia = materia;
                nuevaPregunta.Pregunta = pregunta;
                nuevaPregunta.Respuesta_1 = respuesta_4;
                nuevaPregunta.Respuesta_2 = respuesta_1;
                nuevaPregunta.Respuesta_3 = respuesta_2;
                nuevaPregunta.Respuesta_4 = respuesta_3;
                nuevaPregunta.Examen = examen;
                miBase.Preguntas.InsertOnSubmit(nuevaPregunta);
                miBase.SubmitChanges();
                var consulta = from preguntas in miBase.Preguntas
                               where preguntas.Examen == examen
                               select new
                               {
                                   ID = preguntas.Id,
                                   CODIGO = preguntas.Codigo,
                                   MATERIA = preguntas.Materia,
                                   PREGUNTA = preguntas.Pregunta,
                                   RESPUESTA_1 = preguntas.Respuesta_4,
                                   RESPUESTA_2 = preguntas.Respuesta_1,
                                   RESPUESTA_3 = preguntas.Respuesta_2,
                                   RESPUESTA_4 = preguntas.Respuesta_3,
                                   EXAMEN = preguntas.Examen
                               };
                foreach (var item in consulta)
                {
                    Preguntas cargar = new Preguntas(item.ID, item.CODIGO, item.MATERIA, item.PREGUNTA, item.RESPUESTA_4, item.RESPUESTA_1, item.RESPUESTA_2, item.RESPUESTA_3, item.EXAMEN);
                    lista_preguntas.Add(cargar);
                    mostrarPreguntasUsuario = lista_preguntas;
                }
            }
            return mostrarPreguntasUsuario;
        }

        public List<Preguntas> modificarPreguntas(List<Preguntas> lista_preguntas)
        {
            miBase.ExecuteCommand("Update Preguntas set Id =" + "'" + Convert.ToString(identificadorPregunta) + "'" + "where Id =" + Convert.ToString(identificadorPregunta) + ";");
            miBase.ExecuteCommand("Update Preguntas set Codigo =" + "'" + Convert.ToString(codigo) + "'" + "where Id =" + Convert.ToString(identificadorPregunta) + ";");
            miBase.ExecuteCommand("Update Preguntas set Materia =" + "'" + Convert.ToString(materia) + "'" + "where Id =" + Convert.ToString(identificadorPregunta) + ";");
            miBase.ExecuteCommand("Update Preguntas set Pregunta =" + "'" + Convert.ToString(pregunta) + "'" + "where Id =" + Convert.ToString(identificadorPregunta) + ";");
            miBase.ExecuteCommand("Update Preguntas set Respuesta_1 =" + "'" + Convert.ToString(respuesta_1) + "'" + "where Id =" + Convert.ToString(identificadorPregunta) + ";");
            miBase.ExecuteCommand("Update Preguntas set Respuesta_2 =" + "'" + Convert.ToString(respuesta_2) + "'" + "where Id =" + Convert.ToString(identificadorPregunta) + ";");
            miBase.ExecuteCommand("Update Preguntas set Respuesta_3 =" + "'" + Convert.ToString(respuesta_3) + "'" + "where Id =" + Convert.ToString(identificadorPregunta) + ";");
            miBase.ExecuteCommand("Update Preguntas set Respuesta_4 =" + "'" + Convert.ToString(respuesta_4) + "'" + "where Id =" + Convert.ToString(identificadorPregunta) + ";");
            miBase.ExecuteCommand("Update Preguntas set Examen =" + "'" + Convert.ToString(examen) + "'" + "where Id =" + Convert.ToString(identificadorPregunta) + ";");
            miBase.SubmitChanges();
            mostrarPreguntas(lista_preguntas);
            return mostrarPreguntasUsuario;
        }

        public List<Preguntas> eliminarPreguntas(List<Preguntas> lista_preguntas)
        {
            miBase.ExecuteCommand("Delete from Preguntas where Id = " + Convert.ToString(identificadorPregunta) + ";");
            miBase.SubmitChanges();
            mostrarPreguntas(lista_preguntas);
            return mostrarPreguntasUsuario;
        }

        public List<Preguntas> mostrarPreguntas(List<Preguntas> lista_preguntas)
        {
            var consulta = from preguntas in miBase.Preguntas
                           where preguntas.Id > 0
                           orderby preguntas.Id ascending
                           select new
                           {
                               ID = preguntas.Id,
                               CODIGO = preguntas.Codigo,
                               MATERIA = preguntas.Materia,
                               PREGUNTA = preguntas.Pregunta,
                               RESPUESTA_1 = preguntas.Respuesta_1,
                               RESPUESTA_2 = preguntas.Respuesta_2,
                               RESPUESTA_3 = preguntas.Respuesta_3,
                               RESPUESTA_4 = preguntas.Respuesta_4,
                               EXAMEN = preguntas.Examen
                           };
            foreach (var item in consulta)
            {
                Preguntas cargar = new Preguntas(item.ID, item.CODIGO, item.MATERIA, item.PREGUNTA, item.RESPUESTA_1, item.RESPUESTA_2, item.RESPUESTA_3, item.RESPUESTA_4, item.EXAMEN);
                lista_preguntas.Add(cargar);
                mostrarPreguntasUsuario = lista_preguntas;
            }
            return mostrarPreguntasUsuario;
        }

        public List<Preguntas> mostrarExamenes(List<Preguntas> lista_preguntas)
        {
            var consulta = from preguntas in miBase.Preguntas
                           where preguntas.Examen > 0
                           orderby preguntas.Examen ascending
                           select new
                           {
                               CODIGO = preguntas.Codigo,
                               MATERIA = preguntas.Materia,
                               EXAMEN = preguntas.Examen
                           };
            foreach (var item in consulta.Distinct())
            {
                Preguntas cargar = new Preguntas(item.CODIGO, item.MATERIA, item.EXAMEN);
                lista_preguntas.Add(cargar);
                mostrarPreguntasUsuario = lista_preguntas;
            }
            return mostrarPreguntasUsuario;
        }

        public List<Preguntas> buscarPreguntas_Codigo(List<Preguntas> lista_preguntas)
        {
            var consulta = from preguntas in miBase.Preguntas
                           where preguntas.Codigo == busqueda
                           orderby preguntas.Id ascending
                           select new
                           {
                               ID = preguntas.Id,
                               CODIGO = preguntas.Codigo,
                               MATERIA = preguntas.Materia,
                               PREGUNTA = preguntas.Pregunta,
                               RESPUESTA_1 = preguntas.Respuesta_1,
                               RESPUESTA_2 = preguntas.Respuesta_2,
                               RESPUESTA_3 = preguntas.Respuesta_3,
                               RESPUESTA_4 = preguntas.Respuesta_4,
                               EXAMEN = preguntas.Examen
                           };
            foreach (var item in consulta)
            {
                Preguntas cargar = new Preguntas(item.ID, item.CODIGO, item.MATERIA, item.PREGUNTA, item.RESPUESTA_1, item.RESPUESTA_2, item.RESPUESTA_3, item.RESPUESTA_4, item.EXAMEN);
                lista_preguntas.Add(cargar);
                mostrarPreguntasUsuario = lista_preguntas;
            }
            return mostrarPreguntasUsuario;
        }

        public List<Preguntas> buscarPreguntas_Materia(List<Preguntas> lista_preguntas)
        {
            var consulta = from preguntas in miBase.Preguntas
                           where preguntas.Materia == busqueda
                           orderby preguntas.Id ascending
                           select new
                           {
                               ID = preguntas.Id,
                               CODIGO = preguntas.Codigo,
                               MATERIA = preguntas.Materia,
                               PREGUNTA = preguntas.Pregunta,
                               RESPUESTA_1 = preguntas.Respuesta_1,
                               RESPUESTA_2 = preguntas.Respuesta_2,
                               RESPUESTA_3 = preguntas.Respuesta_3,
                               RESPUESTA_4 = preguntas.Respuesta_4,
                               EXAMEN = preguntas.Examen
                           };
            foreach (var item in consulta)
            {
                Preguntas cargar = new Preguntas(item.ID, item.CODIGO, item.MATERIA, item.PREGUNTA, item.RESPUESTA_1, item.RESPUESTA_2, item.RESPUESTA_3, item.RESPUESTA_4, item.EXAMEN);
                lista_preguntas.Add(cargar);
                mostrarPreguntasUsuario = lista_preguntas;
            }
            return mostrarPreguntasUsuario;
        }

        public List<Preguntas> buscarPreguntas_Pregunta(List<Preguntas> lista_preguntas)
        {
            var consulta = from preguntas in miBase.Preguntas
                           where preguntas.Pregunta == busqueda
                           orderby preguntas.Id ascending
                           select new
                           {
                               ID = preguntas.Id,
                               CODIGO = preguntas.Codigo,
                               MATERIA = preguntas.Materia,
                               PREGUNTA = preguntas.Pregunta,
                               RESPUESTA_1 = preguntas.Respuesta_1,
                               RESPUESTA_2 = preguntas.Respuesta_2,
                               RESPUESTA_3 = preguntas.Respuesta_3,
                               RESPUESTA_4 = preguntas.Respuesta_4,
                               EXAMEN = preguntas.Examen
                           };
            foreach (var item in consulta)
            {
                Preguntas cargar = new Preguntas(item.ID, item.CODIGO, item.MATERIA, item.PREGUNTA, item.RESPUESTA_1, item.RESPUESTA_2, item.RESPUESTA_3, item.RESPUESTA_4, item.EXAMEN);
                lista_preguntas.Add(cargar);
                mostrarPreguntasUsuario = lista_preguntas;
            }
            return mostrarPreguntasUsuario;
        }

        public List<Preguntas> buscarPreguntas_Examen(List<Preguntas> lista_preguntas)
        {
            var consulta = from preguntas in miBase.Preguntas
                           where preguntas.Examen == Convert.ToInt32(busqueda)
                           orderby preguntas.Examen ascending
                           select new
                           {
                               ID = preguntas.Id,
                               CODIGO = preguntas.Codigo,
                               MATERIA = preguntas.Materia,
                               PREGUNTA = preguntas.Pregunta,
                               RESPUESTA_1 = preguntas.Respuesta_1,
                               RESPUESTA_2 = preguntas.Respuesta_2,
                               RESPUESTA_3 = preguntas.Respuesta_3,
                               RESPUESTA_4 = preguntas.Respuesta_4,
                               EXAMEN = preguntas.Examen
                           };
            foreach (var item in consulta)
            {
                Preguntas cargar = new Preguntas(item.ID, item.CODIGO, item.MATERIA, item.PREGUNTA, item.RESPUESTA_1, item.RESPUESTA_2, item.RESPUESTA_3, item.RESPUESTA_4, item.EXAMEN);
                lista_preguntas.Add(cargar);
                mostrarPreguntasUsuario = lista_preguntas;
            }
            return mostrarPreguntasUsuario;
        }

        public List<Preguntas> eliminar_Examen(List<Preguntas> lista_preguntas)
        {
            miBase.ExecuteCommand("Delete from Preguntas where Examen = " + Convert.ToString(examen) + ";");
            miBase.SubmitChanges();
            mostrarPreguntas(lista_preguntas);
            return mostrarPreguntasUsuario;
        }
    }
}