using Conexion.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion.Clases
{
    public class UsuarioAcceso
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=ejercicio3; Uid=root; Pwd= Bayron200028;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public Usuario Login(int no_Cuenta, string contraseña)
        {
            Usuario usuario = new Usuario();

            try
            {
                string sql = "SELECT * FROM usuario WHERE No_Cuenta = @No_Cuenta AND Contraseña = @Contraseña;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@No_Cuenta", no_Cuenta);
                cmd.Parameters.AddWithValue("Contraseña", contraseña);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    usuario = new Usuario();
                    usuario.No_Cuenta = Convert.ToInt32(reader[0]);
                    usuario.Nombre = reader[1].ToString();
                    usuario.Edad = Convert.ToInt32(reader[2]);
                    usuario.Centro_Estudio = reader[3].ToString();
                    usuario.Carrera = reader[4].ToString();
                    usuario.Contraseña = reader[5].ToString();
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception)
            {

            }
            return usuario;
        }

        public DataTable MostrarUsuarios()
        {
            DataTable Listadt = new DataTable();
            try
            {
                string sql = "SELECT * FROM usuario";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                Listadt.Load(reader);
                reader.Close();
                conn.Close();
            }
            catch (Exception)
            {

            }
            return Listadt;
        }
    }
}
