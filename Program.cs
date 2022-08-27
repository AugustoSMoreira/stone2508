Start();

static void Start()
{
  Params();
  Start();
}
// Função de seleção das funções
static void Params()
{
  Console.Clear();

  Console.WriteLine("Olá, vamos calcular?");
  Console.WriteLine("Qual operação tipo de operação você gostaria de fazer?");
  Console.WriteLine("+ - para Somar");
  Console.WriteLine("- - para Subtrair");
  Console.WriteLine("* - para Multiplicar");
  Console.WriteLine("/ - para Dividir ");
  Console.WriteLine("0 - para sair");
  var sinal = char.Parse(Console.ReadLine());

  switch (sinal)
  {
    case '+':
      Values(sinal);
      break;
    case '-':
      Values(sinal);
      break;
    case '*':
      Values(sinal);
      break;
    case '/':
      Values(sinal);
      break;
    case '0':
      System.Environment.Exit(0);
      Thread.Sleep(1000);
      break;
    default:
      Console.WriteLine("Por favor, escolha uma opção válida.");
      Thread.Sleep(2000);
      Params();
      break;
  }
}
// Função que recebe os valores e repassa as funções responsáveis
static void Values(char sinal)
{
  Console.Clear();

  if (sinal == '+')
  {
    Console.WriteLine("Vamos somar então :)");
    Console.WriteLine("Me passe o primeiro valor:");
    var value1 = Double.Parse(Console.ReadLine());
    Console.WriteLine("Me passe o segundo valor:");
    var value2 = Double.Parse(Console.ReadLine());
    Ready();
    Plus(value1, value2);
  }
  else if (sinal == '-')
  {
    Console.WriteLine("Vamos somar então :)");
    Console.WriteLine("Me passe o primeiro valor:");
    var value1 = Double.Parse(Console.ReadLine());
    Console.WriteLine("Me passe o segundo valor:");
    var value2 = Double.Parse(Console.ReadLine());
    Ready();
    subtraction(value1, value2);
  }
  else if (sinal == '*')
  {
    Console.WriteLine("Vamos somar então :)");
    Console.WriteLine("Me passe o primeiro valor:");
    var value1 = Double.Parse(Console.ReadLine());
    Console.WriteLine("Me passe o segundo valor:");
    var value2 = Double.Parse(Console.ReadLine());
    Ready();
    multiplication(value1, value2);
  }
  else if (sinal == '/')
  {
    Console.WriteLine("Vamos somar então :)");
    Console.WriteLine("Me passe o primeiro valor:");
    var value1 = Double.Parse(Console.ReadLine());
    Console.WriteLine("Me passe o segundo valor:");
    var value2 = Double.Parse(Console.ReadLine());
    Ready();
    division(value1, value2);
  }


}
// Função stopwatch
static void Ready()
{
  Console.Clear();

  Console.WriteLine("ESQUENTANDO...");
  Thread.Sleep(1000);
  Console.WriteLine("RABISCANDO...");
  Thread.Sleep(1000);
  Console.WriteLine("FOI...");
  Thread.Sleep(1000);
}
// Funções matemáticas
static void Plus(Double value1, Double value2)
{
  var result = value1 + value2;

  Console.WriteLine($"Esse é seu resultado amigão: {result}");
  Console.WriteLine($"Aperte Enter pra continuar...");
  Console.ReadKey();

}
static void subtraction(Double value1, Double value2)
{
  var result = value1 - value2;

  Console.WriteLine($"Esse é seu resultado amigão: {result}");
  Console.WriteLine($"Aperte Enter pra continuar...");

  Console.ReadKey();
}
static void multiplication(Double value1, Double value2)
{
  var result = value1 * value2;

  Console.WriteLine($"Esse é seu resultado amigão: {result}");
  Console.WriteLine($"Aperte Enter pra continuar...");
  Console.ReadKey();
}
static void division(Double value1, Double value2)
{
  var result = value1 / value2;

  Console.WriteLine($"Esse é seu resultado amigão: {result}");
  Console.WriteLine($"Aperte Enter pra continuar...");
  Console.ReadKey();
}
