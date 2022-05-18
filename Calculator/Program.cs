namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Selecione a operação:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("0 - Sair");

            short opc = short.Parse(Console.ReadLine());

            switch (opc)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                default: Menu(); break;
            }


        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("SOMA:");
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            // Console.WriteLine("Resultado da Soma é " + resultado);
            //interpolacao de string
            Console.WriteLine($"Resultado da Soma é {resultado}");
            // somando direto
            // Console.WriteLine($"Resultado da Soma é {v1 + v2}");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("SUBTRAÇÃO:");
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;

            Console.WriteLine($"Resultado da Subtração é {resultado}");

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("DIVISÃO:");
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;

            Console.WriteLine($"O resultado da divisão é {resultado}");

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("MULTIPLICAÇÃO:");
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;

            Console.WriteLine($"O resultado da multiplicação é {resultado}");

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Menu();
        }
    }

}