double temperatura = 0;
double conversao = 0;
string opcao = "C";

Console.WriteLine("Qual valor da temperatura que deseja converter?");
temperatura = double.Parse(Console.ReadLine());

Console.WriteLine("");

Console.WriteLine("Deseja converter para qual unidade de temperatura?");
Console.WriteLine("C - Graus Celsius");
Console.WriteLine("F - FAHREMHEIT");
opcao = Console.ReadLine();

switch (opcao)
{
    case "C":
        conversao = (temperatura * 9 / 5) + 32;
        break;

    case "F":
        conversao = (temperatura - 32) * 5 / 9;
        break;

    default:

        break; 

}

Console.WriteLine("Temperatura convertida é: " + conversao);

