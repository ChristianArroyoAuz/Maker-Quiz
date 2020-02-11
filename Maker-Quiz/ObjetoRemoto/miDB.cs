using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System;

namespace ObjetoRemoto
{
    class miDB : DataContext
    {
        public Table<Preguntas> Preguntas;
        public Table<Usuario> Usuario;
        public miDB() : base(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\CADENA_DE_CONEXIÓN\miDB.mdf;Integrated Security = True; Connect Timeout = 30") { }
    }
}