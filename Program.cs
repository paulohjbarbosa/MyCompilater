using System;
using System.Text;

namespace MyCompilater
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Environment.CurrentDirectory);
            string path = Environment.CurrentDirectory + @"\file\example.txt";
            Console.WriteLine(path);
            string[] lines = System.IO.File.ReadAllLines(path, Encoding.ASCII);
            string text = string.Empty;
            /* REMOVE QUEBRA DE LINHA */
            foreach (string line in lines)
            {
                text += line.Trim().Replace("\n", string.Empty);
            }

            string[] push_back = text.Split(';');

            foreach (var linha in push_back)
            {
                Console.WriteLine(linha);
            }



            ReservedWorks rw = new ReservedWorks();
            string[] keywords = rw.KeyWords;
            

        }
    }
}
