namespace Listas
{
    internal class Cola
    {
        List<string> _lista;
        public Cola()
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
            if (_lista.Count == 0)
            {
                throw new Exception("No hay elementos");
            }
            _lista.RemoveAt(0);
        }
    }

}

