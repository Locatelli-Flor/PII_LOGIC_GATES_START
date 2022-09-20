using System;

namespace CompuertasLogicas
{
    public interface IConnectable
    {
        public void Connect(string nombre, ICalculable valor);
    }
}