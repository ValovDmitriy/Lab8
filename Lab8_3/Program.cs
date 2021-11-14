using System;
using System.IO;

namespace Lab8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\MasteriaXD\source\repos\Lab8\Lab8_3\bin\Debug\net5.0\ref\Фрагмент текста.txt";

            using (StreamReader sr = new StreamReader(path), sr1 = new StreamReader(path))
            {
                string strok;
                int i = 0;
                int j = 0;
                while ((strok = sr1.ReadLine()) != null)
                {
                    i++;
                }
                string simv = sr.ReadToEnd();

                int simvLen = simv.Length;
                Console.WriteLine("Количество символов - {0}", simvLen-i);
                Console.WriteLine("Количество строк - {0}", i);
                string[] slovs = simv.Split(' ', '\n', '\r');
                foreach (string slov in slovs)
                {
                    j++;
                }

                Console.WriteLine("Количество слов - {0}", j);
            }
        }
    }
}
