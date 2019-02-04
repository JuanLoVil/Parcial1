using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoOrdenado.DTO
{
    class UbicacionDTO
    {
        string Calle;
        string Numero;
        string Cruzamientos;
        string Colonia;

        public UbicacionDTO(string calle, string numero, string cruzamientos, string colonia)
        {
            Calle = calle;
            Numero = numero;
            Cruzamientos = cruzamientos;
            Colonia = colonia;
        }

        public string Calle1 { get => Calle; set => Calle = value; }
        public string Numero1 { get => Numero; set => Numero = value; }
        public string Cruzamientos1 { get => Cruzamientos; set => Cruzamientos = value; }
        public string Colonia1 { get => Colonia; set => Colonia = value; }
    }
}
