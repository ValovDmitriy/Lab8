using System;
using System.IO;
using System.Collections.Generic;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Поиск всех папок и файлов в заданой директории
            //Не учитывает неправильный путь и системные папки
            Console.WriteLine("Введите путь, для поиска папок и файлов");
            string way = Console.ReadLine();
            Dirs(way);
        }

        private static void Dirs(string dirName)
        {
            string[] dirs;
            string[] files;
            dirs = Directory.GetDirectories(dirName);
            files = Directory.GetFiles(dirName);
            foreach (string s in dirs)
                {
                Console.WriteLine(s);
                Dirs(s);
                }
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
