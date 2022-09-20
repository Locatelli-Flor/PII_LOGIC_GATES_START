using System;
using System.Collections.Generic;

namespace CompuertasLogicas
{
    public class AndGate : ILogicGate
    {
        public string Nombre{get;}
        public Dictionary<string,ICalculable> Entradas{get;}

        public AndGate(string nombre)
        {
            this.Nombre = nombre;
            this.Entradas = new Dictionary<string, ICalculable>();
        }
        public bool Calcular()
        {
            foreach (var entrada in this.Entradas)
            {
                if (entrada.Value.Calcular() == false)
                {
                    return false;
                }
            }
            return true;
        }
        public void Connect(string nombre, ICalculable valor)
        {
            this.Entradas.Add(nombre,valor);
        }

    }
}