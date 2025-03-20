using System;
namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu(); // Chamando a função Menu principal
    }

    static void Menu()
    {
      Console.Clear();
      // Menu de escolha para o usuario
      Console.WriteLine("Selecione a opção que deseja realizar");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Divisão");
      Console.WriteLine("4 - Multiplicação");
      Console.WriteLine("5 - Sair");
      Console.WriteLine("=================");
      Console.WriteLine("Selecione uma opção: ");
      Console.WriteLine("=================");
      Console.WriteLine("Para Sair, digite: Crtl + C ");

      short res = short.Parse(Console.ReadLine());

      switch (res) // lógica de qual a opção o usuario deseja realizar
      {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        default: Menu(); break;
      }

    }
    static void Soma()
    {
      Console.Clear(); // Limpar o console antes da execução

      // Entrada do primeiro valor
      Console.WriteLine("Primeiro Valor:");
      float valor1 = float.Parse(Console.ReadLine());

      // Entrada do segundo valor
      Console.WriteLine("Segundo valor:");
      float valor2 = float.Parse(Console.ReadLine());

      Console.WriteLine(" "); // Somente para espaçar

      float resultado = valor1 + valor2; // Faz o calculo dos valores
      Console.WriteLine($"O resultado da soma é: {resultado}"); // Exibe o valor após o calculo
      Console.ReadKey();
      Menu();

    }

    static void Subtracao()
    {
      Console.Clear(); // Limpar o console antes da execução

      // Entrada do primeiro valor
      Console.WriteLine("Digite o primeiro valor:");
      float valor1 = float.Parse(Console.ReadLine());

      // Entrada do segundo valor
      Console.WriteLine("Digite o segundo valor:");
      float valor2 = float.Parse(Console.ReadLine());

      Console.WriteLine(" "); // Somente para espaçar
      float resultado = valor1 - valor2; // Faz o calculo dos valores
      Console.WriteLine($"O resulado da subtração é: {resultado}"); // Exibe o valor após o calculo
      Console.ReadKey();
      Menu();

    }

    static void Divisao()
    {
      Console.Clear();

      Console.WriteLine("Digite o primeiro valor:");
      float valor1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Digite o segundo valor:");
      float valor2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = valor1 / valor2;

      Console.WriteLine($"O resultado da divisão é: {resultado}");
      Console.ReadKey();
      Menu();


    }

    static void Multiplicacao()
    {
      Console.Clear();
      Console.WriteLine("Digite o primeiro valor:");
      float valor1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Digite o segundo valor:");
      float valor2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = valor1 * valor2;

      Console.WriteLine($"O resultado da multiplicação é: {resultado}");
      Console.ReadKey();
      Menu();

    }



  }
}
