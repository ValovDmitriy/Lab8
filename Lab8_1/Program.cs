using System;
using System.IO;

namespace Lab8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            void getallfile(string startdirectory, string filess)
            {
                string[] searchdirectory = Directory.GetDirectories(startdirectory);
                if (searchdirectory.Length > 0)
                {
                    for (int i = 0; i < searchdirectory.Length; i++)
                    {
                        getallfile(searchdirectory[i] + @"\", filess);
                    }
                }
                string[] filesss = Directory.GetFiles(startdirectory);
                for (int i = 0; i < filesss.Length; i++)
                {
                    filess.Items.Add(filesss[i]);
                }
                //void getallfile(string startdirectory, ListBox filess)
                //{
                //    string[] searchdirectory = Directory.GetDirectories(startdirectory);
                //    if (searchdirectory.Length > 0)
                //    {
                //        for (int i = 0; i < searchdirectory.Length; i++)
                //        {
                //            getallfile(searchdirectory[i] + @"\", filess);
                //        }
                //    }
                //    string[] filesss = Directory.GetFiles(startdirectory);
                //    for (int i = 0; i < filesss.Length; i++)
                //    {
                //        filess.Items.Add(filesss[i]);




                //string dirName = @"F:\";

                //if (Directory.Exists(dirName))
                //{
                //    Console.WriteLine("Подкаталоги:");
                //    string[] dirs = Directory.GetDirectories(dirName);
                //    foreach (string s in dirs)
                //    {
                //        Console.WriteLine(s);
                //    }
                //    Console.WriteLine();
                //    Console.WriteLine("Файлы:");
                //    string[] files = Directory.GetFiles(dirName);
                //    foreach (string s in files)
                //    {
                //        Console.WriteLine(s);
                //    }
                //}




                //DirectoryInfo dir = new DirectoryInfo(@"F:\");
                //foreach (var item in dir.GetDirectories())
                //{
                //    Console.WriteLine(item.Name);


                //}
                //foreach (var it in item.GetDirectories())
                //{
                //    Console.WriteLine(it.Name);

                //}
                //foreach (var item in dir.GetFiles())
                //{
                //    Console.WriteLine(item.Name);
                //}
            }
        }
