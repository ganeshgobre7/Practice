using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileIODemo
{
    class FileDemo
    {
        string path = @"D:\B.LAB\C sharp\FileIODemo\FileIODemo\FileDemo1.txt";
        string copypath = @"D:\B.LAB\C sharp\FileIODemo\FileIODemo\FileDemo3.txt";
        public void CheckFile()
        {           
            if(File.Exists(path))
            {
                Console.WriteLine("File Exits");
            }
            else
            {
                Console.WriteLine("File is Missing");
            }
        }
        public void ReadFile()
        {
            if(File.Exists(path))
            {
                var data=File.ReadAllLines(path);
                var data1 = File.ReadAllText(path);
                foreach(var linens in data)
                {
                    Console.WriteLine(linens);
                }
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                foreach (var linens in data1)
                {
                    Console.WriteLine(linens);
                }
            }
        }
        public void WriteFile(string cont="")
        {
            if (!File.Exists(path))
            {
                File.Create(path);
                File.WriteAllText(path, "cont");
            }
        }
        public void CopyFile()
        {
            if (File.Exists(path))
            {
                File.Copy(path, copypath);
                /*FileInfo f1 = new FileInfo(path);
                FileInfo f2 = new FileInfo(copypath);
                f1.CopyTo(copypath);*/
            }
        }
    }
}
