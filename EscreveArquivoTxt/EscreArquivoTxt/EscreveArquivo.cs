using System;
using System.IO;

class EscreveArquivo
{
    public static void Main()
    {
        //Programa verifica se o arquivo em questão existe, se não ele cria e escreve 3 frases nele.
        string NomeArq = "MyTest.txt";
        string path = @"c:\" + NomeArq;

        if (File.Exists(path))
        {
            Console.WriteLine("O Arquivo já existe");
            Console.ReadKey();
        }
        else
        {
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
                
               
            }


            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                    
                }
                Console.WriteLine("Arquivo criado e escrito com sucesso!");
                Console.ReadKey();
            }
        }


    }
}

