using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TIENDAUPI3.Clases
{
    public class Clsestudiante
    {
      

        public int cedula { get; set; }
        public string nombre { get; set; }

        List<Clsestudiante> clsestudianteList = new List<Clsestudiante>();
        public Clsestudiante()
        {
        }

        public List<Clsestudiante> crea_estudiantes()
        {

            var estudiantes = new List<Clsestudiante>()
            {
                new Clsestudiante() { cedula = 1, nombre = "Carlos"},
                new Clsestudiante() { cedula = 2, nombre = "Maria"},
            };


            return estudiantes;
        }

    }
}