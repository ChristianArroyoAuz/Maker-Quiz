using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System;

namespace ObjetoRemoto
{
    [Serializable]
    [Table(Name = "Usuario")]
    public class Usuario
    {
        [Column(IsPrimaryKey = true)]
        public int Id;

        [Column]
        public string Usuarios;

        [Column]
        public string Password;

        public Usuario()
        {
        }

        public Usuario(int ini_id, string ini_nombre, string ini_password)
        {
            Id = ini_id;
            Usuarios = ini_nombre;
            Password = ini_password;
        }

        public override string ToString()
        {
            return Id + Usuarios + Password;
        }
    }
}