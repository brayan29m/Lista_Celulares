using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Celulares
{
    public class Celular
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Precio { get; set; }
        public int Anio { get; set; }
        public Celular() { }
        public Celular(string marca, string modelo, string precio, int anio)
        {
            Marca = marca;
            Modelo = modelo;
            Precio = precio;
            Anio = anio;
        }
    }
}