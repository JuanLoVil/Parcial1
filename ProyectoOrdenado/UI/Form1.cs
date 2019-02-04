using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoOrdenado.DAO;

namespace ProyectoOrdenado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string calle, numero, cruzamientos, colonia;

            calle = textBox1.Text;
            numero = textBox2.Text;
            cruzamientos = textBox3.Text;
            colonia = textBox4.Text;

            insertarConBoton(calle,numero,cruzamientos,colonia);
        }

        private void insertarConBoton(string calle,string numero, string cruzamientos,string colonia)
        {
            UbicacionDAO ubicacion = new UbicacionDAO();

            ubicacion.insertar(calle, numero, cruzamientos, colonia);
        }
    }
}
