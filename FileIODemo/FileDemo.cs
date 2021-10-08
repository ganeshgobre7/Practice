using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileIODemo
{
    class FileDemo
    {
        string path = @"D:\B.LAB\C sharp\FileIODemo\FileIODemo\FileDemo1.txt";
        string copypath = @"D:\B.LAB\C sharp\FileIODemo\FileIODemo\FileDemo4.txt";
        string deletefile = @"D:\B.LAB\C sharp\FileIODemo\FileIODemo\delete.txt";
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
            }
        }
        public void DeleteFile()
        {
            File.Delete(deletefile); 
        }
    }
}
