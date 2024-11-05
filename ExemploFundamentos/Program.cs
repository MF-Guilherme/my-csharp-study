using System.Globalization;
using ExemploFundamentos.Common.Models;


int[] arrayInteiros = new int[3]; //se eu não quiser passar o tamanho do array ao instanciar, tenho que passar os valores, conforme abaixo
// int[] arrayInteiros = new int[] {32,452, 326};


arrayInteiros[0] = 32;
arrayInteiros[1] = 452;
arrayInteiros[2] = 326;

//sar FOR caso precise do índice
System.Console.WriteLine("Iterando com o for");
for (int i = 0; i < arrayInteiros.Length; i++)
{
    System.Console.WriteLine($"Posição Nº{i} - valor: {arrayInteiros[i]}");
}

System.Console.WriteLine("Iterando com o foreach");

//usar FOREACH se não for precisar do índice
foreach(int valor in arrayInteiros) {
    System.Console.WriteLine(valor);
}


// Pessoa p1 = new Pessoa();
// p1.Nome = "Guilherme";
// p1.Idade = 33;
// p1.Apresentar();






// string opcao;
// bool exibirMenu = true;

// while (exibirMenu)
// {
//     System.Console.WriteLine("Digite uma opção:");  
//     System.Console.WriteLine("1 - Cadastrar Cliente");
//     System.Console.WriteLine("2 - Buscar Cliente");
//     System.Console.WriteLine("3 - Apagar Cliente");
//     System.Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             System.Console.WriteLine("Cadastrar cliente");
//             break;
        
//         case "2":
//             System.Console.WriteLine("Buscar cliente");
//             break;

//         case "3":
//             System.Console.WriteLine("Apagar cliente");
//             break;

//         case "4":
//             System.Console.WriteLine("Programa encerrado");
//             exibirMenu = false;
//             // Environment.Exit(0);
//             break;

//         default:
//             System.Console.WriteLine("Opção inválida");
//             break;
//     }
// }

// System.Console.WriteLine("Agora posso continuar o programa");










// int soma = 0, numero = 0;

// do
// {
//     System.Console.Write("Digite um número (0 para parar): ");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while (numero != 0);

// System.Console.WriteLine($"A soma dos números é: {soma}");



// int b = 0;
// while (true)
// {
//     if (b > 10){
//         break;
//     }
//     else{
//         Console.WriteLine(b);
//         b++;
//     }
// }









// for (int i = 0; i <= 10; i++)
// {
//     for (int j = 1; j <= 10; j++)    
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
    
// }



// Calculadora calc = new Calculadora();


// int subtracao = calc.Subtracao(120, 321);
// int multiplicacao = calc.Multiplicacao(120, 321);
// double divisao = calc.Divisao(230, 25);

// Console.WriteLine(calc.Soma(120, 321));
// Console.WriteLine(subtracao);
// Console.WriteLine(multiplicacao);
// Console.WriteLine(divisao.ToString("F4", CultureInfo.InvariantCulture));












// Pessoa p = new Pessoa();

// p.Nome = "Guilherme";
// p.Idade = 33;

// p.Apresentar();