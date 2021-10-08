using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileIODemo
{
    class FileDemo
    {
        public void CheckFile()
        {
            string path = @"D:\B.LAB\C sharp\FileIODemo\FileIODemo\FileDemo1.txt";
            File.Exists(path);
        }
    }
}
