Console.Write("DIGITE UMA LETRA: ");
char? letra = Convert.ToChar(Console.ReadLine());

switch (letra)
{
    case 'A' or 'E' or 'I' or 'O' or 'U':
        Console.WriteLine("É UMA VOGAL");
        break;
    default:
        Console.WriteLine("É UMA CONSOANTE");
        break;
}

