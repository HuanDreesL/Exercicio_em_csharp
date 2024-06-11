Console.WriteLine("Cadastro Professor\n");

Professor professor = new Professor();


Console.Write("Nome do Professor: ");
professor.Nome = Console.ReadLine();

Console.Write("Salário: ");
professor.SalarioAtual = float.Parse(Console.ReadLine());

Console.Write("Data de Admissão: ");
professor.DataAdmissao = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Cadastro da Disciplina");
for (int i = 0; i < professor.Disciplinas.Length; i++) 
{
    Console.Write($"Digite o Nome da {i + 1}° disciplina: ");
    professor.Disciplinas[i].nome = Console.ReadLine();
    Console.Write($"Digite a carga horaria em HR: ");
    professor.Disciplinas[i].cargaHoraria = int.Parse(Console.ReadLine());
    Console.Write("Digite a duração (S = Semestral ou A = Anual): ");
    professor.Disciplinas[i].duracao = Console.ReadLine();
}

Console.WriteLine($"Informações Salvas com Sucesso!\n");
Console.WriteLine($"Dados do Professor {professor.Nome}:\n");
Console.WriteLine($"Salário: {professor.SalarioAtual}");
Console.WriteLine($"Data Admissão: {professor.DataAdmissao}");
Console.WriteLine($"Disciplinas que Trabalha:");
Console.WriteLine($"{professor.Disciplinas}");

for (int i = 0; i < professor.Disciplinas.Length; i++)
{
    Console.WriteLine($"{professor.Disciplinas[i].nome}");
}

struct Professor 
{
    public string Nome;
    public DateTime DataAdmissao;
    public float SalarioAtual;
    public Disciplina [] Disciplinas = new Disciplina [4] ;

    public Professor()
    {
    }
}
struct Disciplina
{
    public string nome;
    public int cargaHoraria;
    public string duracao;
}
