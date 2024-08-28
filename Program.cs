Calculadora calc = new Calculadora();

Console.WriteLine("Digite o primeiro número:");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
double y = Convert.ToDouble(Console.ReadLine());

double resultadoSoma = calc.Soma(x, y);
Console.WriteLine($"A soma de {x} e {y} é igual a {resultadoSoma}");

Console.WriteLine($"O resultado da subtração é {calc.Subtracao(x, y)}");
Console.WriteLine($"O resultado da multiplicação é {calc.Multiplicacao(x, y)}");
Console.WriteLine($"O resultado da divisão é {calc.Divisao(x, y)}");