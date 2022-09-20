using System;
using System.Collections.Generic;

namespace CompuertasLogicas
{
    public static class Program
    {
        public static void Main()
        {
            AndGate And1 = new AndGate("AND-1");
            And1.Connect("A", new BoolValue(true));
            And1.Connect("B", new BoolValue(true));
            Console.WriteLine($"Resultado intermedio de compuerta {And1.Nombre}: {And1.Calcular()}");

            OrGate Or2 = new OrGate("OR-2");
            Or2.Connect("C",new BoolValue(false));
            Or2.Connect(And1.Nombre, And1);
            Console.WriteLine($"Resultado intermedio de compuerta {Or2.Nombre}: {Or2.Calcular()}");

            NotGate Not3 = new NotGate("NOT-3");
            Not3.Connect(Or2.Nombre, Or2);
            Console.WriteLine($"Resultado final: {Not3.Calcular()}");
        }
    }
}
