using System.Text.Json;

namespace Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa
            {
                Nome = "João",
                Idade = 30,
                Cidade = "Chapecó"
            };

            string json = JsonSerializer.Serialize(pessoa);
            Console.WriteLine("Objeto Json: " + json);
        }
    }
}
