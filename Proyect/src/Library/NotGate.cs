using System;
using System.Collections.Generic;

namespace CompuertasLogicas
{
    public class NotGate : ILogicGate
    {
        public string Nombre{get;}
        public Tuple<String,ICalculable> Entrada{get;set;}

        public NotGate(string nombre)
        {
            BoolValue ValorEntrada = new BoolValue(true);
            this.Nombre = nombre;
            this.Entrada = new Tuple<String,ICalculable>("",ValorEntrada);
        }
        public void Connect(string nombre, ICalculable valor)
        {
            var TuplaEntrada = Tuple.Create<string,ICalculable>(nombre, valor);
            this.Entrada = TuplaEntrada;
        }
        public bool Calcular()
        {
            if (this.Entrada.Item2.Calcular() == true)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

    }
}