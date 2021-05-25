using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
namespace Lab_no10_ArchivosJson
{
    public partial class _Default : Page
    {
        static List<Universidad> universidades = new List<Universidad>();
        static List<Estudiante> estudiantes = new List<Estudiante>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Cada vez que se corre el programa, se cargan las universidades existentes en el archivo Json

                //se usará el archivo de universidades
                string archivo = Server.MapPath("Universidades.json");
                //se abre el archivo
                StreamReader jsonStream = File.OpenText(archivo);

                //se lee todo el contenido del archivo y el contenido se guarda en la variable json
                string json = jsonStream.ReadToEnd();

                jsonStream.Close();

                //Se deserializa (convierte) la cadena json en la estructura que tiene la lista universidades
                universidades = JsonConvert.DeserializeObject<List<Universidad>>(json);
            }
        }

        private void GuardarJson()
        {
            string json = JsonConvert.SerializeObject(universidades);
            string archivo = Server.MapPath("Universidades.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        protected void ButtonGuardarEstudiante_Click(object sender, EventArgs e)
        {
            Universidad uni = universidades.Find(u => u.Universidad == TextBoxUniversidad.Text);

            if (uni.Estudiantes.Count > 0)
                estudiantes = uni.Estudiantes;

            Estudiante estudiante = new Estudiante();
            estudiante.Nombre = TextBoxAlumno.Text;

            estudiantes.Add(estudiante);
        }

        protected void ButtonUniversidad_Click(object sender, EventArgs e)
        {
            Universidad uni = universidades.Find(u => u.Universidad == TextBoxUniversidad.Text);

            if (uni.Universidad.Length == 0)
            {
                Universidad universidad = new Universidad();
                universidad.Universidad = TextBoxUniversidad.Text;
                universidad.Estudiantes = estudiantes.ToList();

                universidades.Add(universidad);

                GuardarJson();

                estudiantes.Clear();
            }
            else
            {
                uni.Estudiantes = estudiantes;
                GuardarJson();

            }
        }
    }
}