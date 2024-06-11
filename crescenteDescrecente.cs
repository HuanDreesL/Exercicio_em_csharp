using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

float valor1, valor2;
int opcao;

Console.WriteLine("Insira o primeiro valor: ");
valor1 = float.Parse(Console.ReadLine());

Console.WriteLine("Insira o segundo valor: ");
valor2 = float.Parse(Console.ReadLine());

Console.WriteLine("Tipo de ordenação 1 - Crescente / 2 - Descrecente");
opcao = int.Parse(Console.ReadLine());

if (Ordenar(ref valor1, ref valor2, opcao))
{
    Console.WriteLine($"Número Ordenados: {valor1}, {valor2}");
}else
{
    Console.WriteLine("Opção Inválida");
}

bool Ordenar(ref float num1, ref float num2, int opcao) 
{
    float aux;
    switch (opcao)
    {
        case 1: // Crescente
            if (num1 > num2) 
            {
                Trocar(ref num1, ref num2);
            }
            return true;
        case 2: // Descrecente
            if (num2 > num1) 
            {
                Trocar(ref num1, ref num2);
            }
            return true;
        default: // Inválida
            return false;
    }          
}

void Trocar(ref float n1, ref float n2) 
{
    float aux = n1;
    n1 = n2;
    n2 = aux;
}
