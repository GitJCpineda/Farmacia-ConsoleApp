using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Farmacia_ConsoleApp.DAL
{
    class conexionDAL
    {
        public bool PruebaConectar() {
            try {
                //declaracion de conexion
                SqlConnection Conexion = new SqlConnection("Data Source=localhost;Initial Catalog=Farmacia;User ID=sa;Password=@Carlos95;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //ejecutar comando
                SqlCommand Comando = new SqlCommand();

                Comando.CommandText = "SELECT * FROM Far_Empleado";
                //conexion
                Comando.Connection = Conexion;
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();

                return true;

            } //en caso no
            catch {
                return false;
            }
        
        }
    }
}
