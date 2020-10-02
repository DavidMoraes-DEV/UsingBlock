using System;
using System.IO;

namespace UsingBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            /* * USING BLOCK
               - Sintaxe simplificada que garante que os objetos Idisposable serão fechados.
               - Objetos IDisposable NÃO são gerenciados pelo CLR. Eles precisam ser manualmente fechados. Exemplos: Font, FileStream, StreamReader, StreamWriter
             */

            string path = @"C:\ProgramasCSharp\ConceitoDeUsingBlock\UsingBlock\File1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path)) //Todo o recurso que for colocado nesse bloco depois de ser executado será automaticamento fechado
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
