namespace Manipulando_Arquivos
{
    internal class Program
    {
        static void Main()
        {

            /*
             * Criar e escrever no arquivo
  
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            string idade = Console.ReadLine();

            Console.WriteLine("Digite sua data de nascimento: ");
            string dataNascimento = Console.ReadLine();

            string caminhoArquivo = @"C:\Tmp\teste.txt";
            using (StreamWriter escritor = new(caminhoArquivo)) 
            {
                escritor.WriteLine("Dados do Usuario");

                escritor.WriteLine($"Nome: {nome}");
                escritor.WriteLine($"Idade: {idade}");
                escritor.WriteLine($"Data Nascimento: {dataNascimento}");
            }
            */

            /*
            int contador = 0;
                     
            string caminhoArquivo = @"C:\Tmp\teste.txt";
            using (StreamReader leitor = new (caminhoArquivo)) 
            {
                string linha;
                while ((linha = leitor.ReadLine()) != null) 
                {
                    string[] palavras = linha.Split(' ');
                    contador += palavras.Length;
                }
            }
            Console.WriteLine($"Quantidade de palavras {contador}");
            */

            /*
            Console.WriteLine("DESEJA BUSCAR O LOG COMO ??\n1 - POR PERÍODO\n2 - POR NOME\n3 - POR AMBOS");
            int decicao = int.Parse(Console.ReadLine()!);

            switch (decicao) 
            {
                case 1:

                    Console.Write("Insira o período: ");
                    Console.Clear();
                    string periodo = Console.ReadLine()!;
                    buscarLog(periodo);

                    break;
                case 2:

                    Console.Write("Insira o nome do log: ");
                    Console.Clear();
                    string nomeLog = Console.ReadLine()!;
                    buscarLog(nomeLog);

                    break;
                case 3:

                    Console.Write("Insira o período: ");
                    string periodo2 = Console.ReadLine()!;
                    Console.Write("Insira o nome do log: ");
                    string nome2 = Console.ReadLine()!;
                    buscarLogAmbos(periodo2, nome2);
                    break;
            }

            /*
            Console.Write("Insira o período: ");
            string periodo = Console.ReadLine()!;

            Console.Clear();

            string caminhoArquivo = @"C:\Tmp\senai.txt";
            using (StreamReader lerLog = new(caminhoArquivo)) 
            {
                string linha;
                int contador = 0;
                while ((linha = lerLog.ReadLine()!) != null) 
                {
                    if (linha.Contains(periodo)) 
                    {
                        Console.WriteLine($"Log Encontrado: {linha}\n");
                        contador++;
                    }
                }
                Console.WriteLine($"Foram encontrados {contador} logs no período do dia {periodo}");
            }

            void buscarLog(string parametro)
            {
                string caminhoArquivo = @"C:\Tmp\senai.txt";
                using (StreamReader lerLog = new(caminhoArquivo))
                {
                    string linha;
                    int contador = 0;
                    while ((linha = lerLog.ReadLine()!) != null)
                    {
                        if (linha.Contains(parametro))
                        {
                            Console.WriteLine($"Log Encontrado: {linha}\n");
                            contador++;
                        }
                    }
                    Console.WriteLine($"Foram encontrados {contador} logs baseado no parâmetro exigido {parametro}");
                }
            }

            void buscarLogAmbos(string perido, string nomeLog)
            {
                string caminhoArquivo = @"C:\Tmp\senai.txt";
                using (StreamReader lerLog = new(caminhoArquivo))
                {
                    string linha;
                    int contador = 0;
                    while ((linha = lerLog.ReadLine()!) != null)
                    {
                        if (linha.Contains(perido) && linha.Contains(nomeLog))
                        {
                            Console.WriteLine($"Log Encontrado: {linha}\n");
                            contador++;
                        }
                    }
                    Console.WriteLine($"Foram encontrados {contador} logs baseado no período {perido}, e o nome {nomeLog}");
                }
            }
            */

            string arquivo = "produtos.bin";
            using (BinaryWriter writer = new(File.Open(arquivo, FileMode.Create))) 
            {
                writer.Write("Caneta");
                writer.Write("2.5");
                writer.Write("300");
            }

        }
    }
}
