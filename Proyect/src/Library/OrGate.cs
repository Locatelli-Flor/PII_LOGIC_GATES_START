using System;
using System.Collections.Generic;

namespace CompuertasLogicas
{
    public class OrGate : ILogicGate
    {
        public string Nombre{get;}
        public Dictionary<string,ICalculable> Entradas{get;}

        public OrGate(string nombre)
        {
            this.Nombre = nombre;
            this.Entradas = new Dictionary<string, ICalculable>();
        }
        public bool Calcular()
        {
            foreach (var entrada in this.Entradas)
            {
                if (entrada.Value.Calcular() == true)
                {
                    return true;
                }
            }
            return false;
        }
        public void Connect(string nombre, ICalculable valor)
        {
            this.Entradas.Add(nombre,valor);
        }

    }
}