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
    [Table(Name = "Preguntas")]
    public class Preguntas
    {
        [Column(IsPrimaryKey = true)]
        public int Id;

        [Column]
        public string Codigo;

        [Column]
        public string Materia;

        [Column]
        public string Pregunta;

        [Column]
        public string Respuesta_1;

        [Column]
        public string Respuesta_2;

        [Column]
        public string Respuesta_3;

        [Column]
        public string Respuesta_4;

        [Column]
        public int Examen;

        public Preguntas()
        {
        }

        public Preguntas(string ini_codigo, string ini_materia, int ini_examen)
        {
            Codigo = ini_codigo;
            Materia = ini_materia;
            Examen = ini_examen;
        }

        public Preguntas(int ini_id, string ini_codigo, string ini_materia, string ini_pregunta, string ini_respuesta_1, string ini_respuesta_2, string ini_respuesta_3, string ini_respuesta_4, int ini_examen)
        {
            Id = ini_id;
            Codigo = ini_codigo;
            Materia = ini_materia;
            Pregunta = ini_pregunta;
            Respuesta_1 = ini_respuesta_1;
            Respuesta_2 = ini_respuesta_2;
            Respuesta_3 = ini_respuesta_3;
            Respuesta_4 = ini_respuesta_4;
            Examen = ini_examen;
        }

        public override string ToString()
        {
            return Id + Codigo + Materia + Respuesta_1 + Respuesta_2 + Respuesta_3 + Respuesta_4 + Examen;
        }
    }
}