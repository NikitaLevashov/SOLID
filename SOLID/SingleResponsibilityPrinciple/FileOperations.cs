using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.SingleResponsibilityPrinciple
{
    //Принцип единственной обязанности (Single Responsibility Principle) можно сформулировать так: У класса должна быть только одна причина для изменения



    class FileOperations // класс, который отвечает за работу с файловой системой (работу с файлами).
    {
        public static void GetFileInfo() // метод для получения информации о файле
        {
            var currentPath = Directory.GetCurrentDirectory();
            var path = Path.Combine(currentPath, "Data", "users.json");

            FileInfo fileInfo = new FileInfo(path);

            if (fileInfo.Exists)
            {
                Console.WriteLine($"Имя файла: {fileInfo.Name}");
                Console.WriteLine($"Время создания: {fileInfo.CreationTime}");
                Console.WriteLine($"Размер: {fileInfo.Length}");
                Console.WriteLine($"Расширение: {fileInfo.Extension}");
            }
        }

        public static void MoveFile() // метод для перемещения файла в новое местоположение
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Data", "users.json");
            var newPath = Path.Combine(Directory.GetCurrentDirectory(), "MoveData", "users.json");

            FileInfo fileInfо = new FileInfo(path);
            if (fileInfо.Exists)
            {
                if (!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                }

                fileInfо.MoveTo(newPath);
               
            }
        }

        public static void CopyFile() // метод для копирования существующего файла в новый файл
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Data", "users.json");
            var newPath = Path.Combine(Directory.GetCurrentDirectory(), "MoveData", "users.json");

            FileInfo fileInfо = new FileInfo(path);
            if (fileInfо.Exists)
            {
                fileInfо.CopyTo(newPath, true);
            }
        }

        public static void RemoveFile() // метод для удаления файлв
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "MoveData", "users.json");

            FileInfo fileInfо = new FileInfo(path);
            if (fileInfо.Exists)
            {
                fileInfо.Delete();
              
            }
        }
    }
}
