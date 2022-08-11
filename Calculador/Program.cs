int num1 = 0; int num2 = 0; string loop = "";

static string answerToUpper()
{
    string loop = Console.ReadLine();
    loop = loop.ToUpper();
    return loop;
}



Console.WriteLine("Calculadora em console C#\r");
Console.WriteLine("-------------------------\n");
do
{
    Console.WriteLine("Digite um número, e tecle Enter");
    num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite o segundo número, e tecle Enter");
    num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Escolha uma opção na lista abaixo:");
    Console.WriteLine("\t1 - Adição");
    Console.WriteLine("\t2 - Subtração");
    Console.WriteLine("\t3 - Multiplicação");
    Console.WriteLine("\t4 - Divisão");

    var option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.WriteLine($"Resultado: {num1} + {num2} = {num1 + num2}");
            break;

        case "2":
            Console.WriteLine($"Resultado: {num1} - {num2} = {num1 - num2}");
            break;

        case "3":
            Console.WriteLine($"Resultado: {num1} x {num2} = {num1 * num2}");
            break;

        case "4":
            Console.WriteLine($"Resultado: {num1} / {num2} = {num1 / num2}");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    };
    Console.WriteLine("Deseja realizar outra operação?");
    Console.WriteLine("\nS - Sim");
    Console.WriteLine("\nN - Não");
    loop = answerToUpper();
} while (loop == "S");

