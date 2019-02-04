using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace ProyectoOrdenado.DAO
{
    public class ConexionSQL
    {
        MySqlConnection miConexion;
        string parametrosConexion = "server=127.0.0.1; database=sci_bd;Uid=root; pwd=root;";

        public MySqlConnection conectar()
        {
            miConexion = new MySqlConnection(parametrosConexion);

            return miConexion;
        }

        public ConexionSQL()
        {
            parametrosConexion = "server=127.0.0.1; database=sci_bd;Uid=root; pwd=root;";

            miConexion = conectar();
        }

    }
}
