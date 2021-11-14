using System;
using System.IO;

namespace Lab8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Запись десяти случайных чисел в текстовый файл и подсчёт их суммы
            //Не учитывает неправильный путь и системные папки
            Console.WriteLine("Введите путь для создания файла");
            string path = Console.ReadLine();

            Directory.CreateDirectory(path);

            string filePath = path + "Lab8_2.txt";

            var myFile = File.Create(filePath);
            myFile.Close();

            Rnd(out int[] tenNum);
            foreach (int item in tenNum)
            {
                StreamWriter sw = new StreamWriter(filePath, true);
                sw.Write(item + " ");
                sw.Close();
            }

            StreamReader sr = new StreamReader(filePath);
            string tenNumRead = sr.ReadLine();
            sr.Close();
            Console.WriteLine(tenNumRead);

            Console.WriteLine("Сумма чисел равна:");
            string tenNumReadTrim = tenNumRead.TrimEnd();
            string[] subs = tenNumReadTrim.Split(' ');
            int summ = 0;
            foreach (string sub in subs)
            {
                int numSub = Convert.ToInt32(sub);
                summ += numSub;
            }
            Console.WriteLine(summ);
        }
        static void Rnd(out int[] massive)
        {
            int length = 10;
            massive = new int[length];
            Random rnd = new Random();
            for (int i = 1; i < length; i++)
            {
                massive[i] = rnd.Next(0, 50);
            }
        }
    }
}
