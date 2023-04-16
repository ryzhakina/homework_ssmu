namespace homework5_app2;

using System.Collections.Generic;

class Program
{
    const string Tmp = @"%AppData%/Lesson12Homework.txt";

    static void Main(string[] args)
    {
        var tmp = Environment.ExpandEnvironmentVariables(Tmp);

        // получаю csv строки
        string[] csv;
        try
        {
            var pathToCSV = File.ReadAllText(tmp);


            if (pathToCSV.Length == 0)
            {
                throw new Exception($"Отсутствует путь к csv файлу, запустите первое приложение");
            }

            csv = File.ReadAllLines(pathToCSV);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка открытия csv-файла: {e}");
            throw;
        }

        // формирую элементы списка
        var items = new List<DirectoryItem>();

        foreach (var line in csv)
        {
            var tempStr = line.Split("\t");

            DirectoryItem.ItemTypes type;
            switch (tempStr[0])
            {
                case "file":
                    type = DirectoryItem.ItemTypes.File;
                    break;
                case "folder":
                    type = DirectoryItem.ItemTypes.Folder;
                    break;
                default:
                    throw new FileLoadException($"Файл {csv} повреждён.");
            }

            items.Add(new DirectoryItem(type, tempStr[1], Convert.ToDateTime(tempStr[2])));
        }

        // сортирую и вывожу
        foreach (var item in items.OrderBy(x => x.DateLastChange))
        {
            Console.WriteLine($"{item.Type} {item.Name} {item.DateLastChange}");
        }

        // удаляю то, что породила
        try
        {
            File.Delete(tmp);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка удаления tmp-файла: {e}");
            throw;
        }

    }
}
