using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_no10_ArchivosJson
{
    public class Universidad
    {
        string universidad;

        List<Estudiante> estudiantes = new List<Estudiante>();

        public string Universidad { get => universidad; set => universidad = value; }
        public List<Estudiante> Estudiantes { get => estudiantes; set => estudiantes = value; }


        public Universidad()
        {
            Estudiantes = new List<Estudiante>();
        }
    }
}