using System.Security.Cryptography;

Console.Clear();

int naipe = RandomNumberGenerator.GetInt32(1,5);

string nomeNaipe = naipe switch
{
    1 => "Paus",
    2 => "Espada",
    3 => "Copas",
    4 => "ouros",
    _ => ""
};

switch (naipe)
{
    case 1:
        nomeNaipe = "Paus";
        break;
    case 2:
        nomeNaipe = "Espada";
        break;
    case 3:
        nomeNaipe = "Copas";
        break;
    case 4:
        nomeNaipe = "Ouros";
        break;
    default:
        break;
}

Console.WriteLine(nomeNaipe);