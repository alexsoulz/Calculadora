bool terminou = false;
int numero1, numero2, resultado = 0;

Console.WriteLine("Digite uma operação:");
Console.WriteLine("1 - Soma");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");

do{

switch (Console.ReadLine()) {
    
    case "1":
        Console.Clear();
        Console.WriteLine("Digite o primeiro valor");
        numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor");
        numero2 = int.Parse(Console.ReadLine());
        resultado = numero1 + numero2;
        Console.WriteLine($"O resultado da soma de {numero1} mais {numero2} é {resultado}");
        break;

    case "2":
        Console.Clear();
        Console.WriteLine("Digite o primeiro valor");
        numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor");
        numero2 = int.Parse(Console.ReadLine());
        resultado = numero1 - numero2;
        Console.WriteLine($"O resultado da subtração de {numero1} menos {numero2} é {resultado}");
        break;

        case "3":
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            numero2 = int.Parse(Console.ReadLine());
            resultado = numero1 * numero2;
            Console.WriteLine($"O resultado da multiplicação de {numero1} vezes {numero2} é {resultado}");
            break;

        case "4":
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            numero2 = int.Parse(Console.ReadLine());
            resultado = numero1 / numero2;
            Console.WriteLine($"O resultado da divisão de {numero1} divido por {numero2} é {resultado}");
            break;

        default:
        Console.WriteLine("Opção inválida");
        break;
}

Console.Write("\n" + "Fazer outra operação? (y/n)");
char reniciar = char.Parse(Console.ReadLine());

if (reniciar == 'y') {
    Console.Clear();
    Console.WriteLine("Digite uma operação:");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    terminou = false;
}
else {
    terminou = true;
    Console.Clear();
    Console.WriteLine("O programa se encerrou!");
}
}while (!terminou);

