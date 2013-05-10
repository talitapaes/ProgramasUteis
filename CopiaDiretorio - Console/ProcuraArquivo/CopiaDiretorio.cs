using System;
using System.IO;

class CopiaDiretorio
{
    public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
    {
        if (source.FullName.ToLower() == target.FullName.ToLower())
        {
            return;
        }

         //Check if the target directory exists, if not, create it.
        if (Directory.Exists(target.FullName) == false)
        {
            Directory.CreateDirectory(target.FullName);
        }

        // Copy each file into it's new directory.
        foreach (FileInfo arquivo in source.GetFiles())
        {
            Console.WriteLine(@"Copying {0}\{1}", target.FullName, arquivo.Name);
            arquivo.CopyTo(Path.Combine(target.ToString(), arquivo.Name), true);
        }


         //Copy each subdirectory using recursion.
        
        foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
        {
            DirectoryInfo nextTargetSubDir =
            target.CreateSubdirectory(diSourceSubDir.Name);
            CopyAll(diSourceSubDir, nextTargetSubDir);
        }
        

    }
    

    public static void Main()
    {
        string diretorioOrigem = @"C:\Users\Eggtech006\Desktop"; 
        string diretorioDestino = @"c:\DiretorioDestino";

        DirectoryInfo dirOrigem = new DirectoryInfo(diretorioOrigem);
        DirectoryInfo dirDestino = new DirectoryInfo(diretorioDestino);
        CopyAll(dirOrigem, dirDestino);
        Console.WriteLine("Copia Finalizada!!");
        Console.ReadKey();
    }


}

