using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Calculadora
    {
        public string Soma(int x, int y)
        {
            return $"A Soma de {x} + {y} é igual a: {x+y}";
        }

        public int Subtracao(int x, int y)
        {
            return x - y;
        }

        public int Multiplicacao(int x, int y)
        {
            return x * y;
        }

        public double Divisao(double x, double y)
        {
            return x / y;
        }

    }
}