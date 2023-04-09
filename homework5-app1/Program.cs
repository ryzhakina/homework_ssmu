using System.IO.Compression;

class Program
{
    const string Archive = @"C:\archive\files.zip";
    const string Dir = "archive";
    const string Csv = "list.csv";

    const string Tmp = @"%AppData%/Lesson12Homework.txt";

    static void Main(string[] args)
    {
        // распаковываю
        try
        {
            if (Directory.Exists(Dir))
            {
                Directory.Delete(Dir, true);
            }

            ZipFile.ExtractToDirectory(sourceArchiveFileName: Archive, destinationDirectoryName: Dir);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка распаковки архива: {e}");
        }

        // насыщаю csv-файл
        try
        {
            if (File.Exists(Csv))
            {
                File.Delete(Csv);
            }

            string[] dirs = Directory.GetDirectories(Dir);
            foreach (string dir in dirs)
            {
                File.AppendAllText(Csv, $"folder\t{dir}\t{Directory.GetLastWriteTime(dir)}" + Environment.NewLine);
            }

            string[] files = Directory.GetFiles(Dir);
            foreach (string file in files)
            {
                File.AppendAllText(Csv, $"file\t{file}\t{Directory.GetLastWriteTime(file)}" + Environment.NewLine);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка заполнения csv-файла: {e}");
        }

        // сохраняю путь к csv-файлу
        try
        {
            var tmp = Environment.ExpandEnvironmentVariables(Tmp);

            if (File.Exists(tmp))
            {
                File.Delete(tmp);
            }

            File.WriteAllText(tmp, Path.GetFullPath(Csv));
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка заполнения tmp-файла: {e}");
        }
    }
}
