using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe um número para ver a tabuada: ");

        // Lê o número informado pelo usuário
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            int contador = 1; // Inicializa o contador

            Console.WriteLine($"\nTabuada do {numero}:");

            // Laço while para calcular a tabuada de 1 a 10
            while (contador <= 10)
            {
                int resultado = numero * contador;
                Console.WriteLine($"{numero} x {contador} = {resultado}");
                contador++;
            }
        }
        else
        {
            Console.WriteLine("Por favor, insira um número válido.");
        }
    }
}

