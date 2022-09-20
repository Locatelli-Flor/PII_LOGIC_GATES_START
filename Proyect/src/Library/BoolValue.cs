using System;

namespace CompuertasLogicas
{
    public class BoolValue : ICalculable
    {
        public bool Valor{get;set;}
        public BoolValue(bool valor)
        {
            this.Valor = valor;
        }
        public bool Calcular()
        {
            return this.Valor;
        }
    }
}