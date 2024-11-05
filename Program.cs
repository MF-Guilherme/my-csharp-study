using System.Globalization;
using ExemploFundamentos.Models;


Calculadora calc = new Calculadora();


int subtracao = calc.Subtracao(120, 321);
int multiplicacao = calc.Multiplicacao(120, 321);
double divisao = calc.Divisao(230, 25);

Console.WriteLine(calc.Soma(120, 321));
Console.WriteLine(subtracao);
Console.WriteLine(multiplicacao);
Console.WriteLine(divisao.ToString("F4", CultureInfo.InvariantCulture));












// Pessoa p = new Pessoa();

// p.Nome = "Guilherme";
// p.Idade = 33;

// p.Apresentar();