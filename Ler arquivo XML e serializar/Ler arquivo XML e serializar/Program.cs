using System.Xml.Serialization;

namespace Ler_arquivo_XML_e_serializar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader xml = new StreamReader(@"C:\tmp\pessoa.xml")) 
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Pessoa));
                Pessoa pessoa = (Pessoa)serializer.Deserialize(xml);

                Console.WriteLine($"Nome: {pessoa.Nome}");
                Console.WriteLine($"Idade: {pessoa.Idade}");
                Console.WriteLine($"Cidade: {pessoa.Cidade}");
            }

        }
    }
}
