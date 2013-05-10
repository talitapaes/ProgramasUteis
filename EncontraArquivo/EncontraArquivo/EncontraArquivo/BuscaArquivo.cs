using System;
using System.IO;

class BuscaArquivo
{
    public static void Main()
    {
        try
        {
            //Aplicativo que busca um arquivo num diretório
            string[] dirs = Directory.GetFiles(@"c:\Users\Eggtech006\Desktop", "Uteis*", SearchOption.AllDirectories);
            Console.WriteLine("Foi encontrado {0} arquivos com os critérios da busca.", dirs.Length);
            foreach (string dir in dirs)
            {
                //Mostra a quantidade de arquivos e o caminho
                Console.WriteLine("O caminho do arquivo é: ");
                Console.WriteLine(dir);
                Console.ReadKey();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
            Console.ReadKey();
        }
    
    }
}