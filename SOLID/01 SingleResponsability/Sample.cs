using System;

namespace SOLID._01_SingleResponsability
{
    public class Sample
    {
        public void Sumar(int a, int b)
        {
            var c = a + b;
            var m = "";
            if (c > 0 && c <= 10) m = "Valor entre 0 y 10";
            else if (c > 10 && c <= 20) m = "Valor entre 11 y 20";
            else if (c > 20 && c <= 30) m = "Valor entre 11 y 20";
            Console.WriteLine(string.Format("La suma es: {0} y es {1}", c, m));
        }
    }
}
