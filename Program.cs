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

            string[] allLines = System.IO.File.ReadAllLines(path, Encoding.ASCII);
            string text = string.Empty;

            /*LISTAS */
            List<string> token = new List<string>();
            List<string> variaveis = new List<string>();

            /* REMOVE QUEBRA DE LINHA */
            foreach (string line in allLines)
            {
                text += line.Trim().Replace("\n", string.Empty);
            }
            string[] pushBack = text.Split(';');
            for (int l = 0; l < pushBack.Length; l++)
            {
                string[] onPushBack = metodos.PushBackSplit(pushBack[l]);
                for (int i = 0; i < onPushBack.Length; i++)
                {
                    /* VERIFICA SE A 1ª POSIÇÃO É UMA PALAVRA RESERVADA OU VARIÁVEL */
                    if (i == 0 && (
                        !metodos.IsReservedWorks(onPushBack[0])
                        && !metodos.IsOperation(onPushBack[0])
                        && !variaveis.Contains(onPushBack[0]))
                        || metodos.IsNumeric(onPushBack[0])
                       )
                    {
                        Console.WriteLine("Error line {1}: O nome '{0}' não existe no contexto atual", onPushBack[0], l);
                        System.Environment.Exit(1);
                    }
                    else if ((i != 0 && metodos.IsReservedWorks(onPushBack[i])) || (metodos.InitialNumber(onPushBack[i]) && !metodos.IsNumeric(onPushBack[i])))
                    {
                        Console.WriteLine("Error line {1}: Termo de expressão inválido '{0}'", onPushBack[i], l);
                        System.Environment.Exit(1);
                    }
                    // else if (variaveis.Contains(onPushBack[i]))
                    // {
                    //     Console.WriteLine("Error line {1}: Uma variável de local ou função denominada '{0}' já está definida neste escopo", onPushBack[i], l);
                    //     System.Environment.Exit(1);
                    // }

                    else
                    {
                        if (metodos.FiltersVariable(onPushBack[i]).Length > 0 && !variaveis.Contains(metodos.FiltersVariable(onPushBack[i])))
                        {
                            variaveis.Add(metodos.FiltersVariable(onPushBack[i]));
                        }

                        token.Add(onPushBack[i]);
                    }
                }

            }
        //    Console.ReadKey();
        }
    }
}