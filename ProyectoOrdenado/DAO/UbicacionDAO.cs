using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace ProyectoOrdenado.DAO
{
    class UbicacionDAO : ConexionSQL
    {
        MySqlConnection cn;
        MySqlCommand cmd = new MySqlCommand();

        public void insertar(string calle, string numero, string cruzamientos, string colonia)
        {
                cn = conectar();
                cn.Open();
                cmd.Connection = cn;
                cmd.CommandText = "INSERT INTO ubicacion(Calle, Numero, Cruzamientos, Colonia) VALUES('" + calle + "','" + numero + "','" + cruzamientos + "','" + colonia + "')";
                cmd.ExecuteNonQuery();

        }

    }
}
