using System.Xml.Serialization;

namespace Produtos_XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produtosXml = @"C:\tmp\produtos.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(Produtos));
            using (FileStream fileStream = new FileStream(produtosXml, FileMode.Open)) 
            {
                Produtos produtos;
                try 
                {
                    produtos = (Produtos)serializer.Deserialize(fileStream);
                    foreach (var produto in produtos.produtos) 
                    {
                        Console.WriteLine($"Nome: {produto.Nome}");
                        Console.WriteLine($"Preço: R$ {produto.Preco}");
                        Console.WriteLine($"Descrição: {produto.Descricao}");
                        Console.WriteLine($"Categoria: {produto.Categoria}");
                    }
                }catch (Exception ex) 
                {
                    Console.Write(ex.Message);
                }
            }
        }
    }
}
