using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Celulares
{
    public class Celulares
    {
        public List<Celular> ListCelulares { get; set; }
        public Celulares()
        {
            ListCelulares = new List<Celular>();
        }
        public void Agregar (Celular celular)
        {
            ListCelulares.Add(celular);
        }
        public List<Celular> ImprimirCelulares()
        {
            List<Celular> impcelulares = new List<Celular>();
            foreach(Celular celular in ListCelulares)
            {
                impcelulares.Add(celular);
            }
            return impcelulares;
        }
        public List<Celular> CelularXModelo(string modelo)
        {
            List<Celular> aux = new List<Celular>();
            foreach(Celular celular in ListCelulares)
            {
                if (celular.Modelo.StartsWith(modelo))
                {
                    aux.Add(celular);
                }
            }
            return aux;
        }
        public List<Celular> CelularXAnio(int anio)
        {
            List<Celular> auxA = new List<Celular>();
            foreach(Celular celular in ListCelulares)
            {
                if (celular.Anio == anio)
                {
                    auxA.Add(celular);
                }
            }
            return auxA;
        }
        public List<Celular> CelularXMarca(string marca)
        {
            List<Celular> auxM = new List<Celular>();
            foreach (Celular celular in ListCelulares)
            {
                if (celular.Marca.StartsWith(marca))
                {
                    auxM.Add(celular);
                }
            }
            return auxM;
        }
    }
}