using System;
using System.Collections.Generic;
using System.Text;

namespace MyCompilater
{
    class Program
    {

        public static Metodos metodos = new Metodos();

        static void Main(string[] args)
        {

            string path = Environment.CurrentDirectory + @"\file\example.txt";

            string[] lines = System.IO.File.ReadAllLines(path, Encoding.ASCII);
            string text = string.Empty;

            /*LISTAS */
            List<string> token = new List<string>();
            List<string> variaveis = new List<string>();

            /* REMOVE QUEBRA DE LINHA */
            foreach (string line in lines)
            {
                text += line.Trim().Replace("\n", string.Empty);
            }

             string[] push_back = text.Split(';');


            foreach (var l in push_back)
            {
                string[] tokens = l.Split(' ');
                
                /* VERIFICA SE A 1ª POSIÇÃO É UMA PALAVRA RESERVADA OU VARIÁVEL */
                if (!metodos.IsReservedWorks(tokens[0]) || !variaveis.Contains(tokens[0]))
                {
                    Console.WriteLine("O nome '{0}' não existe no contexto atual",tokens[0]);
                }
                token.Add(l);
                // Console.WriteLine (linha);
            }



            /****** COMPARACAO *********/


        }
    }
}