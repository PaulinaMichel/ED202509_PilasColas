using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Pila
    {
        List<string> _lista;

        public Pila()
        {
            _lista = new List<string>();
        }

        public void Agregar(string dato)
        {
            _lista.Add(dato);
        }

        public string Imprimir()
        {
            string datos = string.Empty;
            foreach (string dato in _lista)
            {
                datos += $"{dato}{Environment.NewLine}";
            }
            return datos;
        }

        public void Eliminar()
        {
            int ultimoIndice = _lista.Count - 1;
            if (ultimoIndice < 0)
            {
                throw new Exception("No hay elementos");
            }
            _lista.RemoveAt(ultimoIndice);
        }
    }
}