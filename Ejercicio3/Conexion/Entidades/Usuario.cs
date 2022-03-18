using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion.Entidades
{
    public class Usuario
    {
        public int No_Cuenta { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Centro_Estudio { get; set; }
        public string Carrera { get; set; }
        public string Contraseña { get; set; }

        public Usuario(int no_Cuenta, string nombre, int edad, string centro_Estudio, string carrera, string contraseña)
        {
            No_Cuenta = no_Cuenta;
            Nombre = nombre;
            Edad = edad;
            Centro_Estudio = centro_Estudio;
            Carrera = carrera;
            Contraseña = contraseña;
        }

        public Usuario()
        {
        }
    }
}
